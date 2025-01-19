namespace _01_DependencyInjectionConsolePractice
{
    // Teacher sınıfı interface'i implement ediyor
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
