using Domain.Enum;

namespace Domain.Model.Clock.Header
{
    /// <summary>
    ///     Represents header of berlin clock
    /// </summary>
    public class HeaderRow
    {
        public YellowLightEnum RoundBlinker { get; set; }
    }
}