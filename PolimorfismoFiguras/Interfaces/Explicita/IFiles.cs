namespace PolimorfismoFiguras.Interfaces.Explicita;
public interface IFiles
{
    bool Save(string name);
    bool Delete(string name);
    bool Update(string name);
    string Tipo(string name);
}
