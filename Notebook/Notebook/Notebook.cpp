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
	string getName() const { return name; }
	string getPhone() const { return phone; }
	string getEmail() const { return email; }
	string getAdress() const { return adress; }

	void setName(string newName) { name = newName; }
	void setPhone(string newPhone) { phone = newPhone; }
	void setEmail(string newEmail) {  email = newEmail; }
	void setAdress(string newAdress) {  adress = newAdress; }

	void printInfo();
};

class ContactBook {

};

void Contact :: printInfo() {
	cout << "Имя: " << name << endl;
	cout << "Номер телефона: " << phone << endl;
	cout << "Почта: " << email << endl;
	cout << "Адрес: " << adress << endl;
}

int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
}
