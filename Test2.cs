// 21. Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.
// Click me to see the solution

int num24 = 20;
int num25 = 20;

Console.WriteLine(num24 + num25 == 20 || num24 == 20 || num25 == 20);



// 22. Write a C# program to check if the given integer is within 20 of 100 or 200.
// Sample Output:
// Input an integer:
// 25
// False
// Click me to see the solution

int num26 = 25;

Console.WriteLine(Math.Abs(100 - num26) <= 20 || Math.Abs(200 - num26) <= 20);


// 23. Write a C# program to convert a given string into lowercase.
// Sample Output:
// write a c# sharp program to display the following pattern using the alphabet.
// Click me to see the solution

string num27 = "write a c# sharp program to display the following pattern using the alphabet.";

Console.WriteLine(num27.ToLower());

// 24. Write a C# program to find the longest word in a string.
// Test Data: Write a C# Sharp Program to display the following pattern using the alphabet.
// Sample Output:
// following
// Click me to see the solution

string num28 = "Write a C# Sharp Program to display the following pattern using the alphabet.";

Console.WriteLine(num28.Split(' ')[0]);


// 25. Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
// Sample Output:
// Odd numbers from 1 to 99. Prints one number per line.
// 1
// 3
// 5
// 7
// 9
// ...
// 95
// 97
// 99
// Click me to see the solution

for (int i = 1; i <= 99; i += 2)
{
    Console.WriteLine(i);
}


// 26. Write a C# program to compute the sum of the first 500 prime numbers.
// Sample Output:
// Sum of the first 500 prime numbers:
// 824693
// Click me to see the solution

int sum = 0;
for (int i = 2; i <= 500; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        sum += i;
    }
}
Console.WriteLine(sum);


// 27. Write a C# program and compute the sum of an integer's digits.
// Sample Output:
// Input a number(integer): 12
// Sum of the digits of the said integer: 3
// Click me to see the solution

int num29 = 12;
int sum2 = 0;
while (num29 > 0)
{
    sum2 += num29 % 10;
    num29 /= 10;
}
Console.WriteLine(sum2);


// 28. Write a C# program to reverse the words of a sentence.
// Sample Output:
// Original String: Display the pattern like pyramid using the alphabet.
// Reverse String: alphabet. the using pyramid like pattern the Display
// Click me to see the solution

string str = "Display the pattern like pyramid using the alphabet.";
string[] words = str.Split(' ');
Array.Reverse(words);
Console.WriteLine(string.Join(" ", words));


// 29. Write a C# program to find the size of a specified file in bytes.
// Sample Output:
// Size of a file: 31
// Click me to see the solution

string path = @"C:\Users\...\Test.txt";
FileInfo file = new FileInfo(path);
Console.WriteLine(file.Length);



// 30. Write a C# program to convert a hexadecimal number to a decimal number.
// Sample Output:
// Hexadecimal number: 4B0
// Convert to-
// Decimal number: 1200
// Click me to see the solution

string hex = "4B0";
int dec = Convert.ToInt32(hex, 16);
Console.WriteLine(dec);

// 31. Write a C# program to multiply the corresponding elements of two integer arrays.
// Sample Output:
// Array1: [1, 3, -5, 4]
// Array2: [1, 4, -5, -2]
// Multiply corresponding elements of two arrays:
// 1 12 25 -8
// Click me to see the solution

int[] arr1 = { 1, 3, -5, 4 };
int[] arr2 = { 1, 4, -5, -2 };

for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i] * arr2[i] + " ");
}



// 32. Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.
// Sample Output:
// Input a string : The quick brown fox jumps over the lazy dog.
// dog.dog.dog.dog.
// Click me to see the solution



// 33. Write a C# program to check if a given positive number is a multiple of 3 or 7.
// Sample Output:
// Input first integer:
// 15
// True
// Click me to see the solution



// 34. Write a C# program to check if a string starts with a specified word.
// Note: Suppose the sentence starts with "Hello"
// Sample Data: string1 = "Hello how are you?"
// Result: Hello.
// Sample Output:
// Input a string : Hello how are you?
// True
// Click me to see the solution



// 35. Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.
// Sample Output:
// Input a first number(<100): 75
// Input a second number(>100): 250
// True
// Click me to see the solution



// 36. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
// Sample Output:
// Input a first number: -5
// Input a second number: 8
// True
// Click me to see the solution



// 37. Write a C# program to check if "HP" appears at the second position in a string and return the string without "HP".
// Test Data: PHP Tutorial
// Sample Output:
// P Tutorial
// Click me to see the solution



// 38. Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
// Test Data: PHP
// Sample Output:
// PH
// Click me to see the solution



// 39. Write a C# program to find the largest and lowest values from three integer values.
// Test Data:
// Input first integer:
// 15
// Input second integer:
// 25
// Input third integer:
// 30
// Sample Output
// Largest of three: 30
// Lowest of three: 15
// Click me to see the solution



// 40. Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.
// Test Data:
// Input first integer:
// 15
// Input second integer:
// 12
// Sample Output
// 15
// Click me to see the solution



// 41. Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
// Test Data:
// Input a string (contains at least one 'w' char) : w3resource
// Test the string contains 'w' character between 1 and 3 times:
// Sample Output
// True