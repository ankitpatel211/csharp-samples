// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using RegularExpression;

string dateToday = DateTime.Now.ToString(ConsoleOutput.dateFormat).Trim();
string currentTime = DateTime.Now.ToString(ConsoleOutput.timeFormat).Trim();
string input = "Today is " + dateToday + " and current time is " + currentTime + ".";
string inputCmd = string.Concat(ConsoleOutput.inputText, input);
Console.WriteLine(inputCmd);
Regex regex = new(ConsoleOutput.regExp);
var match = regex.Match(input);
bool isMatched = match.Success;
if (isMatched) {
    string matchValue = match.Value;
    var hoursMinutes = string.IsNullOrEmpty(matchValue) ? currentTime.Split(ConsoleOutput.space) : matchValue.Split(ConsoleOutput.space);
    string hourText = hoursMinutes[0].Split(ConsoleOutput.colon)[0];
    string minuteText = hoursMinutes[0].Split(ConsoleOutput.colon)[1];
    string amPm = hoursMinutes[1];
    try {
        int hour = int.Parse(hourText);
        int minute = int.Parse(minuteText);
        string hoursRange = hour >= 02 && hour <= 12 ? ConsoleOutput.hours : ConsoleOutput.hour;
        string minutesRange = minute >= 02 && minute <= 59 ? ConsoleOutput.minutes : ConsoleOutput.minute;
        string hoursTime = string.Concat(hourText, hoursRange);
        string minutesTime = string.Concat(minuteText, minutesRange);
        var replaceText = string.Concat(hoursTime, ConsoleOutput.and, minutesTime);
        if (hour >= 07 && hour < 12 && amPm == ConsoleOutput.am) {
            replaceText += ConsoleOutput.morning;
        } else if (hour >= 01 && hour <= 03 || hour == 12 && amPm == ConsoleOutput.pm) {
            replaceText += ConsoleOutput.afternoon;
        } else if (hour >= 04 && hour <= 06 && amPm == ConsoleOutput.pm) {
            replaceText += ConsoleOutput.evening;
        } else if (hour >= 07 && hour < 12 && amPm == ConsoleOutput.pm) {
            replaceText += ConsoleOutput.night;
        } else if (hour >= 01 && hour <= 06 || hour == 12 && amPm == ConsoleOutput.am) {
            replaceText += ConsoleOutput.midNight;
        }
        var output = input.Replace(matchValue, replaceText);
        string outputCmd = string.Concat(ConsoleOutput.outputText, output);
        Console.WriteLine(outputCmd);
    } catch (FormatException) {
        string outputCmd = string.Concat(ConsoleOutput.outputText, ConsoleOutput.nonIntegerOutput);
        Console.WriteLine(outputCmd);
    } catch (OverflowException) {
        string outputCmd = string.Concat(ConsoleOutput.outputText, ConsoleOutput.overflowIntegerOutput);
        Console.WriteLine(outputCmd);
    }
} else {
    string outputCmd = string.Concat(ConsoleOutput.outputText, ConsoleOutput.falseMatchOutput);
    Console.WriteLine(outputCmd);
}
