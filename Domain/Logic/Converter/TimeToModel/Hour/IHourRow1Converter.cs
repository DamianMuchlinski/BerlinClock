using Domain.Model.Clock.Hour;

namespace Domain.Logic.Converter.TimeToModel.Hour
{
    public interface IHourRow1Converter
    {
        HourRow1 Convert(int hour);
    }
}