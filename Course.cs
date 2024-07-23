

namespace princpipio_de_abierot_y_cerrado__OCP_
{
    public abstract class Course
    {

        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Cliente std);
       
    }
}
