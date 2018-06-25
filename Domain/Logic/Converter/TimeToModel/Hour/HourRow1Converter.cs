using Domain.Enum;
using Domain.Model.Clock.Hour;

namespace Domain.Logic.Converter.TimeToModel.Hour
{
    public class HourRow1Converter : IHourRow1Converter
    {
        private const int HoursDivider = 5;

        public HourRow1 Convert(int hour)
        {
            var hourDivided = hour / HoursDivider;

            var h5Passed = hourDivided > 0;
            var h10Passed = hourDivided > 1;
            var h15Passed = hourDivided > 2;
            var h20Passed = hourDivided > 3;

            var firstRow = new HourRow1
            {
                Field1 = h5Passed ? RedLightEnum.Active : RedLightEnum.InActive,
                Field2 = h10Passed ? RedLightEnum.Active : RedLightEnum.InActive,
                Field3 = h15Passed ? RedLightEnum.Active : RedLightEnum.InActive,
                Field4 = h20Passed ? RedLightEnum.Active : RedLightEnum.InActive
            };

            return firstRow;
        }
    }
}