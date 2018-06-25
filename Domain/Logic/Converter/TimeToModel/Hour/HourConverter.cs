using Domain.Model.Clock.Hour;

namespace Domain.Logic.Converter.TimeToModel.Hour
{
    public class HourConverter : IHourConverter
    {
        private readonly IHourRow1Converter _hourRow1Converter;
        private readonly IHourRow2Converter _hourRow2Converter;

        public HourConverter(IHourRow1Converter hourRow1Converter, IHourRow2Converter hourRow2Converter)
        {
            _hourRow1Converter = hourRow1Converter;
            _hourRow2Converter = hourRow2Converter;
        }

        public HourRows Convert(int hour)
        {
            var hourRow1 = _hourRow1Converter.Convert(hour);
            var hourRow2 = _hourRow2Converter.Convert(hour);

            var hourRows = new HourRows {HourRow1 = hourRow1, HourRow2 = hourRow2};

            return hourRows;
        }
    }
}