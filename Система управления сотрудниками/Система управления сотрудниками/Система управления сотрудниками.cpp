#include <iostream>
#include <string>
#include<vector>
#include<windows.h>
#include<fstream>

using namespace std;

class Employee {
public:
	string Name;
	int Salary;  //Расчет ЗП
};

void SaveToFile(const vector<Employee>& employees, const string& filename) {
	ofstream file(filename);

	if (!file.is_open()) {
		cout << "Не удалось открыть файл" << endl;

		return;
	}

	file << employees.size() << endl;

	for (const auto& emp : employees) {
		file << emp.Name << endl;
		file << emp.Salary << endl;
	}

	file.close();
	cout << "Данные сохранены в файл " << filename << endl;
}

void LoadFromFile(vector<Employee>& employees, const string& filename) {
	ifstream file(filename);

	if (!file.is_open()) {
		cout << "Файл не был найден. Будет создан новый список сотрудников" << endl;

		return;
	}

	employees.clear();

	int count;
	file >> count;
	file.ignore();

	for (int i = 0; i < count; i++) {
		Employee emp;
		getline(file, emp.Name);
		file >> emp.Salary;
		file.ignore();
		employees.push_back(emp);
	}

	file.close();
	cout << "Сотрудников загружено: " << employees.size() << " Загружено из файла: " << filename << endl;
}



int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	vector<Employee> employees;
	const string filename = "employees.txt";

	LoadFromFile(employees, filename);
	
	int count;
	cout << "Сколько сотрудников добавить?" << endl;
	cin >> count;

	for (int i = 0; i < count; i++) {
		Employee emp;

		cout << "\nСотрудник #" << i + 1 << endl;
		cout << "Имя: " << endl;

		cin.ignore();
		getline(cin, emp.Name);

		cout << "Зарплата: " << endl;
		cin >> emp.Salary;

		employees.push_back(emp);

	}

	SaveToFile(employees, filename);

	cout << "Список сотрудников:" << endl;

	for (int i = 0; i < employees.size(); i++) {
		cout << i + 1 << "." << employees[i].Name;
		cout << "-" << employees[i].Salary << " руб." << endl;
	}

	/*Employee First;

	First.Name = "Сергей";
	First.Salary = 35000;

	Employee Artem;

	Artem.Name = "Артём";
	Artem.Salary = 355;*/

}