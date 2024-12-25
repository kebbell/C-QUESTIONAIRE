// // 81. Write a C# Sharp program to check whether the first two characters and the last two characters of a given string are the same.
// // Sample Input:
// // "abab"
// // "abcdef"
// // "xyzsderxy"
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// string s1 = "abab";
// string s2 = "abcdef";
// string s3 = "xyzsderxy";
// if (s1.Substring(0, 2) == s1.Substring(s1.Length - 2, 2))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }
// if (s2.Substring(0, 2) == s2.Substring(s2.Length - 2, 2))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }
// if (s3.Substring(0, 2) == s3.Substring(s3.Length - 2, 2))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 82. Write a C# Sharp program to combine two given strings. If the given strings have different lengths remove the characters from the longer string.
// // Sample Input:
// // "abc", "abcd"
// // "Python", "Python"
// // "JS", "Python"
// // Expected Output:
// // abcbcd
// // PythonPython
// // JSon
// // Click me to see the solution

// string s12 = "abc";
// string s22 = "abcd";
// string s32 = "Python";
// string s4 = "Python";
// string s5 = "JS";
// string s6 = "Python";
// if (s1.Length > s22.Length)
// {
//     s12 = s12.Substring(0, s22.Length);
// }
// else
// {
//     s22 = s22.Substring(0, s12.Length);
// }
// Console.WriteLine(s12 + s22);
// if (s32.Length > s4.Length)
// {
//     s32 = s32.Substring(0, s4.Length);
// }
// else
// {
//     s4 = s4.Substring(0, s32.Length);
// }
// Console.WriteLine(s32 + s4);
// if (s5.Length > s6.Length)
// {
//     s5 = s5.Substring(0, s6.Length);
// }
// else
// {
//     s6 = s6.Substring(0, s5.Length);
// }
// Console.WriteLine(s5 + s6);


// // 83. Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. If the string length is less than 2 use the whole string.
// // Sample Input:
// // "abc"
// // "Python"
// // "J"
// // Expected Output:
// // ababab
// // PyPyPy
// // JJJ
// // Click me to see the solution

// string s7 = "abc";
// string s81 = "Python";
// string s91 = "J";
// if (s7.Length > 2)
// {
//     s7 = s7.Substring(0, 2) + s7.Substring(0, 2) + s7.Substring(0, 2);
// }
// else
// {    
//     s7 = s7.Substring(0, s7.Length) + s7.Substring(0, s7.Length) + s7.Substring(0, s7.Length);
// }
// Console.WriteLine(s7);
// if (s81.Length > 2)
// {
//     s81 = s81.Substring(0, 2) + s81.Substring(0, 2) + s81.Substring(0, 2);
// }
// else
// {
//     s81 = s81.Substring(0, s81.Length) + s81.Substring(0, s81.Length) + s81.Substring(0, s81.Length);
// }
// Console.WriteLine(s81);
// if (s91.Length > 2)
// {
//     s91 = s91.Substring(0, 2) + s91.Substring(0, 2) + s91.Substring(0, 2);
// }
// else
// {
//     s91 = s91.Substring(0, s91.Length) + s91.Substring(0, s91.Length) + s91.Substring(0, s91.Length);
// }
// Console.WriteLine(s91);


// // 84. Write a C# Sharp program to create a new string from a string. In the case that the two characters at the beginning and end of the given string are the same, return the given string without the first two characters, otherwise return the original string.
// // Sample Input:
// // "abcab"
// // "Python"
// // Expected Output:
// // cab
// // Python
// // Click me to see the solution

// string s10 = "abcab";
// string s11 = "Python";
// if (s10.Substring(0, 1) == s10.Substring(s10.Length - 1, 1))
// {
//     s10 = s10.Substring(2);
// }
// Console.WriteLine(s10);
// if (s11.Substring(0, 1) == s11.Substring(s11.Length - 1, 1))
// {
//     s11 = s11.Substring(2);
// }
// Console.WriteLine(s11); 


// 85. Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y".
// Sample Input:
// "abcab"
// "python"
// "press"
// "jython"
// Expected Output:
// cab
// python
// pess
// ython
// Click me to see the solution

string s12 = "abcab";
string s13 = "python";
string s14 = "press";
string s15 = "jython";
if (s12.Substring(0, 1) == "p" && s12.Substring(1, 1) == "y")
{
    s12 = s12.Substring(2);
}
Console.WriteLine(s12);
if (s13.Substring(0, 1) == "p" && s13.Substring(1, 1) == "y")
{
    s13 = s13.Substring(2);
}
Console.WriteLine(s13);
if (s14.Substring(0, 1) == "p" && s14.Substring(1, 1) == "y")
{
    s14 = s14.Substring(2);
}
Console.WriteLine(s14);
if (s15.Substring(0, 1) == "p" && s15.Substring(1, 1) == "y")
{
    s15 = s15.Substring(2);
}
Console.WriteLine(s15); 

// 86. Write a C# Sharp program to create a string from a given string without the first and last character. This is if the first or last characters are 'a' otherwise return the original given string.
// Sample Input:
// "abcab"
// "python"
// "abcda"
// "jython"
// Expected Output:
// bcab
// python
// bcd
// jython
// Click me to see the solution

string s16 = "abcab";
string s17 = "python";
string s18 = "abcda";
string s19 = "jython";
if (s16.Substring(0, 1) == "a" && s16.Substring(s16.Length - 1, 1) == "a")
{
    s16 = s16.Substring(1, s16.Length - 2);
}
Console.WriteLine(s16);
if (s17.Substring(0, 1) == "a" && s17.Substring(s17.Length - 1, 1) == "a")
{
    s17 = s17.Substring(1, s17.Length - 2);
}
Console.WriteLine(s17);
if (s18.Substring(0, 1) == "a" && s18.Substring(s18.Length - 1, 1) == "a")
{
    s18 = s18.Substring(1, s18.Length - 2);
}
Console.WriteLine(s18);
if (s19.Substring(0, 1) == "a" && s19.Substring(s19.Length - 1, 1) == "a")
{
    s19 = s19.Substring(1, s19.Length - 2);
}
Console.WriteLine(s19);

// 87. Write a C# Sharp program to create a new string from a given string. Return the string without the first or first two 'a' characters otherwise return the original string.
// Sample Input:
// "abcab"
// "python"
// "aacda"
// "jython"
// Expected Output:
// bcab
// python
// cda
// jython
// Click me to see the solution

string s20 = "abcab";
string s21 = "python";
string s22 = "aacda";
string s23 = "jython";
if (s20.Substring(0, 1) == "a" && s20.Substring(1, 1) == "a")
{
    s20 = s20.Substring(2);
}
Console.WriteLine(s20);
if (s21.Substring(0, 1) == "a" && s21.Substring(1, 1) == "a")
{
    s21 = s21.Substring(2);
}
Console.WriteLine(s21);
if (s22.Substring(0, 1) == "a" && s22.Substring(1, 1) == "a")
{
    s22 = s22.Substring(2);
}
Console.WriteLine(s22);
if (s23.Substring(0, 1) == "a" && s23.Substring(1, 1) == "a")
{
    s23 = s23.Substring(2);
}
Console.WriteLine(s23);

// 88. Write a C# Sharp program to check a given array of integers of length 1 or more. Return true if 10 appears as either the first or last element in the given array.
// Sample Input:
// { 10, 20, 40, 50 }
// { 5, 20, 40, 10 }
// { 10, 20, 40, 10 }
// { 12, 24, 35, 55 }
// Expected Output:
// True
// True
// True
// False
// Click me to see the solution

int[] s24 = { 10, 20, 40, 50 };
int[] s25 = { 5, 20, 40, 10 };
int[] s26 = { 10, 20, 40, 10 };
int[] s27 = { 12, 24, 35, 55 };
if (s24[0] == 10 || s24[s24.Length - 1] == 10)
{
    Console.WriteLine("True");
}
if (s25[0] == 10 || s25[s25.Length - 1] == 10)
{
    Console.WriteLine("True");
}
if (s26[0] == 10 || s26[s26.Length - 1] == 10)
{
    Console.WriteLine("True");
}
if (s27[0] == 10 || s27[s27.Length - 1] == 10)
{
    Console.WriteLine("True");
}

// 89. Write a C# Sharp program to check a given array of integers of length 1 or more. Return true if the first and the last element in the array are equal.
// Sample Input:
// { 10, 20, 40, 50 }
// { 10, 20, 40, 10 }
// { 12, 24, 35, 55 }
// Expected Output:
// False
// True
// False
// Click me to see the solution

int[] s28 = { 10, 20, 40, 50 };
int[] s29 = { 10, 20, 40, 10 };
int[] s30 = { 12, 24, 35, 55 };
if (s28[0] == s28[s28.Length - 1])
{
    Console.WriteLine("False");
}
if (s29[0] == s29[s29.Length - 1])
{
    Console.WriteLine("True");
}
if (s30[0] == s30[s30.Length - 1])
{
    Console.WriteLine("False");
}

// 90. Write a C# Sharp program to check two given arrays of integers of length 1 or more. Return true if they have the same first element or the same last element.
// Sample Input:
// { 10, 20, 40, 50 }, { 10, 20, 40, 50 }
// { 10, 20, 40, 50 }, { 10, 20, 40, 5 }
// { 10, 20, 40, 50 }, { 1, 20, 40, 5 }
// Expected Output:
// True
// True
// False
// Click me to see the solution

int[] s31 = { 10, 20, 40, 50 };
int[] s32 = { 10, 20, 40, 50 };
int[] s33 = { 10, 20, 40, 5 };
int[] s34 = { 1, 20, 40, 5 };
if (s31[0] == s32[0] || s31[s31.Length - 1] == s32[s32.Length - 1])
{
    Console.WriteLine("True");
}
if (s31[0] == s33[0] || s31[s31.Length - 1] == s33[s33.Length - 1])
{
    Console.WriteLine("True");
}
if (s31[0] == s34[0] || s31[s31.Length - 1] == s34[s34.Length - 1])
{
    Console.WriteLine("False");
}



// 91. Write a C# Sharp program to compute the sum of the elements of an array of integers.
// Sample Input:
// { 10, 20, 30, 40, 50 }
// { 10, 20, -30, -40, 50 }
// Expected Output:
// 150
// 10
// Click me to see the solution

int[] s35 = { 10, 20, 30, 40, 50 };
int[] s36 = { 10, 20, -30, -40, 50 };
int sum = 0;
for (int i = 0; i < s35.Length; i++)
{
    sum += s35[i];
}
Console.WriteLine(sum);
sum = 0;
for (int i = 0; i < s36.Length; i++)
{
    sum += s36[i];
}
Console.WriteLine(sum); 



// 92. Write a C# Sharp program to rotate the elements of a given array of integers (length 4 ) in the left direction and return the array.
// Sample Input:
// { 10, 20, -30, -40 }
// Expected Output:
// Rotated array: 20 -30 -40 10
// Click me to see the solution

int[] s37 = { 10, 20, -30, -40 };
int temp = s37[0];
for (int i = 0; i < s37.Length - 1; i++)
{
    s37[i] = s37[i + 1];
}
s37[s37.Length - 1] = temp;
for (int i = 0; i < s37.Length; i++)
{
    Console.Write(s37[i] + " ");
}


// 93. Write a C# Sharp program to reverse a given array of integers and length 5.
// Sample Input:
// { 10, 20, -30, -40, 50 }
// Expected Output:
// Reverse array: 50 -40 -30 20 10
// Click me to see the solution



// 94. Write a C# Sharp program to find out the maximum element between the first and last element in a given array of integers ( length 4), replace all elements with the maximum element.
// Sample Input:
// { 10, 20, -30, -40 }
// Expected Output:
// New array: 20 20 20 20
// Click me to see the solution



// 95. Write a C# Sharp program to create an array containing the middle elements from the two given arrays of integers, each length 5.
// Sample Input:
// { 10, 20, -30, -40, 30 }, { 10, 20, 30, 40, 30 }
// Expected Output:
// New array: -30 30
// Click me to see the solution



// 96. Write a C# Sharp program to create an array taking the first and last elements of a given array of integers and length 1 or more.
// Sample Input:
// { 10, 20, -30, -40, 30 }
// Expected Output :
// New array: 10 30
// Click me to see the solution




// 97. Write a C# Sharp program to check if an array of integers length 2 contains 15 or 20.
// Sample Input:
// { 12, 20 }
// { 14, 15 }
// { 11, 21 }
// Expected Output :
// True
// True
// False
// Click me to see the solution



// 98. Write a C# Sharp program to check if an array of integers with length 2 does not contain 15 or 20.
// Sample Input:
// { 12, 20 }
// { 14, 15 }
// { 11, 21 }
// Expected Output :
// False
// False
// True
// Click me to see the solution




// 99. Write a C# Sharp program to create an array of integers with a length of 1 or more. The array length will be double the given array length. All the elements are 0 except the first element which is equal to the given array.
// Sample Input:
// { 10, 20, -30, -40, 30 }
// Expected Output :
// New array: 10 0 0 0 0 0 0 0 0 0
// Click me to see the solution



// 100. Write a C# Sharp program to check a given array of integers and return true if it contains 10 or 20 twice. The array length will be 0, 1, or 2.
// Sample Input:
// { 12, 20 }
// { 20, 20 }
// { 10, 10 }
// { 10 }
// Expected Output :
// False
// True
// True
// False
// Click me to see the solution