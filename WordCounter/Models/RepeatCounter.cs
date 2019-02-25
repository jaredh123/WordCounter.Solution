using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string[] SplitSentence(string array)
    {
      string[] sentArray = array.Split(' ');
      return sentArray;
    }
    public int Searcher(string item, string[] array)
    {
      int result = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (item == array[i])
        {
          result++;
        }
      }
      return result;
    }
  }
}
