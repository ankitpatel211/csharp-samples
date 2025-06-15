// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string todayDate = DateTime.Now.ToString("MM/dd/yyyy");
string currentTime = DateTime.Now.ToString("hh:mm tt");
string input = "Today is " + todayDate + " and current time is " + currentTime + ".";
string regExp = "((((0?[1-9])|(1[0-2])):([0-5][0-9]))\\s?(am|AM|pm|PM))";
Regex regex = new(regExp);
var match = regex.Match(input);
if (match.Success) {
    Console.WriteLine(input);
    var replaceText = match.Value[0].ToString() + ""
                      + match.Value[1].ToString() + " hours and " 
                      + match.Value[3].ToString() + ""
                      + match.Value[4].ToString() + " minutes";
    var newInput = input.Replace(match.Value, replaceText);
    Console.WriteLine(newInput);
}