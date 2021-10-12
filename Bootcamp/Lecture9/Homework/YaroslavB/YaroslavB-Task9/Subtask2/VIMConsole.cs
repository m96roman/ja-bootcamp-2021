using System;
using System.Collections.Generic;
using System.IO;

namespace YaroslavB_Task9
{
    class VIMConsole
    {
        #region Fields

        private static List<string> _linesBuffer = new List<string>();
        private const string _exitWord = "EXIT";
        private static int _fileIndex = 0;
        private static string _lineIndent = ": ";
        private static bool _showLineNumbers = true;
        private static int _numLinesToLog = 8;
        private static bool _isConsoleRunning = false;

        private static string _workDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Subtask2_VimConsole");
        private static string _fileNamePrefix = "inputFromVIM";
        private static string _fileExtension = ".txt";
        private static string _date = DateTime.Now.ToString("dd.MMM.yyyy hh-mm-ss");
        private static string _backupFolderPrefix = "Session_";

        #endregion

        public static void StartVIMconsole(bool showLineNumbers = true, int linesToLog = 8)
        {
            if (_isConsoleRunning)
            {
                Console.WriteLine("\nNo access! VIM console already running!");
                return;
            }

            Console.WriteLine("Welcome to VIM Console\n" +
                             "Type your text below \n" +
                             "*  separate lines by \'Enter\', \n" +
                             $"** enter key-word \'{_exitWord}\' to quit\n\n");

            _showLineNumbers = showLineNumbers;
            _numLinesToLog = linesToLog;
            _isConsoleRunning = true;

            ConsoleInfiniteLog();
        }

        private static void ConsoleInfiniteLog()
        {
            int lineNumber = 1;
            while (true)
            {
                if (_showLineNumbers)
                {
                    Console.Write(lineNumber + _lineIndent);
                }

                string inputText = Console.ReadLine();

                if (inputText.ToUpper() == _exitWord)
                {
                    if (_linesBuffer.Count > 0)
                    {
                        _fileIndex++;
                        TryToLog();
                    }
                    BackupFiles();
                    _isConsoleRunning = false;

                    Console.WriteLine("\nApplication is closed.");
                    return;
                }

                _linesBuffer.Add(inputText);

                if (lineNumber % _numLinesToLog == 0)
                {
                    _fileIndex++;
                    TryToLog();
                    _linesBuffer.Clear();
                }

                lineNumber++;
            }
        }

        private static void TryToLog()
        {
            CreateFolder(_workDirectory);
            string fileName = _fileNamePrefix + _fileIndex + _fileExtension;
            string filePath = Path.Combine(_workDirectory, fileName);

            Console.Write($"..saving.... ");

            try
            {
                LogTextToFile(filePath, _linesBuffer);
            }
            catch (Exception ex)
            {
                Console.WriteLine("fail!");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("done.");
        }

        private static void LogTextToFile(string filePath, List<string> textLines)
        {
            File.WriteAllLines(filePath, textLines);
        }

        private static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private static void BackupFiles()
        {
            string backupFolderName = _backupFolderPrefix + _date;
            string backupFolderPath = Path.Combine(_workDirectory, backupFolderName);
            CreateFolder(backupFolderPath);
            var allFiles = Directory.GetFiles(_workDirectory);
            FileInfo fi;
            string fileName;

            foreach (var file in allFiles)
            {
                fi = new FileInfo(file);
                fileName = fi.Name;

                if (!fileName.StartsWith(_fileNamePrefix))
                {
                    //Console.WriteLine($"Skipped {file}");
                    continue;
                }

                string newLocation = Path.Combine(backupFolderPath, fileName);
                fi.MoveTo(newLocation);

                //Console.WriteLine($"Moved {fileName} to {backupFolderPath}");
            }

        }
    }
}
