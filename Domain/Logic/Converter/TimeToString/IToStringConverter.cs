namespace Domain.Logic.Converter.TimeToString
{
    /// <summary>
    ///     Converts string datetime format to string representation of berlin clock
    /// </summary>
    public interface IToStringConverter
    {
        /// <summary>
        ///     Converts string datetime format to string representation of berlin clock
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        string ToBerlinClock(string time);
    }
}