#include <iostream>
#include<string>
#include <fstream>
#include<vector>
#include<windows.h>


using namespace std;

class Item {
public:
	string Name;
	int Pages;
	int Duration;
};

 class Book {
 public:
	 string Name;
	 int Pages;

};

 class Music {
 public:
	 string Name;
	 int Duration;
 };

 class Movie {
 public:
	 string Name;
	 int Duration;
 };

  void SaveToFile(const vector<Item>& items, const string& filename) {
	  ofstream file(filename);

	  if (!file.is_open()) {
		  cout << "Не удалось отркыть файл";

		  return;
	  }

	  file << items.size() << endl;

	  for (const auto& b : items) {
		  
		  file << b.Name << endl;
		  file << b.Pages << endl;
	  }

	  file.close();
	  cout << "Данные сохранены в файл " << filename << endl;
  }

  void LoadFromFile(vector<Item>& items, const string& filename) {
	  ifstream file(filename);

	  if (!file.is_open()) {
		  cout << "Файл не был найден. Будет создан новый" << endl;

		  return;
	  }

	  items.clear();

	  int Bookcount, Musiccount, Moviecount;
	  file >> Bookcount;
	  file >> Musiccount;
	  file >> Moviecount;
	  file.ignore();

	  for (int i = 0; i < Bookcount; i++) {
		  Book b;
		  getline(file, b.Name);
		  file >> b.Pages;
		  file.ignore();
		  books.push_back(b);
	  }

	  for (int i = 0; i < Musiccount; i++) {
		  Music m;
		  getline(file, m.Name);
		  file >> m.Duration;
		  file.ignore();
		  musics.push_back(m);
	  }

	  for (int i = 0; i < Moviecount; i++) {
		  Movie f;
		  getline(file, f.Name);
		  file >> f.Duration;
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
	  vector<Item> items;

	  const string filename = "Library.txt";

	  LoadFromFile(items, filename);


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
				  getline(cin, b.Name);

				  cout << "Количество страниц: " << endl;
				  cin >> b.Pages;

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
				  getline(cin, m.Name);

				  cout << "Длительность(мин): " << endl;
				  cin >> m.Duration;

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
				  getline(cin, f.Name);

				  cout << "Длительность(мин): " << endl;
				  cin >> f.Duration;

				  movies.push_back(f);
			  }
		  }

		  SaveToFile(books, musics, movies, filename);
	  }
  }