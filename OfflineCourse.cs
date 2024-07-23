

namespace princpipio_de_abierot_y_cerrado__OCP_
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Cliente std)
        {
            // código para suscribirse a un curso offline
            Console.WriteLine($"{std.Name} se ha suscrito al curso offline: {Title}");
        }
    }
}
