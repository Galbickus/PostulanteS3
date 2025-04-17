namespace PostulanteS3
{
    partial class FrmPrincipal
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            lblTipo = new Label();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            cboTipo = new ComboBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(57, 120);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(392, 183);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(57, 183);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(517, 45);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(517, 111);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            cboTipo.AutoCompleteCustomSource.AddRange(new string[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Extranjero" });
            cboTipo.Location = new Point(161, 175);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(204, 28);
            cboTipo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(161, 111);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(517, 180);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(179, 27);
            txtDocumento.TabIndex = 9;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cboTipo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(lblTipo);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postulante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private Label lblTipo;
        private Button btnIngresar;
        private Button btnLimpiar;
        private ComboBox cboTipo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
    }
}
