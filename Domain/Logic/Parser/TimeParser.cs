using System;
using Domain.Model;

namespace Domain.Logic.Parser
{
    public class TimeParser : ITimeParser
    {
        private const char Separator = ':';

        public CustomTime TimeFromString(string time)
        {
            var timeArray = Split(time);
            var cTime = Parse(timeArray);
            Validate(cTime);

            return cTime;
        }

        #region Parser implementation details

        private string[] Split(string time)
        {
            var timeArray = time.Split(Separator);

            return timeArray;
        }

        private CustomTime Parse(string[] timeArray)
        {
            try
            {
                var hour = int.Parse(timeArray[0]);
                var minute = int.Parse(timeArray[1]);
                var second = int.Parse(timeArray[2]);

                var time = new CustomTime {Hour = hour, Minute = minute, Second = second};
                return time;
            }
            catch (Exception)
            {
                throw new ArgumentException("Supplied string datetime parametert does not meet expected value");
            }
        }

        private void Validate(CustomTime time)
        {
            ValidateHour(time.Hour);
            ValidateMin(time.Minute);
            ValidateSec(time.Second);
            ValidateTogether(time);
        }

        private void ValidateHour(int hour)
        {
            if (hour < 0 || hour > 24)
                throw new ArgumentException("Supplied hour part does not meet expected value");
        }

        private void ValidateMin(int minute)
        {
            if (minute < 0 || minute > 59)
                throw new ArgumentException("Supplied minute part does not meet expected value");
        }
        private void ValidateSec(int second)
        {
            if (second < 0 || second > 59)
                throw new ArgumentException("Supplied second part does not meet expected value");
        }

        private void ValidateTogether(CustomTime time)
        {
            if (time.Hour==24 && (time.Minute>0 || time.Second>0))
            {
                throw new ArgumentException("Supplied time part does not meet expected value (Time after 24:00:00)");
            }
        }

        #endregion
    }
}