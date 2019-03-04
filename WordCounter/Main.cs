// using System;
// using System.Collections.Generic;
// using WordCounter.Models;
//
// namespace WordCounter
// {
//   public class Wordcounter
//   {
//     public static void Main(string[] args)
//     {
//       Console.WriteLine("\nEnter a sentence to look through for a word then press enter.\nNext enter the word to be searched for withing the sentence then press enter.\nThe computer will tell you how many times the word is in the sentence.\nIf your searched for word is part of another word it will not be counted.\n\nSentence:");
//
//       string userSentence = Console.ReadLine().ToLower();
//       Console.WriteLine("Word:");
//       string userWord = Console.ReadLine().ToLower();
//       RepeatCounter Counter = new RepeatCounter();
//
//       string[] sentArray = Counter.SplitSentence(userSentence);
//       int result = Counter.Searcher(userWord, sentArray);
//       Console.WriteLine("\n" + userSentence + ":\n" + userWord + " is in the above statement " + result + " times.");
//     }
//   }
// }
