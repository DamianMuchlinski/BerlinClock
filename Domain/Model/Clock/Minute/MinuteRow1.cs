using Domain.Enum;

namespace Domain.Model.Clock.Minute
{
    /// <summary>
    ///     Represents 1st row of minute in berlin clock
    /// </summary>
    public class MinuteRow1
    {
        public YellowLightEnum Field1 { get; set; }
        public YellowLightEnum Field2 { get; set; }
        public RedLightEnum Field3 { get; set; }

        public YellowLightEnum Field4 { get; set; }
        public YellowLightEnum Field5 { get; set; }
        public RedLightEnum Field6 { get; set; }

        public YellowLightEnum Field7 { get; set; }
        public YellowLightEnum Field8 { get; set; }
        public RedLightEnum Field9 { get; set; }

        public YellowLightEnum Field10 { get; set; }
        public YellowLightEnum Field11 { get; set; }
    }
}