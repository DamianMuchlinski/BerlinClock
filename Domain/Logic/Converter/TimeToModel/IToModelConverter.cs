using Domain.Model.Clock;

namespace Domain.Logic.Converter.TimeToModel
{
    /// <summary>
    ///     Converts string datetime format to model representing berlin clock
    /// </summary>
    public interface IToModelConverter
    {
        /// <summary>
        ///     Converts string datetime format to model representing berlin clock
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        BerlinClock ToBerlinClock(string time);
    }
}