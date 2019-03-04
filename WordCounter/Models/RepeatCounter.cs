using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static string _userWord;
    private static string _userSentence;
    private static int _result;

    public RepeatCounter (string userWord, string userSentence, int result)
    {
      _userWord = userWord;
      _userSentence = userSentence;
      _result = result;
    }

    public int Searcher(string userWord, string userSentence, int result)
    {
      string[] sentArray = userSentence.ToLower().Split(' ', '.', ',', '!', '?', '(', ')', '/');
      for (int i = 0; i < sentArray.Length; i++)
      {
        if (userWord.ToLower() == sentArray[i])
        {
          result++;
        }
      }
      _result = result;
      return _result;
    }

    public static string GetUserWord()
    {
      return _userWord;
    }

    public static string GetUserSentence()
    {
      return _userSentence;
    }

    public static int GetResult()
    {
      return _result;
    }
  }
}
