using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    public class Tarea
    {
        //Atributos que tendrá la clase
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        //se agrega una propiedad adicional
        public string Prioridad { get; set; } 

        //Metodo que devuelve una cadena en tipo string y descripcion de tarea
        public override string ToString()
        {
            return $"{Descripcion} - {(Completada ? "Finalizada" : "Pendiente")} - Prioridad: {Prioridad}";
        }
    }
}
