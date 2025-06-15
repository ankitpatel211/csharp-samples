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
    string hours = match.Value[zerothIndex].ToString() + "" + match.Value[firstIndex].ToString();
    string minutes = match.Value[thirdIndex].ToString() + "" + match.Value[fourthIndex].ToString();
    string amPm = currentTime[(length - 1) - 1].ToString() + currentTime[length - 1].ToString();
    var replaceText = hours + " hours and " + minutes + " minutes";
    if (Convert.ToInt16(hours) >= 07 && Convert.ToInt16(hours) < 12 && amPm == "AM") {
        replaceText += " in the morning";
    } else if (((Convert.ToInt16(hours) >= 00 && Convert.ToInt16(hours) <= 03) || Convert.ToInt16(hours) == 12) && amPm == "PM") {
        replaceText += " in the afternoon";
    } else if (Convert.ToInt16(hours) >= 03 && Convert.ToInt16(hours) <= 07 && amPm == "PM") {
        replaceText += " in the evening";
    } else if (Convert.ToInt16(hours) >= 07 && Convert.ToInt16(hours) < 12 && amPm == "PM") {
        replaceText += " in the night";
    } else if (((Convert.ToInt16(hours) >= 00 && Convert.ToInt16(hours) <= 07) || Convert.ToInt16(hours) == 12) && amPm == "AM") { 
        replaceText += " in the midnight";
    }
    var newInput = input.Replace(match.Value, replaceText);
    Console.WriteLine(newInput);
}