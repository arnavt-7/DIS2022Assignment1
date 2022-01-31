/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK
*/
using System;
using System.Text.RegularExpressions;
using System.Text;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {

                string str1 = "";
                Regex rgx = new Regex("[^A-Za-z0-9]");
                bool hasSpecialChars = rgx.IsMatch(s);
                // Running a for loop which iterates over the input string from 0 -> total length of string
                //it checks if each letter of input string is a vowel in upper and lower case.  
                //If the string has vowels, if loop does nothing and otherwise it will keep concantenating all the
                //alphabets without vowels and finally give the output in final_string to the calling method
                if ((s.Length <= 1000))
                {
                    if ((!hasSpecialChars))
                        //this loop will check if there are any vowels including upper case as well
                        //as lower case. If there are vowels then the if loop will perform no execution 
                        // if there is no vowel then the element will be added to str1
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
                                || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                            { }
                            else
                            {
                                str1 = str1 + s[i];
                            }
                        }
                }
                else
                {

                }
                String final_string = str1;
                return final_string;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only characters");
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //This function will first iterate over the first string and then iterate over the 
                //second loop. It will check if the ith element of the first string is equal to the
                //jth element of the second string and so on. If any element is not matching 
                //then the loop will return false to the driver function. But if all the emelemts are
                //matching then the loop will return true.
                for (int i = 0; i < bulls_string1.Length; i++)
                {
                    for (int j = 0; i < bulls_string2.Length; j++)
                    {
                        if (bulls_string1[i] == bulls_string2[j])
                        {

                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                return true;



            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only characters");
                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // sort all elements of array
                Array.Sort(bull_bucks);
                //The code will take each element of the sorted array and
                //compare each element with the next consecutive element of the same 
                //array. If the element is same then the element will be added to the sum
                //varible. It also checks if i < bull_bucks.Length to make sure that the
                //loop does not fall out of bound when the index of array is 3. This is 
                //achieved by checking if i+1 < bull_bucks.Length i.e. 3
                int sum = bull_bucks[0];
                for (int i = 0; i < bull_bucks.Length; i++)
                {
                    int j = i + 1;
                    if (j < bull_bucks.Length)
                    {
                        if (bull_bucks[i] != bull_bucks[i + 1])
                        {
                            sum = sum + bull_bucks[i + 1];
                        }
                    }
                }
                Console.WriteLine(sum);
                return sum;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only numbers");
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                //This logic will add the diagonal elements with index 1,1 2,2 and 3,3
                int m = 3;
                int n = 3;
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j == i)
                        {
                            sum = sum + bulls_grid[i, j];
                        }

                    }
                }
                //This logic will add the diagonal elements at index 1,3 and 3,1
                for (int i = 0; i < n; i++)
                {
                    for (int j = n; j < 0; j--)
                    {
                        if ((i == 1 && j == 3) || ((i == 3 && j == 1)))
                        {
                            sum = sum + bulls_grid[i, j];
                        }

                    }
                }
                Console.WriteLine();

                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                char res;
                char a = bulls_string[1];
                int b;
                bool x;
                bool y;
                // Determines if int array is sorted from 0 -> Max
                //If the array is not sorted then the loop will break and jump
                //out of the for loop and the next for loop will start executing
                //which will shuffle the character at the ith position to indices[i]
                //in the shuffled string.
                //It will then return the shuffled string.
                for (int j = 1; j < indices.Length; j++)
                {
                    if (indices[j - 1] > indices[j])
                    {
                        break;
                    }
                    else
                    {
                        string z = bulls_string;
                        return (z);
                    }
                }
                // This function will shuffle the string as per the indices 
                for (int i = 0; i < indices.Length; i++)
                {
                    b = indices[i];
                    res = bulls_string[b];
                    return res.ToString();
                }
                return "";

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                int l = bulls_string6.Length;
                int char_index = -1; // we have initialized the char_index by default to -1
                char temp;
                string[] stringArray = new string[] { bulls_string6 };

                String prefix_string = "";

                // This loop will find out the index position at which the bulls_string has
                //a character "ch". Once it is located, the index or ith value is stored
                //in a variable named char_index
                for (int i = 0; i < l; i++)
                {
                    if (bulls_string6[i] == ch)
                    {
                        char_index = i;
                        break;
                    }
                }

                // we will check if ch is found or not. If the value is other then -1. It means
                // we have found "ch". But if it is -1 then it means there is no "ch" in the string
                // and we will return the original string as it is.
                if (char_index == -1)
                    return bulls_string6;

                //if char_index is initialized then the if loop will break and now we
                //can swap the elements
                for (int i = 0; i <= char_index / 2; i++)
                {
                    temp = bulls_string6[i];
                    stringArray[i] = stringArray[char_index - i];
                    stringArray[char_index - i] = temp.ToString();
                }
                StringBuilder builder = new StringBuilder();
                //This loop will append the stringArray to string and return the value to the 
                //driver function
                foreach (string value in stringArray)
                {
                    builder.Append(value);
                    builder.Append('.');
                }
                return builder.ToString();
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter only characters");
                throw;
            }

        }
    }
}
