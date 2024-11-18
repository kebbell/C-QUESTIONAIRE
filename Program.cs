// See https://aka.ms/new-console-template for more information

//1
// Write a C# Sharp program to print Hello and your name in a separate line.
// Console.WriteLine("Hello");
// Console.WriteLine("Sam Kebbell");

//2
// Write a C# Sharp program to print the sum of two numbers.
// int num1 = 853;
// double num2 = 434.11;
// double answer = num1 + num2;

// ANSWER
// Console.WriteLine(answer);

// 3
// Write a C# Sharp program to print the result of dividing two numbers.

// ANSWER
// int num3 = 853;
// int num4 = 32;
// double answer2 = num3 / num4;

// Console.WriteLine(answer2);

// 4
// Write a C# Sharp program to print the results of the specified operations.
// -1 + 4 * 6
// ( 35+ 5 ) % 7
// 14 + -4 * 6 / 11
// 2 + 15 / 6 * 1 - 7 % 2
// Expected Output:
// 23
// 5
// 12
// 3

// ANSWER
// Console.WriteLine(-1 + 4 * 6);
// Console.WriteLine(( 35+ 5 ) % 7);
// Console.WriteLine( 14 + -4 * 6 / 11);
// Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

// 5. Write a C# Sharp program to swap two numbers.
// Test Data:
// Input the First Number : 5
// Input the Second Number : 6
// Expected Output:
// After Swapping :
// First Number : 6
// Second Number : 5

// int num5 = 5;
// int num6 = 6;


                            // COME BACK TO THE ABOVE




// 6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
// Test Data:
// Input the first number to multiply: 2
// Input the second number to multiply: 3
// Input the third number to multiply: 6
// Expected Output:
// 2 x 3 x 6 = 36

// ANSWER
// int num7 = 2;
// int num8 = 3;
// int num9 = 6;

// Console.WriteLine(num7 * num8 * num9);


// 7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
// Test Data:
// Input the first number: 25
// Input the second number: 4
// Expected Output:
// 25 + 4 = 29
// 25 - 4 = 21
// 25 x 4 = 100
// 25 / 4 = 6
// 25 mod 4 = 1

// ANSWER
// int num10 = 25;
// int num11 = 4;

// Console.WriteLine(num10 + num11 + " = " + (num10 + num11));
// Console.WriteLine(num10 + " - " + num11 + " = " + (num10 - num11));
// Console.WriteLine(num10 + " x " + num11 + " = " + (num10 * num11));
// Console.WriteLine(num10 + " / " + num11 + " = " + (num10 / num11));
// Console.WriteLine(num10 + " mod " + num11 + " = " + (num10 % num11));

// 8. Write a C# Sharp program that prints the multiplication table of a number as input.
// Test Data:
// Enter the number: 5
// Expected Output:
// 5 * 0 = 0
// 5 * 1 = 5
// 5 * 2 = 10
// 5 * 3 = 15
// ....
// 5 * 10 = 50

// ANSWER
// int num12 = 5;
// int num13 = 0;

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine(num12 + " * " + num13 + " = " + (num12 * num13));
//     num13++;
// }


// 9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
// Test Data:
// Enter the First number: 10
// Enter the Second number: 15
// Enter the third number: 20
// Enter the four number: 30

// Expected Output:
// The average of 10 , 15 , 20 , 30 is: 18

int num14 = 10;
int num15 = 15;
int num16 = 20;
int num17 = 30;

Console.WriteLine("The average of " + num14 + " , " + num15 + " , " + num16 + " , " + num17 + " is: " + ((num14 + num15 + num16 + num17) / 4));

// 10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
// Test Data:
// Enter first number - 5
// Enter second number - 6
// Enter third number - 7

// Expected Output:
// Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

int num18 = 5;
int num19 = 6;
int num20 = 7;

Console.WriteLine("Result of specified numbers " + num18 + ", " + num19 + " and " + num20 + ", (x+y).z is " + ((num18 + num19) * num20) + " and x.y + y.z is " + (num18 * num19 + num19 * num20));

// 11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
// Test Data:
// Enter your age - 25
// Expected Output:
// You look older than 25

int num21 = 25;

Console.WriteLine("You look older than " + num21);

// 12. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
// Test Data:
// Enter a digit: 25
// Expected Output:
// 25 25 25 25
// 25252525
// 25 25 25 25
// 25252525

int num22 = 25;

Console.WriteLine(num22 + " " + num22 + " " + num22 + " " + num22);
Console.WriteLine(num22 + num22 + num22 + num22 + num22 + num22 + num22 + num22);
Console.WriteLine(num22 + " " + num22 + " " + num22 + " " + num22);
Console.WriteLine(num22 + num22 + num22 + num22 + num22 + num22 + num22 + num22);

// 13. Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
// Test Data:
// Enter a number: 5
// Expected Output:
// 555
// 5 5
// 5 5
// 5 5
// 555

int num23 = 5;

Console.WriteLine(num23 + num23 + num23);
Console.WriteLine(num23 + " " + num23);
Console.WriteLine(num23 + " " + num23);
Console.WriteLine(num23 + " " + num23);
Console.WriteLine(num23 + num23 + num23);

// 14. Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
// Test Data:
// Enter the amount of celsius: 30
// Expected Output:
// Kelvin = 303
// Fahrenheit = 86

int num24 = 30;

Console.WriteLine("Kelvin = " + (num24 + 273));
Console.WriteLine("Fahrenheit = " + (num24 * 1.8 + 32));

// 15. Write a C# program that removes a specified character from a non-empty string using the index of a character.
// Test Data:
// w3resource
// Sample Output:
// wresource
// w3resourc
// 3resource

string str = "w3resource";

Console.WriteLine(str.Remove(3));
Console.WriteLine(str.Remove(0, 3));
Console.WriteLine(str.Remove(2, 1));

// 16. Write a C# program to create a new string from a given string where the first and last characters change their positions.
// Test Data:
// w3resource
// Python
// Sample Output:
// e3resourcw
// nythoP
// x

string str2 = "w3resource";

Console.WriteLine(str2[1] + str2[2] + str2[3] + str2[4] + str2[5] + str2[6] + str2[0] + str2[7]);
Console.WriteLine(str2[6] + str2[7] + str2[0] + str2[1] + str2[2] + str2[3] + str2[4] + str2[5]);

// 17. Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
// Sample Output:
// Input a string : The quick brown fox jumps over the lazy dog.
// TThe quick brown fox jumps over the lazy dog.T

string str3 = "The quick brown fox jumps over the lazy dog.";

Console.WriteLine(str3[0] + str3 + str3[str3.Length - 1]);


// 18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
// Sample Output:
// Input first integer:
// -5
// Input second integer:
// 25
// Check if one is negative and one is positive:
// True

int num25 = -5;
int num26 = 25;

Console.WriteLine((num25 < 0 && num26 > 0) || (num25 > 0 && num26 < 0));



// 19. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.

int num27 = 21;
int num28 = 21;

Console.WriteLine((num27 == num28) ? (num27 + num28) * 3 : num27 + num28);


// 20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.

int num29 = 24;
int num30 = 24;

Console.WriteLine((num29 > num30) ? (num29 - num30) * 2 : num29 - num30);
