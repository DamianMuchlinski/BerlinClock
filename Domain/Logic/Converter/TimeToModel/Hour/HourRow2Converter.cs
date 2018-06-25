using Domain.Enum;
using Domain.Model.Clock.Hour;

namespace Domain.Logic.Converter.TimeToModel.Hour
{
    public class HourRow2Converter : IHourRow2Converter
    {
        private const int HoursDivider = 5;

        public HourRow2 Convert(int hour)
        {
            var hourRestOfDiv = hour % HoursDivider;

            var field1Lighted = hourRestOfDiv > 0;
            var field2Lighted = hourRestOfDiv > 1;
            var field3Lighted = hourRestOfDiv > 2;
            var field4Lighted = hourRestOfDiv > 3;

            var secondRow = new HourRow2
            {
                Field1 = field1Lighted ? RedLightEnum.Active : RedLightEnum.InActive,
                Field2 = field2Lighted ? RedLightEnum.Active : RedLightEnum.InActive,
                Field3 = field3Lighted ? RedLightEnum.Active : RedLightEnum.InActive,
                Field4 = field4Lighted ? RedLightEnum.Active : RedLightEnum.InActive
            };

            return secondRow;
        }
    }
}