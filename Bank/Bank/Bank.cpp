#include<iostream>
#include<fstream>
#include<vector>
#include<string>

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

void Account::deposit(double amount) {

}