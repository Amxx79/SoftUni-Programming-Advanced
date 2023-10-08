
public static class DateModifierr
    {
        public static int DifferenceInDays(string one, string two)
        {
            DateTime first = DateTime.Parse(one);
            DateTime second = DateTime.Parse(two);

            TimeSpan difference = first - second;
            int differenceString = difference.Days;

            return differenceString;
        }
    }
