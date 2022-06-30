public class Carpetas
{
    private string Nombre;
    private int ID;

    public Carpetas(string NombreDeCarpeta, int NumeroDeCarpeta)
    {   
        if (NombreDeCarpeta == null)
        {
            Nombre = "";
        } else {
            Nombre = NombreDeCarpeta;
        }
        ID = NumeroDeCarpeta;
    }    
}

public class Archivos{
    public int ID;
    public string Nombre, Extension;

    public Archivos(int NumeroDeArchivo, string NombreDelArchivo, string ExtensionDelArchivo)
    {
        ID = NumeroDeArchivo;
        if (NombreDelArchivo == null)
        {
            Nombre = "";
        } else {
            Nombre = NombreDelArchivo;
        }
        if (ExtensionDelArchivo == null)
        {
            Extension = "";
        } else {
            Extension = ExtensionDelArchivo;
        }
    }
}