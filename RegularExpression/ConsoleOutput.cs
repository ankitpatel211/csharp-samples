namespace RegularExpression
{
    public static class ConsoleOutput {
        public const string inputText = "Input= ";
        public const string outputText = "Output= ";
    }
    public static class TwelveHoursTimeRegEx {
        public const string expression = "(((0?[1-9]|1[0-2]):([0-5][0-9]))\\s?(am|AM|pm|PM))";
    }
    public static class DateTimeFormat {
        public const string date = "MM/dd/yyyy";
        public const string time = "hh:mm tt";
    }
    public static class TwelveHoursFormat {
        public const string am = "AM";
        public const string pm = "PM";
    }
    public static class ExceptionOutput {
        public const string falseMatch = "There is no search text matching successfully according to a regular expression.";
        public const string nonInteger = "Invalid input! cannot convert to integer.";
        public const string overflowInteger = "Value is too large for a conversion of an integer.";
    }
    public static class Split {
        public const string space = " ";
        public const string colon = ":";
    }
    public static class DayParts {
        public const string morning = "in the morning";
        public const string afternoon = "in the afternoon";
        public const string evening = "in the evening";
        public const string night = "in the night";
        public const string midNight = "in the midnight";
    }
    public static class HourMinute {
        public const string hours = "hours";
        public const string hour = "hour";
        public const string and = "and";
        public const string minutes = "minutes";
        public const string minute = "minute";
    }
}
