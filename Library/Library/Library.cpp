#include <iostream>
#include<string>
#include <fstream>
#include<vector>
#include<windows.h>


using namespace std;

class Book {
public:
	string name;
	int pages;

};

class Music {
public:
	string name;
	int duration;
};

class Movie {
public:
	string name;
	int duration;
};

void SaveToFile(const vector<Book>& books, const vector<Music>& musics, const vector<Movie>& movies, const string& filename) {
	ofstream file(filename);

	if (!file.is_open()) {
		cout << "Не удалось отркыть файл";

		return;
	}

	file << books.size() << endl;
	file << musics.size() << endl;
	file << movies.size() << endl;

	for (const auto& b : books) {

		file << b.name << endl;
		file << b.pages << endl;
	}


	for (const auto& m : musics) {

		file << m.name << endl;
		file << m.duration << endl;
	}

	for (const auto& f : movies) {

		file << f.name << endl;
		file << f.duration << endl;
	}

	file.close();
	cout << "Данные сохранены в файл " << filename << endl;
}

void LoadFromFile(vector<Book>& books, vector<Music>& musics, vector<Movie>& movies, const string& filename) {
	ifstream file(filename);

	if (!file.is_open()) {
		cout << "Файл не был найден. Будет создан новый" << endl;

		return;
	}

	books.clear();
	musics.clear();
	movies.clear();

	int Bookcount, Musiccount, Moviecount;
	file >> Bookcount;
	file >> Musiccount;
	file >> Moviecount;
	file.ignore();

	for (int i = 0; i < Bookcount; i++) {
		Book b;
		getline(file, b.name);
		file >> b.pages;
		file.ignore();
		books.push_back(b);
	}

	for (int i = 0; i < Musiccount; i++) {
		Music m;
		getline(file, m.name);
		file >> m.duration;
		file.ignore();
		musics.push_back(m);
	}

	for (int i = 0; i < Moviecount; i++) {
		Movie f;
		getline(file, f.name);
		file >> f.duration;
		file.ignore();
		movies.push_back(f);
	}

	file.close();
	cout << "Книг добавлено: " << books.size() << endl;
	cout << "Песен добавлено: " << musics.size() << endl;
	cout << "Фильмов добавлено: " << movies.size() << endl;
}

int main() {
	setlocale(LC_ALL, "ru");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	char Choice;
	int count;
	vector<Book> books;
	vector<Music> musics;
	vector<Movie> movies;

	const string filename = "Library.txt";

	LoadFromFile(books, musics, movies, filename);


	while (true) {
		cout << "Выберите функцию: \n B - Добавить книгу \n M - Добавить музыку \n F - Добавить фильм \n E - Выйти" << endl;
		cin >> Choice;

		if (Choice == 'E' || Choice == 'e') {
			break;
		}

		if (Choice == 'B' || Choice == 'b') {

			cout << "Сколько книг добавить? \n";
			cin >> count;

			for (int i = 0; i < count; i++) {
				Book b;

				cout << "\nКнига номер: " << i + 1 << endl;
				cout << "Название" << endl;

				cin.ignore();
				getline(cin, b.name);

				cout << "Количество страниц: " << endl;
				cin >> b.pages;

				books.push_back(b);
			}
		}

		if (Choice == 'M' || Choice == 'm') {

			cout << "Сколько песен добавить? \n";
			cin >> count;

			for (int i = 0; i < count; i++) {
				Music m;

				cout << "\n Песня номер: " << i + 1 << endl;
				cout << "Название" << endl;

				cin.ignore();
				getline(cin, m.name);

				cout << "Длительность(мин): " << endl;
				cin >> m.duration;

				musics.push_back(m);
			}
		}


		if (Choice == 'F' || Choice == 'f') {

			cout << "Сколько фильмов добавить? \n";
			cin >> count;

			for (int i = 0; i < count; i++) {
				Movie f;

				cout << "\n Фильм номер: " << i + 1 << endl;
				cout << "Название" << endl;

				cin.ignore();
				getline(cin, f.name);

				cout << "Длительность(мин): " << endl;
				cin >> f.duration;

				movies.push_back(f);
			}
		}

		SaveToFile(books, musics, movies, filename);
	}
}