using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFiguras;
public class Circulo : Forma
{
    public double Radio { get; set; }
    public override string Nombre
    {
        get { return "Radio"; }
        set { }
    }
    public Circulo(double radio) => Radio = radio;

    public override double Area() => Math.PI * Radio * Radio;

    public override double Perimetro() => 2 * Math.PI * Radio;

}
