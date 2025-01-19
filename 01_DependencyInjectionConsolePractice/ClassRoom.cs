namespace _01_DependencyInjectionConsolePractice
{

    // Classroom sınıfı Teacher'a bağımlı

    public class ClassRoom
    {
        private readonly ITeacher _teacher;


        // Constructor Injection
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }

    }
}
