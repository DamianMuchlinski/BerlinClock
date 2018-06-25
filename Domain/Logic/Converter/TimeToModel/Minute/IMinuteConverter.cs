using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel.Minute
{
    /// <summary>
    /// Converter to Berlin Model Minutes Rows
    /// </summary>
    public interface IMinuteConverter
    {
        /// <summary>
        /// Convert minute to MinuteRows Model
        /// </summary>
        /// <param name="minute"></param>
        /// <returns></returns>
        MinuteRows Convert(int minute);
    }
}