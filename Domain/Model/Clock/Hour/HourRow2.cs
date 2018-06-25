using Domain.Enum;

namespace Domain.Model.Clock.Hour
{
    /// <summary>
    ///     Represents 2nd row of hour in berlin clock
    /// </summary>
    public class HourRow2
    {
        public RedLightEnum Field1 { get; set; }
        public RedLightEnum Field2 { get; set; }
        public RedLightEnum Field3 { get; set; }
        public RedLightEnum Field4 { get; set; }
    }
}