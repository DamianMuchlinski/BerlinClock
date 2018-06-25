using Domain.Logic.Converter.TimeToModel;
using Domain.Logic.Extensions;

namespace Domain.Logic.Converter.TimeToString
{
    public class ToStringConverter : IToStringConverter
    {
        private readonly IToModelConverter _toModelConverter;

        public ToStringConverter(IToModelConverter toModelConverter)
        {
            _toModelConverter = toModelConverter;
        }

        public string ToBerlinClock(string time)
        {
            var berlinModel = _toModelConverter.ToBerlinClock(time);
            var berlinClock = berlinModel.BerlinClockToString();

            return berlinClock;
        }
    }
}