

namespace princpipio_de_abierot_y_cerrado__OCP_
{
    public class HybridCourse : Course
    {
        public override void Subscribe(Cliente std)
        {
            // código para suscribirse a un curso híbrido
            Console.WriteLine($"{std.Name} se ha suscrito al curso híbrido: {Title}");
        }

        
    }
}
