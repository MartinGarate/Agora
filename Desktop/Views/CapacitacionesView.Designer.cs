namespace Desktop.Views
{
    partial class CapacitacionesView
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            label10 = new Label();
            label1 = new Label();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            checkVerEliminados = new CheckBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            DataGrid = new DataGridView();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            TabPageAgregarEditar = new TabPage();
            ButtonQuitar = new FontAwesome.Sharp.IconButton();
            ButtonAnadir = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            numericCosto = new NumericUpDown();
            comboBoxTiposInscripciones = new ComboBox();
            label8 = new Label();
            checkInscripcionAbierta = new CheckBox();
            label7 = new Label();
            DateTimeFechaHora = new DateTimePicker();
            TxtPonente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            NumericCupo = new NumericUpDown();
            TxtDetalle = new TextBox();
            label4 = new Label();
            TxtNombre = new TextBox();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panel1 = new Panel();
            dataGridViewTiposInscripciones = new DataGridView();
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposInscripciones).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(0, -2);
            TabControl.Margin = new Padding(2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1084, 613);
            TabControl.TabIndex = 0;
            // 
            // TabPageLista
            // 
            TabPageLista.BackColor = Color.FromArgb(248, 250, 252);
            TabPageLista.Controls.Add(label10);
            TabPageLista.Controls.Add(label1);
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(checkVerEliminados);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(DataGrid);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Margin = new Padding(2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(2);
            TabPageLista.Size = new Size(1076, 585);
            TabPageLista.TabIndex = 1;
            TabPageLista.Text = "Lista";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Manrope SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            label10.ForeColor = Color.FromArgb(107, 114, 128);
            label10.Location = new Point(147, 78);
            label10.Margin = new Padding(2);
            label10.Name = "label10";
            label10.Size = new Size(600, 22);
            label10.TabIndex = 14;
            label10.Text = "A continuación se muestra un listado de todas las capacitaciones existentes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Manrope ExtraBold", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(140, 30);
            label1.Margin = new Padding(2);
            label1.Name = "label1";
            label1.Size = new Size(442, 44);
            label1.TabIndex = 9;
            label1.Text = "Gestión de Capacitaciones";
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.BackColor = Color.FromArgb(229, 231, 235);
            BtnRestaurar.FlatAppearance.BorderSize = 0;
            BtnRestaurar.FlatStyle = FlatStyle.Flat;
            BtnRestaurar.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnRestaurar.ForeColor = Color.FromArgb(31, 41, 55);
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.FromArgb(31, 41, 55);
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.IconSize = 26;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(579, 493);
            BtnRestaurar.Margin = new Padding(2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(113, 36);
            BtnRestaurar.TabIndex = 6;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = false;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // checkVerEliminados
            // 
            checkVerEliminados.AutoSize = true;
            checkVerEliminados.FlatStyle = FlatStyle.Flat;
            checkVerEliminados.Font = new Font("Manrope SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            checkVerEliminados.ForeColor = Color.FromArgb(75, 85, 99);
            checkVerEliminados.Location = new Point(854, 121);
            checkVerEliminados.Margin = new Padding(2);
            checkVerEliminados.Name = "checkVerEliminados";
            checkVerEliminados.Size = new Size(110, 21);
            checkVerEliminados.TabIndex = 1;
            checkVerEliminados.Text = "  Ver eliminados";
            checkVerEliminados.UseVisualStyleBackColor = true;
            checkVerEliminados.CheckedChanged += checkVerEliminados_CheckedChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.Transparent;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.ForeColor = Color.FromArgb(107, 114, 128);
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.FromArgb(31, 41, 55);
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 18;
            BtnBuscar.ImageAlign = ContentAlignment.TopCenter;
            BtnBuscar.Location = new Point(798, 119);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(30, 31);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.TextAlign = ContentAlignment.TopCenter;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.BackColor = Color.White;
            TxtBuscar.Font = new Font("Manrope SemiBold", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtBuscar.ForeColor = Color.FromArgb(31, 41, 55);
            TxtBuscar.Location = new Point(147, 119);
            TxtBuscar.Margin = new Padding(2);
            TxtBuscar.Multiline = true;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.PlaceholderText = "   Buscar Capacitacion...";
            TxtBuscar.Size = new Size(652, 31);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnSalir.ForeColor = Color.FromArgb(31, 41, 55);
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.FromArgb(31, 41, 55);
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 20;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(1015, 552);
            BtnSalir.Margin = new Padding(2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(59, 31);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Manrope", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 5, 22, 21);
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.BackgroundColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle10.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle10.Padding = new Padding(4);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle11.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle11.Padding = new Padding(4);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            DataGrid.GridColor = Color.FromArgb(249, 250, 251);
            DataGrid.Location = new Point(147, 165);
            DataGrid.Margin = new Padding(2);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle12.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle12.Padding = new Padding(4);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            DataGrid.RowHeadersWidth = 62;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(817, 310);
            DataGrid.TabIndex = 7;
            DataGrid.SelectionChanged += GridPeliculas_SelectionChanged_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.BackColor = Color.FromArgb(239, 68, 68);
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.White;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 26;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(851, 493);
            BtnEliminar.Margin = new Padding(2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(113, 36);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.BackColor = Color.FromArgb(0, 71, 171);
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.White;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 30;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(773, 52);
            BtnAgregar.Margin = new Padding(2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(193, 38);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "&Crear Nueva Capacitación";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModificar.BackColor = Color.FromArgb(229, 231, 235);
            BtnModificar.FlatAppearance.BorderSize = 0;
            BtnModificar.FlatStyle = FlatStyle.Flat;
            BtnModificar.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnModificar.ForeColor = Color.FromArgb(31, 41, 55);
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.FromArgb(31, 41, 55);
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.IconSize = 26;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(715, 493);
            BtnModificar.Margin = new Padding(2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(113, 34);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "&Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = false;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(label2);
            TabPageAgregarEditar.Controls.Add(checkInscripcionAbierta);
            TabPageAgregarEditar.Controls.Add(label7);
            TabPageAgregarEditar.Controls.Add(DateTimeFechaHora);
            TabPageAgregarEditar.Controls.Add(TxtPonente);
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(NumericCupo);
            TabPageAgregarEditar.Controls.Add(TxtDetalle);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(TxtNombre);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Controls.Add(panel1);
            TabPageAgregarEditar.Location = new Point(4, 24);
            TabPageAgregarEditar.Margin = new Padding(2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(2);
            TabPageAgregarEditar.Size = new Size(1076, 585);
            TabPageAgregarEditar.TabIndex = 0;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // ButtonQuitar
            // 
            ButtonQuitar.Anchor = AnchorStyles.Bottom;
            ButtonQuitar.BackColor = Color.FromArgb(239, 68, 68);
            ButtonQuitar.FlatAppearance.BorderSize = 0;
            ButtonQuitar.FlatStyle = FlatStyle.Flat;
            ButtonQuitar.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            ButtonQuitar.ForeColor = Color.White;
            ButtonQuitar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            ButtonQuitar.IconColor = Color.White;
            ButtonQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonQuitar.IconSize = 20;
            ButtonQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonQuitar.Location = new Point(367, 320);
            ButtonQuitar.Margin = new Padding(2);
            ButtonQuitar.Name = "ButtonQuitar";
            ButtonQuitar.Size = new Size(81, 23);
            ButtonQuitar.TabIndex = 34;
            ButtonQuitar.Text = "&Quitar";
            ButtonQuitar.TextAlign = ContentAlignment.MiddleRight;
            ButtonQuitar.UseVisualStyleBackColor = false;
            ButtonQuitar.Click += ButtonQuitar_Click;
            // 
            // ButtonAnadir
            // 
            ButtonAnadir.Anchor = AnchorStyles.Bottom;
            ButtonAnadir.BackColor = Color.FromArgb(207, 227, 246);
            ButtonAnadir.FlatAppearance.BorderSize = 0;
            ButtonAnadir.FlatStyle = FlatStyle.Flat;
            ButtonAnadir.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            ButtonAnadir.ForeColor = Color.FromArgb(24, 119, 213);
            ButtonAnadir.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            ButtonAnadir.IconColor = Color.FromArgb(24, 119, 213);
            ButtonAnadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonAnadir.IconSize = 20;
            ButtonAnadir.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonAnadir.Location = new Point(367, 289);
            ButtonAnadir.Margin = new Padding(2);
            ButtonAnadir.Name = "ButtonAnadir";
            ButtonAnadir.Size = new Size(81, 27);
            ButtonAnadir.TabIndex = 33;
            ButtonAnadir.Text = "&Añadir";
            ButtonAnadir.TextAlign = ContentAlignment.MiddleRight;
            ButtonAnadir.UseVisualStyleBackColor = false;
            ButtonAnadir.Click += ButtonAnadir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label9.ForeColor = Color.FromArgb(13, 20, 27);
            label9.Location = new Point(214, 279);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 32;
            label9.Text = "Costo:";
            // 
            // numericCosto
            // 
            numericCosto.DecimalPlaces = 2;
            numericCosto.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            numericCosto.ForeColor = Color.FromArgb(13, 20, 27);
            numericCosto.Location = new Point(216, 301);
            numericCosto.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericCosto.Name = "numericCosto";
            numericCosto.Size = new Size(129, 27);
            numericCosto.TabIndex = 31;
            // 
            // comboBoxTiposInscripciones
            // 
            comboBoxTiposInscripciones.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxTiposInscripciones.ForeColor = Color.FromArgb(13, 20, 27);
            comboBoxTiposInscripciones.FormattingEnabled = true;
            comboBoxTiposInscripciones.Location = new Point(26, 301);
            comboBoxTiposInscripciones.Name = "comboBoxTiposInscripciones";
            comboBoxTiposInscripciones.Size = new Size(167, 27);
            comboBoxTiposInscripciones.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Manrope ExtraBold", 17F, FontStyle.Bold, GraphicsUnit.Pixel);
            label8.ForeColor = Color.FromArgb(13, 20, 27);
            label8.Location = new Point(578, 108);
            label8.Name = "label8";
            label8.Size = new Size(359, 23);
            label8.TabIndex = 29;
            label8.Text = "Tipos de inscripciones de la capacitacion:";
            // 
            // checkInscripcionAbierta
            // 
            checkInscripcionAbierta.AutoSize = true;
            checkInscripcionAbierta.FlatStyle = FlatStyle.Flat;
            checkInscripcionAbierta.Font = new Font("Manrope SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            checkInscripcionAbierta.ForeColor = Color.FromArgb(75, 85, 99);
            checkInscripcionAbierta.Location = new Point(339, 465);
            checkInscripcionAbierta.Margin = new Padding(2);
            checkInscripcionAbierta.Name = "checkInscripcionAbierta";
            checkInscripcionAbierta.Size = new Size(129, 21);
            checkInscripcionAbierta.TabIndex = 6;
            checkInscripcionAbierta.Text = "Inscripción abierta";
            checkInscripcionAbierta.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label7.ForeColor = Color.FromArgb(13, 20, 27);
            label7.Location = new Point(153, 222);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 27;
            label7.Text = "Fecha y hora:";
            // 
            // DateTimeFechaHora
            // 
            DateTimeFechaHora.CalendarForeColor = Color.FromArgb(13, 20, 27);
            DateTimeFechaHora.CalendarTitleForeColor = Color.FromArgb(13, 20, 27);
            DateTimeFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimeFechaHora.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            DateTimeFechaHora.Format = DateTimePickerFormat.Custom;
            DateTimeFechaHora.Location = new Point(157, 243);
            DateTimeFechaHora.Margin = new Padding(2);
            DateTimeFechaHora.Name = "DateTimeFechaHora";
            DateTimeFechaHora.Size = new Size(370, 27);
            DateTimeFechaHora.TabIndex = 4;
            // 
            // TxtPonente
            // 
            TxtPonente.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TxtPonente.ForeColor = Color.FromArgb(13, 20, 27);
            TxtPonente.Location = new Point(157, 182);
            TxtPonente.Margin = new Padding(2);
            TxtPonente.Name = "TxtPonente";
            TxtPonente.PlaceholderText = "Ej: Dr. Alan Gonzales";
            TxtPonente.Size = new Size(370, 27);
            TxtPonente.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label6.ForeColor = Color.FromArgb(13, 20, 27);
            label6.Location = new Point(153, 161);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 24;
            label6.Text = "Orador/a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.ForeColor = Color.FromArgb(13, 20, 27);
            label5.Location = new Point(153, 442);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 19;
            label5.Text = "Cupo:";
            // 
            // NumericCupo
            // 
            NumericCupo.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            NumericCupo.ForeColor = Color.FromArgb(13, 20, 27);
            NumericCupo.Location = new Point(157, 463);
            NumericCupo.Margin = new Padding(2);
            NumericCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericCupo.Name = "NumericCupo";
            NumericCupo.Size = new Size(134, 27);
            NumericCupo.TabIndex = 5;
            NumericCupo.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDetalle
            // 
            TxtDetalle.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TxtDetalle.ForeColor = Color.FromArgb(13, 20, 27);
            TxtDetalle.Location = new Point(157, 308);
            TxtDetalle.Margin = new Padding(2);
            TxtDetalle.Multiline = true;
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.PlaceholderText = "Ej: Una capacitación completa sobre los fundamentos y aplicaciones de la inteligencia artificial generativa en el ámbito educativo.";
            TxtDetalle.Size = new Size(370, 109);
            TxtDetalle.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(13, 20, 27);
            label4.Location = new Point(153, 287);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 16;
            label4.Text = "Detalle:";
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            TxtNombre.ForeColor = Color.FromArgb(13, 20, 27);
            TxtNombre.Location = new Point(157, 121);
            TxtNombre.Margin = new Padding(2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PlaceholderText = "Ej: Introduccion a la IA Generativa";
            TxtNombre.Size = new Size(370, 27);
            TxtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Manrope SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.ForeColor = Color.FromArgb(13, 20, 27);
            label3.Location = new Point(153, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.BackColor = Color.FromArgb(226, 232, 240);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Manrope ExtraBold", 11F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(764, 511);
            BtnCancelar.Margin = new Padding(2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(101, 38);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.BackColor = Color.FromArgb(16, 124, 16);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Manrope ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.White;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 30;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(886, 511);
            BtnGuardar.Margin = new Padding(2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(158, 38);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "&Guardar Cambios";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Manrope ExtraBold", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.ForeColor = Color.FromArgb(31, 41, 55);
            label2.Location = new Point(148, 29);
            label2.Margin = new Padding(2);
            label2.Name = "label2";
            label2.Size = new Size(330, 44);
            label2.TabIndex = 35;
            label2.Text = "Editar Capacitación";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridViewTiposInscripciones);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBoxTiposInscripciones);
            panel1.Controls.Add(ButtonQuitar);
            panel1.Controls.Add(ButtonAnadir);
            panel1.Controls.Add(numericCosto);
            panel1.Location = new Point(564, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 365);
            panel1.TabIndex = 36;
            // 
            // dataGridViewTiposInscripciones
            // 
            dataGridViewTiposInscripciones.AllowUserToAddRows = false;
            dataGridViewTiposInscripciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Manrope", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(0, 5, 22, 21);
            dataGridViewTiposInscripciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTiposInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTiposInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTiposInscripciones.BackgroundColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle14.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle14.Padding = new Padding(4);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposInscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTiposInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle15.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle15.Padding = new Padding(4);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposInscripciones.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTiposInscripciones.GridColor = Color.FromArgb(249, 250, 251);
            dataGridViewTiposInscripciones.Location = new Point(26, 30);
            dataGridViewTiposInscripciones.Margin = new Padding(2);
            dataGridViewTiposInscripciones.MultiSelect = false;
            dataGridViewTiposInscripciones.Name = "dataGridViewTiposInscripciones";
            dataGridViewTiposInscripciones.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle16.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(75, 85, 99);
            dataGridViewCellStyle16.Padding = new Padding(4);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(224, 235, 249);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dataGridViewTiposInscripciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTiposInscripciones.RowHeadersWidth = 62;
            dataGridViewTiposInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiposInscripciones.Size = new Size(422, 237);
            dataGridViewTiposInscripciones.TabIndex = 37;
            // 
            // CapacitacionesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(TabControl);
            Margin = new Padding(2);
            Name = "CapacitacionesView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private DataGridView DataGrid;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox TxtDetalle;
        private Label label4;
        private TextBox TxtNombre;
        private Label label3;
        private Label label5;
        private NumericUpDown NumericCupo;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private CheckBox checkVerEliminados;
        private TextBox TxtPonente;
        private Label label6;
        private Label label7;
        private DateTimePicker DateTimeFechaHora;
        private CheckBox checkInscripcionAbierta;
        private ComboBox comboBoxTiposInscripciones;
        private Label label8;
        private FontAwesome.Sharp.IconButton ButtonQuitar;
        private FontAwesome.Sharp.IconButton ButtonAnadir;
        private Label label9;
        private NumericUpDown numericCosto;
        private Label label1;
        private Label label10;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridViewTiposInscripciones;
    }
}