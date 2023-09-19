namespace WinFormCRUD
{
    partial class FrmCRUD
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lstVisor = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(68, 378);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 42);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(287, 378);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 42);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(506, 378);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 42);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(21, 12);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(636, 349);
            lstVisor.TabIndex = 3;
            lstVisor.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 448);
            Controls.Add(lstVisor);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmCRUD";
            Text = "Form1";
            Load += FrmCRUD_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox lstVisor;
    }
}