using Domain.Logic.Converter.TimeToModel;
using Domain.Logic.Converter.TimeToModel.Header;
using Domain.Logic.Converter.TimeToModel.Hour;
using Domain.Logic.Converter.TimeToModel.Minute;
using Domain.Logic.Converter.TimeToString;
using Domain.Logic.Parser;

namespace Domain.Logic.Factory
{
    /// <summary>
    ///     Responsible for dependend tree  of objects creation
    ///     Note: Should be replaced by IoC Container
    /// </summary>
    public class BerlinClockConverterFactory
    {
        /// <summary>
        ///     Get prepared IToStringConverter interface object
        /// </summary>
        /// <returns></returns>
        public static IToStringConverter GetStringConverter()
        {
            var timeParser = new TimeParser();

            var headerConverter = new HeaderConverter();

            var hourConverter = GetHourConverter();
            var minuteConverter = GetMinuteConverter();

            var modelConverter = new ToModelConverter(timeParser, headerConverter, hourConverter, minuteConverter);
            var obj = new ToStringConverter(modelConverter);

            return obj;
        }

        private static MinuteConverter GetMinuteConverter()
        {
            var minuteRow1Converter = new MinuteRow1Converter();
            var minuteRow2Converter = new MinuteRow2Converter();
            var minuteConverter = new MinuteConverter(minuteRow1Converter, minuteRow2Converter);
            return minuteConverter;
        }

        private static HourConverter GetHourConverter()
        {
            var hourRow1Converter = new HourRow1Converter();
            var hourRow2Converter = new HourRow2Converter();
            var hourConverter = new HourConverter(hourRow1Converter, hourRow2Converter);
            return hourConverter;
        }
    }
}