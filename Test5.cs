// 81. Write a C# Sharp program to swap a two-digit number and check whether the given number is greater than its swap value.
// Sample Output:
// Input an integer value:
// Check whether the said value is greater than its swap value: True
// Click me to see the solution

int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10;
int num2 = num % 10;
int num3 = num1 * 10 + num2;
Console.WriteLine("Check whether the said value is greater than its swap value: " + (num > num3));

// 82. Write a C# Sharp program to remove all non-letter characters from a given string.
// From Wikipedia,
// A letter is a segmental symbol of a phonemic writing system. The inventory of all letters forms the alphabet. Letters broadly correspond to phonemes in the spoken form of the language, although there is rarely a consistent, exact correspondence between letters and phonemes
// Sample Output:
// Orginal string: Py@th12on
// Remove all characters from the said string which are non-letters: Python
// Orginal string: Python 3.0
// Remove all characters from the said string which are non-letters: Python
// Orginal string: 2^sdfds*^*^jlljdslfnoswje34u230sdfds984
// Remove all characters from the said string which are non-letters: sdfdsjlljdslfnoswjeusdfds
// Click me to see the solution

string str = "Py@th12on";
string str1 = "Python 3.0";
string str2 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";  
string str3 = "Python 3.0";
string str4 = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
char[] arr = str.ToCharArray();
char[] arr1 = str1.ToCharArray();
char[] arr2 = str2.ToCharArray();
char[] arr3 = str3.ToCharArray();
char[] arr4 = str4.ToCharArray();
for (int i = 0; i < arr.Length; i++)
{
    if (char.IsLetter(arr[i]))
    {
        Console.Write(arr[i]);
    }
}
Console.WriteLine();
for (int i = 0; i < arr1.Length; i++)
{
    if (char.IsLetter(arr1[i]))
    {
        Console.Write(arr1[i]);
    }
}
Console.WriteLine();
for (int i = 0; i < arr2.Length; i++)
{
    if (char.IsLetter(arr2[i]))
    {
        Console.Write(arr2[i]);
    }
}
Console.WriteLine();    
for (int i = 0; i < arr3.Length; i++)
{
    if (char.IsLetter(arr3[i]))
    {
        Console.Write(arr3[i]);
    }
}
Console.WriteLine();
for (int i = 0; i < arr4.Length; i++)
{
    if (char.IsLetter(arr4[i]))
    {
        Console.Write(arr4[i]);
    }  
}



// 83. Write a C# Sharp program to remove all vowels from a given string.
// Sample Output:
// Orginal string: Python
// After removing all the vowels from the said string: Pythn
// Orginal string: C Sharp
// After removing all the vowels from the said string: C Shrp
// Orginal string: JavaScript
// After removing all the vowels from the said string: JvScrpt
// Click me to see the solution

string str22 = "Python";
string str23 = "C Sharp";
string str24 = "JavaScript";
// string str25 = "Python";
// string str26 = "JavaScript";
string newStr = "";
string newStr1 = "";
string newStr2 = "";
for (int i = 0; i < str22.Length; i++)
{
    if (str22[i] != 'a' && str22[i] != 'e' && str22[i] != 'i' && str22[i] != 'o' && str22[i] != 'u' && str22[i] != 'A' && str22[i] != 'E' && str22[i] != 'I' && str22[i] != 'O' && str22[i] != 'U')
    {
        newStr += str22[i];
    }
}
for (int i = 0; i < str23.Length; i++)
{
    if (str23[i] != 'a' && str23[i] != 'e' && str23[i] != 'i' && str23[i] != 'o' && str23[i] != 'u' && str23[i] != 'A' && str23[i] != 'E' && str23[i] != 'I' && str23[i] != 'O' && str23[i] != 'U')
    {
        newStr1 += str23[i];
    }
}
for (int i = 0; i < str24.Length; i++)
{
    if (str24[i] != 'a' && str24[i] != 'e' && str24[i] != 'i' && str24[i] != 'o' && str24[i] != 'u' && str24[i] != 'A' && str24[i] != 'E' && str24[i] != 'I' && str24[i] != 'O' && str24[i] != 'U')
    {
        newStr2 += str24[i];
    }
}
Console.WriteLine("Orginal string: " + str22);
Console.WriteLine("After removing all the vowels from the said string: " + newStr);
Console.WriteLine("Orginal string: " + str23);
Console.WriteLine("After removing all the vowels from the said string: " + newStr1);
Console.WriteLine("Orginal string: " + str24);
Console.WriteLine("After removing all the vowels from the said string: " + newStr2);   


// 84. Write a C# Sharp program to get the index number of all lower case letters in a given string.
// Sample Output:
// Orginal string: Python
// Indices of all lower case letters of the said string:
// 1 2 3 4 5
// Orginal string: JavaScript
// Indices of all lower case letters of the said string:
// 1 2 3 5 6 7 8 9
// Click me to see the solution

string str27 = "Python";
string str28 = "JavaScript";
for (int i = 0; i < str27.Length; i++)
{
    if (char.IsLower(str27[i]))
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();
for (int i = 0; i < str28.Length; i++)
{
    if (char.IsLower(str28[i]))
    {
        Console.Write(i + " ");
    }
}   

// 85. Write a C# Sharp program to find the cumulative sum of an array of numbers.
// A cumulative sum is a sequence of partial sums of a given sequence. For example, the cumulative sums of the sequence {x, y, z,...}, are x , x+y , x+y+z
// Sample Output:
// Orginal Array elements:
// 1 3 4 5 6 7
// Cumulative sum of the said array elements:
// 1 4 8 13 19 26
// Orginal Array elements:
// 1.2 -3 4.1 6 -5.47
// Cumulative sum of the said array elements:
// 1.2 -1.8 2.3 8.3 2.83
// Click me to see the solution

int[] nums = { 1, 3, 4, 5, 6, 7 };
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
    Console.Write(sum + " ");
}
Console.WriteLine();
double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };
double sum1 = 0;
for (int i = 0; i < nums1.Length; i++)
{
    sum1 += nums1[i];
    Console.Write(sum1 + " ");
}

// 86. Write a C# Sharp program to get the number of letters and digits in a given string.
// Sample Output:
// Original string:: Python 3.0
// Number of letters: 6 Number of digits: 2
// Original string:: dsfkaso230samdm2423sa
// Number of letters: 14 Number of digits: 7
// Click me to see the solution

// 87. Write a C# Sharp program to reverse a Boolean value.
// Sample Output:
// Original value: False
// Reverse value: True
// Original value: True
// Reverse value: False
// Click me to see the solution

// 88. Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given polygon. Input the number of straight lines.
// From Wikipedia,
// In geometry, a polygon is a plane figure that is described by a finite number of straight line segments connected to form a closed polygonal chain or polygonal circuit. The solid plane region, the bounding circuit, or the two together, may be called a Polygon.
// Sample Output:
// Input number of straight lines of the polygon:
// Sum of the interior angles (in degrees) of the said polygon: -360
// Click me to see the solution

// 89. Write a C# Sharp program to count positive and negative numbers in a given array of integers.
// Sample Output:
// Original Array elements:
// 10 -11 12 -13 14 -18 19 -20
// Number of positive numbers: 4
// Number of negative numbers: 4
// Original Array elements:
// -4 -3 -2 0 3 5 6 2 6
// Number of positive numbers: 5
// Number of negative numbers: 3
// Original Array elements:
// Number of positive numbers: 0
// Number of negative numbers: 0
// Click me to see the solution

// 90. Write a C# Sharp program to count the number of ones and zeros in the binary representation of a given integer.
// Sample Output:
// Original number: 12
// Number of ones and zeros in the binary representation of the said number:
// Number of ones: 2
// Number of zeros: 2
// Original number: 1234
// Number of ones and zeros in the binary representation of the said number:
// Number of ones: 5
// Number of zeros: 6
// Click me to see the solution

// 91. Write a C# Sharp program to remove all values except integer values from a given array of mixed values.
// Sample Output:
// Original array elements:
// 25 Anna False 4/24/2021 11:43:11 AM -112 -34.67
// After removing all the values except integer values from the said array of mixed values: 25 -112
// Click me to see the solution

// 92. Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number.
// From Wikipedia,
// A prime number (or a prime) is a natural number greater than 1 that is not a product of two smaller natural numbers. A natural number greater than 1 that is not prime is called a composite number. For example, 5 is prime because the only ways of writing it as a product, 1 × 5 or 5 × 1, involve 5 itself. However, 4 is composite because it is a product (2 × 2) in which both numbers are smaller than 4. Primes are central in number theory because of the fundamental theorem of arithmetic: every natural number greater than 1 is either a prime itself or can be factorized as a product of primes that is unique up to their order.
// Sample Output:
// Original number: 120
// Next prime number/Current prime number: 127
// Original number: 321
// Next prime number/Current prime number: 331
// Original number: 43
// Next prime number/Current prime number: 43
// Original number: 4433
// Next prime number/Current prime number: 4441
// Click me to see the solution

// 93. Write a C# Sharp program to calculate the square root of a given number. Return the integer part of the result instead of using any built-in functions.
// Sample Data:
// (120) -> 10
// (225) -> 15
// (335) -> 18
// Click me to see the solution

// 94. Write a C# program that finds the longest common prefix from an array of strings.
// Sample Data:
// ({ "Padas", "Packed", "Pace", "Pacha" }) -> "Pa"
// ({ "Jacket", "Joint", "Junky", "Jet" }) -> "J"
// ({ "Bort", "Whang", "Yarder", "Zoonic" }) -> ""
// Click me to see the solution

// 95. Write a C# programme to check the said string is valid or not. The input string will be valid when open brackets and closed brackets are same type of brackets.
// Or
// open brackets will be closed in proper order.
// Sample Data:
// ( "<>") -> True
// ("<>()[]{}”) -> True
// ("(<>”) -> False
// ("[<>()[]{}]”) -> True
// Click me to see the solution

// 96. Write a C# Sharp program to check whether all characters in a string are the same. Return true if all the characters in the string are the same, otherwise false.
// Sample Data:
// ("aaa") -> True
// ("abcd") -> False
// ("3333") -> True
// ("2342342") -> False
// Click me to see the solution

// 97. Write a C# Sharp program to check if a given string (floating point and negative numbers included) is numeric or not. Return True if the string is numeric, otherwise false.
// Sample Data:
// ("123") -> True
// ("123.33") -> True
// ("33/33") -> False
// ("234234d2") -> False
// Click me to see the solution

// 98. Write a C# Sharp program to create and display all prime numbers in strictly descending decimal digit order.
// Sample Data:
// 2, 3, 5, 7, 31, 41, 43, 53, 61, 71, 73, 83, 97, 421, 431.....
// Click me to see the solution

// 99. Write a C# Sharp program to create and display all prime numbers in strict ascending decimal digit order.
// Sample Data:
// 2, 3, 5, 7, 13, 17, 19, 23, 29, 37, 47, 59, 67, 79,
// Click me to see the solution

// 100. Write a C# Sharp program to check the equality comparison (value and type) of two parameters. Return true if they are equal otherwise false.
// Sample Data:
// ("AAA", "BBB") -> False
// (true, false) -> False
// (true, "true") -> False
// (10, 10) -> True
// Click me to see the solution