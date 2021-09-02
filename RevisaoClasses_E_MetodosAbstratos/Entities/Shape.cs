using RevisaoClasses_E_MetodosAbstratos.Entities.Enums;

namespace RevisaoClasses_E_MetodosAbstratos.Entities
{
    abstract class Shape //Classe abstrata
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //Método Abstrato
    }
}
