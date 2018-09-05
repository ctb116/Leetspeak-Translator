using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;



namespace Leetspeak
 {
   public class LeetspeakTranslator
   {

     public string Translate(string input)
     {
       Regex rx = new Regex(@"^[a-zA-Z]+$");
       List<char> inputList = new List<char> { };
       List<char> outputList = new List<char> { };

       for(int i = 0; i < input.Length; i++)
       {
         inputList.Add(input[i]);
         if (inputList[i] == 'e')
         {
           outputList.Add('3');
         }
         else if(inputList[i] == 'o')
         {
           outputList.Add('0');
         }
         else if(inputList[i] == 't')
         {
           outputList.Add('7');
         }
         else if(inputList[i] == 'I')
         {
           outputList.Add('1');
         }
         else if(i > 1 && rx.IsMatch(inputList[i - 1].ToString()) && ((inputList[i] == 's') || (inputList[i] == 'S')))
         {
           outputList.Add('z');
         }
         else
         {
           outputList.Add(inputList[i]);
         }
       }
       string translatedOutput = string.Join("", outputList.ToArray());
       return translatedOutput;
     }
   }
 }


 // class Program
 // {
 //   public static void Main()
 //   {
 //
 //
 //   }
 // }
