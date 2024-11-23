// 41. Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
// Test Data:
// Input a string (contains at least one 'w' char) : w3resource
// Test the string contains 'w' character between 1 and 3 times:
// Sample Output
// True
// Click me to see the solution

string str = "w3resource";
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == 'w')
    {
        count++;
    }
}
if (count >= 1 && count <= 3)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

// 42. Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.
// Test Data:
// Input a string: w3r
// Sample Output
// W3R
// Click me to see the solution

string str2 = "w3r";
if (str2.Length < 4)
{
    Console.WriteLine(str2.ToUpper());
}
else
{
    Console.WriteLine(str2.Substring(0, 4).ToLower());
}

// 43. Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".
// Test Data:
// Input a string : www
// Sample Output
// False
// Click me to see the solution

// 44. Write a C# program to create a string of every other character (odd position) from the first position of a given string.
// Test Data:
// Input a string : w3resource
// Sample Output
// wrsuc
// Click me to see the solution

// 45. Write a C# program to count a specified number in a given array of integers.
// Test Data:
// Input an integer: 5
// Sample Output
// Number of 5 present in the said array: 2
// Click me to see the solution

// 46. Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.
// Test Data:
// Input an integer: 25
// Sample Output
// False
// Click me to see the solution

// 47. Write a C# program to compute the sum of all the elements of an array of integers.
// Test Data:
// Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
// Sample Output
// Sum: 69
// Click me to see the solution

// 48. Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more.
// Test Data:
// Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
// Sample Output
// True
// Click me to see the solution

// 49. Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.
// Test Data:
// Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
// Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
// Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
// Sample Output
// True
// Click me to see the solution

// 50. Write a C# program to rotate an array (length 3) of integers in the left direction.
// Test Data:
// Array1: [1, 2, 8]
// After rotating array becomes: [2, 8, 1]
// Click me to see the solution

// 51. Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.
// Test Data:
// Array1: [1, 2, 5, 7, 8]
// Highest value between first and last values of the said array: 8
// Click me to see the solution

// 52. Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
// Test Data:
// Array1: [1, 2, 5]
// Array2: [0, 3, 8]
// Array3: [-1, 0, 2]
// New array: [2, 3, 0]
// Click me to see the solution

// 53. Write a C# program to check if an array contains an odd number.
// Test Data:
// Original array: [2, 4, 7, 8, 6]
// Check if an array contains an odd number? True
// Click me to see the solution

// 54. Write a C# program to get the century of a year.
// Click me to see the solution

// 55. Write a C# program to find the pair of adjacent elements that has the largest product of the given array.
// Click me to see the solution

// 56. Write a C# program to check if a given string is a palindrome or not.
// Sample Example:
// For 'aaa' the output should be true
// For 'abcd' the output should be false
// Click me to see the solution

// 57. Write a C# program to find the pair of adjacent elements that has the highest product of an array of integers.
// Click me to see the solution



// 58. Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range.
// Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list. So output will be 4.
// Click me to see the solution



// 59. Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array.
// Click me to see the solution




// 60. Write a C# program to calculate the sum of all integers in a rectangular matrix. However, exclude those integers located below an integer of value 0.
// Sample Example:
// matrix = [[0, 2, 3, 2],
// [0, 6, 0, 1],
// [4, 0, 3, 0]]
// Eligible integers which will be participated to calculate the sum -
// matrix = [[X, 2, 3, 2],
// [X, 6, X, 1],
// [X, X, X, X]]
// Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
// Click me to see the solution