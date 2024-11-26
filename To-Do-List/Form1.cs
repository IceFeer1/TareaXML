using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace To_Do_List
{
    //Inicialización de eventos 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Se inicia la lista de modo XML
        private GestionarTareaXML gestionar = new GestionarTareaXML();

        private void ActualizarListaTareas(List<Tarea> tareasFiltradas = null)
        {
            Tarea.Items.Clear();
            var tareasAMostrar = tareasFiltradas ?? gestionar.ObtenerTareas();
            foreach (var tarea in tareasAMostrar)
            {
                Tarea.Items.Add(tarea);
            }
        }
        //Metodo para limpiar el campo de tarea
        public void LimpiarCampos()
        {
            txtTarea.Clear();
        }
        //Se añade el evento de boton agregar con sus condiciones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                Tarea nuevatarea = new Tarea
                {
                    Descripcion = txtTarea.Text,
                    Completada = false,
                };
                gestionar.AgregarTarea(nuevatarea);
                ActualizarListaTareas();
            } 
            //Se agrega un mensaje de advertencia
            else
            {
                MessageBox.Show("Ingrese una tarea");
            }
            LimpiarCampos();

        }
        //Metodo de doble click para cambiar anuncio en pantalla
        private void Tarea_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Tarea.SelectedItem is Tarea tareaSeleccionada)
            {
                tareaSeleccionada.Completada = !tareaSeleccionada.Completada;
                ActualizarListaTareas();
            }
        }
        //Implementación de botones que permiten filtrar las tareas en completadas y pendientes
        private void btnMostrarPendientes_Click(object sender, EventArgs e)
        {
            var tareasPendientes = gestionar.ObtenerTareas().Where(t => !t.Completada).ToList();
            ActualizarListaTareas(tareasPendientes);
        }

        //Se agrega boton para filtrar solo las tareas que han sido completadas
        private void btnMostrarCompletadas_Click(object sender, EventArgs e)
        {
            var tareasCompletadas = gestionar.ObtenerTareas().Where(t => t.Completada).ToList();
            ActualizarListaTareas(tareasCompletadas);
        }
        //implementación de boton para eliminar una tarea que se seleccione por medio del mouse
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //condicion que se debe cumplir para eliminar la tarea
            if (Tarea.SelectedItem is Tarea tareaSeleccionada)
            {
                gestionar.EliminarTarea(tareaSeleccionada);
                ActualizarListaTareas();
            }
        }

        //Implementación de boton para guardar el codigo en archivo XML
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Title = "Guardar Tareas"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gestionar.GuardarTareas(saveFileDialog.FileName);
                MessageBox.Show("Tareas guardadas correctamente.");
            }
        }
        //Implementación de boton para cargar el codigo en archivo XML
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
                Title = "Cargar Tareas"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gestionar.CargarTareas(openFileDialog.FileName);
                ActualizarListaTareas();
                MessageBox.Show("Tareas cargadas correctamente.");
            }
        }
    }
}
