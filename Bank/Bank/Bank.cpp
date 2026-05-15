#include<iostream>
#include<fstream>
#include<vector>
#include<string>

using namespace std;

class Account {
private:
	int id;
	string name;
	
protected:
	double balance;
	vector<string> history;
};