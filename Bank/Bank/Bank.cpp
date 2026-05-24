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

}

void Account::withdraw(double amount) {

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
}