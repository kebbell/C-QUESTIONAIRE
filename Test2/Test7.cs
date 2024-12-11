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


// // 25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.
// // Sample Input:
// // "JS", 2
// // "JS", 3
// // "JS", 1
// // Expected Output:
// // JSJS
// // JSJSJS
// // JS
// // Click me to see the solution

// string s1 = "JS";
// int n = 2;
// string result = "";
// for (int i = 0; i < n; i++)
// {
//     result += s1;
// }
// Console.WriteLine(result);


// // 26. Write a C# Sharp program to create a string that is n (non-negative integer) copies of the first 3 characters of a given string. If the given string is shorter than 3, return n copies of the string.
// // Sample Input:
// // "Python", 2
// // "Python", 3
// // "JS", 3
// // Expected Output:
// // PytPyt
// // PytPytPyt
// // JSJSJS
// // Click me to see the solution

// string s2 = "Python";
// int n2 = 2;
// string result2 = "";
// if (s2.Length < 3)
// {
//     for (int i = 0; i < n2; i++)
//     {
//         result2 += s2;
//     }
//     Console.WriteLine(result2);
// }
// else
// {
//     result2 = s2.Substring(0, 3);
//     for (int i = 0; i < n2 - 1; i++)
//     {
//         result2 += result2;
//     }
//     Console.WriteLine(result2);
// }



// // 27. Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".
// // Sample Input:
// // "bbaaccaag"
// // "jjkiaaasew"
// // "JSaaakoiaa"
// // Expected Output:
// // 2
// // 2
// // 3
// // Click me to see the solution

// string s3 = "bbaaccaag";
// string s4 = "jjkiaaasew";
// string s5 = "JSaaakoiaa";
// int count = 0;
// int count2 = 0;
// int count3 = 0;
// for (int i = 0; i < s3.Length; i++)
// {
//     if (s3.Substring(i, 2) == "aa")
//     {
//         count++;
//     }
// }
// for (int i = 0; i < s4.Length; i++)
// {
//     if (s4.Substring(i, 3) == "aaa")
//     {
//         count2++;
//     }
// }
// for (int i = 0; i < s5.Length; i++)
// {
//     if (s5.Substring(i, 3) == "aaa")
//     {
//         count3++;
//     }
// }
// Console.WriteLine(count);
// Console.WriteLine(count2);
// Console.WriteLine(count3);  


// // 28. Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
// // Sample Input:
// // "caabb"
// // "babaaba"
// // "aaaaa"
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// string s6 = "caabb";
// string s7 = "babaaba";
// string s8 = "aaaaa";
// if (s6.IndexOf("a") == s6.IndexOf("a", s6.IndexOf("a") + 1))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }
// if (s7.IndexOf("a") == s7.IndexOf("a", s7.IndexOf("a") + 1))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }
// if (s8.IndexOf("a") == s8.IndexOf("a", s8.IndexOf("a") + 1))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 29. Write a C# Sharp program to create a string made of every other character starting with the first in a given string.
// // Sample Input:
// // "Python"
// // "PHP"
// // "JS"
// // Expected Output:
// // Pto
// // PP
// // J
// // Click me to see the solution

// string s9 = "Python";
// string s10 = "PHP";
// string s11 = "JS";
// string result3 = "";
// for (int i = 0; i < s9.Length; i += 2)
// {
//     result3 += s9[i];
// }
// Console.WriteLine(result3);
// string result4 = "";
// for (int i = 0; i < s10.Length; i += 2)
// {
//     result4 += s10[i];
// }
// Console.WriteLine(result4);
// string result5 = "";
// for (int i = 0; i < s11.Length; i += 2)
// {
//     result5 += s11[i];
// }
// Console.WriteLine(result5);

// // 30. Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd".
// // Sample Input:
// // "abcd"
// // "abc"
// // "a"
// // Expected Output:
// // aababcabcd
// // aababc
// // a
// // Click me to see the solution

// string str = "abcd";
// string result = "";
// for (int i = 0; i < str.Length; i++)
// {
//     result += str[i];
//     result += str[i];
// }
// Console.WriteLine(result);
// str = "abc";
// string result2 = "";
// for (int i = 0; i < str.Length; i++)
// {
//     result2 += str[i];
//     result2 += str[i];
// }
// Console.WriteLine(result2);
// str = "a";
// string result3 = "";
// for (int i = 0; i < str.Length; i++)
// {
//     result3 += str[i];
//     result3 += str[i];
// }
// Console.WriteLine(result3);




// // 31. Write a C# Sharp program to count a substring of length 2 that appears in a given string. This substring appears as the last 2 characters of the string. Do not count the end substring.
// // Sample Input:
// // "abcdsab"
// // "abcdabab"
// // "abcabdabab"
// // "abcabd"
// // Expected Output:
// // 1
// // 2
// // 3
// // 0
// // Click me to see the solution

// string s12 = "abcdsab";
// string s13 = "abcdabab";
// string s14 = "abcabdabab";
// string s15 = "abcabd";
// int count = 0;
// for (int i = 0; i < s12.Length - 2; i++)
// {
//     if (s12.Substring(i, 2) == s12.Substring(i + 2, 2))
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);
// count = 0;
// for (int i = 0; i < s13.Length - 2; i++)
// {
//     if (s13.Substring(i, 2) == s13.Substring(i + 2, 2))
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);
// count = 0;
// for (int i = 0; i < s14.Length - 2; i++)
// {
//     if (s14.Substring(i, 2) == s14.Substring(i + 2, 2))
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);
// count = 0;
// for (int i = 0; i < s15.Length - 2; i++)
// {
//     if (s15.Substring(i, 2) == s15.Substring(i + 2, 2))
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);


// // 32. Write a C# Sharp program to check if a specified number is present in a given array of integers.
// // Sample Input:
// // {1,2,9,3}, 3
// // {1,2,2,3}, 2
// // {1,2,2,3}, 9
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int[] arr = { 1, 2, 9, 3 };
// int num = 3;
// bool flag = false;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == num)
//     {
//         flag = true;
//         break;
//     }
// }
// if (flag)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 33. Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
// // Sample Input:
// // {1,2,9,3}, 3
// // {1,2,3,4,5,6}, 2
// // {1,2,2,3}, 9
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int[] arr2 = { 1, 2, 9, 3 };
// int num2 = 3;
// bool flag2 = false;
// for (int i = 0; i < 4; i++)
// {
//     if (arr2[i] == num2)
//     {
//         flag2 = true;
//         break;
//     }
// }
// if (flag2)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 34. Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
// // Sample Input:
// // {1,1,2,3,1}
// // {1,1,2,4,1}
// // {1,1,2,1,2,3}
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// int[] arr3 = { 1, 1, 2, 3, 1 };
// bool flag3 = false;
// for (int i = 0; i < arr3.Length - 2; i++)
// {
//     if (arr3[i] == 1 && arr3[i + 1] == 2 && arr3[i + 2] == 3)
//     {
//         flag3 = true;
//         break;
//     }
// }
// if (flag3)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 35. Write a C# Sharp program to compare two given strings and return the number of positions where they contain the same length of 2 substrings.
// // Sample Input:
// // "abcdefgh", "abijsklm"
// // "abcde", "osuefrcd"
// // "pqrstuvwx", "pqkdiewx"
// // Expected Output:
// // 1
// // 1
// // 2
// // Click me to see the solution

// string s16 = "abcdefgh";
// string s17 = "abijsklm";
// int count4 = 0;
// for (int i = 0; i < s16.Length - 1; i++)
// {
//     if (s16.Substring(i, 2) == s17.Substring(i, 2))
//     {
//         count4++;
//     }
// }
// Console.WriteLine(count4);
// string s18 = "abcde";
// string s19 = "osuefrcd";
// int count5 = 0;
// for (int i = 0; i < s18.Length - 1; i++)
// {
//     if (s18.Substring(i, 2) == s19.Substring(i, 2))
//     {
//         count5++;
//     }
// }
// Console.WriteLine(count5);
// string s20 = "pqrstuvwx";
// string s21 = "pqkdiewx";
// int count6 = 0;
// for (int i = 0; i < s20.Length - 1; i++)
// {
//     if (s20.Substring(i, 2) == s21.Substring(i, 2))
//     {
//         count6++;
//     }
// }
// Console.WriteLine(count6);



// // 36. Write a C# Sharp program to create a string from a given string where a specified character is removed except for the beginning and ending positions.
// // Sample Input:
// // "xxHxix", "x"
// // "abxdddca", "a"
// // "xabjbhtrb", "b"
// // Expected Output:
// // xHix
// // abxdddca
// // xajhtrb
// // Click me to see the solution

// string s22 = "xxHxix";
// string s23 = "x";
// string result6 = "";
// for (int i = 0; i < s22.Length; i++)
// {
//     if (s22[i] != s23[0] && s22[i] != s23[s23.Length - 1])
//     {
//         result6 += s22[i];
//     }
// }
// Console.WriteLine(result6);
// string s24 = "abxdddca";
// string s25 = "a";
// string result7 = "";
// for (int i = 0; i < s24.Length; i++)
// {
//     if (s24[i] != s25[0] && s24[i] != s25[s25.Length - 1])
//     {
//         result7 += s24[i];
//     }
// }
// Console.WriteLine(result7);
// string s26 = "xabjbhtrb";
// string s27 = "b";
// string result8 = "";
// for (int i = 0; i < s26.Length; i++)
// {
//     if (s26[i] != s27[0] && s26[i] != s27[s27.Length - 1])
//     {
//         result8 += s26[i];
//     }
// }
// Console.WriteLine(result8);



// // 37. Write a C# Sharp program to create a string of characters at indexes 0,1, 4,5, 8,9 ... from a given string.
// // Sample Input:
// // "Python"
// // "JavaScript"
// // "HTML"
// // Expected Output:
// // Pyon
// // JaScpt
// // HT
// // Click me to see the solution

// string s28 = "Python";
// string s29 = "JavaScript";
// string s30 = "HTML";
// string result9 = "";
// for (int i = 0; i < s28.Length; i++)
// {
//     result9 += s28[i];
//     result9 += s29[i];
//     result9 += s30[i];
// }
// Console.WriteLine(result9);



// // 38. Write a C# Sharp program to count the number of two 5's next to each other in an array of integers. Count the situation where the second 5 is actually a 6.
// // Sample Input:
// // { 5, 5, 2 }
// // { 5, 5, 2, 5, 5 }
// // { 5, 6, 2, 9}
// // Expected Output:
// // 1
// // 2
// // 1
// // Click me to see the solution

// int[] arr3 = { 5, 5, 2 };
// int count7 = 0;
// for (int i = 0; i < arr3.Length - 1; i++)
// {
//     if (arr3[i] == 5 && arr3[i + 1] == 5)
//     {
//         count7++;
//     }
//     else if (arr3[i] == 5 && arr3[i + 1] == 6)
//     {
//         count7++;
//     }
// }
// Console.WriteLine(count7);
// int[] arr4 = { 5, 5, 2, 5, 5 };
// int count8 = 0;
// for (int i = 0; i < arr4.Length - 1; i++)
// {
//     if (arr4[i] == 5 && arr4[i + 1] == 5)
//     {
//         count8++;
//     }
//     else if (arr4[i] == 5 && arr4[i + 1] == 6)
//     {        
//         count8++;        
//     }
// }
// Console.WriteLine(count8);
// int[] arr5 = { 5, 6, 2, 9 };
// int count9 = 0;
// for (int i = 0; i < arr5.Length - 1; i++)
// {
//     if (arr5[i] == 5 && arr5[i + 1] == 5)
//     {
//         count9++;
//     }
//     else if (arr5[i] == 5 && arr5[i + 1] == 6)
//     {
//         count9++;
//     }
// }
// Console.WriteLine(count9);




// // 39. Write a C# Sharp program to check if a triple is present in an array of integers or not. If a value appears three times in a row in an array it is called a triple.
// // Sample Input:
// // { 1, 1, 2, 2, 1 }
// // { 1, 1, 2, 1, 2, 3 }
// // { 1, 1, 1, 2, 2, 2, 1 }
// // Expected Output:
// // False
// // False
// // True
// // Click me to see the solution

// int[] arr6 = { 1, 1, 2, 2, 1 };
// bool flag3 = false;
// for (int i = 0; i < arr6.Length - 2; i++)
// {
//     if (arr6[i] == arr6[i + 1] && arr6[i] == arr6[i + 2])
//     {
//         flag3 = true;
//         break;
//     }
// }
// Console.WriteLine(flag3);
// int[] arr7 = { 1, 1, 2, 1, 2, 3 };
// bool flag4 = false;
// for (int i = 0; i < arr7.Length - 2; i++)
// {
//     if (arr7[i] == arr7[i + 1] && arr7[i] == arr7[i + 2])
//     {
//         flag4 = true;
//         break;
//     }
// }
// Console.WriteLine(flag4);
// int[] arr8 = { 1, 1, 1, 2, 2, 2, 1 };
// bool flag5 = false;
// for (int i = 0; i < arr8.Length - 2; i++)
// {
//     if (arr8[i] == arr8[i + 1] && arr8[i] == arr8[i + 2])
//     {
//         flag5 = true;
//         break;
//     }
// }
//     if (flag5)
//     {
//         Console.WriteLine("True");
//     }
//     else
//     {
//         Console.WriteLine("False"); 
//     }
    


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

int a = 12, b = 17;
int sum = a + b;
if (sum >= 10 && sum <= 20)
{
    Console.WriteLine(30);
}
else
{
    Console.WriteLine(sum);
}