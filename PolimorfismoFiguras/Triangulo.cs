namespace PolimorfismoFiguras;
public class Triangulo : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseTriangulo, double altura)
    {
        Base = baseTriangulo;
        Altura = altura;
    }
    public override string Nombre
    {
        get { return "Triangulo"; }
        set { }
    }

    public override double Area()
    {
        return 0.5 * Base * Altura;
    }
    public override double Perimetro()
    {
        throw new NotImplementedException();
    }



}
