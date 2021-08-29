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
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class Form_Dashboard : Form
    {
        N_DashBoard objNegocio = new N_DashBoard();
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        //Codigo Mover Form y Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        /////////////////////////////////////////////////////////////////////////////////////////////

        //Cerrar la Aplicacion
        private void Icon_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimizar la Aplicaicon
        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mover Form mediante el Panel_Top
        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FH_Timer_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        //Mostrar la Tabla
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            MostrarRutas();
            HideWidthColumns();
            MostrarC();
        }

        private void BTN_Nuevo_Chofer_Click(object sender, EventArgs e)
        {
            Form Formulario_Nuevo = new Form_Add_Choferes();
            Formulario_Nuevo.Show();
            MostrarC();
        }

        private void BTN_Nuevo_Autobus_Click(object sender, EventArgs e)
        {
            Form Formulario_Nuevo = new Form_Add_Autobuses();
            Formulario_Nuevo.Show();
            MostrarC();
        }

        private void BTN_Nueva_Ruta_Click(object sender, EventArgs e)
        {
            Form Formulario_Nuevo = new Form_Add_Rutas();
            Formulario_Nuevo.Show();
            MostrarRutas();
            MostrarC();
        }

        public void HideWidthColumns()
        {
            Tabla_Rutas.Columns[3].Visible = false;
            Tabla_Rutas.Columns[5].Visible = false;
            Tabla_Rutas.Columns[0].Visible = false;

            Tabla_Rutas.Columns[1].Width = 100;
            Tabla_Rutas.Columns[2].Width = 250;

            Tabla_Rutas.Columns[4].Width = 150;
            Tabla_Rutas.Columns[6].Width = 150;
            Tabla_Rutas.Columns[7].Width = 250;
            Tabla_Rutas.Columns[8].Width = 250;
        }

        public void MostrarRutas()
        {
            N_DashBoard objNegocio = new N_DashBoard();
            Tabla_Rutas.DataSource = objNegocio.ListingRutas();
        }

        public void BuscarRutas(string search)
        {
            N_DashBoard objNegocio = new N_DashBoard();
            Tabla_Rutas.DataSource = objNegocio.SearchingRutas(search);
        }

        private void Buscar_Rutas_TextChanged(object sender, EventArgs e)
        {
            BuscarRutas(Buscar_Rutas.Text);
        }

        private void Actualizar_Tabla_Click(object sender, EventArgs e)
        {
            MostrarRutas();
            MostrarC();
        }

        public void MostrarC() 
        {
            E_DashBoard objEntidad = new E_DashBoard();
            N_DashBoard objNegocio = new N_DashBoard();
            objNegocio.ACUMULACIONES(objEntidad);
            Total_C.Text = objEntidad.Total_choferes;
            Total_A.Text = objEntidad.Total_autobuses;
            Total_R.Text = objEntidad.Total_rutas;
        }

        private void Eliminar_Tabla_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(Tabla_Rutas.CurrentRow.Cells[0].Value.ToString());
            objNegocio.EliminarRutas(delete);
            MessageBox.Show("El registro se elimino correctamente");
            MostrarRutas();
            MostrarC();
        }

        private void BTN_Exportar_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets[1];
            worksheet.Name = "Rutas";

            for (int i = 1; i < Tabla_Rutas.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Tabla_Rutas.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < Tabla_Rutas.Rows.Count; i++)
            {
                for (int j = 0; j < Tabla_Rutas.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Tabla_Rutas.Rows[i].Cells[j].Value.ToString();
                }
            }
            app.Visible = true;
        }
    }
}
