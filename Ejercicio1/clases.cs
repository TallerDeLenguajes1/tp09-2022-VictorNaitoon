public class Carpetas
{
    private string Nombre;
    private int ID;

    public Carpetas(string NombreDeCarpeta, int NumeroDeCarpeta)
    {   
        Nombre = NombreDeCarpeta;
        ID = NumeroDeCarpeta;
    }    
}

public class Archivos{
    public int ID;
    public string Nombre, Extension;

    public Archivos(int NumeroDeArchivo, string NombreDelArchivo, string ExtensionDelArchivo)
    {
        ID = NumeroDeArchivo;
        Nombre = NombreDelArchivo;
        Extension = ExtensionDelArchivo;
    }
}