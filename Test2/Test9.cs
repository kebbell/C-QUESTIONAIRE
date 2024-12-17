// 61. Write a C# Sharp program to insert a given string into the middle of another given string of length 4.
// Sample Input:
// "[[]]","Hello"
// "(())", "Hi"
// Expected Output:
// [[Hello]]
// ((Hi))
// Click me to see the solution

string s1 = "[[]]", s2 = "Hello";
string s3 = "(())", s4 = "Hi";
string s5 = s1.Insert(1, s2);
string s6 = s3.Insert(1, s4);
Console.WriteLine(s5);
Console.WriteLine(s6);


// 62. Write a C# Sharp program to create a string using three copies of the last two characters of a given string of length at least two.
// Sample Input:
// "Hello"
// "Hi"
// Expected Output:
// lololo
// HiHiHi
// Click me to see the solution

string s7 = "Hello";
string s8 = "Hi";
string s9 = s7.Substring(s7.Length - 2) + s7.Substring(s7.Length - 2) + s7.Substring(s7.Length - 2);
string s10 = s8.Substring(s8.Length - 2) + s8.Substring(s8.Length - 2) + s8.Substring(s8.Length - 2);  
Console.WriteLine(s9);
Console.WriteLine(s10);



// 63. Write a C# Sharp program to create a new string using the first two characters of a given string. If the string length is less than 2, return the original string.
// Sample Input:
// "Hello"
// "Hi"
// "H"
// " "
// Expected Output:
// He
// Hi
// H
// Click me to see the solution




// 64. Write a C# Sharp program to create a string from the first half of a given string of even length.
// Sample Input:
// "Hello"
// "Hi"
// Expected Output:
// He
// H
// Click me to see the solution




// 65. Write a C# Sharp program to create a new string without the first and last character of a given string of length at least two.
// Sample Input:
// "Hello"
// "Hi"
// "Python"
// Expected Output:
// ell
// ytho
// Click me to see the solution



// 66. Write a C# Sharp program to create a new string from two given strings, one of which is shorter and one of which is longer. The new string format will be long string + short string + long string.
// Sample Input:
// "Hello", "Hi"
// "JS", "Python"
// Expected Output:
// HelloHiHello
// PythonJSPython
// Click me to see the solution




// 67. Write a C# Sharp program to combine two strings of length at least 1, after removing their first character.
// Sample Input:
// "Hello", "Hi"
// "JS", "Python"
// Expected Output:
// elloi
// Sython
// Click me to see the solution



// 68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.
// Sample Input:
// "Hello"
// "JS"
// Expected Output:
// lloHe
// JS
// Click me to see the solution



// 69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.
// Sample Input:
// "Hello"
// "JS"
// Expected Output:

// loHel
// JS
// Click me to see the solution
// 70. Write a C# Sharp program to create a new string without the first and last characters of a given string of any length.

// Sample Input:
// "Hello"
// "JS"
// ""
// Expected Output:

// ell
// Click me to see the solution
// 71. Write a C# Sharp program to create a string using the two middle characters of a given string of even length (at least 2).

// Sample Input:
// "Hell"
// "JS"
// Expected Output:

// el
// JS
// Click me to see the solution
// 72. Write a C# Sharp program to check if a given string ends with "on".

// Sample Input:
// "Hello"
// "Python"
// "on"
// "o"

// Expected Output:

// False
// True
// True
// False
// Click me to see the solution
// 73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.

// Sample Input:
// "Hello", 1
// "Python", 2
// "on", 1
// "o", 1
// Expected Output:

// Ho
// Pyon
// on
// oo
// Click me to see the solution
// 74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.

// Sample Input:
// "Hello", 1
// "Python", 2
// "on", 1
// Expected Output:

// el
// th
// on
// Click me to see the solution
// 75. Write a C# Sharp program to create a string by taking at least 3 characters from the middle of a given string.

// Sample Input:
// "Hello"
// "Python"
// "abc"
// Expected Output:

// ell
// yth
// abc
// Click me to see the solution
// 76. Write a C# Sharp program to create a new string of length 2, using the first two characters of a given string. If the given string length is less than 2 use '#' as missing characters.

// Sample Input:
// "Hello"
// "Python"
// "a"
// ""
// Expected Output:

// He
// Py
// a#
// ##
// Click me to see the solution
// 77. Write a C# Sharp program to create a string by taking the first character from a string and the last character from another string. If a string's length is 0, use '#' as its missing character.

// Sample Input:
// "Hello", "Hi"
// "Python", "PHP"
// "JS", "JS"
// "Csharp", ""
// Expected Output:

// Hi
// PP
// JS
// C#
// Click me to see the solution
// 78. Write a C# Sharp program to combine two given strings (lowercase). If there are any double characters in the string, omit one character.

// Sample Input:
// "abc", "cat"
// "python", "php"
// "php", "php"
// Expected Output:

// abcat
// pythonphp
// phphp
// Click me to see the solution
// 79. Write a C# Sharp program to create a new string from a given string after swapping the last two characters.

// Sample Input:
// "Hello"
// "Python"
// "PHP"
// "JS"
// "C"
// Expected Output:

// Helol
// Pythno
// PPH
// SJ
// C
// Click me to see the solution
// 80. Write a C# Sharp program to check if a given string begins with 'abc' or 'xyz'. If the string begins with 'abc' or 'xyz' return 'abc' or 'xyz' otherwise return an empty string.

// Sample Input:
// "abc"
// "abcdef"
// "C"
// "xyz"
// "xyzsder"
// Expected Output:

// abc
// abc

// xyz
// xyz
// Click me to see the solution