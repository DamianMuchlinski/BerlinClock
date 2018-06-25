using Domain.Enum;

namespace Domain.Model.Clock.Minute
{
    /// <summary>
    ///     Represents 2nd row of minute in berlin clock
    /// </summary>
    public class MinuteRow2
    {
        public YellowLightEnum Field1 { get; set; }
        public YellowLightEnum Field2 { get; set; }
        public YellowLightEnum Field3 { get; set; }
        public YellowLightEnum Field4 { get; set; }
    }
}