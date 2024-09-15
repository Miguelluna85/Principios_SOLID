namespace PolimorfismoFiguras.Interfaces.Implicita;
public class EmailGoogleService : IEmail
{
    public string Aviso(string aviso)
    {
        return aviso;
    }

    public string Send(string remitente, string destinatario, string body)
    {
        return "Sent";
    }
}
