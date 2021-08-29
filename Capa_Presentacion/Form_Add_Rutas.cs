using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Form_Add_Rutas : Form
    {
        E_DashBoard objEntidad = new E_DashBoard();
        N_DashBoard objNegocio = new N_DashBoard();

        private bool Edit = false;

        public Form_Add_Rutas()
        {
            InitializeComponent();
            ListChoferes();
            ListAutobuses();
        }

        //Codigo Mover Form y Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void Icon_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ListChoferes()
        {
            N_Choferes objNegocio = new N_Choferes();
            Choferes_Combo.DataSource = objNegocio.ListarChoferes("");
            Choferes_Combo.ValueMember = "IdChoferes";
            Choferes_Combo.DisplayMember = "Nombre";
        }

        public void ListAutobuses()
        {
            N_Autobuses objNegocio = new N_Autobuses();
            Marca_Combo.DataSource = objNegocio.ListarAutobuses("");
            Marca_Combo.ValueMember = "IdAutobuses";
            Marca_Combo.DisplayMember = "Marca";
        }

        private void ClearALL()
        {
            Edit = false;
            Txt_Code.Text = "";
            Txt_Ruta.Text = "";
            Txt_Ciudad.Text = "";
            Txt_Fecha.Text = "";
            Choferes_Combo.Text = "";
            Marca_Combo.Text = "";
            Txt_Ruta.Focus();
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {
                    objEntidad.Ruta = Txt_Ruta.Text;
                    objEntidad.Ciudad = Txt_Ciudad.Text;
                    objEntidad.Fecha = Txt_Fecha.Text;
                    objEntidad.IdChoferes = Convert.ToInt32(Choferes_Combo.SelectedValue);
                    objEntidad.IdAutobuses = Convert.ToInt32(Marca_Combo.SelectedValue);

                    objNegocio.InsertarRutas(objEntidad);
                    MessageBox.Show("Se guardo el registro!");
                    ClearALL();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if (Edit == true)
            {
                try
                {
                    objEntidad.IdRutas = Convert.ToInt32(Txt_Code);
                    objEntidad.Ruta = Txt_Ruta.Text;
                    objEntidad.Ciudad = Txt_Ciudad.Text;
                    objEntidad.Fecha = Txt_Fecha.Text;
                    objEntidad.IdChoferes = Convert.ToInt32(Choferes_Combo.SelectedValue);
                    objEntidad.IdAutobuses = Convert.ToInt32(Marca_Combo.SelectedValue);

                    objNegocio.InsertarRutas(objEntidad);

                    MessageBox.Show("Se edito el registro!");
                    ClearALL();
                    Edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro" + ex);
                }
            }
        }
    }
}
