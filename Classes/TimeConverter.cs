using Domain.Logic.Converter.TimeToString;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        private readonly IToStringConverter _converter;

        public TimeConverter(IToStringConverter converter)
        {
            _converter = converter;
        }

        public string ConvertTime(string aTime)
        {
            return _converter.ToBerlinClock(aTime);
        }
    }
}