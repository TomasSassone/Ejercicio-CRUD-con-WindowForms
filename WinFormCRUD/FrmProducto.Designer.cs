namespace WinFormCRUD
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            label1.Click += txtCodigo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += txtNombre_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            label3.Click += txtPrecio_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(23, 259);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 41);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(151, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(18, 53);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(230, 23);
            txtCodigo.TabIndex = 8;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(18, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 23);
            txtNombre.TabIndex = 9;
            txtNombre.TextChanged += textBox2_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(18, 206);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(230, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.TextChanged += textBox3_TextChanged;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 320);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProducto";
            Text = "FrmProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
    }
}