namespace PolimorfismoFiguras.Interfaces.Explicita;
public class PDFFilesServices : IFiles
{
    private readonly string nameFile;
    public PDFFilesServices(string NameFile) => nameFile = NameFile;
    bool IFiles.Delete(string name) => true;
    bool IFiles.Save(string name) => false;
    string IFiles.Tipo(string name) => "PDF_MAIL";
    bool IFiles.Update(string name) => true!;
}
