using Domain.Model.Clock.Header;

namespace Domain.Logic.Converter.TimeToModel.Header
{
    /// <summary>
    /// Converter to Berlin Model Header
    /// </summary>
    public interface IHeaderConverter
    {
        /// <summary>
        /// Convert sec to Header Row
        /// </summary>
        /// <param name="second"></param>
        /// <returns></returns>
        HeaderRow Convert(int second);
    }
}