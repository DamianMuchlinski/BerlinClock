using Domain.Enum;
using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel.Minute
{
    public class MinuteRow2Converter : IMinuteRow2Converter
    {
        private const int MinutesDivider = 5;

        public MinuteRow2 Convert(int minute)
        {
            var minutesRestOfDiv = minute % MinutesDivider;

            var field1Lighted = minutesRestOfDiv > 0;
            var field2Lighted = minutesRestOfDiv > 1;
            var field3Lighted = minutesRestOfDiv > 2;
            var field4Lighted = minutesRestOfDiv > 3;

            var secondRow = new MinuteRow2
            {
                Field1 = field1Lighted ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field2 = field2Lighted ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field3 = field3Lighted ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field4 = field4Lighted ? YellowLightEnum.Active : YellowLightEnum.InActive
            };

            return secondRow;
        }
    }
}