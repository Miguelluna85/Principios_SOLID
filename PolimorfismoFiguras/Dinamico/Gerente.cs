namespace PolimorfismoFiguras.Dinamico;
public class SubGerente : Empleado
{
    public override string Descripcion
    {
        get { return "Subgerente"; }
    }

    public override string Antiguedad()
    {
        throw new NotImplementedException();
    }

    public override string Puesto()
    {
        throw new NotImplementedException();
    }

    public override void Format()
    {
        base.Format();
    }

    public void Region() { }
    
}
