using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel.Minute
{
    public class MinuteConverter : IMinuteConverter
    {
        private readonly IMinuteRow1Converter _minuteRow1Converter;
        private readonly IMinuteRow2Converter _minuteRow2Converter;

        public MinuteConverter(IMinuteRow1Converter minuteRow1Converter, IMinuteRow2Converter minuteRow2Converter)
        {
            _minuteRow1Converter = minuteRow1Converter;
            _minuteRow2Converter = minuteRow2Converter;
        }

        public MinuteRows Convert(int minute)
        {
            var minuteRow1 = _minuteRow1Converter.Convert(minute);
            var minuteRow2 = _minuteRow2Converter.Convert(minute);

            var minutesRows = new MinuteRows {MinuteRow1 = minuteRow1, MinuteRow2 = minuteRow2};

            return minutesRows;
        }
    }
}