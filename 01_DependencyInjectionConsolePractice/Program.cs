using _01_DependencyInjectionConsolePractice;

public class Program
{
    public static void Main()
    {
        // Teacher instance'ı oluştur
        ITeacher teacher = new Teacher("Burak", "Mahim");

        // Teacher'ı ClassRoom'a inject et
        ClassRoom classroom = new ClassRoom(teacher);


        //Boş Constructor ile oluşturup propertyleri sonradan verme alternatifi

        //ITeacher teacher1 = new Teacher
        //{
        //    FirstName = "Ahmet",
        //    LastName = "Yılmaz"
        //};


        Console.Write("Öğretmen: ");

        // Bilgileri yazdır
        Console.WriteLine(classroom.GetTeacherInfo());

        Console.ReadKey();
    }
}