// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string filePath = "C:\\Users\\patel\\source\\repos\\ankitpatel211\\CSharp-Samples\\Directory\\Directory.cs";
string fileOrFolderRegex = @"[a-zA-Z0-9_-]+(\.[a-zA-Z]{2,4})?\/?\\?$";
string newFilePath = Regex.Replace(filePath, fileOrFolderRegex, string.Empty);
string fileName = Regex.Match(filePath, fileOrFolderRegex).Value;
string folderName = Regex.Match(newFilePath, fileOrFolderRegex).Value;
string folderPath = Regex.Replace(newFilePath, fileOrFolderRegex, string.Empty);
Console.WriteLine("FileName= " + fileName);
Console.WriteLine("FilePath= " + newFilePath);
Console.WriteLine("FolderName= " + folderName);
Console.WriteLine("FolderPath= " + folderPath);




