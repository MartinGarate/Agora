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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapacitacionesView));
            tabControl = new TabControl();
            tabPageLista = new TabPage();
            buttonRestaurar = new FontAwesome.Sharp.IconButton();
            checkBox_VerEliminados = new CheckBox();
            ButtonEliminarAuto = new FontAwesome.Sharp.IconButton();
            ButtonEditarAuto = new FontAwesome.Sharp.IconButton();
            ButtonAgregarAuto = new FontAwesome.Sharp.IconButton();
            ButtonBuscarAuto = new FontAwesome.Sharp.IconButton();
            textBoxFiltrarAuto = new TextBox();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            ButtonClose = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            tabPageAgregar_Editar = new TabPage();
            label5 = new Label();
            dateTimeFechaHora = new DateTimePicker();
            numericUpDownCupo = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            TxtPonente = new TextBox();
            label2 = new Label();
            TxtDetalle = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ButtonCancelar = new FontAwesome.Sharp.IconButton();
            ButtonGuardar = new FontAwesome.Sharp.IconButton();
            pictureBox4 = new PictureBox();
            checkBoxInscripcion = new CheckBox();
            label1 = new Label();
            TxtNombre = new TextBox();
            contextMenuStripLimpiar = new ContextMenuStrip(components);
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageAgregar_Editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCupo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            contextMenuStripLimpiar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageLista);
            tabControl.Controls.Add(tabPageAgregar_Editar);
            tabControl.Location = new Point(-5, -2);
            tabControl.Margin = new Padding(0);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(989, 605);
            tabControl.TabIndex = 0;
            // 
            // tabPageLista
            // 
            tabPageLista.BackColor = Color.FromArgb(242, 242, 242);
            tabPageLista.BackgroundImageLayout = ImageLayout.None;
            tabPageLista.Controls.Add(buttonRestaurar);
            tabPageLista.Controls.Add(checkBox_VerEliminados);
            tabPageLista.Controls.Add(ButtonEliminarAuto);
            tabPageLista.Controls.Add(ButtonEditarAuto);
            tabPageLista.Controls.Add(ButtonAgregarAuto);
            tabPageLista.Controls.Add(ButtonBuscarAuto);
            tabPageLista.Controls.Add(textBoxFiltrarAuto);
            tabPageLista.Controls.Add(dataGridView);
            tabPageLista.Controls.Add(panel1);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Size = new Size(981, 577);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            // 
            // buttonRestaurar
            // 
            buttonRestaurar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRestaurar.BackColor = Color.FromArgb(28, 28, 27);
            buttonRestaurar.FlatStyle = FlatStyle.Flat;
            buttonRestaurar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRestaurar.ForeColor = Color.FromArgb(242, 242, 242);
            buttonRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            buttonRestaurar.IconColor = Color.FromArgb(242, 242, 242);
            buttonRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonRestaurar.IconSize = 24;
            buttonRestaurar.ImageAlign = ContentAlignment.MiddleRight;
            buttonRestaurar.Location = new Point(283, 512);
            buttonRestaurar.Name = "buttonRestaurar";
            buttonRestaurar.Size = new Size(103, 28);
            buttonRestaurar.TabIndex = 5;
            buttonRestaurar.Text = "Restaurar";
            buttonRestaurar.TextAlign = ContentAlignment.MiddleLeft;
            buttonRestaurar.UseVisualStyleBackColor = false;
            buttonRestaurar.Visible = false;
            buttonRestaurar.Click += buttonRestaurar_Click;
            // 
            // checkBox_VerEliminados
            // 
            checkBox_VerEliminados.AutoSize = true;
            checkBox_VerEliminados.Location = new Point(818, 145);
            checkBox_VerEliminados.Name = "checkBox_VerEliminados";
            checkBox_VerEliminados.Size = new Size(103, 19);
            checkBox_VerEliminados.TabIndex = 1;
            checkBox_VerEliminados.Text = "Ver eliminados";
            checkBox_VerEliminados.UseVisualStyleBackColor = true;
            checkBox_VerEliminados.CheckedChanged += checkBox_VerEliminados_CheckedChanged;
            // 
            // ButtonEliminarAuto
            // 
            ButtonEliminarAuto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonEliminarAuto.BackColor = Color.FromArgb(242, 242, 242);
            ButtonEliminarAuto.FlatStyle = FlatStyle.Flat;
            ButtonEliminarAuto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEliminarAuto.ForeColor = Color.FromArgb(28, 28, 27);
            ButtonEliminarAuto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            ButtonEliminarAuto.IconColor = Color.FromArgb(28, 28, 27);
            ButtonEliminarAuto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonEliminarAuto.IconSize = 24;
            ButtonEliminarAuto.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEliminarAuto.Location = new Point(833, 512);
            ButtonEliminarAuto.Name = "ButtonEliminarAuto";
            ButtonEliminarAuto.Size = new Size(88, 28);
            ButtonEliminarAuto.TabIndex = 6;
            ButtonEliminarAuto.Text = "Eliminar";
            ButtonEliminarAuto.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEliminarAuto.UseVisualStyleBackColor = false;
            ButtonEliminarAuto.Click += ButtonEliminarAuto_Click;
            // 
            // ButtonEditarAuto
            // 
            ButtonEditarAuto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonEditarAuto.BackColor = Color.FromArgb(28, 28, 27);
            ButtonEditarAuto.FlatStyle = FlatStyle.Flat;
            ButtonEditarAuto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEditarAuto.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonEditarAuto.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            ButtonEditarAuto.IconColor = Color.FromArgb(242, 242, 242);
            ButtonEditarAuto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonEditarAuto.IconSize = 24;
            ButtonEditarAuto.ImageAlign = ContentAlignment.MiddleRight;
            ButtonEditarAuto.Location = new Point(174, 512);
            ButtonEditarAuto.Name = "ButtonEditarAuto";
            ButtonEditarAuto.Size = new Size(103, 28);
            ButtonEditarAuto.TabIndex = 4;
            ButtonEditarAuto.Text = "Editar";
            ButtonEditarAuto.TextAlign = ContentAlignment.MiddleLeft;
            ButtonEditarAuto.UseVisualStyleBackColor = false;
            ButtonEditarAuto.Click += ButtonEditarAuto_Click;
            // 
            // ButtonAgregarAuto
            // 
            ButtonAgregarAuto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonAgregarAuto.BackColor = Color.FromArgb(28, 28, 27);
            ButtonAgregarAuto.FlatStyle = FlatStyle.Flat;
            ButtonAgregarAuto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAgregarAuto.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonAgregarAuto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            ButtonAgregarAuto.IconColor = Color.FromArgb(242, 242, 242);
            ButtonAgregarAuto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonAgregarAuto.IconSize = 24;
            ButtonAgregarAuto.ImageAlign = ContentAlignment.MiddleRight;
            ButtonAgregarAuto.Location = new Point(65, 512);
            ButtonAgregarAuto.Name = "ButtonAgregarAuto";
            ButtonAgregarAuto.Size = new Size(103, 28);
            ButtonAgregarAuto.TabIndex = 3;
            ButtonAgregarAuto.Text = "Agregar";
            ButtonAgregarAuto.TextAlign = ContentAlignment.MiddleLeft;
            ButtonAgregarAuto.UseVisualStyleBackColor = false;
            ButtonAgregarAuto.Click += ButtonAgregarAuto_Click;
            // 
            // ButtonBuscarAuto
            // 
            ButtonBuscarAuto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonBuscarAuto.BackColor = Color.FromArgb(28, 28, 27);
            ButtonBuscarAuto.FlatStyle = FlatStyle.Popup;
            ButtonBuscarAuto.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonBuscarAuto.IconChar = FontAwesome.Sharp.IconChar.Search;
            ButtonBuscarAuto.IconColor = Color.FromArgb(242, 242, 242);
            ButtonBuscarAuto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonBuscarAuto.IconSize = 20;
            ButtonBuscarAuto.Location = new Point(885, 170);
            ButtonBuscarAuto.Name = "ButtonBuscarAuto";
            ButtonBuscarAuto.Size = new Size(36, 25);
            ButtonBuscarAuto.TabIndex = 2;
            ButtonBuscarAuto.UseVisualStyleBackColor = false;
            ButtonBuscarAuto.Click += ButtonBuscarAuto_Click;
            // 
            // textBoxFiltrarAuto
            // 
            textBoxFiltrarAuto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFiltrarAuto.Font = new Font("Segoe UI", 10F);
            textBoxFiltrarAuto.ForeColor = Color.FromArgb(28, 28, 27);
            textBoxFiltrarAuto.Location = new Point(65, 170);
            textBoxFiltrarAuto.Name = "textBoxFiltrarAuto";
            textBoxFiltrarAuto.PlaceholderText = "¿Qué estás buscando?...";
            textBoxFiltrarAuto.Size = new Size(820, 25);
            textBoxFiltrarAuto.TabIndex = 0;
            textBoxFiltrarAuto.TextChanged += textBoxFiltrarAuto_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.FromArgb(242, 242, 242);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.GridColor = Color.FromArgb(20, 21, 20);
            dataGridView.Location = new Point(65, 201);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(856, 305);
            dataGridView.TabIndex = 2;
            dataGridView.SelectionChanged += dataGridViewAutos_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(20, 21, 20);
            panel1.Controls.Add(ButtonClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 110);
            panel1.TabIndex = 0;
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.BackColor = Color.Transparent;
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonClose.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonClose.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            ButtonClose.IconColor = Color.FromArgb(242, 242, 242);
            ButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonClose.IconSize = 24;
            ButtonClose.ImageAlign = ContentAlignment.MiddleRight;
            ButtonClose.Location = new Point(917, 15);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(65, 28);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "Salir";
            ButtonClose.TextAlign = ContentAlignment.MiddleLeft;
            ButtonClose.UseVisualStyleBackColor = false;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabPageAgregar_Editar
            // 
            tabPageAgregar_Editar.BackColor = Color.FromArgb(242, 242, 242);
            tabPageAgregar_Editar.Controls.Add(label5);
            tabPageAgregar_Editar.Controls.Add(dateTimeFechaHora);
            tabPageAgregar_Editar.Controls.Add(numericUpDownCupo);
            tabPageAgregar_Editar.Controls.Add(label4);
            tabPageAgregar_Editar.Controls.Add(label3);
            tabPageAgregar_Editar.Controls.Add(TxtPonente);
            tabPageAgregar_Editar.Controls.Add(label2);
            tabPageAgregar_Editar.Controls.Add(TxtDetalle);
            tabPageAgregar_Editar.Controls.Add(panel2);
            tabPageAgregar_Editar.Controls.Add(ButtonCancelar);
            tabPageAgregar_Editar.Controls.Add(ButtonGuardar);
            tabPageAgregar_Editar.Controls.Add(pictureBox4);
            tabPageAgregar_Editar.Controls.Add(checkBoxInscripcion);
            tabPageAgregar_Editar.Controls.Add(label1);
            tabPageAgregar_Editar.Controls.Add(TxtNombre);
            tabPageAgregar_Editar.Location = new Point(4, 24);
            tabPageAgregar_Editar.Name = "tabPageAgregar_Editar";
            tabPageAgregar_Editar.Padding = new Padding(3);
            tabPageAgregar_Editar.Size = new Size(981, 577);
            tabPageAgregar_Editar.TabIndex = 1;
            tabPageAgregar_Editar.Text = "Agregar o Editar";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Plus Jakarta Sans ExtraBold", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(20, 21, 20);
            label5.Location = new Point(52, 325);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 31;
            label5.Text = "Fecha y Hora";
            // 
            // dateTimeFechaHora
            // 
            dateTimeFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimeFechaHora.Format = DateTimePickerFormat.Custom;
            dateTimeFechaHora.Location = new Point(172, 329);
            dateTimeFechaHora.Name = "dateTimeFechaHora";
            dateTimeFechaHora.Size = new Size(291, 23);
            dateTimeFechaHora.TabIndex = 4;
            // 
            // numericUpDownCupo
            // 
            numericUpDownCupo.Location = new Point(172, 300);
            numericUpDownCupo.Name = "numericUpDownCupo";
            numericUpDownCupo.Size = new Size(291, 23);
            numericUpDownCupo.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Plus Jakarta Sans ExtraBold", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(20, 21, 20);
            label4.Location = new Point(113, 294);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 28;
            label4.Text = "Cupo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Plus Jakarta Sans ExtraBold", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(20, 21, 20);
            label3.Location = new Point(78, 264);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 26;
            label3.Text = "Orador/a";
            // 
            // TxtPonente
            // 
            TxtPonente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtPonente.BackColor = Color.FromArgb(242, 242, 242);
            TxtPonente.Font = new Font("Segoe UI", 10F);
            TxtPonente.ForeColor = Color.FromArgb(28, 28, 27);
            TxtPonente.Location = new Point(172, 269);
            TxtPonente.Name = "TxtPonente";
            TxtPonente.PlaceholderText = "Nombre del orador/a";
            TxtPonente.Size = new Size(291, 25);
            TxtPonente.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Plus Jakarta Sans ExtraBold", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(20, 21, 20);
            label2.Location = new Point(100, 235);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 24;
            label2.Text = "Detalle";
            // 
            // TxtDetalle
            // 
            TxtDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtDetalle.BackColor = Color.FromArgb(242, 242, 242);
            TxtDetalle.Font = new Font("Segoe UI", 10F);
            TxtDetalle.ForeColor = Color.FromArgb(28, 28, 27);
            TxtDetalle.Location = new Point(172, 238);
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.PlaceholderText = "Mas información...";
            TxtDetalle.Size = new Size(291, 25);
            TxtDetalle.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(20, 21, 20);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-4, -7);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 110);
            panel2.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Agora_Logo2;
            pictureBox2.Location = new Point(17, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonCancelar.BackColor = Color.FromArgb(242, 242, 242);
            ButtonCancelar.FlatStyle = FlatStyle.Flat;
            ButtonCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCancelar.ForeColor = Color.FromArgb(28, 28, 27);
            ButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            ButtonCancelar.IconColor = Color.FromArgb(28, 28, 27);
            ButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonCancelar.IconSize = 24;
            ButtonCancelar.ImageAlign = ContentAlignment.MiddleRight;
            ButtonCancelar.Location = new Point(370, 405);
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.Size = new Size(93, 28);
            ButtonCancelar.TabIndex = 7;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.TextAlign = ContentAlignment.MiddleLeft;
            ButtonCancelar.UseVisualStyleBackColor = false;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // ButtonGuardar
            // 
            ButtonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonGuardar.BackColor = Color.FromArgb(28, 28, 27);
            ButtonGuardar.FlatStyle = FlatStyle.Flat;
            ButtonGuardar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonGuardar.ForeColor = Color.FromArgb(242, 242, 242);
            ButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            ButtonGuardar.IconColor = Color.FromArgb(242, 242, 242);
            ButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ButtonGuardar.IconSize = 24;
            ButtonGuardar.ImageAlign = ContentAlignment.MiddleRight;
            ButtonGuardar.Location = new Point(271, 405);
            ButtonGuardar.Name = "ButtonGuardar";
            ButtonGuardar.Size = new Size(93, 28);
            ButtonGuardar.TabIndex = 6;
            ButtonGuardar.Text = "Guardar";
            ButtonGuardar.TextAlign = ContentAlignment.MiddleLeft;
            ButtonGuardar.UseVisualStyleBackColor = false;
            ButtonGuardar.Click += ButtonGuardar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(592, 207);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(291, 206);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // checkBoxInscripcion
            // 
            checkBoxInscripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxInscripcion.AutoSize = true;
            checkBoxInscripcion.Font = new Font("Plus Jakarta Sans ExtraBold", 12.7499981F, FontStyle.Bold);
            checkBoxInscripcion.ForeColor = Color.FromArgb(20, 21, 20);
            checkBoxInscripcion.Location = new Point(277, 358);
            checkBoxInscripcion.Name = "checkBoxInscripcion";
            checkBoxInscripcion.Size = new Size(186, 32);
            checkBoxInscripcion.TabIndex = 5;
            checkBoxInscripcion.Text = "Inscripción Abierta";
            checkBoxInscripcion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Plus Jakarta Sans ExtraBold", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(20, 21, 20);
            label1.Location = new Point(90, 204);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TxtNombre.BackColor = Color.FromArgb(242, 242, 242);
            TxtNombre.Font = new Font("Segoe UI", 10F);
            TxtNombre.ForeColor = Color.FromArgb(28, 28, 27);
            TxtNombre.Location = new Point(172, 207);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PlaceholderText = "Nombre de la capacitación";
            TxtNombre.Size = new Size(291, 25);
            TxtNombre.TabIndex = 0;
            TxtNombre.TextChanged += textBoxImagenAuto_TextChanged;
            // 
            // contextMenuStripLimpiar
            // 
            contextMenuStripLimpiar.Items.AddRange(new ToolStripItem[] { limpiarToolStripMenuItem });
            contextMenuStripLimpiar.Name = "contextMenuStrip1";
            contextMenuStripLimpiar.ShowImageMargin = false;
            contextMenuStripLimpiar.Size = new Size(99, 26);
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(98, 22);
            limpiarToolStripMenuItem.Text = "Limpiar...";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // CapacitacionesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(980, 599);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CapacitacionesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Auto Stock Garate";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageAgregar_Editar.ResumeLayout(false);
            tabPageAgregar_Editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCupo).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            contextMenuStripLimpiar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageLista;
        private TabPage tabPageAgregar_Editar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxAuto;
        private FontAwesome.Sharp.IconButton ButtonBuscarAuto;
        private TextBox textBoxFiltrarAuto;
        private DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton ButtonAgregarAuto;
        private FontAwesome.Sharp.IconButton ButtonEliminarAuto;
        private FontAwesome.Sharp.IconButton ButtonEditarAuto;
        private ContextMenuStrip contextMenuStripLimpiar;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private Label label2;
        private TextBox textBoxMarcaAuto;
        private Label label1;
        private TextBox TxtNombre;
        private Label label3;
        private Label label4;
        private TextBox textBoxModeloAuto;
        private Label label5;
        private PictureBox pictureBox4;
        private CheckBox checkBoxInscripcion;
        private FontAwesome.Sharp.IconButton ButtonCancelar;
        private FontAwesome.Sharp.IconButton ButtonGuardar;
        private NumericUpDown numericAnioAuto;
        private NumericUpDown numericPrecioAuto;
        private Panel panel2;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton ButtonClose;
        private CheckBox checkBox_VerEliminados;
        private FontAwesome.Sharp.IconButton buttonRestaurar;
        private DateTimePicker dateTimeFechaHora;
        private NumericUpDown numericUpDownCupo;
        private TextBox TxtPonente;
        private TextBox TxtDetalle;
    }
}