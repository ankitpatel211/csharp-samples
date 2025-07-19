string filePath = "C:\\Users\\patel\\source\\repos\\ankitpatel211\\CSharp-Samples\\Directory\\Directory.cs";
string fileDirectory = string.Empty;
string fileName = string.Empty;
string reverseFilename = string.Empty;
int slashIndex = 0;

for (int i = filePath.Length - 1; i >= 0; i--) {
    if (filePath[i] == '/' || filePath[i] == '\\') {
        slashIndex = i;
        break;
    }
    reverseFilename += filePath[i];
}
for (int j = reverseFilename.Length - 1; j >= 0; j--) {
    fileName += reverseFilename[j];
}
Console.WriteLine("Filename: " + fileName);
for (int i = 0; i < slashIndex; i++) {
    fileDirectory = fileDirectory + filePath[i];
}
Console.WriteLine("Filepath: " + fileDirectory);