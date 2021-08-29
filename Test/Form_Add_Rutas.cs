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
//using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class Form_Add_Rutas : Form
    {
        E_Rutas objEntidad = new E_Rutas();
        N_Rutas objNegocio = new N_Rutas();

        private string IdRutas;
        private bool Edit = false;
        public Form_Add_Rutas()
        {
            InitializeComponent();
        }

        //Codigo Mover Form y Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Icon_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void mostrarBuscarTable(string buscar)
        {
            N_Rutas objNegocio = new N_Rutas();
            Tabla_Rutas.DataSource = objNegocio.ListarRutas(buscar);
        }

        private void Form_Add_Rutas_Load(object sender, EventArgs e)
        {
            mostrarBuscarTable("");
            AccionTable();
        }

        public void AccionTable()
        {
            Tabla_Rutas.ClearSelection();
            Tabla_Rutas.Columns[0].Visible = false;
            Tabla_Rutas.Columns[1].Width = 125;
            Tabla_Rutas.Columns[2].Width = 250;
            Tabla_Rutas.Columns[3].Width = 170;
            Tabla_Rutas.Columns[4].Width = 200;
        }
    }
}
