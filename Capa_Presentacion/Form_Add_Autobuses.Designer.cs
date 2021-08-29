namespace Capa_Presentacion
{
    partial class Form_Add_Autobuses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Autobuses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Icon_Exit = new System.Windows.Forms.PictureBox();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.Text_Buscar = new System.Windows.Forms.TextBox();
            this.Pic_Search = new System.Windows.Forms.PictureBox();
            this.Panel_Tabla = new System.Windows.Forms.Panel();
            this.Tabla_Autobuses = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txt_Color = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Año = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_T = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_S = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Search)).BeginInit();
            this.Panel_Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Autobuses)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Panel_Top.Controls.Add(this.Icon_Minimize);
            this.Panel_Top.Controls.Add(this.Title);
            this.Panel_Top.Controls.Add(this.Icon_Exit);
            this.Panel_Top.Controls.Add(this.Pic_Logo);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(926, 67);
            this.Panel_Top.TabIndex = 2;
            this.Panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseDown);
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Minimize.Image")));
            this.Icon_Minimize.Location = new System.Drawing.Point(817, 8);
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
            this.Title.Size = new System.Drawing.Size(179, 37);
            this.Title.TabIndex = 2;
            this.Title.Text = "- AUTOBUSES";
            // 
            // Icon_Exit
            // 
            this.Icon_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Exit.Image")));
            this.Icon_Exit.Location = new System.Drawing.Point(867, 8);
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
            // Panel_Search
            // 
            this.Panel_Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel_Search.Controls.Add(this.Text_Buscar);
            this.Panel_Search.Controls.Add(this.Pic_Search);
            this.Panel_Search.Location = new System.Drawing.Point(6, 79);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(261, 36);
            this.Panel_Search.TabIndex = 9;
            // 
            // Text_Buscar
            // 
            this.Text_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Buscar.Location = new System.Drawing.Point(38, 3);
            this.Text_Buscar.Multiline = true;
            this.Text_Buscar.Name = "Text_Buscar";
            this.Text_Buscar.Size = new System.Drawing.Size(220, 30);
            this.Text_Buscar.TabIndex = 1;
            this.Text_Buscar.TextChanged += new System.EventHandler(this.Text_Buscar_TextChanged);
            // 
            // Pic_Search
            // 
            this.Pic_Search.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Search.Image")));
            this.Pic_Search.Location = new System.Drawing.Point(0, 0);
            this.Pic_Search.Name = "Pic_Search";
            this.Pic_Search.Size = new System.Drawing.Size(45, 36);
            this.Pic_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_Search.TabIndex = 0;
            this.Pic_Search.TabStop = false;
            // 
            // Panel_Tabla
            // 
            this.Panel_Tabla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_Tabla.Controls.Add(this.Tabla_Autobuses);
            this.Panel_Tabla.Location = new System.Drawing.Point(5, 141);
            this.Panel_Tabla.Name = "Panel_Tabla";
            this.Panel_Tabla.Size = new System.Drawing.Size(664, 351);
            this.Panel_Tabla.TabIndex = 10;
            // 
            // Tabla_Autobuses
            // 
            this.Tabla_Autobuses.AllowUserToAddRows = false;
            this.Tabla_Autobuses.AllowUserToDeleteRows = false;
            this.Tabla_Autobuses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Autobuses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Tabla_Autobuses.BackgroundColor = System.Drawing.Color.White;
            this.Tabla_Autobuses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_Autobuses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Tabla_Autobuses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Autobuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Tabla_Autobuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Autobuses.ColumnHeadersVisible = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla_Autobuses.DefaultCellStyle = dataGridViewCellStyle14;
            this.Tabla_Autobuses.GridColor = System.Drawing.Color.LightGray;
            this.Tabla_Autobuses.Location = new System.Drawing.Point(3, 3);
            this.Tabla_Autobuses.Name = "Tabla_Autobuses";
            this.Tabla_Autobuses.ReadOnly = true;
            this.Tabla_Autobuses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_Autobuses.RowHeadersVisible = false;
            this.Tabla_Autobuses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Autobuses.Size = new System.Drawing.Size(658, 345);
            this.Tabla_Autobuses.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label5.Location = new System.Drawing.Point(480, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "COLOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(362, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "PLACA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(240, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "MODELO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(93, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "MARCA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "COD";
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Eliminar.BorderRadius = 7;
            this.BTN_Eliminar.ButtonText = "Eliminar";
            this.BTN_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Eliminar.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Eliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Eliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Eliminar.Iconimage")));
            this.BTN_Eliminar.Iconimage_right = null;
            this.BTN_Eliminar.Iconimage_right_Selected = null;
            this.BTN_Eliminar.Iconimage_Selected = null;
            this.BTN_Eliminar.IconMarginLeft = 0;
            this.BTN_Eliminar.IconMarginRight = 0;
            this.BTN_Eliminar.IconRightVisible = true;
            this.BTN_Eliminar.IconRightZoom = 0D;
            this.BTN_Eliminar.IconVisible = true;
            this.BTN_Eliminar.IconZoom = 65D;
            this.BTN_Eliminar.IsTab = false;
            this.BTN_Eliminar.Location = new System.Drawing.Point(487, 509);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Eliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Eliminar.selected = false;
            this.BTN_Eliminar.Size = new System.Drawing.Size(158, 36);
            this.BTN_Eliminar.TabIndex = 56;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Eliminar.Textcolor = System.Drawing.Color.White;
            this.BTN_Eliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Editar.BorderRadius = 7;
            this.BTN_Editar.ButtonText = "Editar";
            this.BTN_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Editar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Editar.Iconimage")));
            this.BTN_Editar.Iconimage_right = null;
            this.BTN_Editar.Iconimage_right_Selected = null;
            this.BTN_Editar.Iconimage_Selected = null;
            this.BTN_Editar.IconMarginLeft = 0;
            this.BTN_Editar.IconMarginRight = 0;
            this.BTN_Editar.IconRightVisible = true;
            this.BTN_Editar.IconRightZoom = 0D;
            this.BTN_Editar.IconVisible = true;
            this.BTN_Editar.IconZoom = 64D;
            this.BTN_Editar.IsTab = false;
            this.BTN_Editar.Location = new System.Drawing.Point(267, 509);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Editar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Editar.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Editar.selected = false;
            this.BTN_Editar.Size = new System.Drawing.Size(158, 36);
            this.BTN_Editar.TabIndex = 55;
            this.BTN_Editar.Text = "Editar";
            this.BTN_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Editar.Textcolor = System.Drawing.Color.White;
            this.BTN_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Nuevo
            // 
            this.BTN_Nuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Nuevo.BorderRadius = 7;
            this.BTN_Nuevo.ButtonText = "Nuevo";
            this.BTN_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Nuevo.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Nuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Nuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Nuevo.Iconimage")));
            this.BTN_Nuevo.Iconimage_right = null;
            this.BTN_Nuevo.Iconimage_right_Selected = null;
            this.BTN_Nuevo.Iconimage_Selected = null;
            this.BTN_Nuevo.IconMarginLeft = 0;
            this.BTN_Nuevo.IconMarginRight = 0;
            this.BTN_Nuevo.IconRightVisible = true;
            this.BTN_Nuevo.IconRightZoom = 0D;
            this.BTN_Nuevo.IconVisible = true;
            this.BTN_Nuevo.IconZoom = 65D;
            this.BTN_Nuevo.IsTab = false;
            this.BTN_Nuevo.Location = new System.Drawing.Point(32, 509);
            this.BTN_Nuevo.Name = "BTN_Nuevo";
            this.BTN_Nuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Nuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Nuevo.selected = false;
            this.BTN_Nuevo.Size = new System.Drawing.Size(158, 36);
            this.BTN_Nuevo.TabIndex = 54;
            this.BTN_Nuevo.Text = "Nuevo";
            this.BTN_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Nuevo.Textcolor = System.Drawing.Color.White;
            this.BTN_Nuevo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Nuevo.Click += new System.EventHandler(this.BTN_Nuevo_Click);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.BTN_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Guardar.BorderRadius = 7;
            this.BTN_Guardar.ButtonText = "Guardar";
            this.BTN_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Guardar.DisabledColor = System.Drawing.Color.Gray;
            this.BTN_Guardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BTN_Guardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTN_Guardar.Iconimage")));
            this.BTN_Guardar.Iconimage_right = null;
            this.BTN_Guardar.Iconimage_right_Selected = null;
            this.BTN_Guardar.Iconimage_Selected = null;
            this.BTN_Guardar.IconMarginLeft = 0;
            this.BTN_Guardar.IconMarginRight = 0;
            this.BTN_Guardar.IconRightVisible = true;
            this.BTN_Guardar.IconRightZoom = 0D;
            this.BTN_Guardar.IconVisible = true;
            this.BTN_Guardar.IconZoom = 65D;
            this.BTN_Guardar.IsTab = false;
            this.BTN_Guardar.Location = new System.Drawing.Point(695, 509);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Guardar.selected = false;
            this.BTN_Guardar.Size = new System.Drawing.Size(200, 36);
            this.BTN_Guardar.TabIndex = 53;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Guardar.Textcolor = System.Drawing.Color.White;
            this.BTN_Guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label6.Location = new System.Drawing.Point(601, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "AÑO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.Txt_Placa);
            this.panel5.Location = new System.Drawing.Point(695, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 31);
            this.panel5.TabIndex = 67;
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Placa.Location = new System.Drawing.Point(3, 3);
            this.Txt_Placa.Multiline = true;
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.Size = new System.Drawing.Size(194, 25);
            this.Txt_Placa.TabIndex = 39;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.Txt_Color);
            this.panel6.Location = new System.Drawing.Point(695, 406);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 31);
            this.panel6.TabIndex = 66;
            // 
            // Txt_Color
            // 
            this.Txt_Color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Color.Location = new System.Drawing.Point(3, 3);
            this.Txt_Color.Multiline = true;
            this.Txt_Color.Name = "Txt_Color";
            this.Txt_Color.Size = new System.Drawing.Size(99, 25);
            this.Txt_Color.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.Txt_Modelo);
            this.panel4.Location = new System.Drawing.Point(695, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 31);
            this.panel4.TabIndex = 65;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Modelo.Location = new System.Drawing.Point(3, 3);
            this.Txt_Modelo.Multiline = true;
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(194, 25);
            this.Txt_Modelo.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.Txt_Marca);
            this.panel3.Location = new System.Drawing.Point(695, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 31);
            this.panel3.TabIndex = 64;
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Marca.Location = new System.Drawing.Point(3, 3);
            this.Txt_Marca.Multiline = true;
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(194, 25);
            this.Txt_Marca.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.Txt_Code);
            this.panel2.Location = new System.Drawing.Point(695, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 31);
            this.panel2.TabIndex = 63;
            // 
            // Txt_Code
            // 
            this.Txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Code.Enabled = false;
            this.Txt_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Code.Location = new System.Drawing.Point(3, 3);
            this.Txt_Code.Multiline = true;
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.Size = new System.Drawing.Size(83, 25);
            this.Txt_Code.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label11.Location = new System.Drawing.Point(693, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "COLOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label10.Location = new System.Drawing.Point(690, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "PLACA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label9.Location = new System.Drawing.Point(690, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "MODELO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label8.Location = new System.Drawing.Point(690, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "MARCA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label7.Location = new System.Drawing.Point(690, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "COD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Txt_Año);
            this.panel1.Location = new System.Drawing.Point(695, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 31);
            this.panel1.TabIndex = 69;
            // 
            // Txt_Año
            // 
            this.Txt_Año.BackColor = System.Drawing.Color.White;
            this.Txt_Año.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Año.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Año.Location = new System.Drawing.Point(3, 3);
            this.Txt_Año.Multiline = true;
            this.Txt_Año.Name = "Txt_Año";
            this.Txt_Año.Size = new System.Drawing.Size(98, 25);
            this.Txt_Año.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label12.Location = new System.Drawing.Point(693, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "AÑO";
            // 
            // Form
            // 
            this.Form.ElipseRadius = 7;
            this.Form.TargetControl = this;
            // 
            // Panel_T
            // 
            this.Panel_T.ElipseRadius = 7;
            this.Panel_T.TargetControl = this.Panel_Tabla;
            // 
            // Panel_S
            // 
            this.Panel_S.ElipseRadius = 7;
            this.Panel_S.TargetControl = this.Panel_Search;
            // 
            // Form_Add_Autobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(926, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Nuevo);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel_Tabla);
            this.Controls.Add(this.Panel_Search);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add_Autobuses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Autobuses";
            this.Load += new System.EventHandler(this.Form_Add_Autobuses_Load);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Search)).EndInit();
            this.Panel_Tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Autobuses)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Icon_Exit;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Panel Panel_Search;
        private System.Windows.Forms.TextBox Text_Buscar;
        private System.Windows.Forms.PictureBox Pic_Search;
        private System.Windows.Forms.Panel Panel_Tabla;
        private System.Windows.Forms.DataGridView Tabla_Autobuses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txt_Placa;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Txt_Color;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Año;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuElipse Form;
        private Bunifu.Framework.UI.BunifuElipse Panel_T;
        private Bunifu.Framework.UI.BunifuElipse Panel_S;
    }
}