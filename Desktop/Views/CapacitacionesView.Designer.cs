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
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            checkVerEliminados = new CheckBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
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
            dataGridViewTiposInscripciones = new DataGridView();
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
            panel1 = new Panel();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposInscripciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(15, 50);
            TabControl.Margin = new Padding(2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(845, 363);
            TabControl.TabIndex = 0;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(checkVerEliminados);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(DataGrid);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Margin = new Padding(2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(2);
            TabPageLista.Size = new Size(837, 335);
            TabPageLista.TabIndex = 1;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(735, 155);
            BtnRestaurar.Margin = new Padding(2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(95, 32);
            BtnRestaurar.TabIndex = 6;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // checkVerEliminados
            // 
            checkVerEliminados.AutoSize = true;
            checkVerEliminados.Location = new Point(618, 16);
            checkVerEliminados.Margin = new Padding(2);
            checkVerEliminados.Name = "checkVerEliminados";
            checkVerEliminados.Size = new Size(103, 19);
            checkVerEliminados.TabIndex = 1;
            checkVerEliminados.Text = "Ver eliminados";
            checkVerEliminados.UseVisualStyleBackColor = true;
            checkVerEliminados.CheckedChanged += checkVerEliminados_CheckedChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(735, 5);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(95, 32);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(60, 13);
            TxtBuscar.Margin = new Padding(2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(546, 23);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 13;
            label2.Text = "Buscar:";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(735, 229);
            BtnSalir.Margin = new Padding(2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(95, 31);
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
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(4, 37);
            DataGrid.Margin = new Padding(2);
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersWidth = 62;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(722, 230);
            DataGrid.TabIndex = 7;
            DataGrid.SelectionChanged += GridPeliculas_SelectionChanged_1;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(735, 120);
            BtnEliminar.Margin = new Padding(2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(95, 32);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(735, 50);
            BtnAgregar.Margin = new Padding(2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(95, 32);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(735, 86);
            BtnModificar.Margin = new Padding(2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(95, 30);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "&Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(ButtonQuitar);
            TabPageAgregarEditar.Controls.Add(ButtonAnadir);
            TabPageAgregarEditar.Controls.Add(label9);
            TabPageAgregarEditar.Controls.Add(numericCosto);
            TabPageAgregarEditar.Controls.Add(comboBoxTiposInscripciones);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(dataGridViewTiposInscripciones);
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
            TabPageAgregarEditar.Location = new Point(4, 24);
            TabPageAgregarEditar.Margin = new Padding(2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(2);
            TabPageAgregarEditar.Size = new Size(837, 335);
            TabPageAgregarEditar.TabIndex = 0;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // ButtonQuitar
            // 
            ButtonQuitar.Anchor = AnchorStyles.Bottom;
            ButtonQuitar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            ButtonQuitar.IconColor = Color.Black;
            ButtonQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonQuitar.IconSize = 20;
            ButtonQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonQuitar.Location = new Point(711, 173);
            ButtonQuitar.Margin = new Padding(2);
            ButtonQuitar.Name = "ButtonQuitar";
            ButtonQuitar.Size = new Size(70, 23);
            ButtonQuitar.TabIndex = 34;
            ButtonQuitar.Text = "&Quitar";
            ButtonQuitar.TextAlign = ContentAlignment.MiddleRight;
            ButtonQuitar.UseVisualStyleBackColor = true;
            ButtonQuitar.Click += ButtonQuitar_Click;
            // 
            // ButtonAnadir
            // 
            ButtonAnadir.Anchor = AnchorStyles.Bottom;
            ButtonAnadir.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            ButtonAnadir.IconColor = Color.Black;
            ButtonAnadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonAnadir.IconSize = 20;
            ButtonAnadir.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonAnadir.Location = new Point(637, 173);
            ButtonAnadir.Margin = new Padding(2);
            ButtonAnadir.Name = "ButtonAnadir";
            ButtonAnadir.Size = new Size(70, 23);
            ButtonAnadir.TabIndex = 33;
            ButtonAnadir.Text = "&Añadir";
            ButtonAnadir.TextAlign = ContentAlignment.MiddleRight;
            ButtonAnadir.UseVisualStyleBackColor = true;
            ButtonAnadir.Click += ButtonAnadir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7F);
            label9.Location = new Point(386, 157);
            label9.Name = "label9";
            label9.Size = new Size(42, 12);
            label9.TabIndex = 32;
            label9.Text = "Importe:";
            // 
            // numericCosto
            // 
            numericCosto.DecimalPlaces = 2;
            numericCosto.Location = new Point(386, 172);
            numericCosto.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numericCosto.Name = "numericCosto";
            numericCosto.Size = new Size(184, 23);
            numericCosto.TabIndex = 31;
            // 
            // comboBoxTiposInscripciones
            // 
            comboBoxTiposInscripciones.FormattingEnabled = true;
            comboBoxTiposInscripciones.Location = new Point(386, 126);
            comboBoxTiposInscripciones.Name = "comboBoxTiposInscripciones";
            comboBoxTiposInscripciones.Size = new Size(184, 23);
            comboBoxTiposInscripciones.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7F);
            label8.Location = new Point(386, 111);
            label8.Name = "label8";
            label8.Size = new Size(185, 12);
            label8.TabIndex = 29;
            label8.Text = "Tipos de inscripciones de la capacitacion:";
            // 
            // dataGridViewTiposInscripciones
            // 
            dataGridViewTiposInscripciones.AllowUserToAddRows = false;
            dataGridViewTiposInscripciones.AllowUserToDeleteRows = false;
            dataGridViewTiposInscripciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewTiposInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTiposInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTiposInscripciones.Location = new Point(385, 200);
            dataGridViewTiposInscripciones.Margin = new Padding(2);
            dataGridViewTiposInscripciones.Name = "dataGridViewTiposInscripciones";
            dataGridViewTiposInscripciones.ReadOnly = true;
            dataGridViewTiposInscripciones.RowHeadersVisible = false;
            dataGridViewTiposInscripciones.RowHeadersWidth = 62;
            dataGridViewTiposInscripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTiposInscripciones.Size = new Size(396, 92);
            dataGridViewTiposInscripciones.TabIndex = 28;
            // 
            // checkInscripcionAbierta
            // 
            checkInscripcionAbierta.AutoSize = true;
            checkInscripcionAbierta.Location = new Point(153, 154);
            checkInscripcionAbierta.Margin = new Padding(2);
            checkInscripcionAbierta.Name = "checkInscripcionAbierta";
            checkInscripcionAbierta.Size = new Size(123, 19);
            checkInscripcionAbierta.TabIndex = 6;
            checkInscripcionAbierta.Text = "Inscripción abierta";
            checkInscripcionAbierta.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 106);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 27;
            label7.Text = "Fecha y hora:";
            // 
            // DateTimeFechaHora
            // 
            DateTimeFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimeFechaHora.Format = DateTimePickerFormat.Custom;
            DateTimeFechaHora.Location = new Point(153, 100);
            DateTimeFechaHora.Margin = new Padding(2);
            DateTimeFechaHora.Name = "DateTimeFechaHora";
            DateTimeFechaHora.Size = new Size(211, 23);
            DateTimeFechaHora.TabIndex = 4;
            // 
            // TxtPonente
            // 
            TxtPonente.Location = new Point(153, 73);
            TxtPonente.Margin = new Padding(2);
            TxtPonente.Name = "TxtPonente";
            TxtPonente.Size = new Size(628, 23);
            TxtPonente.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 81);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 24;
            label6.Text = "Orador/a:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 135);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 19;
            label5.Text = "Cupo:";
            // 
            // NumericCupo
            // 
            NumericCupo.Location = new Point(153, 127);
            NumericCupo.Margin = new Padding(2);
            NumericCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericCupo.Name = "NumericCupo";
            NumericCupo.Size = new Size(78, 23);
            NumericCupo.TabIndex = 5;
            NumericCupo.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDetalle
            // 
            TxtDetalle.Location = new Point(153, 46);
            TxtDetalle.Margin = new Padding(2);
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.Size = new Size(628, 23);
            TxtDetalle.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 49);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 16;
            label4.Text = "Detalle:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(153, 19);
            TxtNombre.Margin = new Padding(2);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(628, 23);
            TxtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(437, 296);
            BtnCancelar.Margin = new Padding(2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(95, 32);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(297, 296);
            BtnGuardar.Margin = new Padding(2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(95, 32);
            BtnGuardar.TabIndex = 7;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 47);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 1;
            label1.Text = "Capacitaciones";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 423);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 10, 0);
            statusStrip1.Size = new Size(868, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 17);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // CapacitacionesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 445);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewTiposInscripciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private DataGridView DataGrid;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private Label label2;
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private CheckBox checkVerEliminados;
        private TextBox TxtPonente;
        private Label label6;
        private Label label7;
        private DateTimePicker DateTimeFechaHora;
        private CheckBox checkInscripcionAbierta;
        private ComboBox comboBoxTiposInscripciones;
        private Label label8;
        private DataGridView dataGridViewTiposInscripciones;
        private FontAwesome.Sharp.IconButton ButtonQuitar;
        private FontAwesome.Sharp.IconButton ButtonAnadir;
        private Label label9;
        private NumericUpDown numericCosto;
    }
}