// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

string path = @"C:\Downloads\SwedenConverse.png";
string fileName = string.Empty;
string filePath = string.Empty;
string folderName = string.Empty;
string folderPath = string.Empty;
string drive;
string driveRegex = @"^[a-zA-Z]:\/?\/?\\?\\?";
bool isDrive = Regex.IsMatch(path, driveRegex);
Console.WriteLine("Input= " + path);
Console.Write("Output= ");
if (string.IsNullOrEmpty(path) || !isDrive) {
    Console.WriteLine("Path should be valid like drive:/, drive:/folder/, or drive:/folder/file");
    return;
}
string fileOrFolderRegex = @"[a-zA-Z0-9_\s-]+(\.[a-zA-Z]{2,4})?\/?\/?\\?\\?$";
string folderNameRegex = @"[a-zA-Z0-9_\s-]+\/?\/?\\?\\?$";
string fileNameRegex = @"[a-zA-Z0-9_\s-]+(\.[a-zA-Z]{2,4})$";
drive = Regex.Match(path, driveRegex).Value;
bool isFolderName = Regex.IsMatch(path, folderNameRegex);
bool isFileName = Regex.IsMatch(path, fileNameRegex);
if (isFileName) {
    fileName = Regex.Match(path, fileOrFolderRegex).Value;
    filePath = Regex.Replace(path, fileOrFolderRegex, string.Empty);
    folderName = Regex.Match(filePath, fileOrFolderRegex).Value;
    folderPath = Regex.Replace(filePath, fileOrFolderRegex, string.Empty);
} else if (isFolderName) {
    folderName = Regex.Match(path, fileOrFolderRegex).Value;
    folderPath = Regex.Replace(path, fileOrFolderRegex, string.Empty);
}
if (!string.IsNullOrEmpty(drive))
    Console.WriteLine("Drive= " + drive);
if (!string.IsNullOrEmpty(folderName)
    && !string.IsNullOrEmpty(folderPath))
    Console.WriteLine("\tFolderPath= " + folderPath);
if (!string.IsNullOrEmpty(folderName))
    Console.WriteLine("\tFolderName= " + folderName);
if (!string.IsNullOrEmpty(fileName) 
    && !string.IsNullOrEmpty(filePath))
    Console.WriteLine("\tFilePath= " + filePath);
if (!string.IsNullOrEmpty(fileName))
    Console.WriteLine("\tFileName= " + fileName);
