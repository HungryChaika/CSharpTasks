using Task_2;

namespace Task_2.Test
{
    public class YearIsLeap
    {
        CheckingLeapYear? checkingLeapYear;

        [Test]
        [TestCase(1804)] // div into 4
        [TestCase(2400)] // div into 4 and 100 and 400 
        public void LeapYearIsTrue(int Year)
        {
            checkingLeapYear = new CheckingLeapYear();
            var result = checkingLeapYear.AnalyzeYear(Year);
            Assert.That(result, Is.EqualTo("Високосный"));
        }

        [Test]
        [TestCase(1951)] // divn't into 4
        [TestCase(2500)] // div into 4 and 100, but divn't into 400
        public void LeapYearIsFalse(int Year)
        {
            checkingLeapYear = new CheckingLeapYear();
            var result = checkingLeapYear.AnalyzeYear(Year);
            Assert.That(result, Is.EqualTo("Не високосный"));
        }
    }
}