#include<iostream>
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
	void deposit(double amount);
	void withdraw(double amount);
	void addHistory(string text);
	void printInfo();
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
	void SaveToFile();
	void LoadFromFile();

};

void Account::deposit(double amount) {

	if (amount <= 0) {
		cout << "Такой депозит не вносится" << endl;
		return;
	}

	balance += amount;
}

void Account::withdraw(double amount) {

	if (amount > balance) {
		cout << "Недостаточно средств" << endl;
		return;
	}

	balance -= amount;
}

void Account::addHistory(string text) {

}

void Account::printInfo() {

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

		cout << "Имя: " << a.getName() << "Номер: " << a.getId() << endl;
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

void Bank::SaveToFile() {

}

void Bank::LoadFromFile() {

}

int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	char choice;
	double amount;
	string Inputname, Inputpassword;

	while (true) {

		cout << "Выберите операцию: " << endl;
		cout << "A - авторизация \n";

		cin >> choice;

		if (choice == 'A' || choice == 'a') {
			cout << "Введите имя" << endl;
			cin >> Inputname;
			cout << "Введите пароль" << endl;
			cin >> Inputpassword;
		}
	
	}
}