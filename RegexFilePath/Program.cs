// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string filePath = "C:\\Users\\patel\\source\\repos\\ankitpatel211\\CSharp-Samples\\Directory\\Directory.cs";
string fileName = string.Empty;
string newFilePath = string.Empty;
string folderName;
string folderPath;
string fileOrFolderRegex = @"[a-zA-Z0-9_\s-]+(\.[a-zA-Z]{2,4})?\/?\/?\\?\\?$";
string fileNameRegex = @"[a-zA-Z0-9_\s-]+(\.[a-zA-Z]{2,4})";
bool isFileName = Regex.IsMatch(filePath, fileNameRegex);
if (isFileName) {
    fileName = Regex.Match(filePath, fileOrFolderRegex).Value;
    newFilePath = Regex.Replace(filePath, fileOrFolderRegex, string.Empty);
    folderName = Regex.Match(newFilePath, fileOrFolderRegex).Value;
    folderPath = Regex.Replace(newFilePath, fileOrFolderRegex, string.Empty);
} else {
    folderName = Regex.Match(filePath, fileOrFolderRegex).Value;
    folderPath = Regex.Replace(filePath, fileOrFolderRegex, string.Empty);
}
if (!string.IsNullOrEmpty(newFilePath))
    Console.WriteLine("FilePath= " + newFilePath);
if (!string.IsNullOrEmpty(fileName))
    Console.WriteLine("FileName= " + fileName);
if (!string.IsNullOrEmpty(folderPath))
    Console.WriteLine("FolderPath= " + folderPath);
if (!string.IsNullOrEmpty(folderName))
    Console.WriteLine("FolderName= " + folderName);


