using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TXT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contenido = "Este es un archivo de texto generado por un programa en C#.";

            try
            {
                string rutaArchivo = @"C:\\Users\\Orozco\\Desktop\\mi_archivo.txt";

                using (StreamWriter archivo = new StreamWriter(rutaArchivo))
                {
                    archivo.WriteLine(contenido);
                }

                Console.WriteLine("Archivo generado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar el archivo: " + ex.Message);
            }
        }
    }
}
