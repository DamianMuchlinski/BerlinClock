using Domain.Model.Clock.Hour;

namespace Domain.Logic.Converter.TimeToModel.Hour
{
    public interface IHourRow2Converter
    {
        HourRow2 Convert(int hour);
    }
}