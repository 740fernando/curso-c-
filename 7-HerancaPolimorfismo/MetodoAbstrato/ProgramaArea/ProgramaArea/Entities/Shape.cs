
using ProgramaArea.Entities.Enums;


namespace ProgramaArea.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        abstract public double Area(); //Não é necessário colocar o virtual, o abstract já diz que vai ser implementado em outra classe
    }
}
