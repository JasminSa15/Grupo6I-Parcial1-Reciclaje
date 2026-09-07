using System;
using System.Linq;

namespace MarketplaceAcademico
{
    public class HU001_Epica1_Registro
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Contrasena { get; set; }

        private readonly string[] DominiosValidos = {
            "@ugb.edu.sv",
            "@ues.edu.sv",
            "@uca.edu.sv",
            "@utec.edu.sv",
            "@unab.edu.sv",
            "@catolica.edu.sv",
            "@utoral.edu.sv",
            "@upal.edu.sv",
            "@univo.edu.sv"
        };

        public HU001_Epica1_Registro(string nombre, string apellido, string correo, string contrasena)
        {
            Nombre = nombre;
            Apellido = apellido;
            CorreoInstitucional = correo;
            Contrasena = contrasena;
        }

        public void ValidarYRegistrar()
        {
            if (string.IsNullOrWhiteSpace(Nombre) || 
                string.IsNullOrWhiteSpace(Apellido) || 
                string.IsNullOrWhiteSpace(CorreoInstitucional) || 
                string.IsNullOrWhiteSpace(Contrasena))
            {
                Console.WriteLine("Error: Todos los campos son obligatorios.");
                return;
            }

            bool esValido = DominiosValidos.Any(dominio => CorreoInstitucional.EndsWith(dominio, StringComparison.OrdinalIgnoreCase));

            if (!esValido)
            {
                Console.WriteLine("Acceso denegado: Se requiere un correo institucional válido.");
                return;
            }

            Console.WriteLine($"¡Registro exitoso, {Nombre}! Usuario registrado correctamente.");
        }
    }
}