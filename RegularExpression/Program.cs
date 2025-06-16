// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string todayDate = DateTime.Now.ToString("MM/dd/yyyy");
string currentTime = DateTime.Now.ToString("hh:mm tt").Trim();
string input = "Today is " + todayDate + " and current time is " + currentTime + ".";
string regExp = "(((00|0?[1-9]|1[0-2]):([0-5][0-9]))\\s?(am|AM|pm|PM))";
Regex regex = new(regExp);
var match = regex.Match(input);
if (match.Success) {
    Console.WriteLine(input);
    int length = currentTime.Length;
    int zerothIndex = length - length;
    int firstIndex = length - (length - 1);
    int thirdIndex = length - ((length - 1) - 1) + 1;
    int fourthIndex = length - (((length - 1) - 1) - 1) + 1;
    string hourText = match.Value[zerothIndex].ToString() + match.Value[firstIndex].ToString();
    string minuteText = match.Value[thirdIndex].ToString() + match.Value[fourthIndex].ToString();
    string amPm = currentTime[(length - 1) - 1].ToString() + currentTime[length - 1].ToString();
    var hour = Convert.ToInt16(hourText);
    var minute = Convert.ToInt16(minuteText);
    var replaceText = hourText + (hour >= 2 && hour <= 12 ? " hours" : " hour") 
                    + " and " + minuteText + (minute >= 2 && minute <= 59 ? " minutes" : " minute") + "";
    if ((hour >= 07 && hour < 12) && amPm == "AM") {
        replaceText += " in the morning";
    } else if (((hour >= 00 && hour <= 03) || hour == 12) && amPm == "PM") {
        replaceText += " in the afternoon";
    } else if ((hour >= 03 && hour <= 07) && amPm == "PM") {
        replaceText += " in the evening";
    } else if ((hour >= 07 && hour < 12) && amPm == "PM") {
        replaceText += " in the night";
    } else if (((hour >= 00 && hour <= 07) || hour == 12) && amPm == "AM") { 
        replaceText += " in the midnight";
    }
    var newInput = input.Replace(match.Value, replaceText);
    Console.WriteLine(newInput);
}