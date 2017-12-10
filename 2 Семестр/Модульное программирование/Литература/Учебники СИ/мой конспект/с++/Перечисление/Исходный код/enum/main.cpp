#include <iostream>
#include <clocale>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	enum spectrum {red, white, blue, green};

    cout << "Hello world!" <<spectrum<< endl;
    return 0;
}
