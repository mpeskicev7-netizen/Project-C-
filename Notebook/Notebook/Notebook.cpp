#include<iostream>
#include<sstream>
#include<iomanip>
#include<fstream>
#include<map>
#include<string>
#include<windows.h>

using namespace std;

class Contact {
private:
	string name;
	string phone;
	string email;
	string adress;

public:
	Contact(string name, string phone, string email, string adress) {
		this->name = name;
		this->phone = phone;
		this->email = email;
		this->adress = adress;
	}
	Contact() : name(""), phone(""), email(""), adress("") {}
	string getName() const { return name; }
	string getPhone() const { return phone; }
	string getEmail() const { return email; }
	string getAdress() const { return adress; }

	void setName(string newName) { name = newName; }
	void setPhone(string newPhone) { phone = newPhone; }
	void setEmail(string newEmail) {  email = newEmail; }
	void setAdress(string newAdress) {  adress = newAdress; }

	void printInfo() const;
};

void Contact::printInfo() const {
	cout << "Имя: " << name << endl;
	cout << "Номер телефона: " << phone << endl;
	cout << "Почта: " << email << endl;
	cout << "Адрес: " << adress << endl;
}

class ContactBook {
private:
	map<string, Contact> contacts;

public:
	void addContacts(const Contact& contact);
	void FindByname(string name);
	void FindByPhone(string phone);
	void editContacts(string name, string newPhone, string newEmail, string newAdress);
	void deleteContact(string name);
	void printAll();
	void SaveToFile(const string& filename);
	void LoadFromFile(const string& filename);
};

void ContactBook::addContacts(const Contact& contact) {
	contacts[contact.getName()] = contact;
}

void ContactBook::FindByname(string name) {
	auto it = contacts.find(name);

	if (it == contacts.end()) {
		cout << "Контакт не найден" << endl;
	}
	else {
		it->second.printInfo();
	}
}

void ContactBook::FindByPhone(string phone) { 
	auto it = contacts.find(phone);

	for (const auto& pair : contacts) {
		if (pair.second.getPhone() == phone) {
			pair.second.printInfo();
			return;
		}
	}

	cout << "Контакт не найден" << endl;
}

void ContactBook::editContacts(string name, string newPhone, string newEmail, string newAdress) {
	auto it = contacts.find(name);

	if (it != contacts.end()) {
		it->second.setPhone(newPhone);
		it->second.setEmail(newEmail);
		it->second.setAdress(newAdress);

		cout << "Контакт обновлен" << endl;
	}
	else {
		cout << "Контакт не найден" << endl;
	}
}

void ContactBook::deleteContact(string name) {
	auto it = contacts.find(name);

	if (it != contacts.end()) {
		contacts.erase(it);
		cout << "Контакт удален" << endl;
	}
	else {
		cout << "Контакт не найден" << endl;
	}
}

void ContactBook::printAll() {
	if (contacts.empty()) {
		cout << "Книга контактов пуста" << endl;

		return;
	}

	for (const auto& pair : contacts) {
		pair.second.printInfo();
		cout << "---" << endl;
	}
}

void ContactBook::SaveToFile(const string& filename) {
	ofstream file(filename);

	if (!file.is_open()) {
		cout << "Не удалось открыть файл" << endl;

		return;
	}

	file << contacts.size() << endl;
	for (const auto& pair : contacts) {
		file << pair.second.getName() << endl;
		file << pair.second.getPhone() << endl;
		file << pair.second.getEmail() << endl;
		file << pair.second.getAdress() << endl;
	}

	file.close();
	cout << "Данные сохранены в файл " << filename << endl;
}

void ContactBook::LoadFromFile(const string& filename) {
	ifstream file(filename);

	if (!file.is_open()) {
		cout << "Файл не был найден, будет создан новый" << endl;

		return;
	}

	contacts.clear();

	int count;
	file >> count;
	file.ignore();

	for (int i = 0; i < count; i++) {
		string name, phone, email, adress;
		getline(file, name);
		getline(file, phone);
		getline(file, email);
		getline(file, adress);
		Contact c(name, phone, email, adress);
		contacts[name] = c;
	}

	file.close();
	cout << "Добавлено новых контактов: " << contacts.size() << endl;
}

int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	const string filename = "Notebook.txt";

	char choice;
	string name, phone, email, adress;
	ContactBook book;

	book.LoadFromFile(filename);

	while (true) {
		cout << "1 - Добавить контакт \n2 - Поиск контакта по имени \n3 - Найти по номеру \n0 - Выйти\n";

		cin >> choice;

		if (choice == '1') {
			cout << "Введите имя:" << endl;
			cin >> name;
			cout << "Введите телефон:" << endl;
			cin >> phone;
			cout << "Введите почту:" << endl;
			cin >> email;
			cout << "Введите адрес:" << endl;
			cin >> adress;

			Contact c (name, phone, email, adress);

			book.addContacts(c);
		}

		if (choice == '2') {
			cout << "Введите имя:" << endl;
			cin >> name;

			book.FindByname(name);
		}

		if (choice == '3') {
			cout << "Введите телефон:" << endl;
			cin >> phone;

			book.FindByPhone(phone);
		}

		if (choice == '0') {
			break;
		}

		book.SaveToFile(filename);
	}
}
