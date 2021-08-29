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
    public partial class Form_Add_Autobuses : Form
    {
        E_Autobuses objEntidad = new E_Autobuses();
        N_Autobuses objNegocio = new N_Autobuses();

        private string IdAutobuses;
        private bool Edit = false;
        public Form_Add_Autobuses()
        {
            InitializeComponent();
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

        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void mostrarBuscarTable(string buscar)
        {
            N_Autobuses objNegocio = new N_Autobuses();
            Tabla_Autobuses.DataSource = objNegocio.ListarAutobuses(buscar);
        }

        public void AccionTable()
        {
            Tabla_Autobuses.ClearSelection();
            Tabla_Autobuses.Columns[0].Visible = false;
            Tabla_Autobuses.Columns[1].Width = 80;
            Tabla_Autobuses.Columns[2].Width = 150;
            Tabla_Autobuses.Columns[3].Width = 120;
            Tabla_Autobuses.Columns[4].Width = 120;
            Tabla_Autobuses.Columns[5].Width = 120;

        }

        private void Form_Add_Autobuses_Load(object sender, EventArgs e)
        {
            mostrarBuscarTable("");
            AccionTable();
        }

        private void ClearALL()
        {
            Edit = false;
            Txt_Code.Text = "";
            Txt_Marca.Text = "";
            Txt_Modelo.Text = "";
            Txt_Placa.Text = "";
            Txt_Color.Text = "";
            Txt_Año.Text = "";
            Txt_Marca.Focus();
        }

        private void BTN_Nuevo_Click(object sender, EventArgs e)
        {
            ClearALL();
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            if (Tabla_Autobuses.SelectedRows.Count > 0)
            {
                Edit = true;
                IdAutobuses = Tabla_Autobuses.CurrentRow.Cells[0].Value.ToString();
                Txt_Code.Text = Tabla_Autobuses.CurrentRow.Cells[1].Value.ToString();
                Txt_Marca.Text = Tabla_Autobuses.CurrentRow.Cells[2].Value.ToString();
                Txt_Modelo.Text = Tabla_Autobuses.CurrentRow.Cells[3].Value.ToString();
                Txt_Placa.Text = Tabla_Autobuses.CurrentRow.Cells[4].Value.ToString();
                Txt_Color.Text = Tabla_Autobuses.CurrentRow.Cells[5].Value.ToString();
                Txt_Año.Text = Tabla_Autobuses.CurrentRow.Cells[6].Value.ToString();
            }

            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void Text_Buscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTable(Text_Buscar.Text);
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            objEntidad.IdAutobuses = Convert.ToInt32(Tabla_Autobuses.CurrentRow.Cells[0].Value.ToString());
            objNegocio.EliminarAutobuses(objEntidad);

            MessageBox.Show("El registro se elimino correctamente");
            mostrarBuscarTable("");
        }

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {
                    objEntidad.Marca = Txt_Marca.Text.ToUpper();
                    objEntidad.Modelo = Txt_Modelo.Text.ToUpper();
                    objEntidad.Placa = Txt_Placa.Text.ToUpper();
                    objEntidad.Color = Txt_Color.Text.ToUpper();
                    objEntidad.Año = Txt_Año.Text.ToUpper();

                    objNegocio.InsertarAutobuses(objEntidad);

                    MessageBox.Show("Se guardo el registro!");
                    mostrarBuscarTable("");
                    ClearALL();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error");
                }
            }

            if (Edit == true)
            {
                try
                {
                    objEntidad.IdAutobuses = Convert.ToInt32(IdAutobuses);
                    objEntidad.Marca = Txt_Marca.Text.ToUpper();
                    objEntidad.Modelo = Txt_Modelo.Text.ToUpper();
                    objEntidad.Placa = Txt_Placa.Text.ToUpper();
                    objEntidad.Color = Txt_Color.Text.ToUpper();
                    objEntidad.Año = Txt_Año.Text.ToUpper();

                    objNegocio.InsertarAutobuses(objEntidad);

                    MessageBox.Show("Se edito el registro!");
                    mostrarBuscarTable("");
                    ClearALL();
                    Edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro", "Error" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
