namespace SOLID._2_L.Problem;
internal class Car : Vehicle
{
    public override void Color()
    {
        //Implement
    }
    public override void Park()
    {
        //Implement
    }
    public override void Brake()
    {
        //Implement
    }
    public override void SpeedUp()
    {
        //Implement
    }
    public override void Land()//no tiene esta accion car
    {
        throw new NotImplementedException();
    }
    public override void TakeOff()//no tiene esta accion car
    {
        throw new NotImplementedException();
    }
}
