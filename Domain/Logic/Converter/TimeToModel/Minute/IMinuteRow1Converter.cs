using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel.Minute
{
    public interface IMinuteRow1Converter
    {
        MinuteRow1 Convert(int minute);
    }
}