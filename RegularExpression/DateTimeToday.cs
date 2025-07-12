// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using RegularExpression;

string dateToday = DateTime.Now.ToString(DateTimeFormat.date).Trim();
string currentTime = DateTime.Now.ToString(DateTimeFormat.time).Trim();
string input = "Today is " + dateToday + " and current time is " + currentTime + ".";
string inputCmd = string.Concat(ConsoleOutput.inputText, input);
Console.WriteLine(inputCmd);
Regex regex = new(TwelveHoursTimeRegEx.expression);
var match = regex.Match(input);
bool isMatched = match.Success;
if (isMatched) {
    string matchValue = match.Value;
    var hoursMinutes = string.IsNullOrEmpty(matchValue) ? currentTime.Split(Split.space) : matchValue.Split(Split.space);
    string hourText = hoursMinutes[0].Split(Split.colon)[0];
    string minuteText = hoursMinutes[0].Split(Split.colon)[1];
    string amPm = hoursMinutes[1];
    try {
        int hour = int.Parse(hourText);
        int minute = int.Parse(minuteText);
        string hoursRange = hour >= 02 && hour <= 12 ? HourMinute.hours : HourMinute.hour;
        string minutesRange = minute >= 02 && minute <= 59 ? HourMinute.minutes : HourMinute.minute;
        string hoursTime = string.Concat(hourText, Split.space, hoursRange);
        string minutesTime = string.Concat(minuteText, Split.space, minutesRange);
        var replaceText = string.Concat(hoursTime, Split.space, HourMinute.and, Split.space, minutesTime);
        if (hour >= 07 && hour < 12 && amPm == TwelveHoursFormat.am) {
            replaceText += Split.space + DayParts.morning;
        } else if (hour >= 01 && hour <= 03 || hour == 12 && amPm == TwelveHoursFormat.pm) {
            replaceText += Split.space + DayParts.afternoon;
        } else if (hour >= 04 && hour <= 06 && amPm == TwelveHoursFormat.pm) {
            replaceText += Split.space + DayParts.evening;
        } else if (hour >= 07 && hour < 12 && amPm == TwelveHoursFormat.pm) {
            replaceText += Split.space + DayParts.night;
        } else if (hour >= 01 && hour <= 06 || hour == 12 && amPm == TwelveHoursFormat.am) {
            replaceText += Split.space + DayParts.midNight;
        }
        var output = input.Replace(matchValue, replaceText);
        string outputCmd = string.Concat(ConsoleOutput.outputText, output);
        Console.WriteLine(outputCmd);
    } catch (FormatException) {
        string outputCmd = string.Concat(ConsoleOutput.outputText, ExceptionOutput.nonInteger);
        Console.WriteLine(outputCmd);
    } catch (OverflowException) {
        string outputCmd = string.Concat(ConsoleOutput.outputText, ExceptionOutput.overflowInteger);
        Console.WriteLine(outputCmd);
    }
} else {
    string outputCmd = string.Concat(ConsoleOutput.outputText, ExceptionOutput.falseMatch);
    Console.WriteLine(outputCmd);
}
