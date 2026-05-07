#include <iostream>
#include<ctime>

using namespace std;

int main() {
	setlocale(LC_ALL, "ru");

	srand(time(0));

	int a;
	int secret = rand() % 100 + 1;
	int attempts = 0;

	cout << "Я загадал число от 1 до 100 угадай его" << endl;

	while (true) {
		attempts++;
		cout << "Попытка: " << attempts << endl;
		cin >> a;

		if (a < 1 || a > 100) {
			attempts--;
			cout << "Ты введ неправильное число" << endl;
			continue;
		}

		if (secret == a) {
			cout << "Угадал за " << attempts << " попыток" << endl;
			cout << "Моё число " << secret << endl;

			break;
		}

		else if (secret > a) {
			cout << "Моё число больше" << endl;
		}

		else {
			cout << "Моё число меньше" << endl;
		}
	}
	return 0;
}