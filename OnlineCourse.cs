
namespace princpipio_de_abierot_y_cerrado__OCP_
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Cliente std)
        {
            // código para suscribirse a un curso online
            Console.WriteLine($"{std.Name} se ha suscrito al curso online: {Title}");
        }
    }
}
