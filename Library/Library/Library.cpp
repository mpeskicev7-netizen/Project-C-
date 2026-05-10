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

  }

  int main() {
	  setlocale(LC_ALL, "ru");

	  char Choice;
	  vector<Book> books;
	  vector<Music> musics;
	  vector<Movie> movies;

	  while (true) {
		  cout << "Выберите функцию: \n B - Добавить книгу \n M - Добавить музыку \n F - Добавить фильм \n E - Выйти" << endl;
		  cin >> Choice;

		  if (Choice == 'E' || Choice == 'e') {
			  break;
		  }

		  if (Choice == 'B' || Choice == 'b') {
			
		  }
	  }
  }