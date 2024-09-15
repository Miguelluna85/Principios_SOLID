namespace PolimorfismoFiguras.LISKOV;
public class Perico : Ave
{
    public override void Comer()
    {
        Console.WriteLine("El Perico hoy muere");
    }
}
