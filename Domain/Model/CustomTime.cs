namespace Domain.Model
{
    /// <summary>
    ///     Represents custom time - (DateTime does not accept 24:00:00)
    /// </summary>
    public class CustomTime
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }
}