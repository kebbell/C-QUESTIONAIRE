// // 21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
// // Sample Input:
// // 78, 95
// // 20, 30
// // 21, 25
// // 28, 28
// // Expected Output:
// // 0
// // 30
// // 25
// // 28
// // Click me to see the solution

// using System.Diagnostics;

// int a = 78, b = 95;
// if (a > 20 && a < 30 && b > 20 && b < 30)
// {
//     Console.WriteLine(Math.Max(a, b));
// }
// else
// {
//     Console.WriteLine(0);
// }


// // 22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
// // Sample Input:
// // "frizz"
// // "zane"
// // "Zazz"
// // "false"
// // "zzzz"
// // "ZZZZ"
// // Expected Output:
// // True
// // False
// // True
// // False
// // True
// // False
// // Click me to see the solution

// string s = "frizz";
// bool containsZ = s.Contains('z');
// bool containsZ2 = s.Contains('z') && s.Contains('z') && s.Contains('z');
// Console.WriteLine(containsZ);   
// Console.WriteLine(containsZ2);

// // 23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
// // Sample Input:
// // 123, 456
// // 12, 512
// // 7, 87
// // 12, 45
// // Expected Output:
// // False
// // True
// // True
// // False
// // Click me to see the solution

// int a1 = 123, b1 = 456;
// int a2 = 12, b2 = 512;
// int a3 = 7, b3 = 87;
// int a4 = 12, b4 = 45;
// if (a1 % 10 == b1 % 10 && a2 % 10 == b2 % 10 && a3 % 10 == b3 % 10 && a4 % 10 == b4 % 10)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }



// // 24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.
// // Sample Input:
// // "Python"
// // "Javascript"
// // "js"
// // "PHP"
// // Expected Output:
// // PytHON
// // JavascrIPT
// // JS
// // PHP
// // Click me to see the solution

// string s1 = "Python";
// string s2 = "Javascript";
// string s3 = "js";
// string s4 = "PHP";
// int length = s1.Length;
// if (length < 3)
// {
//     Console.WriteLine(s1.ToUpper());
//     Console.WriteLine(s2.ToUpper());
//     Console.WriteLine(s3.ToUpper());
//     Console.WriteLine(s4.ToUpper());
// }
// else
// {
//     Console.WriteLine(s1.Substring(length - 3));
//     Console.WriteLine(s2.Substring(length - 3));
//     Console.WriteLine(s3.Substring(length - 3));
//     Console.WriteLine(s4.Substring(length - 3));
// }


// 25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.
// Sample Input:
// "JS", 2
// "JS", 3
// "JS", 1
// Expected Output:
// JSJS
// JSJSJS
// JS
// Click me to see the solution

string s1 = "JS";
int n = 2;
string result = "";
for (int i = 0; i < n; i++)
{
    result += s1;
}
Console.WriteLine(result);


// 26. Write a C# Sharp program to create a string that is n (non-negative integer) copies of the first 3 characters of a given string. If the given string is shorter than 3, return n copies of the string.
// Sample Input:
// "Python", 2
// "Python", 3
// "JS", 3
// Expected Output:
// PytPyt
// PytPytPyt
// JSJSJS
// Click me to see the solution

string s2 = "Python";
int n2 = 2;
string result2 = "";
if (s2.Length < 3)
{
    for (int i = 0; i < n2; i++)
    {
        result2 += s2;
    }
    Console.WriteLine(result2);
}
else
{
    result2 = s2.Substring(0, 3);
    for (int i = 0; i < n2 - 1; i++)
    {
        result2 += result2;
    }
    Console.WriteLine(result2);
}



// 27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
// Sample Input:
// "bbaaccaag"
// "jjkiaaasew"
// "JSaaakoiaa"
// Expected Output:
// 2
// 2
// 3
// Click me to see the solution

string s3 = "bbaaccaag";
string s4 = "jjkiaaasew";
string s5 = "JSaaakoiaa";
int count = 0;
int count2 = 0;
int count3 = 0;
for (int i = 0; i < s3.Length; i++)
{
    if (s3.Substring(i, 2) == "aa")
    {
        count++;
    }
}
for (int i = 0; i < s4.Length; i++)
{
    if (s4.Substring(i, 3) == "aaa")
    {
        count2++;
    }
}
for (int i = 0; i < s5.Length; i++)
{
    if (s5.Substring(i, 3) == "aaa")
    {
        count3++;
    }
}
Console.WriteLine(count);
Console.WriteLine(count2);
Console.WriteLine(count3);  


// 28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
// Sample Input:
// "caabb"
// "babaaba"
// "aaaaa"
// Expected Output:
// True
// False
// True
// Click me to see the solution





// 29. Write a C# Sharp program to create a string made of every other character starting with the first in a given string.
// Sample Input:
// "Python"
// "PHP"
// "JS"
// Expected Output:

// Pto
// PP
// J
// Click me to see the solution
// 30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".

// Sample Input:
// "abcd"
// "abc"
// "a"
// Expected Output:

// aababcabcd
// aababc
// a
// Click me to see the solution
// 31. Write a C# Sharp program to count a substring of length 2 that appears in a given string. This substring appears as the last 2 characters of the string. Do not count the end substring.

// Sample Input:
// "abcdsab"
// "abcdabab"
// "abcabdabab"
// "abcabd"
// Expected Output:

// 1
// 2
// 3
// 0
// Click me to see the solution
// 32. Write a C# Sharp program to check if a specified number is present in a given array of integers.

// Sample Input:
// {1,2,9,3}, 3
// {1,2,2,3}, 2
// {1,2,2,3}, 9
// Expected Output:

// True
// True
// False
// Click me to see the solution
// 33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.

// Sample Input:
// {1,2,9,3}, 3
// {1,2,3,4,5,6}, 2
// {1,2,2,3}, 9
// Expected Output:

// True
// True
// False
// Click me to see the solution
// 34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.

// Sample Input:
// {1,1,2,3,1}
// {1,1,2,4,1}
// {1,1,2,1,2,3}
// Expected Output:

// True
// False
// True
// Click me to see the solution
// 35. Write a C# Sharp program to compare two given strings and return the number of positions where they contain the same length of 2 substrings.

// Sample Input:
// "abcdefgh", "abijsklm"
// "abcde", "osuefrcd"
// "pqrstuvwx", "pqkdiewx"
// Expected Output:

// 1
// 1
// 2
// Click me to see the solution
// 36. Write a C# Sharp program to create a string from a given string where a specified character is removed except for the beginning and ending positions.

// Sample Input:
// "xxHxix", "x"
// "abxdddca", "a"
// "xabjbhtrb", "b"
// Expected Output:

// xHix
// abxdddca
// xajhtrb
// Click me to see the solution
// 37. Write a C# Sharp program to create a string of characters at indexes 0,1, 4,5, 8,9 ... from a given string.

// Sample Input:
// "Python"
// "JavaScript"
// "HTML"
// Expected Output:

// Pyon
// JaScpt
// HT
// Click me to see the solution
// 38. Write a C# Sharp program to count the number of two 5's next to each other in an array of integers. Count the situation where the second 5 is actually a 6.

// Sample Input:
// { 5, 5, 2 }
// { 5, 5, 2, 5, 5 }
// { 5, 6, 2, 9}
// Expected Output:

// 1
// 2
// 1
// Click me to see the solution
// 39. Write a C# Sharp program to check if a triple is present in an array of integers or not. If a value appears three times in a row in an array it is called a triple.

// Sample Input:
// { 1, 1, 2, 2, 1 }
// { 1, 1, 2, 1, 2, 3 }
// { 1, 1, 1, 2, 2, 2, 1 }
// Expected Output:

// False
// False
// True
// Click me to see the solution
// 40. Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.

// Sample Input:
// 12, 17
// 2, 17
// 22, 17
// 20, 0
// Expected Output:

// 29
// 30
// 39
// 30
// Click me to see the solution