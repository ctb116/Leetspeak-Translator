using System;
using System.Collections.Generic;

// namespace Leetspeak
//  {
   public class LeetspeakTranslator
   {
     public char letter;
     public char Translate(char letter)
     {
       if(letter == 'e')
       {
         return '3';
       }
       else if(letter == 'o')
       {
         return '0';
       }
       else if(letter == 't')
       {
         return '7';
       }
       else if(letter == 'I')
       {
         return '1';
       }
       else
       {
         return letter;
       }
     }
   }
 // }


 class Program
 {
   public static void Main()
   {
     Console.WriteLine("Please enter a sentence");
     string input = Console.ReadLine();

     char[] array = input.ToCharArray();
     LeetspeakTranslator myTranslator = new LeetspeakTranslator();
     List<char> resultArr = new List<char>{};
     for(int i = 0; i < array.Length; i++)
     {
       char letter = array[i];
       resultArr.Add(myTranslator.Translate(letter));
      //  output = myTranslator.Translate(letter)
      //  string strOutput = string.Join("", output.ToArray());
      //  Console.WriteLine(strOutput);

     }
     Console.WriteLine("Input Sentence: " + input);
     Console.WriteLine(resultArr.ToArray());



   }
 }
