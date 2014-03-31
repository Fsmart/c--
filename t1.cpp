#include <iostream>  //预定义
#include <iomanip>
using namespace std;

int main()
{
	cout << "    ";
	for (int colHead= 0; colHead < 11; colHead++)
	cout << setw(3) << colHead;
	cout << endl;
	cout << " ---------------------------------" << endl;
	for (int rowVal = 0; rowVal < 10; rowVal++)
	{
		cout << setw(3) << rowVal << ' ' << "|";
		for (int colVal = 0; colVal <11; colVal++)
			cout << setw(3) << rowVal * colVal;
		cout << endl;
	}

	return 0;
}
