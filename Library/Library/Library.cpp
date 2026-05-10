#include <iostream>
#include<string>
#include <fstream>
#include<vector>
#include<windows.h>


using namespace std;

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

  void SaveToFile(const vector<Book>& books, const vector<Music>& musics, const vector<Movie>& movies, const string& filename) {
	  ofstream file(filename);

	  if (!file.is_open()) {
		  cout << "Не удалось отркыть файл";

		  return;
	  }

	  file << books.size() << "Книг(а)" << endl;
	  file << musics.size() << "Песен(я/и)" << endl;
	  file << movies.size() << "Фильмов(а)" << endl;

	  for (const auto& b : books) {
		  
		  file << b.Name << endl;
		  file << b.Pages << endl;
	  }


	  for (const auto& m : musics) {

		  file << m.Name << endl;
		  file << m.Duration << endl;
	  }

	  for (const auto& f : movies) {

		  file << f.Name << endl;
		  file << f.Duration << endl;
	  }

	  file.close();
	  cout << "Данные сохранены в файл " << filename;
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

			  SaveToFile(books, musics, movies, filename);
		  }
	  }
  }