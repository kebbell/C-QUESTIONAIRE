// // 61. Write a C# Sharp program to insert a given string into the middle of another given string of length 4.
// // Sample Input:
// // "[[]]","Hello"
// // "(())", "Hi"
// // Expected Output:
// // [[Hello]]
// // ((Hi))
// // Click me to see the solution

// string s1 = "[[]]", s2 = "Hello";
// string s3 = "(())", s4 = "Hi";
// string s5 = s1.Insert(1, s2);
// string s6 = s3.Insert(1, s4);
// Console.WriteLine(s5);
// Console.WriteLine(s6);


// // 62. Write a C# Sharp program to create a string using three copies of the last two characters of a given string of length at least two.
// // Sample Input:
// // "Hello"
// // "Hi"
// // Expected Output:
// // lololo
// // HiHiHi
// // Click me to see the solution

// string s7 = "Hello";
// string s8 = "Hi";
// string s9 = s7.Substring(s7.Length - 2) + s7.Substring(s7.Length - 2) + s7.Substring(s7.Length - 2);
// string s10 = s8.Substring(s8.Length - 2) + s8.Substring(s8.Length - 2) + s8.Substring(s8.Length - 2);  
// Console.WriteLine(s9);
// Console.WriteLine(s10);



// // 63. Write a C# Sharp program to create a new string using the first two characters of a given string. If the string length is less than 2, return the original string.
// // Sample Input:
// // "Hello"
// // "Hi"
// // "H"
// // " "
// // Expected Output:
// // He
// // Hi
// // H
// // Click me to see the solution


// string s11 = "Hello";
// string s12 = "Hi";
// string s13 = s11.Substring(0, 2);
// string s14 = s12.Substring(0, 2);
// string s15 = s13;
// string s16 = s14;
// Console.WriteLine(s15);
// Console.WriteLine(s16);


// // 64. Write a C# Sharp program to create a string from the first half of a given string of even length.
// // Sample Input:
// // "Hello"
// // "Hi"
// // Expected Output:
// // He
// // H
// // Click me to see the solution

// string s17 = "Hello";
// string s18 = "Hi";
// string s19 = s17.Substring(0, s17.Length / 2);
// string s20 = s18.Substring(0, s18.Length / 2);
// Console.WriteLine(s19);
// Console.WriteLine(s20);



// // 65. Write a C# Sharp program to create a new string without the first and last character of a given string of length at least two.
// // Sample Input:
// // "Hello"
// // "Hi"
// // "Python"
// // Expected Output:
// // ell
// // ytho
// // Click me to see the solution

// string s21 = "Hello";
// string s22 = "Hi";
// string s23 = "Python";
// string s24 = s21.Substring(1, s21.Length - 2);
// string s25 = s22.Substring(1, s22.Length - 2);
// string s26 = s23.Substring(1, s23.Length - 2);
// Console.WriteLine(s24);
// Console.WriteLine(s25);
// Console.WriteLine(s26);

// // 66. Write a C# Sharp program to create a new string from two given strings, one of which is shorter and one of which is longer. The new string format will be long string + short string + long string.
// // Sample Input:
// // "Hello", "Hi"
// // "JS", "Python"
// // Expected Output:
// // HelloHiHello
// // PythonJSPython
// // Click me to see the solution

// string s27 = "Hello", s28 = "Hi";
// string s29 = "JS", s30 = "Python";
// string s31 = s27 + s28 + s27;
// string s32 = s29 + s30 + s29;
// Console.WriteLine(s31);
// Console.WriteLine(s32);

// // 67. Write a C# Sharp program to combine two strings of length at least 1, after removing their first character.
// // Sample Input:
// // "Hello", "Hi"
// // "JS", "Python"
// // Expected Output:
// // elloi
// // Sython
// // Click me to see the solution

// string s33 = "Hello", s34 = "Hi";
// string s35 = "JS", s36 = "Python";
// string s37 = s33.Substring(1) + s34.Substring(1);
// string s38 = s35.Substring(1) + s36.Substring(1);
// Console.WriteLine(s37);
// Console.WriteLine(s38);

// // 68. Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.
// // Sample Input:
// // "Hello"
// // "JS"
// // Expected Output:
// // lloHe
// // JS
// // Click me to see the solution

// string s39 = "Hello";
// string s40 = "JS";
// string s41 = s39.Substring(2) + s39.Substring(0, 2);
// string s42 = s40.Substring(2) + s40.Substring(0, 2);
// Console.WriteLine(s41);
// Console.WriteLine(s42);

// // 69. Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.
// // Sample Input:
// // "Hello"
// // "JS"
// // Expected Output:
// // loHel
// // JS
// // Click me to see the solution

// string s43 = "Hello";
// string s44 = "JS";
// string s45 = s43.Substring(s43.Length - 2) + s43.Substring(0, s43.Length - 2);
// string s46 = s44.Substring(s44.Length - 2) + s44.Substring(0, s44.Length - 2);
// Console.WriteLine(s45);
// Console.WriteLine(s46); 

// // 70. Write a C# Sharp program to create a new string without the first and last characters of a given string of any length.
// // Sample Input:
// // "Hello"
// // "JS"
// // ""
// // Expected Output:
// // ell
// // Click me to see the solution

// string s47 = "Hello";
// string s48 = "JS";
// string s49 = "";
// string s50 = s47.Substring(1, s47.Length - 2);
// string s51 = s48.Substring(1, s48.Length - 2);
// string s52 = s49.Substring(1, s49.Length - 2);
// Console.WriteLine(s50);
// Console.WriteLine(s51);
// Console.WriteLine(s52);


// // 71. Write a C# Sharp program to create a string using the two middle characters of a given string of even length (at least 2).
// // Sample Input:
// // "Hell"
// // "JS"
// // Expected Output:
// // el
// // JS
// // Click me to see the solution

// string s53 = "Hell";
// string s54 = "JS";
// string s55 = s53.Substring(s53.Length / 2 - 1, 2);
// string s56 = s54.Substring(s54.Length / 2 - 1, 2);
// Console.WriteLine(s55);
// Console.WriteLine(s56);


// // 72. Write a C# Sharp program to check if a given string ends with "on".
// // Sample Input:
// // "Hello"
// // "Python"
// // "on"
// // "o"
// // Expected Output:
// // False
// // True
// // True
// // False
// // Click me to see the solution

// string s57 = "Hello";
// string s58 = "Python";
// string s59 = "on";
// string s60 = "o";
// bool s61 = s57.EndsWith("on");
// bool s62 = s58.EndsWith("on");
// bool s63 = s59.EndsWith("on");
// bool s64 = s60.EndsWith("on");
// Console.WriteLine(s61);
// Console.WriteLine(s62);
// Console.WriteLine(s63);
// Console.WriteLine(s64);


// // 73. Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n.
// // Sample Input:
// // "Hello", 1
// // "Python", 2
// // "on", 1
// // "o", 1
// // Expected Output:
// // Ho
// // Pyon
// // on
// // oo
// // Click me to see the solution

// string s65 = "Hello";
// string s66 = "Python";
// string s67 = "on";
// string s68 = "o";
// string s69 = s65.Substring(0, 1) + s65.Substring(s65.Length - 1, 1);
// string s70 = s66.Substring(0, 2) + s66.Substring(s66.Length - 2, 2);
// string s71 = s67.Substring(0, 1) + s67.Substring(s67.Length - 1, 1);
// string s72 = s68.Substring(0, 1) + s68.Substring(s68.Length - 1, 1);
// Console.WriteLine(s69);
// Console.WriteLine(s70);
// Console.WriteLine(s71);
// Console.WriteLine(s72);



// // 74. Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.
// // Sample Input:
// // "Hello", 1
// // "Python", 2
// // "on", 1
// // Expected Output:
// // el
// // th
// // on
// // Click me to see the solution

// string s73 = "Hello";
// string s74 = "Python";
// string s75 = "on";
// string s76 = s73.Substring(1, 2);
// string s77 = s74.Substring(2, 2);
// string s78 = s75.Substring(1, 2);
// Console.WriteLine(s76);
// Console.WriteLine(s77);
// Console.WriteLine(s78);



// // 75. Write a C# Sharp program to create a string by taking at least 3 characters from the middle of a given string.
// // Sample Input:
// // "Hello"
// // "Python"
// // "abc"
// // Expected Output:
// // ell
// // yth
// // abc
// // Click me to see the solution

// string s79 = "Hello";
// string s80 = "Python";
// string s81 = "abc";
// string s82 = s79.Substring(s79.Length / 2, 3);
// string s83 = s80.Substring(s80.Length / 2, 3);
// string s84 = s81.Substring(s81.Length / 2, 3);
// Console.WriteLine(s82);
// Console.WriteLine(s83);
// Console.WriteLine(s84);


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

string s85 = "Hello";
string s86 = "Python";
string s87 = "a";
string s88 = "";
string s89 = s85.Substring(0, 2);
string s90 = s86.Substring(0, 2);
string s91 = s87.Substring(0, 2);
string s92 = s88.Substring(0, 2);
Console.WriteLine(s89);
Console.WriteLine(s90);
Console.WriteLine(s91);
Console.WriteLine(s92);


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

string s93 = "Hello";
string s94 = "Hi";
string s95 = "Python";
string s96 = "PHP";
string s97 = "JS";
string s98 = "JS";
string s99 = "Csharp";
string s100 = "";
string s101 = s93.Substring(0, 1) + s94.Substring(s94.Length - 1, 1);
string s102 = s95.Substring(0, 1) + s96.Substring(s96.Length - 1, 1);
string s103 = s97.Substring(0, 1) + s98.Substring(s98.Length - 1, 1);
string s104 = s99.Substring(0, 1) + s100.Substring(s100.Length - 1, 1);
Console.WriteLine(s101);
Console.WriteLine(s102);
Console.WriteLine(s103);
Console.WriteLine(s104);



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

string s105 = "abc";
string s106 = "cat";
string s107 = "python";
string s108 = "php";
string s109 = "php";
string s110 = s105 + s106;
string s111 = s107 + s108;
string s112 = s108 + s109;
Console.WriteLine(s110);
Console.WriteLine(s111);
Console.WriteLine(s112);


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

string s113 = "Hello";
string s114 = "Python";
string s115 = "PHP";
string s116 = "JS";
string s117 = "C"; 
string s118 = s113.Substring(0, s113.Length - 2) + s113.Substring(s113.Length - 1, 1) + s113.Substring(s113.Length - 2, 1);
string s119 = s114.Substring(0, s114.Length - 2) + s114.Substring(s114.Length - 1, 1) + s114.Substring(s114.Length - 2, 1);
string s120 = s115.Substring(0, s115.Length - 2) + s115.Substring(s115.Length - 1, 1) + s115.Substring(s115.Length - 2, 1);
string s121 = s116.Substring(0, s116.Length - 2) + s116.Substring(s116.Length - 1, 1) + s116.Substring(s116.Length - 2, 1);
string s122 = s117.Substring(0, s117.Length - 2) + s117.Substring(s117.Length - 1, 1) + s117.Substring(s117.Length - 2, 1);
Console.WriteLine(s118);
Console.WriteLine(s119);
Console.WriteLine(s120);
Console.WriteLine(s121);
Console.WriteLine(s122);


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

string s123 = "abc";
string s124 = "abcdef";
string s125 = "C";
string s126 = "xyz";
string s127 = "xyzsder";
string s128 = s123.Substring(0, 3);
string s129 = s124.Substring(0, 3);
string s130 = s125.Substring(0, 1);
string s131 = s126.Substring(0, 3);
string s132 = s127.Substring(0, 3);
Console.WriteLine(s128);
Console.WriteLine(s129);
Console.WriteLine(s130);
Console.WriteLine(s131);
Console.WriteLine(s132);