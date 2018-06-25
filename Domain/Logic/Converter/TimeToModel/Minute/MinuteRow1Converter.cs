using Domain.Enum;
using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel.Minute
{
    public class MinuteRow1Converter : IMinuteRow1Converter
    {
        private const int MinutesDivider = 5;

        public MinuteRow1 Convert(int minute)
        {
            var minutesDivided = minute / MinutesDivider;

            var m5Passed = minutesDivided > 0;
            var m10Passed = minutesDivided > 1;
            var m15Passed = minutesDivided > 2;
            var m20Passed = minutesDivided > 3;
            var m25Passed = minutesDivided > 4;
            var m30Passed = minutesDivided > 5;
            var m35Passed = minutesDivided > 6;
            var m40Passed = minutesDivided > 7;
            var m45Passed = minutesDivided > 8;
            var m50Passed = minutesDivided > 9;
            var m55Passed = minutesDivided > 10;

            var firstRow = new MinuteRow1
            {
                Field1 = m5Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field2 = m10Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field3 = m15Passed ? RedLightEnum.Active : RedLightEnum.InActive,

                Field4 = m20Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field5 = m25Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field6 = m30Passed ? RedLightEnum.Active : RedLightEnum.InActive,

                Field7 = m35Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field8 = m40Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field9 = m45Passed ? RedLightEnum.Active : RedLightEnum.InActive,

                Field10 = m50Passed ? YellowLightEnum.Active : YellowLightEnum.InActive,
                Field11 = m55Passed ? YellowLightEnum.Active : YellowLightEnum.InActive
            };

            return firstRow;
        }
    }
}