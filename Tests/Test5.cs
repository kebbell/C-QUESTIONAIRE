// // 81. Write a C# Sharp program to swap a two-digit number and check whether the given number is greater than its swap value.
// // Sample Output:
// // Input an integer value:
// // Check whether the said value is greater than its swap value: True
// // Click me to see the solution

// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = num / 10;
// int num2 = num % 10;
// int num3 = num1 * 10 + num2;
// Console.WriteLine("Check whether the said value is greater than its swap value: " + (num > num3));

// // 82. Write a C# Sharp program to remove all non-letter characters from a given string.
// // From Wikipedia,
// // A letter is a segmental symbol of a phonemic writing system. The inventory of all letters forms the alphabet. Letters broadly correspond to phonemes in the spoken form of the language, although there is rarely a consistent, exact correspondence between letters and phonemes
// // Sample Output:
// // Orginal string: Py@th12on
// // Remove all characters from the said string which are non-letters: Python
// // Orginal string: Python 3.0
// // Remove all characters from the said string which are non-letters: Python
// // Orginal string: 2^sdfds*^*^jlljdslfnoswje34u230sdfds984
// // Remove all characters from the said string which are non-letters: sdfdsjlljdslfnoswjeusdfds
// // Click me to see the solution

// string str = "Py@th12on";
// string str1 = "Python 3.0";
// string str2 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";  
// string str3 = "Python 3.0";
// string str4 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
// char[] arr = str.ToCharArray();
// char[] arr1 = str1.ToCharArray();
// char[] arr2 = str2.ToCharArray();
// char[] arr3 = str3.ToCharArray();
// char[] arr4 = str4.ToCharArray();
// for (int i = 0; i < arr.Length; i++)
// {
//     if (char.IsLetter(arr[i]))
//     {
//         Console.Write(arr[i]);
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < arr1.Length; i++)
// {
//     if (char.IsLetter(arr1[i]))
//     {
//         Console.Write(arr1[i]);
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < arr2.Length; i++)
// {
//     if (char.IsLetter(arr2[i]))
//     {
//         Console.Write(arr2[i]);
//     }
// }
// Console.WriteLine();    
// for (int i = 0; i < arr3.Length; i++)
// {
//     if (char.IsLetter(arr3[i]))
//     {
//         Console.Write(arr3[i]);
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < arr4.Length; i++)
// {
//     if (char.IsLetter(arr4[i]))
//     {
//         Console.Write(arr4[i]);
//     }  
// }



// // 83. Write a C# Sharp program to remove all vowels from a given string.
// // Sample Output:
// // Orginal string: Python
// // After removing all the vowels from the said string: Pythn
// // Orginal string: C Sharp
// // After removing all the vowels from the said string: C Shrp
// // Orginal string: JavaScript
// // After removing all the vowels from the said string: JvScrpt
// // Click me to see the solution

// string str22 = "Python";
// string str23 = "C Sharp";
// string str24 = "JavaScript";
// // string str25 = "Python";
// // string str26 = "JavaScript";
// string newStr = "";
// string newStr1 = "";
// string newStr2 = "";
// for (int i = 0; i < str22.Length; i++)
// {
//     if (str22[i] != 'a' && str22[i] != 'e' && str22[i] != 'i' && str22[i] != 'o' && str22[i] != 'u' && str22[i] != 'A' && str22[i] != 'E' && str22[i] != 'I' && str22[i] != 'O' && str22[i] != 'U')
//     {
//         newStr += str22[i];
//     }
// }
// for (int i = 0; i < str23.Length; i++)
// {
//     if (str23[i] != 'a' && str23[i] != 'e' && str23[i] != 'i' && str23[i] != 'o' && str23[i] != 'u' && str23[i] != 'A' && str23[i] != 'E' && str23[i] != 'I' && str23[i] != 'O' && str23[i] != 'U')
//     {
//         newStr1 += str23[i];
//     }
// }
// for (int i = 0; i < str24.Length; i++)
// {
//     if (str24[i] != 'a' && str24[i] != 'e' && str24[i] != 'i' && str24[i] != 'o' && str24[i] != 'u' && str24[i] != 'A' && str24[i] != 'E' && str24[i] != 'I' && str24[i] != 'O' && str24[i] != 'U')
//     {
//         newStr2 += str24[i];
//     }
// }
// Console.WriteLine("Orginal string: " + str22);
// Console.WriteLine("After removing all the vowels from the said string: " + newStr);
// Console.WriteLine("Orginal string: " + str23);
// Console.WriteLine("After removing all the vowels from the said string: " + newStr1);
// Console.WriteLine("Orginal string: " + str24);
// Console.WriteLine("After removing all the vowels from the said string: " + newStr2);   


// // 84. Write a C# Sharp program to get the index number of all lower case letters in a given string.
// // Sample Output:
// // Orginal string: Python
// // Indices of all lower case letters of the said string:
// // 1 2 3 4 5
// // Orginal string: JavaScript
// // Indices of all lower case letters of the said string:
// // 1 2 3 5 6 7 8 9
// // Click me to see the solution

// string str27 = "Python";
// string str28 = "JavaScript";
// for (int i = 0; i < str27.Length; i++)
// {
//     if (char.IsLower(str27[i]))
//     {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine();
// for (int i = 0; i < str28.Length; i++)
// {
//     if (char.IsLower(str28[i]))
//     {
//         Console.Write(i + " ");
//     }
// }   

// // 85. Write a C# Sharp program to find the cumulative sum of an array of numbers.
// // A cumulative sum is a sequence of partial sums of a given sequence. For example, the cumulative sums of the sequence {x, y, z,...}, are x , x+y , x+y+z
// // Sample Output:
// // Orginal Array elements:
// // 1 3 4 5 6 7
// // Cumulative sum of the said array elements:
// // 1 4 8 13 19 26
// // Orginal Array elements:
// // 1.2 -3 4.1 6 -5.47
// // Cumulative sum of the said array elements:
// // 1.2 -1.8 2.3 8.3 2.83
// // Click me to see the solution

// int[] nums = { 1, 3, 4, 5, 6, 7 };
// int sum = 0;
// for (int i = 0; i < nums.Length; i++)
// {
//     sum += nums[i];
//     Console.Write(sum + " ");
// }
// Console.WriteLine();
// double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };
// double sum1 = 0;
// for (int i = 0; i < nums1.Length; i++)
// {
//     sum1 += nums1[i];
//     Console.Write(sum1 + " ");
// }

// // 86. Write a C# Sharp program to get the number of letters and digits in a given string.
// // Sample Output:
// // Original string:: Python 3.0
// // Number of letters: 6 Number of digits: 2
// // Original string:: dsfkaso230samdm2423sa
// // Number of letters: 14 Number of digits: 7
// // Click me to see the solution

// string str29 = "Python 3.0";
// int num = 0;
// int num1 = 0;
// for (int i = 0; i < str29.Length; i++)
// {
//     if (char.IsLetter(str29[i]))
//     {
//         num++;
//     }
//     else if (char.IsDigit(str29[i]))
//     {
//         num1++;
//     }
// }
// Console.WriteLine("Original string:: " + str29);
// Console.WriteLine("Number of letters: " + num + " Number of digits: " + num1);
// string str30 = "dsfkaso230samdm2423sa";
// int num2 = 0;
// int num3 = 0;
// for (int i = 0; i < str30.Length; i++)
// {
//     if (char.IsLetter(str30[i]))
//     {
//         num2++;
//     }
//     else if (char.IsDigit(str30[i]))
//     {
//         num3++;
//     }
// }
// Console.WriteLine("Original string:: " + str30);
// Console.WriteLine("Number of letters: " + num2 + " Number of digits: " + num3); 


// // 87. Write a C# Sharp program to reverse a Boolean value.
// // Sample Output:
// // Original value: False
// // Reverse value: True
// // Original value: True
// // Reverse value: False
// // Click me to see the solution

// bool value = true;
// bool value1 = false;
// Console.WriteLine("Original value: " + value);
// Console.WriteLine("Reverse value: " + !value);
// Console.WriteLine("Original value: " + value1);
// Console.WriteLine("Reverse value: " + !value1);


// // 88. Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given polygon. Input the number of straight lines.
// // From Wikipedia,
// // In geometry, a polygon is a plane figure that is described by a finite number of straight line segments connected to form a closed polygonal chain or polygonal circuit. The solid plane region, the bounding circuit, or the two together, may be called a Polygon.
// // Sample Output:
// // Input number of straight lines of the polygon:
// // Sum of the interior angles (in degrees) of the said polygon: -360
// // Click me to see the solution

// int num11 = Convert.ToInt32(Console.ReadLine());
// int sum41 = 0;
// for (int i = 1; i <= num11; i++)
// {
//     sum41 += 180 * (num11 - 2);
// }
// Console.WriteLine("Sum of the interior angles (in degrees) of the said polygon: " + sum);

// // 89. Write a C# Sharp program to count positive and negative numbers in a given array of integers.
// // Sample Output:
// // Original Array elements:
// // 10 -11 12 -13 14 -18 19 -20
// // Number of positive numbers: 4
// // Number of negative numbers: 4
// // Original Array elements:
// // -4 -3 -2 0 3 5 6 2 6
// // Number of positive numbers: 5
// // Number of negative numbers: 3
// // Original Array elements:
// // Number of positive numbers: 0
// // Number of negative numbers: 0
// // Click me to see the solution

// int[] nums2 = { 10, -11, 12, -13, 14, -18, 19, -20 };
// int num12 = 0;
// int num22 = 0;
// for (int i = 0; i < nums2.Length; i++)
// {
//     if (nums2[i] > 0)
//     {
//         num12++;
//     }
//     else if (nums2[i] < 0)
//     {
//         num22++;
//     }
// }
// Console.WriteLine("Original Array elements:");
// for (int i = 0; i < nums2.Length; i++)
// {
//     Console.Write(nums2[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Number of positive numbers: " + num12);
// Console.WriteLine("Number of negative numbers: " + num22);
// int[] nums3 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };
// int num13 = 0;
// int num23 = 0;
// for (int i = 0; i < nums3.Length; i++)
// {
//     if (nums3[i] > 0)
//     {
//         num13++;
//     }
//     else if (nums3[i] < 0)
//     {
//         num23++;
//     }
// }
// Console.WriteLine("Original Array elements:");
// for (int i = 0; i < nums3.Length; i++)
// {
//     Console.Write(nums3[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Number of positive numbers: " + num13);
// Console.WriteLine("Number of negative numbers: " + num23);
// int[] nums4 = { };
// Console.WriteLine("Original Array elements:");
// for (int i = 0; i < nums4.Length; i++)
// {
//     Console.Write(nums4[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Number of positive numbers: " + num13);
// Console.WriteLine("Number of negative numbers: " + num23);

// // 90. Write a C# Sharp program to count the number of ones and zeros in the binary representation of a given integer.
// // Sample Output:
// // Original number: 12
// // Number of ones and zeros in the binary representation of the said number:
// // Number of ones: 2
// // Number of zeros: 2
// // Original number: 1234
// // Number of ones and zeros in the binary representation of the said number:
// // Number of ones: 5
// // Number of zeros: 6
// // Click me to see the solution

// int num14 = 12;
// int num24 = 1234;
// int num34 = 0;
// int num44 = 0;
// while (num14 > 0)
// {
//     if (num14 % 2 == 1)
//     {
//         num34++;
//     }
//     else
//     {
//         num44++;
//     }
//     num14 /= 2;
// }
// Console.WriteLine("Original number: " + num14);
// Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
// Console.WriteLine("Number of ones: " + num34);
// Console.WriteLine("Number of zeros: " + num44);
// while (num24 > 0)
// {
//     if (num24 % 2 == 1)
//     {
//         num34++;
//     }
//     else
//     {
//         num44++;
//     }
//     num24 /= 2;
// }
// Console.WriteLine("Original number: " + num24);
// Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
// Console.WriteLine("Number of ones: " + num34);
// Console.WriteLine("Number of zeros: " + num44);

// // 91. Write a C# Sharp program to remove all values except integer values from a given array of mixed values.
// // Sample Output:
// // Original array elements:
// // 25 Anna False 4/24/2021 11:43:11 AM -112 -34.67
// // After removing all the values except integer values from the said array of mixed values: 25 -112
// // Click me to see the solution
// object[] nums5 = { 25, "Anna", false, "4/24/2021", "11:43:11 AM", -112, -34.67 };
// int[] nums6 = new int[nums5.Length];
// int num15 = 0;
// for (int i = 0; i < nums5.Length; i++)
// {
//     if (nums5[i] is int)
//     {
//         nums6[num15] = (int)nums5[i];
//         num15++;
//     }
// }
// Console.WriteLine("Original array elements:");
// for (int i = 0; i < nums5.Length; i++)
// {
//     Console.Write(nums5[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("After removing all the values except integer values from the said array of mixed values:");
// for (int i = 0; i < num15; i++)
// {
//     Console.Write(nums6[i] + " ");
// }


// // 92. Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number.
// // From Wikipedia,
// // A prime number (or a prime) is a natural number greater than 1 that is not a product of two smaller natural numbers. A natural number greater than 1 that is not prime is called a composite number. For example, 5 is prime because the only ways of writing it as a product, 1 × 5 or 5 × 1, involve 5 itself. However, 4 is composite because it is a product (2 × 2) in which both numbers are smaller than 4. Primes are central in number theory because of the fundamental theorem of arithmetic: every natural number greater than 1 is either a prime itself or can be factorized as a product of primes that is unique up to their order.
// // Sample Output:
// // Original number: 120
// // Next prime number/Current prime number: 127
// // Original number: 321
// // Next prime number/Current prime number: 331
// // Original number: 43
// // Next prime number/Current prime number: 43
// // Original number: 4433
// // Next prime number/Current prime number: 4441
// // Click me to see the solution

// int num16 = 120;
// int num26 = 321;
// int num36 = 43;
// int num46 = 4433;
// Console.WriteLine("Original number: " + num16);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num16));
// Console.WriteLine("Original number: " + num26);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num26));
// Console.WriteLine("Original number: " + num36);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num36));
// Console.WriteLine("Original number: " + num46);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num46));

// int NextPrime(int num)
// {
//     for (int i = num + 1; ; i++)
//     {
//         bool isPrime = true;
//         for (int j = 2; j < i; j++)
//         {
//             if (i % j == 0)
//             {
//                 isPrime = false;
//                 break;
//             }
//         }
//         if (isPrime)
//         {
//             return i;
//         }
//     }
// }

// // 93. Write a C# Sharp program to calculate the square root of a given number. Return the integer part of the result instead of using any built-in functions.
// // Sample Data:
// // (120) -> 10
// // (225) -> 15
// // (335) -> 18
// // Click me to see the solution

// int num17 = 120;
// int num27 = 225;
// int num37 = 335;
// Console.WriteLine("Original number: " + num17);
// Console.WriteLine("Square root: " + SquareRoot(num17));
// Console.WriteLine("Original number: " + num27);
// Console.WriteLine("Square root: " + SquareRoot(num27));
// Console.WriteLine("Original number: " + num37);
// Console.WriteLine("Square root: " + SquareRoot(num37));

// int SquareRoot(int num)
// {
//     int root = 1;
//     while (root * root < num)
//     {
//         root++;
//     }
//     return root;
// }

// // 94. Write a C# program that finds the longest common prefix from an array of strings.
// // Sample Data:
// // ({ "Padas", "Packed", "Pace", "Pacha" }) -> "Pa"
// // ({ "Jacket", "Joint", "Junky", "Jet" }) -> "J"
// // ({ "Bort", "Whang", "Yarder", "Zoonic" }) -> ""
// // Click me to see the solution

// string[] str5 = { "Padas", "Packed", "Pace", "Pacha" };
// string[] str6 = { "Jacket", "Joint", "Junky", "Jet" };
// string[] str7 = { "Bort", "Whang", "Yarder", "Zoonic" };
// Console.WriteLine("Original array elements:");
// for (int i = 0; i < str5.Length; i++)
// {
//     Console.Write(str5[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Longest common prefix: " + LongestCommonPrefix(str5));
// Console.WriteLine("Original array elements:");
// for (int i = 0; i < str6.Length; i++)
// {
//     Console.Write(str6[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Longest common prefix: " + LongestCommonPrefix(str6));
// Console.WriteLine("Original array elements:");
// for (int i = 0; i < str7.Length; i++)
// {
//     Console.Write(str7[i] + " ");
// }
// Console.WriteLine();
// Console.WriteLine("Longest common prefix: " + LongestCommonPrefix(str7));

// string LongestCommonPrefix(string[] str)
// {
//     string prefix = str[0];
//     for (int i = 1; i < str.Length; i++)
//     {
//         while (str[i].IndexOf(prefix) != 0)
//         {
//             prefix = prefix.Substring(0, prefix.Length - 1);
//         }
//     }
//     return prefix;
// }

// // 95. Write a C# programme to check the said string is valid or not. The input string will be valid when open brackets and closed brackets are same type of brackets.
// // Or
// // open brackets will be closed in proper order.
// // Sample Data:
// // ( "<>") -> True
// // ("<>()[]{}”) -> True
// // ("(<>”) -> False
// // ("[<>()[]{}]”) -> True
// // Click me to see the solution

// string str8 = "<>";
// string str9 = "<>()[]{}";
// string str10 = "(<>";
// string str11 = "[<>()[]{}]";
// Console.WriteLine("Original string: " + str8);
// Console.WriteLine("Valid or not: " + IsValid(str8));
// Console.WriteLine("Original string: " + str9);
// Console.WriteLine("Valid or not: " + IsValid(str9));
// Console.WriteLine("Original string: " + str10);
// Console.WriteLine("Valid or not: " + IsValid(str10));
// Console.WriteLine("Original string: " + str11);
// Console.WriteLine("Valid or not: " + IsValid(str11));

// bool IsValid(string str)
// {
//     Stack<char> stack = new Stack<char>();
//     foreach (char c in str)
//     {
//         if (c == '(' || c == '[' || c == '{')
//         {
//             stack.Push(c);
//         }
//         else if (c == ')' || c == ']' || c == '}')
//         {
//             if (stack.Count == 0 || stack.Pop() != GetMatchingBracket(c))
//             {
//                 return false;
//             }
//         }
//     }    
//     return stack.Count == 0;

//     char GetMatchingBracket(char c)
//     {
//         if (c == ')')
//         {
//             return '(';
//         }
//         else if (c == ']')
//         {
//             return '[';
//         }
//         else
//         {
//             return '{';
//         }
//     }
// }

// // 96. Write a C# Sharp program to check whether all characters in a string are the same. Return true if all the characters in the string are the same, otherwise false.
// // Sample Data:
// // ("aaa") -> True
// // ("abcd") -> False
// // ("3333") -> True
// // ("2342342") -> False
// // Click me to see the solution

// string str12 = "aaa";
// string str13 = "abcd";
// string str14 = "3333";
// string str15 = "2342342";
// Console.WriteLine("Original string: " + str12);
// Console.WriteLine("All characters are the same: " + AreAllCharactersTheSame(str12));
// Console.WriteLine("Original string: " + str13);
// Console.WriteLine("All characters are the same: " + AreAllCharactersTheSame(str13));
// Console.WriteLine("Original string: " + str14);
// Console.WriteLine("All characters are the same: " + AreAllCharactersTheSame(str14));
// Console.WriteLine("Original string: " + str15);
// Console.WriteLine("All characters are the same: " + AreAllCharactersTheSame(str15));

// bool AreAllCharactersTheSame(string str)
// {
//     char firstChar = str[0];
//     for (int i = 1; i < str.Length; i++)
//     {
//         if (str[i] != firstChar)
//         {
//             return false;
//         }
//     }
//     return true;
// }

// // 97. Write a C# Sharp program to check if a given string (floating point and negative numbers included) is numeric or not. Return True if the string is numeric, otherwise false.
// // Sample Data:
// // ("123") -> True
// // ("123.33") -> True
// // ("33/33") -> False
// // ("234234d2") -> False
// // Click me to see the solution

// int num47 = 123;
// double num48 = 123.33;
// string str16 = "33/33";
// string str17 = "234234d2";
// Console.WriteLine("Original string: " + num47);
// Console.WriteLine("Numeric or not: " + IsNumeric(num47));
// Console.WriteLine("Original string: " + num48);
// Console.WriteLine("Numeric or not: " + IsNumeric(num48));
// Console.WriteLine("Original string: " + str16);
// Console.WriteLine("Numeric or not: " + IsNumeric(str16));
// Console.WriteLine("Original string: " + str17); 
// Console.WriteLine("Numeric or not: " + IsNumeric(str17));    

// bool IsNumeric(object obj)
// {
//     try
//     {
//         double num = Convert.ToDouble(obj);
//         return true;
//     }
//     catch (FormatException)
//     {
//         return false;
//     }   
// }

// // 98. Write a C# Sharp program to create and display all prime numbers in strictly descending decimal digit order.
// // Sample Data:
// // 2, 3, 5, 7, 31, 41, 43, 53, 61, 71, 73, 83, 97, 421, 431.....
// // Click me to see the solution

// int num49 = 421;
// int num50 = 431;
// int num51 = 433;
// int num52 = 443;
// Console.WriteLine("Original number: " + num49);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num49));
// Console.WriteLine("Original number: " + num50);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num50));
// Console.WriteLine("Original number: " + num51);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num51));
// Console.WriteLine("Original number: " + num52);
// Console.WriteLine("Next prime number/Current prime number: " + NextPrime(num52));

// int NextPrime(int num)
// {
//     for (int i = num + 1; ; i++)
//     {
//         bool isPrime = true;
//         for (int j = 2; j < i; j++)
//         {
//             if (i % j == 0)
//             {
//                 isPrime = false;
//                 break;
//             }
//         }
//         if (isPrime)
//         {
//             return i;
//         }
//     }
// }


// // 99. Write a C# Sharp program to create and display all prime numbers in strict ascending decimal digit order.
// // Sample Data:
// // 2, 3, 5, 7, 13, 17, 19, 23, 29, 37, 47, 59, 67, 79,
// // Click me to see the solution

// int num53 = 2;
// int num54 = 3;
// int num55 = 5;
// int num56 = 7;
// Console.WriteLine("Original number: " + num53);
// Console.WriteLine("Next prime number/Current prime number: " + PreviousPrime(num53));
// Console.WriteLine("Original number: " + num54);
// Console.WriteLine("Next prime number/Current prime number: " + PreviousPrime(num54));
// Console.WriteLine("Original number: " + num55);
// Console.WriteLine("Next prime number/Current prime number: " + PreviousPrime(num55));
// Console.WriteLine("Original number: " + num56);
// Console.WriteLine("Next prime number/Current prime number: " + PreviousPrime(num56));

// int PreviousPrime(int num)
// {
//     for (int i = num - 1; ; i--)
//     {
//         bool isPrime = true;
//         for (int j = 2; j < i; j++)
//         {
//             if (i % j == 0)
//             {
//                 isPrime = false;
//                 break;
//             }
//         }
//         if (isPrime)
//         {
//             return i;
//         }
//     }
// }

// // 100. Write a C# Sharp program to check the equality comparison (value and type) of two parameters. Return true if they are equal otherwise false.
// // Sample Data:
// // ("AAA", "BBB") -> False
// // (true, false) -> False
// // (true, "true") -> False
// // (10, 10) -> True
// // Click me to see the solution

// string str18 = "AAA";
// string str19 = "BBB";
// bool bool1 = true;
// bool bool2 = false;
// int num57 = 10;
// int num58 = 10;
// Console.WriteLine("(" + str18 + ", " + str19 + ") -> " + AreEqual(str18, str19));
// Console.WriteLine("(" + bool1 + ", " + bool2 + ") -> " + AreEqual(bool1, bool2));
// Console.WriteLine("(" + bool1 + ", " + str19 + ") -> " + AreEqual(bool1, str19));
// Console.WriteLine("(" + num57 + ", " + num58 + ") -> " + AreEqual(num57, num58));

// bool AreEqual(object obj1, object obj2)
// {
//     return obj1.Equals(obj2);
// }   

// // 101. Write a C# Sharp program to calculate the value of e.
// // Note: e is also known as Euler's number and Napier's constant
// // Sample Data:
// // e = 2.718281828459050
// // Click me to see the solution

// double num59 = 2.718281828459050;
// Console.WriteLine("e = " + num59);

// // 102. Write a C# Sharp program to create an identity matrix.
// // Sample Data:
// // Input a number: 3
// // 1 0 0
// // 0 1 0
// // 0 0 1
// // Click me to see the solution

// int num60 = 3;
// for (int i = 0; i < num60; i++)
// {
//     for (int j = 0; j < num60; j++)
//     {
//         if (i == j)
//         {
//             Console.Write("1 ");
//         }
//         else
//         {
//             Console.Write("0 ");
//         }
//     }
//     Console.WriteLine();
// }

// // 103. Write a C# Sharp program to sort characters in a given string (uppercase/lowercase letters and numbers). Return the newly sorted string.
// // Sample Data:
// // ("AAAbfed231") -> "AAAbdef123"
// // (" ") -> "Blank string!"
// // ("Python") -> "hnoPty"
// // ("W3resource") -> "ceeorrsuW3"
// // Click me to see the solution

// string str20 = "AAAbfed231";
// string str21 = " ";
// string str22 = "Python";
// string str23 = "W3resource";
// Console.WriteLine("(" + str20 + ") -> " + SortString(str20));
// Console.WriteLine("(" + str21 + ") -> " + SortString(str21));
// Console.WriteLine("(" + str22 + ") -> " + SortString(str22));
// Console.WriteLine("(" + str23 + ") -> " + SortString(str23));

// string SortString(string str)
// {
//     char[] chars = str.ToCharArray();
//     Array.Sort(chars);
//     return new string(chars);
// }   


// // 104. Write a C# Sharp program to compare the equality of three integers and calculate how many integers have the same value.
// // Sample Data:
// // (1,2, 3) -> 0
// // (1,3,3) -> 2
// // (3,3,3) -> 3
// // Click me to see the solution

// int num61 = 1;
// int num62 = 2;
// int num63 = 3;
// int num64 = 1;
// int num65 = 3;
// int num66 = 3;
// Console.WriteLine("(" + num61 + ", " + num62 + ", " + num63 + ") -> " + CompareIntegers(num61, num62, num63));
// Console.WriteLine("(" + num64 + ", " + num65 + ", " + num66 + ") -> " + CompareIntegers(num64, num65, num66));
// Console.WriteLine("(" + num61 + ", " + num65 + ", " + num66 + ") -> " + CompareIntegers(num61, num65, num66));

// int CompareIntegers(int num67, int num68, int num69)
// {
//     int count = 0;
//     if (num67 == num68 && num67 == num69)
//     {
//         count = 3;
//     }
//     else if (num67 == num68 || num67 == num69 || num68 == num69)
//     {
//         count = 2;
//     }
//     return count;
// }

