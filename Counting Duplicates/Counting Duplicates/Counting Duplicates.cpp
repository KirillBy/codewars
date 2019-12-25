// Counting Duplicates.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
//size_t duplicateCount(const std::string& in); // helper for tests

size_t duplicateCount( const char* in)
{
	size_t counter = 0;
	int j = 0;
	while (*(in + j) != '\0') //taking size of string
	{
		j++;
	}
	char *word = new char[j]; //making new array
	j = 0;
	while (*(in + j) != '\0') //taking size of string
	{
		*(word + j) = *(in + j);
		j++;
	}
	/////////////////////

	
    for(int i =0; i < j; i++) // all symbols to lower
	{	
		if (isalpha(*(word + i)))
		{
			if (isupper(*(word + i)))  *(word +i) = tolower(*(word + i));
		}
	}


	for (int i = 0; i < j; i++) // all symbols to lower
	{
		if (isalpha(*(word + i)))
		{
			if (isupper(*(word + i)))  *(word + i) = tolower(*(word + i));
		}
	}

	int finalArray[36] = { 0 };
	for (int i = 0; i < j; i++) // checking each symbol
	{
		if (isdigit(*(word + i)))
		{
			finalArray[*(word + i)]++;
		}
		else if(isalpha(*(word + i)))
		{
			finalArray[*(word + i) - 87]++;
		}
	}
	for (int i = 0; i < 36; i++) //count number of repeateble symbols
	{
		if (finalArray[i] > 1)
			counter++;
	}
	delete[] word;
	return counter;
}
int main()
{
	size_t result = duplicateCount("AaaA232__**==01012");
	std::cout << result;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
