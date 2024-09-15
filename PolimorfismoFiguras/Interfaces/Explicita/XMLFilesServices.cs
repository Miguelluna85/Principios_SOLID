namespace PolimorfismoFiguras.Interfaces.Explicita;
public class XMLFilesServices : IFiles
{
    bool IFiles.Delete(string name)
    {
        return true;
    }

    bool IFiles.Save(string name)
    {
        return true;
    }

    string IFiles.Tipo(string name)
    {
        return "XML_SAT";
    }

    bool IFiles.Update(string name)
    {
       return false;
    }
}
