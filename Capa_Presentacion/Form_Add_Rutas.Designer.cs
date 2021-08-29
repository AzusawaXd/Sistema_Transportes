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
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Icon_Minimize = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Icon_Exit = new System.Windows.Forms.PictureBox();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Choferes_Combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Marca_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_Ciudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txt_Fecha = new System.Windows.Forms.TextBox();
            this.BTN_Guardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Ruta = new System.Windows.Forms.TextBox();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.Panel_Top.Size = new System.Drawing.Size(532, 67);
            this.Panel_Top.TabIndex = 3;
            this.Panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Top_MouseDown);
            // 
            // Icon_Minimize
            // 
            this.Icon_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Icon_Minimize.Image")));
            this.Icon_Minimize.Location = new System.Drawing.Point(417, 8);
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
            this.Icon_Exit.Location = new System.Drawing.Point(467, 8);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label7.Location = new System.Drawing.Point(23, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "COD";
            // 
            // Choferes_Combo
            // 
            this.Choferes_Combo.BackColor = System.Drawing.Color.White;
            this.Choferes_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Choferes_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choferes_Combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Choferes_Combo.FormattingEnabled = true;
            this.Choferes_Combo.Location = new System.Drawing.Point(7, 5);
            this.Choferes_Combo.Name = "Choferes_Combo";
            this.Choferes_Combo.Size = new System.Drawing.Size(121, 21);
            this.Choferes_Combo.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label8.Location = new System.Drawing.Point(23, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "CHOFERES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.Txt_Code);
            this.panel2.Location = new System.Drawing.Point(28, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 31);
            this.panel2.TabIndex = 45;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Choferes_Combo);
            this.panel1.Location = new System.Drawing.Point(28, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 30);
            this.panel1.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.Marca_Combo);
            this.panel3.Location = new System.Drawing.Point(28, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 30);
            this.panel3.TabIndex = 47;
            // 
            // Marca_Combo
            // 
            this.Marca_Combo.BackColor = System.Drawing.Color.White;
            this.Marca_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Marca_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Marca_Combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Marca_Combo.FormattingEnabled = true;
            this.Marca_Combo.Location = new System.Drawing.Point(7, 5);
            this.Marca_Combo.Name = "Marca_Combo";
            this.Marca_Combo.Size = new System.Drawing.Size(121, 21);
            this.Marca_Combo.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(23, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "MARCA AUTOBUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(278, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "RUTA";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.Txt_Ciudad);
            this.panel5.Location = new System.Drawing.Point(283, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 31);
            this.panel5.TabIndex = 51;
            // 
            // Txt_Ciudad
            // 
            this.Txt_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ciudad.Location = new System.Drawing.Point(3, 3);
            this.Txt_Ciudad.Multiline = true;
            this.Txt_Ciudad.Name = "Txt_Ciudad";
            this.Txt_Ciudad.Size = new System.Drawing.Size(231, 25);
            this.Txt_Ciudad.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(285, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "CIUDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(285, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "FECHA";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.Txt_Fecha);
            this.panel6.Location = new System.Drawing.Point(283, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(142, 31);
            this.panel6.TabIndex = 53;
            // 
            // Txt_Fecha
            // 
            this.Txt_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fecha.Location = new System.Drawing.Point(3, 3);
            this.Txt_Fecha.Multiline = true;
            this.Txt_Fecha.Name = "Txt_Fecha";
            this.Txt_Fecha.Size = new System.Drawing.Size(136, 25);
            this.Txt_Fecha.TabIndex = 33;
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
            this.BTN_Guardar.IconZoom = 55D;
            this.BTN_Guardar.IsTab = false;
            this.BTN_Guardar.Location = new System.Drawing.Point(160, 332);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.BTN_Guardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.BTN_Guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_Guardar.selected = false;
            this.BTN_Guardar.Size = new System.Drawing.Size(193, 36);
            this.BTN_Guardar.TabIndex = 55;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTN_Guardar.Textcolor = System.Drawing.Color.White;
            this.BTN_Guardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.Txt_Ruta);
            this.panel4.Location = new System.Drawing.Point(280, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 31);
            this.panel4.TabIndex = 56;
            // 
            // Txt_Ruta
            // 
            this.Txt_Ruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ruta.Location = new System.Drawing.Point(3, 3);
            this.Txt_Ruta.Multiline = true;
            this.Txt_Ruta.Name = "Txt_Ruta";
            this.Txt_Ruta.Size = new System.Drawing.Size(234, 25);
            this.Txt_Ruta.TabIndex = 33;
            // 
            // Form_Add_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(532, 380);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add_Rutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Add_Rutas";
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.PictureBox Icon_Minimize;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Icon_Exit;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton BTN_Guardar;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox Choferes_Combo;
        public System.Windows.Forms.TextBox Txt_Code;
        public System.Windows.Forms.ComboBox Marca_Combo;
        public System.Windows.Forms.TextBox Txt_Ciudad;
        public System.Windows.Forms.TextBox Txt_Fecha;
        public System.Windows.Forms.TextBox Txt_Ruta;
    }
}