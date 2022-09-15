namespace SummaryS2
{
    public class Person
    {
        private static string _name { get; set; }
        private DateTime _birthDate { get; set; }
        private int _deathAge { get; set; }

        public Person(DateTime BirthDate, int DeathAge)
        {
            _birthDate = BirthDate;
            _deathAge = DeathAge;
        }

        public int Age()
        {
            var timeSpan = DateTime.Today - _birthDate;
            var years = timeSpan.Days / 365;

            return years;
        }

        public int TilDeath()
        {
            // Calculate date from estimated death to now
            var deathDate = _birthDate.AddYears(_deathAge);
            var weeksLeft = deathDate - DateTime.Today;
            var weeks = weeksLeft.Days / 7;
            
            return weeks;
        }

    }
}