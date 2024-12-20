// // 1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
// // Sample Input:
// // 1, 2
// // 3, 2
// // 2, 2
// // Expected Output:
// // 3
// // 5
// // 12   
// // Click me to see the solution

// int num1 = 1;
// int num2 = 2;
// if (num1 == num2)
// {
//     Console.WriteLine(num1 + num2 * 3);
// }
// else
// {
//     Console.WriteLine(num1 + num2);
// }

// // 2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.

// // Sample Input:
// // 53
// // 30
// // 51
// // Expected Output:

// // 6
// // 21
// // 0
// // Click me to see the solution

// int num3 = 53;
// // int num4 = 30;
// int num5 = 51;
// if (num3 > num5)
// {
//     Console.WriteLine((num3 - num5) * 3);
// }
// else
// {
//     Console.WriteLine(num3 - num5);
// }


// // 3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
// // Sample Input:
// // 30, 0
// // 25, 5
// // 20, 30
// // 20, 25
// // Expected Output:
// // True
// // True
// // True
// // False
// // Click me to see the solution

// int num6 = 30;
// int num7 = 0;
// int num8 = 25;
// int num9 = 5;
// int num10 = 20;
// int num11 = 30;
// int num12 = 20;
// int num13 = 25;
// if (num6 == 30 || num7 == 30 || num8 + num9 == 30 || num10 + num11 == 30 || num12 + num13 == 30)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
// // Sample Input:
// // 103
// // 90
// // 89
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution


// int num14 = 103;
// int num15 = 90;
// int num16 = 89;
// if (num14 > 90 && num14 < 110 || num15 > 190 && num15 < 210 || num16 > 190 && num16 < 210)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 5. Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.
// // Sample Input:
// // "if else"
// // "else"
// // Expected Output:
// // if else
// // if else
// // Click me to see the solution


// string str1 = "if else";
// string str2 = "else";
// if (str1.StartsWith("if"))
// {
//     Console.WriteLine(str1);
// }
// else
// {
//     Console.WriteLine("if " + str2);
// }


// // 6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
// // Sample Input:
// // "Python", 1
// // "Python", o
// // "Python", 4
// // Expected Output:
// // Pthon
// // ython
// // Pythn
// // Click me to see the solution

// string str3 = "Python";
// // string str4 = "o";
// // string str5 = "4";
// if (str3.Length > 1)
// {
//     Console.WriteLine(str3.Remove(1, 1));
// }
// else
// {
//     Console.WriteLine(str3);
// }



// // 7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
// // Sample Input:
// // "abcd"
// // "a"
// // "xy"
// // Expected Output:
// // dbca
// // a
// // yx
// // Click me to see the solution

// string str6 = "abcd";
// // string str7 = "a";
// // string str8 = "xy";
// if (str6.Length > 1)
// {
//     Console.WriteLine(str6[str6.Length - 1] + str6.Substring(1, str6.Length - 2) + str6[0]);
// }
// else
// {
//     Console.WriteLine(str6);
// }

// // 8. Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
// // Sample Input:
// // "C Sharp"
// // "JS"
// // "a"
// // Expected Output:
// // C C C C 
// // JSJSJSJS
// // a
// // Click me to see the solution

// string str9 = "C Sharp";
// // string str10 = "JS";
// // string str11 = "a";
// if (str9.Length > 1)
// {
//     Console.WriteLine(str9.Substring(0, 2) + " " + str9.Substring(0, 2) + " " + str9.Substring(0, 2) + " " + str9.Substring(0, 2));
// }
// else
// {
//     Console.WriteLine(str9);
// }



// // 9. Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.
// // Sample Input:
// // "Red"
// // "Green"
// // "1"
// // Expected Output:
// // dRedd
// // nGreenn
// // 111
// // Click me to see the solution

// string str12 = "Red";
// // string str13 = "Green";
// // string str14 = "1";
// if (str12.Length > 1)
// {
//     Console.WriteLine(str12[str12.Length - 1] + str12 + str12[str12.Length - 1]);
// }
// else
// {
//     Console.WriteLine(str12);
// }

// // 10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
// // Sample Input:
// // 3
// // 14
// // 12
// // 37
// // Expected Output:
// // True
// // True
// // True
// // False
// // Click me to see the solution

// int num17 = 3;
// int num18 = 14;
// int num19 = 12;
// int num20 = 37;
// if (num17 % 3 == 0 || num17 % 7 == 0 || num18 % 3 == 0 || num18 % 7 == 0 || num19 % 3 == 0 || num19 % 7 == 0 || num20 % 3 == 0 || num20 % 7 == 0)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
// // Sample Input:
// // "Python"
// // "JS"
// // "Code"
// // Expected Output:
// // PytPythonPyt
// // JSJSJS
// // CodCodeCod
// // Click me to see the solution

// string str15 = "Python";
// // string str16 = "JS";
// // string str17 = "Code";
// if (str15.Length > 2)
// {
//     Console.WriteLine(str15.Substring(0, 3) + str15 + str15.Substring(0, 3));
// }
// else
// {
//     Console.WriteLine(str15);
// }


// // 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
// // Sample Input:
// // "C# Sharp"
// // "C#"
// // "C++"
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// string str18 = "C# Sharp";
// // string str19 = "C#";
// // string str20 = "C++";
// if (str18.StartsWith("C#"))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.
// // Sample Input:
// // 120, -1
// // -1, 120
// // 2, 120
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int num21 = 120;
// int num22 = -1;
// int num23 = 120;
// int num24 = 2;
// if (num21 < 0 || num22 > 100 || num23 < 0 || num24 > 100)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
// // Sample Input:
// // 100, 199
// // 250, 300
// // 105, 190
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// int num25 = 100;
// int num26 = 199;
// int num27 = 250;
// int num28 = 300;
// int num29 = 105;
// int num30 = 190;
// if (num25 >= 100 && num25 <= 200 || num26 >= 100 && num26 <= 200 || num27 >= 100 && num27 <= 200 || num28 >= 100 && num28 <= 200 || num29 >= 100 && num29 <= 200 || num30 >= 100 && num30 <= 200)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// // 15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
// // Sample Input:
// // 11, 20, 12
// // 30, 30, 17
// // 25, 35, 50
// // 15, 12, 8
// // Expected Output:
// // True
// // True
// // True
// // False
// // Click me to see the solution

// string str21 = "11, 20, 12";
// string str22 = "30, 30, 17";
// string str23 = "25, 35, 50";
// string str24 = "15, 12, 8";
// if (str21.Contains(",") || str22.Contains(",") || str23.Contains(",") || str24.Contains(","))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// // 16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if one or other is in the range, otherwise false.
// // Sample Input:
// // 20, 84
// // 14, 50
// // 11, 55
// // 25, 40
// // Expected Output:
// // True
// // True
// // False
// // True
// // Click me to see the solution

// string str25 = "20, 84";
// string str26 = "14, 50";
// string str27 = "11, 55";
// string str28 = "25, 40";
// if (str25.Contains(",") || str26.Contains(",") || str27.Contains(",") || str28.Contains(","))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
// // Sample Input:
// // "Python"
// // "ytade"
// // "jsues"
// // Expected Output:
// // Phon
// // ytade
// // jsues
// // Click me to see the solution

// string str29 = "Python";
// string str30 = "ytade";
// string str31 = "jsues";
// if (str29.Contains("yt") || str30.Contains("yt") || str31.Contains("yt"))
// {
//     Console.WriteLine(str29.Replace("yt", ""));
//     Console.WriteLine(str30.Replace("yt", ""));
//     Console.WriteLine(str31.Replace("yt", ""));
// }
// else
// {
//     Console.WriteLine(str29);
//     Console.WriteLine(str30);
//     Console.WriteLine(str31);
// }


// // 18. Write a C# Sharp program to check the largest number among three given integers.
// // Sample Input:
// // 1,2,3
// // 1,3,2
// // 1,1,1
// // 1,2,2
// // Expected Output:
// // 3
// // 3
// // 1
// // 2
// // Click me to see the solution

// string str32 = "1,2,3";
// string str33 = "1,3,2";
// string str34 = "1,1,1";
// string str35 = "1,2,2";
// if (str32.Contains(",") || str33.Contains(",") || str34.Contains(",") || str35.Contains(","))
// {
//     Console.WriteLine(str32.Split(",")[2]);
//     Console.WriteLine(str33.Split(",")[2]);
//     Console.WriteLine(str34.Split(",")[2]);
//     Console.WriteLine(str35.Split(",")[2]);
// }
// else
// {
//     Console.WriteLine(str32);
//     Console.WriteLine(str33);
//     Console.WriteLine(str34);
//     Console.WriteLine(str35);
// }


// // 19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.
// // Sample Input:
// // 78, 95
// // 95, 95
// // 99, 70
// // Expected Output:
// // 95
// // 0
// // 99
// // Click me to see the solution

// string str36 = "78, 95";
// string str37 = "95, 95";
// string str38 = "99, 70";
// if (str36.Contains(",") || str37.Contains(",") || str38.Contains(","))
// {
//     Console.WriteLine(str36.Split(",")[1]);
//     Console.WriteLine(str37.Split(",")[1]);
//     Console.WriteLine(str38.Split(",")[1]);
// }
// else
// {
//     Console.WriteLine(str36);
//     Console.WriteLine(str37);
//     Console.WriteLine(str38);
// }



// // 20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
// // Sample Input:
// // 78, 95
// // 25, 35
// // 40, 50
// // 55, 60
// // Expected Output:

// // True
// // False
// // True
// // True
// // Click me to see the solution

// string str39 = "78, 95";
// string str40 = "25, 35";
// string str41 = "40, 50";
// string str42 = "55, 60";
// if (str39.Contains(",") || str40.Contains(",") || str41.Contains(",") || str42.Contains(","))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }