
string directoryPath = "C:\\Users\\patel\\source\\repos\\ankitpatel211\\CSharp-Samples\\Directory\\Directory.cs";
string directory = string.Empty;
string fileName = string.Empty;
string reverseFilename = string.Empty;
int slashIndex = 0;

for (int i = directoryPath.Length - 1; i >= 0; i--) {
    if (directoryPath[i] == '/' || directoryPath[i] == '\\') {
        slashIndex = i;
        break;
    }
    reverseFilename += directoryPath[i];
}
for (int j = reverseFilename.Length - 1; j >= 0; j--) {
    fileName += reverseFilename[j];
}
Console.WriteLine("Filename: " + fileName);
for (int i = 0; i < slashIndex; i++) {
    directory = directory + directoryPath[i];
}
Console.WriteLine("Filepath: " + directory);