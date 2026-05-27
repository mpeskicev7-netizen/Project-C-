#include<iostream>
#include<sstream>
#include<iomanip>
#include<fstream>
#include<vector>
#include<string>
#include<windows.h>

using namespace std;

class Account {
private:
	int id;
	string name;
	string password;
	double balance;
	vector<string> history;

public:
	Account(int id, string name, string password) {
		this -> id = id;
		this->name = name;
		this->password = password;
		balance = 0.0;
	}

	int getId() const { return id; }
	string getName() const { return name; }
	double getBalance() const { return balance; }
	string getPassword() const { return password; }
	vector<string> getHistory() const { return history; }
	void deposit(double amount);
	void withdraw(double amount);
	void addHistory(string text);
	void printInfo();
	void printHistory();
	void setBalance(double amount) { balance = amount; }
};

class Bank {
private:
	vector<Account> accounts;
	int nextId;

public:
	Bank() {
		nextId = 1001;
	}

	void CreateAccounts(string name, string password);
	Account* findAccount(int id);
	Account* findAccount(string name);
	void printAllAccounts();
	void SaveToFile(const string& filename);
	void LoadFromFile(const string& filename);

};

void Account::deposit(double amount) {

	if (amount <= 0) {
		cout << "Такой депозит не вносится" << endl;
		return;
	}

	balance += amount;
	ostringstream oss;
	oss << fixed << setprecision(2);
	oss << "Пополнение на: " << amount << " Баланс: " << balance;
	addHistory(oss.str());
}

void Account::withdraw(double amount) {

	if (amount > balance) {
		cout << "Недостаточно средств" << endl;
		return;
	}

	balance -= amount;
	ostringstream oss;
	oss << fixed << setprecision(2);
	oss << "Вывели средств: " << amount << " Баланс: " << balance;
	addHistory(oss.str());
}

void Account::addHistory(string text) {
	history.push_back(text);
}

void Account::printInfo() {
	cout << "Номер счета: " << id << endl;
	cout << "Наименование счета: " << name << endl;
	cout << "Баланс: " << balance << endl;
}

void Account::printHistory() {
	if (history.empty()) {
		cout << "История пуста" << endl;
		return;
	}
	for (const auto& h : history) {
		cout << h << endl;
	}
}

void Bank::CreateAccounts(string name, string password) {
	Account acc(nextId, name, password);
	accounts.push_back(acc);
	cout << "Аккаунт создан, ваш номер: " << nextId << endl;
	nextId++;
}

Account* Bank::findAccount(int id) {

	for (int i = 0; i < accounts.size(); i++) {
		if (accounts[i].getId() == id) {
			return &accounts[i];
		}
	}

	return nullptr;
}

void Bank::printAllAccounts() {

	for (const auto& a : accounts) {

		cout << "Имя: " << a.getName() << endl << "Номер: " << a.getId() << endl << "Баланс: " << a.getBalance() << endl;
	}
}

Account* Bank::findAccount(string name) {

	for (int i = 0; i < accounts.size(); i++) {
		if (accounts[i].getName() == name) {
			return &accounts[i];
		}
	}

	return nullptr;
}

void Bank::SaveToFile(const string& filename) {
	ofstream file(filename);

	if (!file.is_open()) {
		cout << "Не удалочь открыть файл" << endl;

		return;
	}

	file << accounts.size() << endl;

	for (const auto a : accounts) {

		file << a.getId() << endl;
		file << a.getName() << endl;
		file << a.getPassword() << endl;
		file << a.getBalance() << endl;

		file << a.getHistory().size() << endl;
		for (const auto& h : a.getHistory()) {
			file << h << endl;
		}
	}

	file.close();
	cout << "Данные сохранены в файл: " << filename << endl;

}

void Bank::LoadFromFile(const string& filename) {
	ifstream file(filename);

	if (!file.is_open()) {
		cout << "Файл не был найден, будет создан новый" << endl;

		return;
	}

	accounts.clear();

	int acc;
	file >> acc;

	file.ignore();

	for (int i = 0; i < acc; i++) {
		int id;
		string name, password;
		double balance;

		file >> id;
		file.ignore();
		getline(file, name);
		getline(file, password);
		file >> balance;
		file.ignore();

		Account a(id, name, password);
		a.setBalance(balance);

		int historyCount;
		file >> historyCount;

		file.ignore();

		for (int j = 0; j < historyCount; j++) {
			string line;
			getline(file, line);
			a.addHistory(line);
		}

		accounts.push_back(a);
	}

	file.close();
	cout << "Добавлено новых аккаунтов: " << accounts.size() << endl;
}

int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	char choice;
	double amount;
	const string filename = "Bank.txt";
	string name, password;
	Bank bank;

	bank.LoadFromFile(filename);

	while (true) {

		cout << "Выберите операцию: " << endl;
		cout << "A - Добавить счет \nP - Показать аккаунты \nR - Внести депозит \nT - Снять деньги \nI - Данные счета \nH - История операций \nE - Выход \n";

		cin >> choice;


		if (choice == 'A' || choice == 'a') {
			cout << "Введите имя" << endl;
			cin >> name;
			cout << "Введите пароль" << endl;
			cin >> password;

			bank.CreateAccounts(name, password);
		}

		if (choice == 'P' || choice == 'p') {
			bank.printAllAccounts();
		}

		if (choice == 'R' || choice == 'r') {
			cout << "Введите имя: ";
			cin >> name;
			cout << "Введите пароль: ";
			cin >> password;

			Account* acc = bank.findAccount(name);
			if (acc == nullptr) {
				cout << "Счет не найден" << endl;
			}
			else if (acc->getPassword() != password) {
				cout << "Неверный пароль" << endl;
			}
			else {
				cout << "Введите сумму поплнения: ";
				cin >> amount;
				acc->deposit(amount);
			}
			
		}

		if (choice == 'T' || choice == 't') {
			cout << "Введите имя:";
			cin >> name;
			cout << "Введите пароль: ";
			cin >> password;

			Account* acc = bank.findAccount(name);
			if (acc == nullptr) {
				cout << "Счет не найден" << endl;
			}
			else if (acc->getPassword() != password) {
				cout << "Неверный пароль" << endl;
			}
			else {
				cout << "Введите сумму снятия: ";
				cin >> amount;
				acc->withdraw(amount);
			}
		}

		if (choice == 'I' || choice == 'i') {
			cout << "Введите имя: ";
			cin >> name;
			cout << "Введите пароль: ";
			cin >> password;

			Account* acc = bank.findAccount(name);
			if (acc == nullptr) {
				cout << "Счет не найден" << endl;
			}
			else if (acc->getPassword() != password) {
				cout << "Неверный пароль" << endl;
			}
			else {
				acc->printInfo();
			}
		}

		if (choice == 'H' || choice == 'h') {
			cout << "Введите имя: ";
			cin >> name;
			cout << "Введите пароль: ";
			cin >> password;

			Account* acc = bank.findAccount(name);
			if (acc == nullptr) {
				cout << "Счет не найден" << endl;
			}
			else if (acc->getPassword() != password) {
				cout << "Неверный пароль" << endl;
			}
			else {
				acc->printHistory();
			}
		}

		if (choice == 'E' || choice == 'e') {
			break;
		}

		bank.SaveToFile(filename);
	}
}