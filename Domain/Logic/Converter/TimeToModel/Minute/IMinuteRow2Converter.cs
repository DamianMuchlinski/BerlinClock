using Domain.Model.Clock.Minute;

namespace Domain.Logic.Converter.TimeToModel.Minute
{
    public interface IMinuteRow2Converter
    {
        MinuteRow2 Convert(int minute);
    }
}