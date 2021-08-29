namespace Capa_Presentacion
{
    partial class Form_Add_Rutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Rutas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Icon_Exit = new System.Windows.Forms.PictureBox();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.Text_Buscar = new System.Windows.Forms.TextBox();
            this.Pic_Search = new System.Windows.Forms.PictureBox();
            this.Panel_Tabla = new System.Windows.Forms.Panel();
            this.Tabla_Rutas = new System.Windows.Forms.DataGridView();
            this.BTN_Eliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Nuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTN_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.Panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Search)).BeginInit();
            this.Panel_Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Rutas)).BeginInit();
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
            this.Title.Size = new System.Drawing.Size(113, 37);
            this.Title.TabIndex = 2;
            this.Title.Text = "- RUTAS";
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
            this.Panel_Tabla.Controls.Add(this.Tabla_Rutas);
            this.Panel_Tabla.Location = new System.Drawing.Point(5, 141);
            this.Panel_Tabla.Name = "Panel_Tabla";
            this.Panel_Tabla.Size = new System.Drawing.Size(664, 351);
            this.Panel_Tabla.TabIndex = 10;
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
            this.Tabla_Rutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Rutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.Tabla_Rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Rutas.ColumnHeadersVisible = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla_Rutas.DefaultCellStyle = dataGridViewCellStyle22;
            this.Tabla_Rutas.GridColor = System.Drawing.Color.LightGray;
            this.Tabla_Rutas.Location = new System.Drawing.Point(3, 3);
            this.Tabla_Rutas.Name = "Tabla_Rutas";
            this.Tabla_Rutas.ReadOnly = true;
            this.Tabla_Rutas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_Rutas.RowHeadersVisible = false;
            this.Tabla_Rutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Rutas.Size = new System.Drawing.Size(658, 345);
            this.Tabla_Rutas.TabIndex = 0;
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
            this.BTN_Eliminar.Location = new System.Drawing.Point(483, 498);
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
            this.BTN_Editar.Location = new System.Drawing.Point(263, 498);
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
            this.BTN_Nuevo.Location = new System.Drawing.Point(28, 498);
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
            this.BTN_Guardar.Location = new System.Drawing.Point(691, 498);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(327, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "CODIGO.POSTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(117, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "RUTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(5, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "COD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(471, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "CIUDAD";
            // 
            // Form_Add_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(926, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Nuevo);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.Panel_Tabla);
            this.Controls.Add(this.Panel_Search);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add_Rutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Rutas";
            this.Load += new System.EventHandler(this.Form_Add_Rutas_Load);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Search)).EndInit();
            this.Panel_Tabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Rutas)).EndInit();
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
        private System.Windows.Forms.DataGridView Tabla_Rutas;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Eliminar;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Editar;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Nuevo;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}