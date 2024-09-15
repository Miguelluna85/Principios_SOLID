namespace PolimorfismoFiguras.LISKOV;
public abstract class Ave
{
    public abstract void Comer();

    public void Dormir()
    {
        Console.WriteLine("El Ave duerme");
    }
}
