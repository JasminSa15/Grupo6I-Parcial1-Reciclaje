using System;

namespace SistemaReciclaje
{
    public class HU001_Epica4_Chat_Interno_y_reputacion
    {
        public int IdCalificacion { get; set; }
        public int IdChatInterno { get; set; }
        public string IdUsuarioEvaluador { get; set; } 
        public string IdUsuarioEvaluado { get; set; } 
        public int PuntuacionEstrellas { get; set; }
        public string ComentarioTransaccion { get; set; }
        public DateTime FechaCalificacion { get; set; }

        public HU001_Epica4_Chat_Interno_y_reputacion(int idCalificacion, int idChat, string idEvaluador, string idEvaluado, int puntuacion, string comentario)
        {
            IdCalificacion = idCalificacion;
            IdChatInterno = idChat;
            IdUsuarioEvaluador = idEvaluador;
            IdUsuarioEvaluado = idEvaluado;
            PuntuacionEstrellas = puntuacion;
            ComentarioTransaccion = comentario;
            FechaCalificacion = DateTime.Now;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"=== Calificación Registrada ===");
            Console.WriteLine($"ID Calificación: {IdCalificacion}");
            Console.WriteLine($"ID Chat (Transacción): {IdChatInterno}");
            Console.WriteLine($"Usuario Evaluador: {IdUsuarioEvaluador}");
            Console.WriteLine($"Usuario Evaluado: {IdUsuarioEvaluado}");
            Console.WriteLine($"Puntuación: {PuntuacionEstrellas} estrellas");
            Console.WriteLine($"Comentario: {ComentarioTransaccion}");
            Console.WriteLine($"Fecha: {FechaCalificacion}");
        }
    }
}