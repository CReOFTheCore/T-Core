/* 
Task:
Given multiple words, you need to find the longest string that is a substring of all words. 

Input Format:
A string of words, separated by spaces. The string can also contain numbers.

Output Format:
A string, representing the longest common substring. 
If there are multiple longest common substrings, output the smallest one in alphabetical order.

Sample Input:
SoloLearn Learning LearningIsFun Learnable

Sample Output:
Learn
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
  class Program
  {
     static void Main(string[] args)
     { 
        string[] sentence = Console.ReadLine().Split();
        int startInd = 0;
        int noChar = 0; /* if set to 1 condition 6 is not met if set to 2 condition 4 doesn't work*/
        string longest = "";
        string shortWord = sentence[0];

        foreach (string item in sentence)
        {
          if (item.Length<shortWord.Length)
          {
              shortWord = item;
          }
        }
        while ((startInd+noChar) <= shortWord.Length)
        {
          string word = shortWord.Substring(startInd, noChar);

          foreach (string item in sentence)
          {
            if (item == sentence[sentence.Length-1])
            {
              if(item.Contains(word))
              {
                noChar++;
                if (longest.Length <= word.Length)
                {
                   longest = word;
                }
              }else           
              {
                 startInd++;
                 noChar =2;                  
                 break;
              }
           }
           if (!item.Contains(word))
           {
               startInd++;
               noChar = 2;                 
               break;
           }
         }   
       }
      Console.WriteLine(longest.ToString());
    }
  }
}
