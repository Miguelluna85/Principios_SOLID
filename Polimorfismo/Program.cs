using PolimorfismoFiguras.Dinamico;
using PolimorfismoFiguras.Estatico;

//Forma[] formas = new Forma[3];
//formas[0] = new Circulo(5);
//formas[1] = new Rectangulo(5, 6);
//formas[2] = new Triangulo(3, 4);

//foreach (Forma forma in formas)
//{
//    Console.WriteLine(forma.Nombre);
//    Console.WriteLine($"Área: {forma.Area()}");
//    try
//    {
//        Console.WriteLine($"Perímetro: {forma.Perimetro()}");
//    }
//    catch (NotImplementedException)
//    {
//        Console.WriteLine("Perímetro no disponible para esta forma.");
//    }
//    Console.WriteLine();
//}


//Calculadora_PoliEstatic calculadora = new Calculadora_PoliEstatic();
//int resultEntero = calculadora.Suma(3, 4);
//double resultDouble = calculadora.Suma(3.5, 4.2);

//Console.WriteLine($"Resultado entero: {resultEntero}");
//Console.WriteLine($"Resultado double: {resultDouble}");

//Console.WriteLine();

//Vector vector1 = new Vector(1,2);
//Vector vector2 = new Vector(3,4);

//Vector suma = vector1+ vector2;

//Console.WriteLine($"Suma de vectores: ({suma.X}, {suma.Y})");

//Console.WriteLine();

//Animal animal1 = new Animal();
//animal1.HacerSonido();

//Animal perro1 = new Perro();
//perro1.HacerSonido();

//Console.WriteLine();

Empleado empleado = new Empleado();
Empleado gerente = new SubGerente();

Console.WriteLine(empleado.Descripcion);
Console.WriteLine(gerente.Descripcion);


