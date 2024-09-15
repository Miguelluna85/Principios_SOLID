using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFiguras.Interfaces.Implicita;
public interface IEmail
{
    string Send(string remitente, string destinatario, string body);
    string Aviso(string aviso);
}
