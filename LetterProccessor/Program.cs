string input = "this interview is for full stack developer with new string";
string storedLetters = string.Empty;
string renewedLetters = string.Empty;
string subStringChar = string.Empty;
string lastWord = string.Empty;
int wordCounter = 0;
int charCounter = 0;
int charCounterWithSpace = 0;
foreach (char c in input) {
	if (c == (char)32) {
		int counter = 0;
		foreach (char c2 in storedLetters) {
			if (counter >= 1) {
				subStringChar += c2;
			}
			counter++;
		}
		if (counter > 3) {
			char firstChar = storedLetters[0];
			int asciiValue = (int)firstChar - 32;
			char replacedChar = (char)asciiValue;
			renewedLetters += replacedChar + subStringChar + (char)32;
		} else { 
			renewedLetters += storedLetters + (char)32;
		}
		wordCounter++;
		subStringChar = string.Empty;
		storedLetters = string.Empty;
	}
	else {
		storedLetters += c;
	}
	charCounter++;
}
foreach (char c in renewedLetters) {
	charCounterWithSpace++;
}
int lastWordCounter = charCounter - charCounterWithSpace;
if (lastWordCounter > 3) {
	int i = 0;
	subStringChar = string.Empty;
	foreach (char c in input) {
		if (i < lastWordCounter) {
			lastWord += input[charCounterWithSpace + i];
			if(i >= 1) {
			   subStringChar += input[charCounterWithSpace + i];
            }
			i++;
		}
	}
	char firstChar = lastWord[0];
	int asciiValue = (int)firstChar - 32;
	char replaceChar = (char)asciiValue;
	renewedLetters += replaceChar + subStringChar;
	wordCounter++;
}
else {
	renewedLetters += input[charCounterWithSpace].ToString()
					+ input[charCounterWithSpace + 1].ToString() 
					+ input[charCounterWithSpace + 2].ToString();
}
Console.WriteLine(renewedLetters);
Console.WriteLine("Total words: " + wordCounter);
Console.WriteLine("Total characters: " + charCounter);


