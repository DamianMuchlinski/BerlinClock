using Domain.Enum;
using Domain.Model.Clock.Header;

namespace Domain.Logic.Converter.TimeToModel.Header
{
    public class HeaderConverter : IHeaderConverter
    {
        private const int OddNumberDivider = 2;

        public HeaderRow Convert(int second)
        {
            var secondIsEven = second % OddNumberDivider == 0;

            var hours = new HeaderRow {RoundBlinker = secondIsEven ? YellowLightEnum.Active : YellowLightEnum.InActive};

            return hours;
        }
    }
}