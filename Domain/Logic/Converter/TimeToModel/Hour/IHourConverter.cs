using Domain.Model.Clock.Hour;

namespace Domain.Logic.Converter.TimeToModel.Hour
{
    /// <summary>
    /// Converter to Berlin Model Hour Rows
    /// </summary>
    public interface IHourConverter
    {
        /// <summary>
        /// Convert hour to HoureRows Model
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        HourRows Convert(int hour);
    }
}