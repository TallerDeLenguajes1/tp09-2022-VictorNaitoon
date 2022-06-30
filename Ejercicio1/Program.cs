using System.Text.Json;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la direccion del archivo: ");
        string? DireccionArchivo = Console.ReadLine();
        if (!Directory.Exists(DireccionArchivo)){
            return;
        }

        List<string> ListaDeArchivos = new List<string>();
        if (Directory.Exists(DireccionArchivo))
        {
            ListaDeArchivos = Directory.GetDirectories(DireccionArchivo).ToList();
        }
        else
        {
            Console.WriteLine("El archivo no existe");
        }

        FileStream File_Stream;
        string NombreDeArchivoJson = DireccionArchivo +@"\index.json";
        if (!File.Exists(NombreDeArchivoJson))
        {
            File_Stream = File.Create(NombreDeArchivoJson);
            File_Stream.Close();
        }

        using (File_Stream = new FileStream(NombreDeArchivoJson, FileMode.OpenOrCreate))
        using (var streamWriter = new StreamWriter(File_Stream))
        {
            var i = 0;
            var Carpeta = new List<Carpetas>();
            var Archivo = new List<Archivos>();

            foreach (string carpetaX in ListaDeArchivos)
            {
                var carpeta = new Carpetas(new DirectoryInfo(carpetaX).Name, i);
                Carpeta.Add(carpeta);
                i++;
            }

            foreach (string archivoY in Directory.GetFiles(DireccionArchivo))
            {
                var archivo = new Archivos(i, Path.GetFileNameWithoutExtension(archivoY), Path.GetExtension(archivoY));
                Archivo.Add(archivo);
                i++;
            }

            string CarpetaJson = JsonSerializer.Serialize(Carpeta);
            string ArchivoJson = JsonSerializer.Serialize(Archivo);
            streamWriter.WriteLine(CarpetaJson);
            streamWriter.WriteLine(ArchivoJson);
        }
    }
}