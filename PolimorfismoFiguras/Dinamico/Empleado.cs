namespace PolimorfismoFiguras.Dinamico;
public abstract class Empleado
{
    public virtual string Descripcion
    {
        get { return "Empleado"; }
    }

    public abstract string Puesto();

    public abstract string Antiguedad();

    public virtual void Format()
    {

    }
}
