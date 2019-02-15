using System;

class Wordcounter
{
  static void Main()
  {
    Console.WriteLine("\nEnter a sentence to look through for a word then press enter.\nNext enter the word to be searched for withing the sentence then press enter.\nThe computer will tell you how many times the word is in the sentence.\nIf your searched for word is part of another word it will not be counted.\n");

    string userSentence = Console.ReadLine().ToLower();
    string userWord = Console.ReadLine().ToLower();

    if (userSentence.Contains(userWord))
    {
      Console.WriteLine(userSentence + ":\n" + userWord + " is in the above statement x times");
    }
    else
    {
      Console.WriteLine("false");
    }


  }
}
