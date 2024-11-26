using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace To_Do_List
{
    //Se añade "XML" para trabajar este tipo de archivo
    public class GestionarTareaXML
    { 
        //creacion de una lista para almacenar las tareas
        private List<Tarea> tareas = new List<Tarea>();

        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
        }

        public List<Tarea> ObtenerTareas()
        {
            return tareas;
        }

        public void EliminarTarea(Tarea tarea)
        {
            tareas.Remove(tarea);
        }

        //Método que permite guardar las tareas en archivos de tipo XML
        public void GuardarTareas(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tarea>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, tareas);
            }
        }

        //Método que permite cargar las tareas en archivos de tipo XML 
        public void CargarTareas(string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Tarea>));
                using (TextReader reader = new StreamReader(filePath))
                {
                    tareas = (List<Tarea>)serializer.Deserialize(reader);
                }
            }
        }
    }
}
