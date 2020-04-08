using MetodosAbstratoAula135.Entities.Enums;

namespace MetodosAbstratoAula135.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        // metodo abstrato:
        public abstract double Area(); //obs: A classe tbm precisa ser abstract



    }
}
