using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab040425
{
  internal class Program
  {
    private static string ReplacePhoneNumber(Match match)
    {
      string countryCode = "380";
      string operatorCode = match.Groups[1].Value;
      string firstPart = match.Groups[2].Value;
      string secondPart = match.Groups[3].Value;
      string thirdPart = match.Groups[4].Value;

      return $"+{countryCode} {operatorCode} {firstPart} {secondPart} {thirdPart}";
    }

    static void Main(string[] args)
    {
      Dictionary<string, string> incorrectWords = new Dictionary<string, string>
      {
        {"ghbdtn", "привет"},
        {"rfr ltkf", "как дела"},
        {"пирвет", "привет"}
      };

      Console.WriteLine("Введите путь к директории:");
      string directoryPath = Console.ReadLine();

      try
      {
        var files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
        int modifiedFilesCount = 0;

        foreach (var filePath in files)
        {
          // обработка файлов
        }

        if (modifiedFilesCount > 0)
        {
          Console.WriteLine($"Обработка завершена, количество измененных файлов: {modifiedFilesCount}");
        }
        else
        {
          Console.WriteLine($"Файлы подлежащих обработке не найдены");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Ошибка: {ex.Message}");
      }
    }
  }
}