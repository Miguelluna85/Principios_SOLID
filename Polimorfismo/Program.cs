using PolimorfismoFiguras.Dinamico;
using PolimorfismoFiguras.Estatico;
using PolimorfismoFiguras.Interfaces;
using PolimorfismoFiguras.Interfaces.Explicita;
using PolimorfismoFiguras.Interfaces.Implicita;
using PolimorfismoFiguras.LISKOV;

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

////Interfaces Implicitas
//Empleado gerente = new SubGerente();
//Console.WriteLine(gerente.Descripcion);

//EmailGoogleService emailGoogle = new EmailGoogleService();
//Console.WriteLine(emailGoogle.Send("", "", "Test"));
//Console.WriteLine(emailGoogle.Aviso("Send..."));
////Console.WriteLine();

////Interfaces Explicitas
//// Metodos se acceden atravez de la Interface y no atraves de la instancia de la clase
//PDFFilesServices PDFService = new PDFFilesServices("SAT.PDF");
//IFiles IPDF = PDFService;
//Console.WriteLine(IPDF.Save("SAT.PDF"));
//Console.WriteLine(IPDF.Tipo("SAT.PDF"));
//Console.WriteLine(IPDF.Update("SAT.PDF"));

//XMLFilesServices XMLService = new XMLFilesServices();
//IFiles IXML = XMLService;
//Console.WriteLine(IXML.Save("SAT.XML"));
//Console.WriteLine(IXML.Tipo("SAT.XML"));
//Console.WriteLine(IXML.Update("SAT.XML"));


// esta es la magia de Liskov
static void ProcesarAve(Ave ave)
{
    ave.Comer();
    ave.Dormir();

}

Perico perico = new Perico();
Gorrion gorrion = new Gorrion();

ProcesarAve(perico);
ProcesarAve(gorrion);


Console.WriteLine();



