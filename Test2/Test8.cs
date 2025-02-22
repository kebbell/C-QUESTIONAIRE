// // 41. Write a C# Sharp program that accepts two integers and returns true if either is 5 or their sum or difference is 5.
// // Sample Input:
// // 5, 4
// // 4, 3
// // 1, 4
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// int a = 5, b = 4;
// if (a == 5 || b == 5 || a + b == 5 || a - b == 5)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 42. Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or one more than a multiple of 13.
// // Sample Input:
// // 13
// // 14
// // 27
// // 41
// // Expected Output:
// // True
// // True
// // True
// // False
// // Click me to see the solution

// int c = 13;
// if (c % 13 == 0 || c % 13 == 1)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 43. Write a C# Sharp program to check if a given number that is not negative is a multiple of 3 or 7, but not both.
// // Sample Input:
// // 3
// // 7
// // 21
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int d = 3;
// if (d % 3 == 0 && d % 7 != 0)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// // 44. Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.
// // Sample Input:
// // 3
// // 7
// // 8
// // 21
// // Expected Output:
// // False
// // False
// // True
// // True
// // Click me to see the solution

// int e = 3;
// if (e % 10 == 2 || e % 10 == -2)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// // 45. Write a C# Sharp program to compute the sum of the two given integers. Return 18 if one of the given integer values is in the range of 10..20 inclusive.
// // Sample Input:
// // 3, 7
// // 10, 11
// // 10, 20
// // 21, 220
// // Expected Output:
// // 10
// // 18
// // 18
// // 241
// // Click me to see the solution

// int f = 3, g = 7;
// if (f >= 10 && f <= 20 || g >= 10 && g <= 20)
// {
//     Console.WriteLine("18");
// }
// else
// {
//     Console.WriteLine(f + g);
// }

// // 46. Write a C# Sharp program to check whether a given string begins with "F" or ends with "B". If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the original string.
// // In other cases return the original string.
// // Sample Input:
// // "FizzBuzz"
// // "Fizz"
// // "Buzz"
// // "Founder"
// // Expected Output:
// // Fizz
// // Fizz
// // Buzz
// // Fizz
// // Click me to see the solution

// string h = "FizzBuzz";
// if (h.StartsWith("F") && h.EndsWith("B"))
// {
//     Console.WriteLine("FizzBuzz");
// }
// else if (h.StartsWith("F"))
// {
//     Console.WriteLine("Fizz");
// }
// else if (h.EndsWith("B"))
// {
//     Console.WriteLine("Buzz");
// }
// else
// {
//     Console.WriteLine(h);
// }

// // 47. Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.
// // Sample Input:
// // 1, 2, 3
// // 4, 5, 6
// // -1, 1, 0
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// int i = 1, j = 2, k = 3;
// if (i + j == k || i + k == j || j + k == i)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// // 48. Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.
// // Sample Input:
// // 1, 2, 3
// // 4, 5, 6
// // -1, 1, 0
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int l = 1, m = 2, n = 3;
// if (m > l && n > m)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 49. Write a C# Sharp program to check if three given numbers are in strict increasing order.
// // For example, 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8. However, if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.
// // Sample Input:
// // 1, 2, 3, false
// // 1, 2, 3, true
// // 10, 2, 30, false
// // 10, 10, 30, true
// // Expected Output:
// // True
// // True
// // False
// // True
// // Click me to see the solution

// int o = 1, p = 2, q = 3;    
// if (o < p && p < q || o == p && p == q)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }




// // 50. Write a C# Sharp program to check if two or more integers that are not negative have the same rightmost digit.
// // Sample Input:
// // 11, 21, 31
// // 11, 22, 31
// // 11, 22, 33
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int r = 11, s = 21, t = 31;
// if (r % 10 == s % 10 || r % 10 == t % 10 || s % 10 == t % 10)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// // 51. Write a C# Sharp program to check three given integers and return true if one of them is 20 or more less than one of the others.
// // Sample Input:
// // 11, 21, 31
// // 11, 22, 31
// // 10, 20, 15
// // Expected Output:
// // True
// // True
// // False
// // Click me to see the solution

// int u = 11, v = 21, w = 31;
// if (Math.Abs(u - v) >= 20 || Math.Abs(u - w) >= 20 || Math.Abs(v - w) >= 20)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }



// // 52. Write a C# Sharp program to find the largest of two given integers. However if the two integers have the same remainder when divided by 7, then return the smallest integer. If the two integers are the same, return 0.
// // Sample Input:
// // 11, 21
// // 11, 20
// // 10, 10
// // Expected Output:
// // 21
// // 20
// // 0
// // Click me to see the solution

// int x = 11, y = 21;
// if (x % 7 == y % 7)
// {
//     Console.WriteLine(Math.Min(x, y));
// }
// else
// {
//     Console.WriteLine(Math.Max(x, y));
// }



// // 53. Write a C# Sharp program to check two given integers, each in the range 10..99. Return true if a digit appears in both numbers, such as the 3 in 13 and 33.
// // Sample Input:
// // 11, 21
// // 11, 20
// // 10, 10
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// int a = 11, b = 21;
// if (a / 10 == b / 10 || a / 10 == b % 10 || a % 10 == b / 10 || a % 10 == b % 10)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }



// // 54. Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x. If the sum has more digits than x return x without y.
// // Sample Input:
// // 4, 5
// // 7, 4
// // 10, 10
// // Expected Output:
// // 9
// // 7
// // 20
// // Click me to see the solution

// int c = 4, d = 5;
// if (c.ToString().Length + d.ToString().Length == c.ToString().Length)
// {
//     Console.WriteLine(c + d);
// }
// else
// {
//     Console.WriteLine(c);
// }




// // 55. Write a C# Sharp program to compute the sum of three given integers. Return the third value if the two values are the same.
// // Sample Input:
// // 4, 5, 7
// // 7, 4, 12
// // 10, 10, 12
// // 12, 12, 18
// // Expected Output:
// // 16
// // 23
// // 12
// // 18
// // Click me to see the solution

// int e = 4, f = 5, g = 7;
// if (e == f)
// {
//     Console.WriteLine(e + f);
// }
// else
// {
//     Console.WriteLine(e + f + g);
// }


// // 56. Write a C# Sharp program to compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.
// // Sample Input:
// // 4, 5, 7
// // 7, 4, 12
// // 10, 13, 12
// // 13, 12, 18
// // Expected Output:
// // 16
// // 23
// // 10
// // 0
// // Click me to see the solution

// int h = 4, i = 5, j = 7;
// if (h == 13 || i == 13 || j == 13)
// {
//     Console.WriteLine(0);
// }
// else
// {
//     Console.WriteLine(h + i + j);
// }


// // 57. Write a C# Sharp program to compute the sum of the three given integers. All values in the range 10..20 inclusive count as 0, except 13 and 17.
// // Sample Input:
// // 4, 5, 7
// // 7, 4, 12
// // 10, 13, 12
// // 14, 15, 16
// // Expected Output:
// // 16
// // 11
// // 13
// // 0
// // Click me to see the solution

// int k = 4, l = 5, m = 7;
// if (k == 13 || k == 17 || l == 13 || l == 17 || m == 13 || m == 17)
// {
//     Console.WriteLine(0);
// }
// else
// {
//     Console.WriteLine(k + l + m);
// }



// // 58. Write a C# Sharp program to check two integers and return the value nearest to 13 without crossing over. Return 0 if both numbers exceed.
// // Sample Input:
// // 4, 5
// // 7, 12
// // 10, 13
// // 17, 33
// // Expected Output:
// // 5
// // 12
// // 13
// // 0
// // Click me to see the solution

// int n = 4, o = 5;
// if (n > 13 || o > 13)
// {
//     Console.WriteLine(0);
// }
// else
// {
//     Console.WriteLine(Math.Min(n, o));
// }



// // 59. Write a C# Sharp program to compare three integers (small, medium, and large) and return true if the difference between small and medium and the difference between medium and large is the same.
// // Sample Input:
// // 4, 5, 6
// // 7, 12, 13
// // -1, 0, 1
// // Expected Output:
// // True
// // False
// // True
// // Click me to see the solution

// int p = 4, q = 5, r = 6;
// int s = 7, t = 12, u2 = 13;
// int v2 = -1, w2 = 0, x2 = 1;
// if (Math.Abs(p - q) == Math.Abs(q - r) || Math.Abs(s - t) == Math.Abs(t - u2) || Math.Abs(v2 - w2) == Math.Abs(w2 - x2))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }



// // 60. Write a C# Sharp program to create a string using the two given strings s1, s2. The new string format will be s1s2s2s1.
// // Sample Input:
// // "Hi", "Hello"
// // "whats", "app"
// // Expected Output:
// // HiHelloHelloHi
// // whatsappappwhats
// // Click me to see the solution

// string s1 = "Hi", s2 = "Hello";
// string s3 = s1 + s2 + s2 + s1;
// Console.WriteLine(s3);