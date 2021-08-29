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
    public partial class Form_Add_Choferes : Form
    {
        E_Choferes objEntidad = new E_Choferes();
        N_Choferes objNegocio = new N_Choferes();

        private string IdChoferes;
        private bool Edit = false;

        public Form_Add_Choferes()
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
        private void Icon_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void mostrarBuscarTable(string buscar)
        {
            N_Choferes objNegocio = new N_Choferes();
            Tabla_Choferes.DataSource = objNegocio.ListarChoferes(buscar);
        }

        public void AccionTable()
        {
            Tabla_Choferes.ClearSelection();
            Tabla_Choferes.Columns[0].Visible = false;
            Tabla_Choferes.Columns[1].Width = 130;
            Tabla_Choferes.Columns[2].Width = 130;
            Tabla_Choferes.Columns[3].Width = 130;
            Tabla_Choferes.Columns[4].Width = 150;  
            
        }

        private void Form_Add_Choferes_Load(object sender, EventArgs e)
        {
            mostrarBuscarTable("");
            AccionTable();
        }

        private void Panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ClearALL()
        {
            Edit = false;
            Txt_Code.Text = "";
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Fecha.Text = "";
            Txt_Cedula.Text = "";
            Txt_Nombre.Focus();
        }
        private void BTN_Nuevo_Click(object sender, EventArgs e)
        {
            ClearALL();

        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            if(Tabla_Choferes.SelectedRows.Count >0)
            {
                Edit = true;
                IdChoferes = Tabla_Choferes.CurrentRow.Cells[0].Value.ToString();
                Txt_Code.Text = Tabla_Choferes.CurrentRow.Cells[1].Value.ToString();
                Txt_Nombre.Text = Tabla_Choferes.CurrentRow.Cells[2].Value.ToString();
                Txt_Apellido.Text = Tabla_Choferes.CurrentRow.Cells[3].Value.ToString();
                Txt_Fecha.Text = Tabla_Choferes.CurrentRow.Cells[4].Value.ToString();
                Txt_Cedula.Text = Tabla_Choferes.CurrentRow.Cells[5].Value.ToString();
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

        private void BTN_Guardar_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {
                    objEntidad.Nombre = Txt_Nombre.Text.ToUpper();
                    objEntidad.Apellido = Txt_Apellido.Text.ToUpper();
                    objEntidad.FechaNacimiento = Txt_Fecha.Text.ToUpper();
                    objEntidad.Cedula = Txt_Cedula.Text.ToUpper();

                    objNegocio.InsertarChoferes(objEntidad);

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
                    objEntidad.IdChoferes = Convert.ToInt32(IdChoferes);
                    objEntidad.Nombre = Txt_Nombre.Text.ToUpper();
                    objEntidad.Apellido = Txt_Apellido.Text.ToUpper();
                    objEntidad.FechaNacimiento = Txt_Fecha.Text.ToUpper();
                    objEntidad.Cedula = Txt_Cedula.Text.ToUpper();

                    objNegocio.InsertarChoferes(objEntidad);

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

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
                objEntidad.IdChoferes = Convert.ToInt32(Tabla_Choferes.CurrentRow.Cells[0].Value.ToString());
                objNegocio.EliminarChoferesa(objEntidad);

                MessageBox.Show("El registro se elimino correctamente");
                mostrarBuscarTable("");
        }
    }
}
