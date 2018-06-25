using Domain.Model;

namespace Domain.Logic.Parser
{
    /// <summary>
    ///     Parser for datetime
    /// </summary>
    public interface ITimeParser
    {
        /// <summary>
        ///     Parse string representation of datetime to CustomTime
        /// </summary>
        CustomTime TimeFromString(string time);
    }
}