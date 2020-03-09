// SomeApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    std::cout << "Hello Babe!\n";

    int arr[7] = { 16, 5, 6, 77, 40, 1, 23 };
	int length = 7;
	bool haveSwap = true;

	int i = 0;
	while (i < length - 1 && haveSwap)
	{
		i++;
		haveSwap = false;
		for (int j = 0; j < length - 1; j++)
		{
			
			if (arr[j] > arr[j + 1])
			{
				swap(arr[j], arr[j + 1]);
				haveSwap = true;
			}
		}
	}

	//Print to console
	for (i = 0; i < length; i++)
	{
		cout << arr[i] << ", ";
	}
}

void swap(int a, int b)
{
	int temp = a;
	a = b;
	b = temp;
}


