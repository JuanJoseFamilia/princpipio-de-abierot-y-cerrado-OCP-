using princpipio_de_abierot_y_cerrado__OCP_;

public class Program
{
    public static void Main()
    {
        Cliente cliente = new Cliente() { ClienteId = 1, Name = "John Doe" };

        Course onlineCourse = new OnlineCourse() { CourseId = 101, Title = "C# Programming" };
        onlineCourse.Subscribe(cliente);

        Course offlineCourse = new OfflineCourse() { CourseId = 102, Title = "Data Structures" };
        offlineCourse.Subscribe(cliente);

        Course hybridCourse = new HybridCourse() { CourseId = 103, Title = "Advanced Programming" };
        hybridCourse.Subscribe(cliente);
    }
}
