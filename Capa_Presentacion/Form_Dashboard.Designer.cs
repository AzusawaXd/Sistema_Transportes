namespace Capa_Presentacion
{
    partial class Form_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_T = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Icon_Exit = new System.Windows.Forms.PictureBox();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Control_Choferes = new System.Windows.Forms.Panel();
            this.Total_C = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Control_Autobuses = new System.Windows.Forms.Panel();
            this.Total_A = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Contorl_Rutas = new System.Windows.Forms.Panel();
            this.Total_R = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel_C = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_A = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_R = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Tabla = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tabla_Rutas = new System.Windows.Forms.DataGridView();
            this.Panel_HoraF = new System.Windows.Forms.Panel();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.Panel_Button = new System.Windows.Forms.Panel();
            this.Eliminar_Tabla = new System.Windows.Forms.PictureBox();
            this.Actualizar_Tabla = new System.Windows.Forms.PictureBox();
            this.BTN_Exportar_Excel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Nueva_Ruta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Nuevo_Autobus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Nuevo_Chofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_HF = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_B = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FH_Timer = new System.Windows.Forms.Timer(this.components);
            this.Panel_Buscar = new System.Windows.Forms.Panel();
            this.Buscar_Rutas = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Panel_BB = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.Control_Choferes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Control_Autobuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Contorl_Rutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Panel_Tabla.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Rutas)).BeginInit();
            this.Panel_HoraF.SuspendLayout();
            this.Panel_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminar_Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actualizar_Tabla)).BeginInit();
            this.Panel_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.Form.ElipseRadius = 7;
            this.Form.TargetControl = this;
            // 
            // Panel_T
            // 
            this.Panel_T.ElipseRadius = 3;
            this.Panel_T.TargetControl = this.Panel_Top;
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Panel_Top.Controls.Add(this.Icon_Minimize);
            this.Panel_Top.Controls.Add(this.Title);
            this.Panel_Top.Controls.Add(this.Icon_Exit);
            this.Panel_Top.Controls.Add(this.Pic_Logo);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1125, 67);
            this.Panel_Top.TabIndex = 0;
            this.Panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseDown);
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Minimize.Image")));
            this.Icon_Minimize.Location = new System.Drawing.Point(1014, 9);
            this.Icon_Minimize.Name = "Icon_Minimize";
            this.Icon_Minimize.Size = new System.Drawing.Size(53, 50);
            this.Icon_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icon_Minimize.TabIndex = 2;
            this.Icon_Minimize.TabStop = false;
            this.Icon_Minimize.Click += new System.EventHandler(this.Icon_Minimize_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(68, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 37);
            this.Title.TabIndex = 2;
            this.Title.Text = "- DASHBOARD";
            // 
            // Icon_Exit
            // 
            this.Icon_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Exit.Image")));
            this.Icon_Exit.Location = new System.Drawing.Point(1068, 9);
            this.Icon_Exit.Name = "Icon_Exit";
            this.Icon_Exit.Size = new System.Drawing.Size(53, 50);
            this.Icon_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icon_Exit.TabIndex = 1;
            this.Icon_Exit.TabStop = false;
            this.Icon_Exit.Click += new System.EventHandler(this.Icon_Exit_Click);
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Logo.Image")));
            this.Pic_Logo.Location = new System.Drawing.Point(5, 8);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(68, 51);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_Logo.TabIndex = 1;
            this.Pic_Logo.TabStop = false;
            // 
            // Control_Choferes
            // 
            this.Control_Choferes.BackColor = System.Drawing.Color.White;
            this.Control_Choferes.Controls.Add(this.Total_C);
            this.Control_Choferes.Controls.Add(this.label1);
            this.Control_Choferes.Controls.Add(this.pictureBox1);
            this.Control_Choferes.Location = new System.Drawing.Point(12, 79);
            this.Control_Choferes.Name = "Control_Choferes";
            this.Control_Choferes.Size = new System.Drawing.Size(245, 83);
            this.Control_Choferes.TabIndex = 1;
            // 
            // Total_C
            // 
            this.Total_C.AutoSize = true;
            this.Total_C.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Total_C.Location = new System.Drawing.Point(186, 35);
            this.Total_C.Name = "Total_C";
            this.Total_C.Size = new System.Drawing.Size(47, 37);
            this.Total_C.TabIndex = 2;
            this.Total_C.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHOFERES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(189)))), ((int)(((byte)(237)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Control_Autobuses
            // 
            this.Control_Autobuses.BackColor = System.Drawing.Color.White;
            this.Control_Autobuses.Controls.Add(this.Total_A);
            this.Control_Autobuses.Controls.Add(this.label2);
            this.Control_Autobuses.Controls.Add(this.pictureBox2);
            this.Control_Autobuses.Location = new System.Drawing.Point(319, 79);
            this.Control_Autobuses.Name = "Control_Autobuses";
            this.Control_Autobuses.Size = new System.Drawing.Size(245, 83);
            this.Control_Autobuses.TabIndex = 2;
            // 
            // Total_A
            // 
            this.Total_A.AutoSize = true;
            this.Total_A.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Total_A.Location = new System.Drawing.Point(186, 35);
            this.Total_A.Name = "Total_A";
            this.Total_A.Size = new System.Drawing.Size(47, 37);
            this.Total_A.TabIndex = 3;
            this.Total_A.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AUTOBUSES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Contorl_Rutas
            // 
            this.Contorl_Rutas.BackColor = System.Drawing.Color.White;
            this.Contorl_Rutas.Controls.Add(this.Total_R);
            this.Contorl_Rutas.Controls.Add(this.label3);
            this.Contorl_Rutas.Controls.Add(this.pictureBox3);
            this.Contorl_Rutas.Location = new System.Drawing.Point(629, 79);
            this.Contorl_Rutas.Name = "Contorl_Rutas";
            this.Contorl_Rutas.Size = new System.Drawing.Size(245, 83);
            this.Contorl_Rutas.TabIndex = 3;
            // 
            // Total_R
            // 
            this.Total_R.AutoSize = true;
            this.Total_R.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.Total_R.Location = new System.Drawing.Point(186, 35);
            this.Total_R.Name = "Total_R";
            this.Total_R.Size = new System.Drawing.Size(47, 37);
            this.Total_R.TabIndex = 4;
            this.Total_R.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "RUTAS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(96)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Panel_C
            // 
            this.Panel_C.ElipseRadius = 7;
            this.Panel_C.TargetControl = this.Control_Choferes;
            // 
            // Panel_A
            // 
            this.Panel_A.ElipseRadius = 7;
            this.Panel_A.TargetControl = this.Control_Autobuses;
            // 
            // Panel_R
            // 
            this.Panel_R.ElipseRadius = 7;
            this.Panel_R.TargetControl = this.Contorl_Rutas;
            // 
            // Panel_Tabla
            // 
            this.Panel_Tabla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Tabla.Controls.Add(this.panel1);
            this.Panel_Tabla.Controls.Add(this.Tabla_Rutas);
            this.Panel_Tabla.Location = new System.Drawing.Point(12, 209);
            this.Panel_Tabla.Name = "Panel_Tabla";
            this.Panel_Tabla.Size = new System.Drawing.Size(862, 564);
            this.Panel_Tabla.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 30);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label6.Location = new System.Drawing.Point(604, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "FECHA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label9.Location = new System.Drawing.Point(352, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "MARCA AUTOBUS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label8.Location = new System.Drawing.Point(465, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "CIUDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label7.Location = new System.Drawing.Point(79, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "RUTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label5.Location = new System.Drawing.Point(248, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "COD";
            // 
            // Tabla_Rutas
            // 
            this.Tabla_Rutas.AllowUserToAddRows = false;
            this.Tabla_Rutas.AllowUserToDeleteRows = false;
            this.Tabla_Rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Rutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Tabla_Rutas.BackgroundColor = System.Drawing.Color.White;
            this.Tabla_Rutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_Rutas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Rutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla_Rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Rutas.ColumnHeadersVisible = false;
            this.Tabla_Rutas.Location = new System.Drawing.Point(3, 32);
            this.Tabla_Rutas.Name = "Tabla_Rutas";
            this.Tabla_Rutas.ReadOnly = true;
            this.Tabla_Rutas.RowHeadersVisible = false;
            this.Tabla_Rutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Rutas.Size = new System.Drawing.Size(856, 529);
            this.Tabla_Rutas.TabIndex = 8;
            // 
            // Panel_HoraF
            // 
            this.Panel_HoraF.BackColor = System.Drawing.Color.White;
            this.Panel_HoraF.Controls.Add(this.lbl_Fecha);
            this.Panel_HoraF.Controls.Add(this.lbl_Hora);
            this.Panel_HoraF.Location = new System.Drawing.Point(891, 79);
            this.Panel_HoraF.Name = "Panel_HoraF";
            this.Panel_HoraF.Size = new System.Drawing.Size(229, 83);
            this.Panel_HoraF.TabIndex = 5;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.lbl_Fecha.Location = new System.Drawing.Point(4, 4);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(63, 25);
            this.lbl_Fecha.TabIndex = 9;
            this.lbl_Fecha.Text = "label6";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.lbl_Hora.Location = new System.Drawing.Point(59, 45);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(63, 25);
            this.lbl_Hora.TabIndex = 8;
            this.lbl_Hora.Text = "label5";
            // 
            // Panel_Button
            // 
            this.Panel_Button.BackColor = System.Drawing.Color.White;
            this.Panel_Button.Controls.Add(this.Eliminar_Tabla);
            this.Panel_Button.Controls.Add(this.Actualizar_Tabla);
            this.Panel_Button.Controls.Add(this.BTN_Exportar_Excel);
            this.Panel_Button.Controls.Add(this.BTN_Nueva_Ruta);
            this.Panel_Button.Controls.Add(this.BTN_Nuevo_Autobus);
            this.Panel_Button.Controls.Add(this.BTN_Nuevo_Chofer);
            this.Panel_Button.Location = new System.Drawing.Point(891, 209);
            this.Panel_Button.Name = "Panel_Button";
            this.Panel_Button.Size = new System.Drawing.Size(229, 564);
            this.Panel_Button.TabIndex = 6;
            // 
            // Eliminar_Tabla
            // 
            this.Eliminar_Tabla.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar_Tabla.Image")));
            this.Eliminar_Tabla.Location = new System.Drawing.Point(64, 81);
            this.Eliminar_Tabla.Name = "Eliminar_Tabla";
            this.Eliminar_Tabla.Size = new System.Drawing.Size(32, 32);
            this.Eliminar_Tabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Eliminar_Tabla.TabIndex = 8;
            this.Eliminar_Tabla.TabStop = false;
            this.Eliminar_Tabla.Click += new System.EventHandler(this.Eliminar_Tabla_Click);
            // 
            // Actualizar_Tabla
            // 
            this.Actualizar_Tabla.Image = ((System.Drawing.Image)(resources.GetObject("Actualizar_Tabla.Image")));
            this.Actualizar_Tabla.Location = new System.Drawing.Point(123, 81);
            this.Actualizar_Tabla.Name = "Actualizar_Tabla";
            this.Actualizar_Tabla.Size = new System.Drawing.Size(32, 32);
            this.Actualizar_Tabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Actualizar_Tabla.TabIndex = 7;
            this.Actualizar_Tabla.TabStop = false;
            this.Actualizar_Tabla.Click += new System.EventHandler(this.Actualizar_Tabla_Click);
            // 
            // BTN_Exportar_Excel
            // 
            this.BTN_Exportar_Excel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Exportar_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Exportar_Excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Exportar_Excel.BorderRadius = 7;
            this.BTN_Exportar_Excel.ButtonText = "Exportar a Excel";
            this.BTN_Exportar_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Exportar_Excel.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Exportar_Excel.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Exportar_Excel.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Exportar_Excel.Iconimage")));
            this.BTN_Exportar_Excel.Iconimage_right = null;
            this.BTN_Exportar_Excel.Iconimage_right_Selected = null;
            this.BTN_Exportar_Excel.Iconimage_Selected = null;
            this.BTN_Exportar_Excel.IconMarginLeft = 0;
            this.BTN_Exportar_Excel.IconMarginRight = 0;
            this.BTN_Exportar_Excel.IconRightVisible = true;
            this.BTN_Exportar_Excel.IconRightZoom = 0D;
            this.BTN_Exportar_Excel.IconVisible = false;
            this.BTN_Exportar_Excel.IconZoom = 90D;
            this.BTN_Exportar_Excel.IsTab = false;
            this.BTN_Exportar_Excel.Location = new System.Drawing.Point(34, 400);
            this.BTN_Exportar_Excel.Name = "BTN_Exportar_Excel";
            this.BTN_Exportar_Excel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Exportar_Excel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Exportar_Excel.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Exportar_Excel.selected = false;
            this.BTN_Exportar_Excel.Size = new System.Drawing.Size(163, 48);
            this.BTN_Exportar_Excel.TabIndex = 4;
            this.BTN_Exportar_Excel.Text = "Exportar a Excel";
            this.BTN_Exportar_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Exportar_Excel.Textcolor = System.Drawing.Color.White;
            this.BTN_Exportar_Excel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exportar_Excel.Click += new System.EventHandler(this.BTN_Exportar_Excel_Click);
            // 
            // BTN_Nueva_Ruta
            // 
            this.BTN_Nueva_Ruta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Nueva_Ruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nueva_Ruta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Nueva_Ruta.BorderRadius = 7;
            this.BTN_Nueva_Ruta.ButtonText = "Agregar Ruta";
            this.BTN_Nueva_Ruta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Nueva_Ruta.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Nueva_Ruta.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Nueva_Ruta.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Nueva_Ruta.Iconimage")));
            this.BTN_Nueva_Ruta.Iconimage_right = null;
            this.BTN_Nueva_Ruta.Iconimage_right_Selected = null;
            this.BTN_Nueva_Ruta.Iconimage_Selected = null;
            this.BTN_Nueva_Ruta.IconMarginLeft = 0;
            this.BTN_Nueva_Ruta.IconMarginRight = 0;
            this.BTN_Nueva_Ruta.IconRightVisible = true;
            this.BTN_Nueva_Ruta.IconRightZoom = 0D;
            this.BTN_Nueva_Ruta.IconVisible = false;
            this.BTN_Nueva_Ruta.IconZoom = 90D;
            this.BTN_Nueva_Ruta.IsTab = false;
            this.BTN_Nueva_Ruta.Location = new System.Drawing.Point(34, 320);
            this.BTN_Nueva_Ruta.Name = "BTN_Nueva_Ruta";
            this.BTN_Nueva_Ruta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nueva_Ruta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Nueva_Ruta.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Nueva_Ruta.selected = false;
            this.BTN_Nueva_Ruta.Size = new System.Drawing.Size(163, 48);
            this.BTN_Nueva_Ruta.TabIndex = 2;
            this.BTN_Nueva_Ruta.Text = "Agregar Ruta";
            this.BTN_Nueva_Ruta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Nueva_Ruta.Textcolor = System.Drawing.Color.White;
            this.BTN_Nueva_Ruta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Nueva_Ruta.Click += new System.EventHandler(this.BTN_Nueva_Ruta_Click);
            // 
            // BTN_Nuevo_Autobus
            // 
            this.BTN_Nuevo_Autobus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Nuevo_Autobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nuevo_Autobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Nuevo_Autobus.BorderRadius = 7;
            this.BTN_Nuevo_Autobus.ButtonText = "Agregar Autobus";
            this.BTN_Nuevo_Autobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Nuevo_Autobus.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Nuevo_Autobus.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Nuevo_Autobus.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Nuevo_Autobus.Iconimage")));
            this.BTN_Nuevo_Autobus.Iconimage_right = null;
            this.BTN_Nuevo_Autobus.Iconimage_right_Selected = null;
            this.BTN_Nuevo_Autobus.Iconimage_Selected = null;
            this.BTN_Nuevo_Autobus.IconMarginLeft = 0;
            this.BTN_Nuevo_Autobus.IconMarginRight = 0;
            this.BTN_Nuevo_Autobus.IconRightVisible = true;
            this.BTN_Nuevo_Autobus.IconRightZoom = 0D;
            this.BTN_Nuevo_Autobus.IconVisible = false;
            this.BTN_Nuevo_Autobus.IconZoom = 90D;
            this.BTN_Nuevo_Autobus.IsTab = false;
            this.BTN_Nuevo_Autobus.Location = new System.Drawing.Point(34, 236);
            this.BTN_Nuevo_Autobus.Name = "BTN_Nuevo_Autobus";
            this.BTN_Nuevo_Autobus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nuevo_Autobus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Nuevo_Autobus.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Nuevo_Autobus.selected = false;
            this.BTN_Nuevo_Autobus.Size = new System.Drawing.Size(163, 48);
            this.BTN_Nuevo_Autobus.TabIndex = 1;
            this.BTN_Nuevo_Autobus.Text = "Agregar Autobus";
            this.BTN_Nuevo_Autobus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Nuevo_Autobus.Textcolor = System.Drawing.Color.White;
            this.BTN_Nuevo_Autobus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Nuevo_Autobus.Click += new System.EventHandler(this.BTN_Nuevo_Autobus_Click);
            // 
            // BTN_Nuevo_Chofer
            // 
            this.BTN_Nuevo_Chofer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Nuevo_Chofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nuevo_Chofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Nuevo_Chofer.BorderRadius = 7;
            this.BTN_Nuevo_Chofer.ButtonText = "Agregar Chofer";
            this.BTN_Nuevo_Chofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Nuevo_Chofer.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Nuevo_Chofer.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Nuevo_Chofer.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Nuevo_Chofer.Iconimage")));
            this.BTN_Nuevo_Chofer.Iconimage_right = null;
            this.BTN_Nuevo_Chofer.Iconimage_right_Selected = null;
            this.BTN_Nuevo_Chofer.Iconimage_Selected = null;
            this.BTN_Nuevo_Chofer.IconMarginLeft = 0;
            this.BTN_Nuevo_Chofer.IconMarginRight = 0;
            this.BTN_Nuevo_Chofer.IconRightVisible = true;
            this.BTN_Nuevo_Chofer.IconRightZoom = 0D;
            this.BTN_Nuevo_Chofer.IconVisible = false;
            this.BTN_Nuevo_Chofer.IconZoom = 90D;
            this.BTN_Nuevo_Chofer.IsTab = false;
            this.BTN_Nuevo_Chofer.Location = new System.Drawing.Point(34, 152);
            this.BTN_Nuevo_Chofer.Name = "BTN_Nuevo_Chofer";
            this.BTN_Nuevo_Chofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nuevo_Chofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Nuevo_Chofer.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Nuevo_Chofer.selected = false;
            this.BTN_Nuevo_Chofer.Size = new System.Drawing.Size(163, 48);
            this.BTN_Nuevo_Chofer.TabIndex = 0;
            this.BTN_Nuevo_Chofer.Text = "Agregar Chofer";
            this.BTN_Nuevo_Chofer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Nuevo_Chofer.Textcolor = System.Drawing.Color.White;
            this.BTN_Nuevo_Chofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Nuevo_Chofer.Click += new System.EventHandler(this.BTN_Nuevo_Chofer_Click);
            // 
            // Panel_HF
            // 
            this.Panel_HF.ElipseRadius = 7;
            this.Panel_HF.TargetControl = this.Panel_HoraF;
            // 
            // Panel_B
            // 
            this.Panel_B.ElipseRadius = 7;
            this.Panel_B.TargetControl = this.Panel_Button;
            // 
            // FH_Timer
            // 
            this.FH_Timer.Enabled = true;
            this.FH_Timer.Tick += new System.EventHandler(this.FH_Timer_Tick);
            // 
            // Panel_Buscar
            // 
            this.Panel_Buscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Buscar.Controls.Add(this.Buscar_Rutas);
            this.Panel_Buscar.Controls.Add(this.pictureBox4);
            this.Panel_Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Panel_Buscar.Location = new System.Drawing.Point(12, 177);
            this.Panel_Buscar.Name = "Panel_Buscar";
            this.Panel_Buscar.Size = new System.Drawing.Size(309, 29);
            this.Panel_Buscar.TabIndex = 7;
            // 
            // Buscar_Rutas
            // 
            this.Buscar_Rutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Buscar_Rutas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_Rutas.Location = new System.Drawing.Point(31, 3);
            this.Buscar_Rutas.Multiline = true;
            this.Buscar_Rutas.Name = "Buscar_Rutas";
            this.Buscar_Rutas.Size = new System.Drawing.Size(275, 23);
            this.Buscar_Rutas.TabIndex = 1;
            this.Buscar_Rutas.TextChanged += new System.EventHandler(this.Buscar_Rutas_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Panel_BB
            // 
            this.Panel_BB.ElipseRadius = 7;
            this.Panel_BB.TargetControl = this.Panel_Buscar;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1125, 780);
            this.Controls.Add(this.Panel_Buscar);
            this.Controls.Add(this.Panel_Button);
            this.Controls.Add(this.Panel_HoraF);
            this.Controls.Add(this.Panel_Tabla);
            this.Controls.Add(this.Control_Choferes);
            this.Controls.Add(this.Contorl_Rutas);
            this.Controls.Add(this.Control_Autobuses);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.Control_Choferes.ResumeLayout(false);
            this.Control_Choferes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Control_Autobuses.ResumeLayout(false);
            this.Control_Autobuses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Contorl_Rutas.ResumeLayout(false);
            this.Contorl_Rutas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Panel_Tabla.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Rutas)).EndInit();
            this.Panel_HoraF.ResumeLayout(false);
            this.Panel_HoraF.PerformLayout();
            this.Panel_Button.ResumeLayout(false);
            this.Panel_Button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminar_Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actualizar_Tabla)).EndInit();
            this.Panel_Buscar.ResumeLayout(false);
            this.Panel_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Form;
        private Bunifu.Framework.UI.BunifuElipse Panel_T;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.PictureBox Icon_Exit;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Control_Choferes;
        private System.Windows.Forms.Panel Contorl_Rutas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Control_Autobuses;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse Panel_C;
        private Bunifu.Framework.UI.BunifuElipse Panel_A;
        private Bunifu.Framework.UI.BunifuElipse Panel_R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Tabla;
        private System.Windows.Forms.Panel Panel_HoraF;
        private System.Windows.Forms.Panel Panel_Button;
        private Bunifu.Framework.UI.BunifuElipse Panel_HF;
        private Bunifu.Framework.UI.BunifuElipse Panel_B;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer FH_Timer;
        private System.Windows.Forms.Panel Panel_Buscar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox Buscar_Rutas;
        private Bunifu.Framework.UI.BunifuElipse Panel_BB;
        private System.Windows.Forms.DataGridView Tabla_Rutas;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Exportar_Excel;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Nueva_Ruta;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Nuevo_Autobus;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Nuevo_Chofer;
        private System.Windows.Forms.Label Total_C;
        private System.Windows.Forms.Label Total_R;
        private System.Windows.Forms.Label Total_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Actualizar_Tabla;
        private System.Windows.Forms.PictureBox Eliminar_Tabla;
    }
}