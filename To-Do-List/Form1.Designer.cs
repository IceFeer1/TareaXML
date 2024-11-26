namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            btnAgregar = new Button();
            txtTarea = new TextBox();
            label2 = new Label();
            Tarea = new ListBox();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            btnMostrarCompletadas = new Button();
            btnMostrarPendientes = new Button();
            btnCargar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 51);
            label1.Name = "label1";
            label1.Size = new Size(217, 44);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCargar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtTarea);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 286);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(6, 151);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(90, 52);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(125, 27);
            txtTarea.TabIndex = 1;
            txtTarea.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 52);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Tarea";
            // 
            // Tarea
            // 
            Tarea.FormattingEnabled = true;
            Tarea.Location = new Point(319, 163);
            Tarea.Name = "Tarea";
            Tarea.Size = new Size(469, 184);
            Tarea.TabIndex = 0;
            Tarea.MouseDoubleClick += Tarea_MouseDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnMostrarCompletadas);
            groupBox3.Controls.Add(btnMostrarPendientes);
            groupBox3.Location = new Point(319, 353);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(469, 85);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Opciones de filtrado";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(262, 26);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrarCompletadas
            // 
            btnMostrarCompletadas.Location = new Point(137, 26);
            btnMostrarCompletadas.Name = "btnMostrarCompletadas";
            btnMostrarCompletadas.Size = new Size(105, 29);
            btnMostrarCompletadas.TabIndex = 1;
            btnMostrarCompletadas.Text = "Completada";
            btnMostrarCompletadas.UseVisualStyleBackColor = true;
            btnMostrarCompletadas.Click += btnMostrarCompletadas_Click;
            // 
            // btnMostrarPendientes
            // 
            btnMostrarPendientes.Location = new Point(14, 26);
            btnMostrarPendientes.Name = "btnMostrarPendientes";
            btnMostrarPendientes.Size = new Size(94, 29);
            btnMostrarPendientes.TabIndex = 0;
            btnMostrarPendientes.Text = "Pendientes";
            btnMostrarPendientes.UseVisualStyleBackColor = true;
            btnMostrarPendientes.Click += btnMostrarPendientes_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(6, 248);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(94, 29);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 201);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(Tarea);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Button btnAgregar;
        private TextBox txtTarea;
        private Label label2;
        private ListBox Tarea;
        private GroupBox groupBox3;
        private Button btnMostrarCompletadas;
        private Button btnMostrarPendientes;
        private Button btnEliminar;
        private Button btnCargar;
        private Button btnGuardar;
    }
}
