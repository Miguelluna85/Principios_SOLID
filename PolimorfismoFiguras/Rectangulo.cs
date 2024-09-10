namespace PolimorfismoFiguras;
public class Rectangulo : Forma
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }
    public override string Nombre
    {
        get { return "Rectangulo"; }
        set { }
    }
    public override double Area() => Ancho * Alto;

    public override double Perimetro() => 2 * (Ancho + Alto);

}
