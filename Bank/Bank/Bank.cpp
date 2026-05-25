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
	double balance;
	vector<string> history;

public:
	Account(int id, string name) {
		this -> id = id;
		this->name = name;
		balance = 0.0;
	}

	int getId() { return id; }
	string getName() { return name; }
	double getBalance() { return balance; }
	void deposit(double amount);
	void withdraw(double amount);
	void addHistory(string text);
	void printInfo();
};

class Bank {

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

void SaveToFile() {

}

void LoadFromFile() {

}

int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	char choice;

	while (true) {
	
	}
}