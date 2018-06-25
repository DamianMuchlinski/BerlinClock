using Domain.Enum;

namespace Domain.Model.Clock.Hour
{
    /// <summary>
    ///     Represents 1st row of hour in berlin clock
    /// </summary>
    public class HourRow1
    {
        public RedLightEnum Field1 { get; set; }
        public RedLightEnum Field2 { get; set; }
        public RedLightEnum Field3 { get; set; }
        public RedLightEnum Field4 { get; set; }
    }
}