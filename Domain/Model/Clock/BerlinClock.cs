using Domain.Model.Clock.Header;
using Domain.Model.Clock.Hour;
using Domain.Model.Clock.Minute;

namespace Domain.Model.Clock
{
    /// <summary>
    ///     Represents berlin clock
    /// </summary>
    public class BerlinClock
    {
        public HeaderRow Header { get; set; }
        public HourRows HourRows { get; set; }
        public MinuteRows MinuteRows { get; set; }
    }
}