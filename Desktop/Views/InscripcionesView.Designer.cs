namespace Desktop.Views
{
    partial class InscripcionesView
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
            panel2 = new Panel();
            ButtonBuscar = new FontAwesome.Sharp.IconButton();
            BtnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            dataGridViewUsuarios = new DataGridView();
            label3 = new Label();
            textBoxBuscar = new TextBox();
            GridInscripciones = new DataGridView();
            label2 = new Label();
            ComboCapacitaciones = new ComboBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 1;
            label1.Text = "Inscripciones";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(ButtonBuscar);
            panel2.Controls.Add(BtnAgregarUsuario);
            panel2.Controls.Add(BtnBuscar);
            panel2.Controls.Add(dataGridViewUsuarios);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxBuscar);
            panel2.Location = new Point(559, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 460);
            panel2.TabIndex = 17;
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            ButtonBuscar.IconColor = Color.Black;
            ButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonBuscar.IconSize = 20;
            ButtonBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonBuscar.Location = new Point(334, 44);
            ButtonBuscar.Margin = new Padding(2);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(75, 23);
            ButtonBuscar.TabIndex = 18;
            ButtonBuscar.Text = "&Buscar";
            ButtonBuscar.TextAlign = ContentAlignment.MiddleRight;
            ButtonBuscar.UseVisualStyleBackColor = true;
            ButtonBuscar.Click += ButtonBuscar_Click;
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregarUsuario.IconColor = Color.Black;
            BtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregarUsuario.IconSize = 20;
            BtnAgregarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarUsuario.Location = new Point(261, 413);
            BtnAgregarUsuario.Margin = new Padding(2);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(148, 32);
            BtnAgregarUsuario.TabIndex = 16;
            BtnAgregarUsuario.Text = "&Agregar Inscripto...";
            BtnAgregarUsuario.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 20;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(570, 38);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(68, 29);
            BtnBuscar.TabIndex = 15;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(25, 72);
            dataGridViewUsuarios.Margin = new Padding(2);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowHeadersWidth = 62;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(384, 317);
            dataGridViewUsuarios.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 11;
            label3.Text = "Agregar Inscripción:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(25, 44);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Buscar inscriptos...";
            textBoxBuscar.Size = new Size(317, 23);
            textBoxBuscar.TabIndex = 19;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            textBoxBuscar.KeyPress += textBoxBuscar_KeyPress;
            // 
            // GridInscripciones
            // 
            GridInscripciones.AllowUserToAddRows = false;
            GridInscripciones.AllowUserToDeleteRows = false;
            GridInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInscripciones.Location = new Point(19, 114);
            GridInscripciones.Margin = new Padding(2);
            GridInscripciones.Name = "GridInscripciones";
            GridInscripciones.ReadOnly = true;
            GridInscripciones.RowHeadersVisible = false;
            GridInscripciones.RowHeadersWidth = 62;
            GridInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridInscripciones.Size = new Size(535, 460);
            GridInscripciones.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 73);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 15;
            label2.Text = "Capacitación:";
            // 
            // ComboCapacitaciones
            // 
            ComboCapacitaciones.Font = new Font("Segoe UI", 12F);
            ComboCapacitaciones.FormattingEnabled = true;
            ComboCapacitaciones.Location = new Point(142, 72);
            ComboCapacitaciones.Margin = new Padding(2);
            ComboCapacitaciones.Name = "ComboCapacitaciones";
            ComboCapacitaciones.Size = new Size(368, 29);
            ComboCapacitaciones.TabIndex = 14;
            ComboCapacitaciones.SelectedIndexChanged += ComboCapacitaciones_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 47);
            panel1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 416);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 29);
            comboBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(25, 401);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(175, 13);
            label4.TabIndex = 21;
            label4.Text = "Seleccione el tipo de Inscripcion:";
            // 
            // InscripcionesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 585);
            Controls.Add(panel2);
            Controls.Add(GridInscripciones);
            Controls.Add(label2);
            Controls.Add(ComboCapacitaciones);
            Controls.Add(panel1);
            Name = "InscripcionesView";
            Text = "Inscripciones2View";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridInscripciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton BtnAgregarUsuario;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private DataGridView dataGridViewUsuarios;
        private Label label3;
        private DataGridView GridInscripciones;
        private Label label2;
        private ComboBox ComboCapacitaciones;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ButtonBuscar;
        private TextBox textBoxBuscar;
        private ComboBox comboBox1;
        private Label label4;
    }
}