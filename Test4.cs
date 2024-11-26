// 61. Write a C# program to sort the integers in ascending order without moving the number -5.
// Click me to see the solution

int[] arr8 = { 1, 2, 3, 4, 5, -5, 6, 7, 8, 9 };
int[] arr9 = new int[arr8.Length];
int j = 0;
for (int i = 0; i < arr8.Length; i++)
{
    if (arr8[i] != -5)
    {
        arr9[j] = arr8[i];
        j++;
    }
}
Array.Sort(arr9);
for (int i = 0; i < arr9.Length; i++)
{
    Console.Write(arr9[i] + " ");
}

// 62. Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string. It should also remove the parentheses from the given string.
// Click me to see the solution

string str1 = "Hello (W3resource) World";
string str2 = "";
for (int i = 0; i < str1.Length; i++)
{
    if (str1[i] == '(')
    {
        str2 += " ";
    }
    else if (str1[i] == ')')
    {
        str2 += " ";
    }
    else
    {
        str2 += str1[i];
    }
}
Console.WriteLine(str2);

// 63. Write a C# program to check if a given number is present in an array of numbers.
// Click me to see the solution

int[] arr10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int num1 = 5;
bool isPresent = false;
for (int i = 0; i < arr10.Length; i++)
{
    if (arr10[i] == num1)
    {
        isPresent = true;
        break;
    }
}
Console.WriteLine("Is " + num1 + " present in the array? " + isPresent);

// 64. Write a C# Sharp program to get the file name (including extension) from a given path.
// Click me to see the solution

string path = "C:\\Users\\user\\Desktop\\test.txt";
string fileName = Path.GetFileName(path);
Console.WriteLine("File name: " + fileName);

// 65. Write a C# Sharp program to multiply all elements of a given array of numbers by array length.
// Click me to see the solution

int[] arr11 = { 1, 2, 3, 4, 5 };
int product = 1;
for (int i = 0; i < arr11.Length; i++)
{
    product *= arr11[i];
}
Console.WriteLine("Product: " + product);

// 66. Write a C# Sharp program to find the minimum value from two numbers given to you, represented as a string.
// Click me to see the solution

// 67. Write a C# Sharp program to create a coded string from a given string, using a specified formula.
// Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
// Sample Output:
// 969
// J8V81CRI90
// Click me to see the solution

// 68. Write a C# Sharp program to count a specified character (both cases) in a given string.
// Click me to see the solution

// 69. Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.
// Click me to see the solution

// 70. Write a C# Sharp program to remove the first and last elements from a given string.
// Sample Output:
// Original string: PHP
// After removing first and last elements: H
// Original string: Python
// After removing first and last elements: ytho
// Original string: JavaScript
// After removing first and last elements: avaScrip
// Click me to see the solution

// 71. Write a C# Sharp program to check if a given string contains two similar consecutive letters.
// Sample Output:
// Original string: PHP
// Test for consecutive similar letters! False
// Original string: PHHP
// Test for consecutive similar letters! True
// Original string: PHPP
// Test for consecutive similar letters! True
// Original string: PPHP
// Test for consecutive similar letters! True
// Click me to see the solution

// 72. Write a C# Sharp program to check whether the average value of the elements of a given array of numbers is a whole number or not.
// Sample Output:
// nums = { 1, 2, 3, 5, 4, 2, 3, 4 }
// Check the average value of the said array is a whole number or not: True
// nums1 = { 2, 4, 2, 6, 4, 8 }
// Check the average value of the said array is a whole number or not: False
// Click me to see the solution

// 73. Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.
// Sample Output:
// Original string: PHP
// Convert the letters of the said string into alphabetical order: HPP
// Original string: javascript
// Convert the letters of the said string into alphabetical order: aacijprstv
// Original string: python
// Convert the letters of the said string into alphabetical order: hnopty
// Click me to see the solution

// 74. Write a C# Sharp program to check the length of a given string is odd or even. Return 'Odd length' if the string length is odd otherwise 'Even length'.
// Sample Output:
// Original string: PHP
// Convert the letters of the said string into alphabetical order: Odd length
// Original string: javascript
// Convert the letters of the said string into alphabetical order: Even length
// Original string: python
// Convert the letters of the said string into alphabetical order: Even length
// Click me to see the solution

// 75. Write a C# Sharp program that takes a positive number and returns the nth odd number.
// Sample Output:
// 1st odd number: 1
// 2nd odd number: 3
// 4th odd number: 7
// 100th odd number: 199
// Click me to see the solution

// 76. Write a C# Sharp program to get the ASCII value of a given character.
// Sample Output:
// Ascii value of 1 is: 49
// Ascii value of A is: 65
// Ascii value of a is: 97
// Ascii value of # is: 35
// Click me to see the solution

// 77. Write a C# Sharp program to check whether a word is plural or not.
// Sample Output:
// Is 'Exercise' is plural? False
// Is 'Exercises' is plural? True
// Is 'Books' is plural? True
// Is 'Book' is plural? False
// Click me to see the solution

// 78. Write a C# Sharp program to find the sum of squares of elements in a given array of integers.
// Sample Output:
// Sum of squares of elements of the said array: 14
// Sum of squares of elements of the said array: 29
// Click me to see the solution

// 79. Write a C# Sharp program to convert an integer to a string and a string to an integer.
// Sample Output:
// Original value and type: 50, System.String
// Convert string to integer:
// Return value and type: 50, System.Int32
// Original value and type: 122, System.Int32
// Convert integer to string:
// Return value and type: 122, System.String
// Click me to see the solution

// 80. Write a C# Sharp program to convert all the values of a given array of mixed values to string values.
// Sample Output:
// Printing original array elements and their types:
// Value-> 25 :: Type-> System.Int32
// Value-> Anna :: Type-> System.String
// Value-> False :: Type-> System.Boolean
// Value-> 4/15/2021 10:37:47 AM :: Type-> System.DateTime
// Value-> 112.22 :: Type-> System.Double
// Printing array elements and their types:
// Value-> 25 :: Type-> System.String
// Value-> Anna :: Type-> System.String
// Value-> False :: Type-> System.String
// Value-> 4/15/2021 10:37:47 AM :: Type-> System.String
// Value-> 112.22 :: Type-> System.String
// Click me to see the solution