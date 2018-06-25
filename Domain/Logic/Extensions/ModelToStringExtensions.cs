using Domain.Model.Clock;
using Domain.Model.Clock.Header;
using Domain.Model.Clock.Hour;
using Domain.Model.Clock.Minute;

namespace Domain.Logic.Extensions
{
    /// <summary>
    ///     Extension resposible for making string representation of berlin clock model
    ///     More natural way than another converter....
    /// </summary>
    public static class ModelToStringExtensions
    {
        private const string NewLineWithoutCarriageReturn = "\n";

        public static string HeaderToString(this HeaderRow value)
        {
            return ((char) value.RoundBlinker).ToString();
        }

        public static string Hour1RowToString(this HourRow1 value)
        {
            var output = (char) value.Field1 + ((char) value.Field2).ToString()
                                             + (char) value.Field3 + (char) value.Field4;

            return output;
        }

        public static string Hour2RowToString(this HourRow2 value)
        {
            var output = (char) value.Field1 + ((char) value.Field2).ToString()
                                             + (char) value.Field3 + (char) value.Field4;

            return output;
        }

        public static string MinuteRow1ToString(this MinuteRow1 value)
        {
            var output = (char) value.Field1 + ((char) value.Field2).ToString()
                                             + (char) value.Field3 + (char) value.Field4
                                             + (char) value.Field5 + (char) value.Field6
                                             + (char) value.Field7 + (char) value.Field8
                                             + (char) value.Field9 + (char) value.Field10
                                             + (char) value.Field11;

            return output;
        }

        public static string MinuteRow2ToString(this MinuteRow2 value)
        {
            var output = (char) value.Field1 + ((char) value.Field2).ToString()
                                             + (char) value.Field3 + (char) value.Field4;

            return output;
        }

        public static string BerlinClockToString(this BerlinClock value)
        {
            var header = HeaderConverter(value.Header);

            var hours = HourConverter(value.HourRows);

            var minutes = MinuteConverter(value.MinuteRows);

            var output = header + NewLineWithoutCarriageReturn +
                         hours + NewLineWithoutCarriageReturn +
                         minutes;

            return output;
        }

        private static string HeaderConverter(HeaderRow headerRow)
        {
            var header = headerRow.HeaderToString();
            return header;
        }

        private static string HourConverter(HourRows hourRows)
        {
            var hour1RowString = hourRows.HourRow1.Hour1RowToString();

            var hour2RowString = hourRows.HourRow2.Hour2RowToString();

            var hourString = hour1RowString + NewLineWithoutCarriageReturn + hour2RowString;

            return hourString;
        }

        private static string MinuteConverter(MinuteRows minuteRows)
        {
            var minute1RowString = minuteRows.MinuteRow1.MinuteRow1ToString();

            var minute2RowString = minuteRows.MinuteRow2.MinuteRow2ToString();

            var minuteString = minute1RowString + NewLineWithoutCarriageReturn + minute2RowString;

            return minuteString;
        }
    }
}