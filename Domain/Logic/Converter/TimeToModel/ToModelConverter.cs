using Domain.Logic.Converter.TimeToModel.Header;
using Domain.Logic.Converter.TimeToModel.Hour;
using Domain.Logic.Converter.TimeToModel.Minute;
using Domain.Logic.Parser;
using Domain.Model;
using Domain.Model.Clock;
using Domain.Model.Clock.Header;
using Domain.Model.Clock.Hour;
using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel
{
    public class ToModelConverter : IToModelConverter
    {
        private readonly IHeaderConverter _headerConverter;
        private readonly IHourConverter _hourConverter;
        private readonly IMinuteConverter _minuteConverter;
        private readonly ITimeParser _timeParser;

        public ToModelConverter(ITimeParser timeParser, IHeaderConverter headerConverter,
            IHourConverter hourConverter, IMinuteConverter minuteConverter)
        {
            _timeParser = timeParser;
            _headerConverter = headerConverter;
            _hourConverter = hourConverter;
            _minuteConverter = minuteConverter;
        }

        public BerlinClock ToBerlinClock(string time)
        {
            var customTime = _timeParser.TimeFromString(time);
            var berlinClock = ToBerlinClock(customTime);

            return berlinClock;
        }

        private BerlinClock ToBerlinClock(CustomTime time)
        {
            var header = HeaderConverter(time.Second);
            var hour = HourConverter(time.Hour);
            var minute = MinuteConverter(time.Minute);

            var berlinModel = new BerlinClock {Header = header, HourRows = hour, MinuteRows = minute};

            return berlinModel;
        }

        #region Converters

        private HeaderRow HeaderConverter(int second)
        {
            var headerRow = _headerConverter.Convert(second);

            return headerRow;
        }

        private HourRows HourConverter(int hour)
        {
            var hourRows = _hourConverter.Convert(hour);

            return hourRows;
        }

        private MinuteRows MinuteConverter(int minute)
        {
            var minuteRows = _minuteConverter.Convert(minute);

            return minuteRows;
        }

        #endregion Converters
    }
}