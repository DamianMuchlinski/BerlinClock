using System.Reflection;
using BerlinClock.Classes;
using Domain.Logic.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Infrastructure;

namespace BerlinClock.BDD
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private readonly ITimeConverter _timeConverter;
        private string _theTime;

        public TheBerlinClockSteps()
        {
            var toStringConverter = BerlinClockConverterFactory.GetStringConverter();
            _timeConverter = new TimeConverter(toStringConverter);
        }


        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            var actualBerlinClockTime = _timeConverter.ConvertTime(_theTime);

            Assert.AreEqual(actualBerlinClockTime, theExpectedBerlinClockOutput);
        }

    }
}