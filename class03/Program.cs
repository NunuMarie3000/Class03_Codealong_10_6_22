using System;
// JS Equivalent: const system = require('system/io'); or import IO from 'system';
using System.IO;

namespace FileIO
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = "../new-data.txt";
      // string newFilePath = "../new-data.txt";
      // FileCreateNewFile(newFilePath);
      FileCreateNewFile(filePath);

      // FileReadAllTextAsBytes(filePath);
      // FileReadAllText(filePath);
      // FileReadAllTextAsArray(filePath);
      // FileAddSomeLines(filePath);
      FileReadAllText(filePath);
      // FileDelete(filePath);
      // FileCreateNewFile(newFilePath);
      // FileReadAllText(newFilePath);
    }

    // Bytes? Yes!
    static void FileReadAllTextAsBytes(string file)
    {
      byte[] bytes = File.ReadAllBytes(file);
      Console.WriteLine("\n-------READ AS BYTES-------");
      foreach (byte character in bytes)
      {
        Console.Write($"{character}");
      }
      Console.WriteLine();
      // this is converting bytes to string
      // string bytesToString = System.Text.Encoding.UTF8.GetString(bytes);
      // Console.WriteLine(bytesToString);
    }

    static void FileReadAllText(string file)
    {
      Console.WriteLine("\n-------READ AS STRING-------");
      string myFileContents = File.ReadAllText(file);
      Console.WriteLine(myFileContents);
    }

    static void FileReadAllTextAsArray(string file)
    {
      Console.WriteLine("\n-------READ AS ARRAY-------");
      string[] lines = File.ReadAllLines(file);

      foreach(string line in lines)
      {
        Console.WriteLine(line);
      }
    }

    static void FileAddSomeLines(string file)
    {
      Console.WriteLine("\n-------ADD LINES-------");
      string phraseToAdd = "Are you there god, it's me Fiona";
      // adding new ine to the file
      File.AppendAllText(file, "\n");
      // adding the new phrase to the end of the file
      File.AppendAllText(file, phraseToAdd);

      string randomString = "sunny hot loud";
      string[] randoWords = randomString.Split(' ');

      // adding new line to file
      File.AppendAllText(file, "\n");
      // adding new string line by line
      File.AppendAllLines(file, randoWords);
    }

    // use a stream to create a file byte by byte
    static void FileCreateNewFile(string file)
    {
      string messageToCreate = "I love playing games on my gameboy and I wanna learn to create my own gameboy games";
      // string messageToCreate = "This is a new message";
      string[] words = messageToCreate.Split(' ');
      
      try
      {
        using (StreamWriter sw = new StreamWriter(file) )
        {
          try 
          {
            foreach(string word in words)
            {
              sw.Write(word);
              // new line after each word
              sw.Write("\n");
            }
          }
          catch(Exception e)
          {
            Console.WriteLine(e.Message);
            throw;
          }
          finally{
            sw.Close();
          }
        }
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
        throw;
      }
    }

    static void FileDelete(string file)
    {
      File.Delete(file);
      Console.WriteLine("File successfully deleted");
    }



  }
}