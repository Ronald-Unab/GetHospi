using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetHospi.Model;

namespace GetHospi.Vista
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {

            InitializeComponent();
        }
        void cargardatos()

        {

            {
                using (GetHospiEntities con = new GetHospiEntities())
                    dgvUsuariosU.DataSource = con.Usuarios.ToList();
            }

        }
        void Limpiardatos ()
        {
            txtDireccionU.Clear();
            txtNombreU.Clear();
            txtPassU.Clear();
            txtUserU.Clear();
            txtNitU.Clear();
            txtDuiU.Clear();

        }
        Usuarios U = new Usuarios();

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
            
        {
            groupBox1.Enabled = false;
            btnGuardarM.Enabled = false;
            btnEliminarM.Enabled = false;
            btnActualizarM.Enabled = false;
            cargardatos();
        }

        

        private void btnGuardarM_Click(object sender, EventArgs e)

        {

            using (GetHospiEntities con = new GetHospiEntities())
                {
                  
                    U.Nombre = txtNombreU.Text;
                    U.Direccion = txtDireccionU.Text;
                    U.Nit = txtNitU.Text;
                    U.Dui = txtDuiU.Text;
                    U.Usuario = txtUserU.Text;
                    U.Clave = txtPassU.Text;
                    U.Fecha = Convert.ToDateTime(dtFechaU.Text);
                    con.Usuarios.Add(U);
                    con.SaveChanges();
                    MessageBox.Show("Se ha guardado el nuevo usuario con exito");
                Limpiardatos();
                cargardatos();
                }
           
            }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                String Id = dgvUsuariosU.CurrentRow.Cells[0].Value.ToString();
                U = con.Usuarios.Find(int.Parse(Id));
                con.Usuarios.Remove(U);
                con.SaveChanges();
                MessageBox.Show("Se han eliminado los datos seleccionados");
            }
            cargardatos();
            Limpiardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnActualizarM.Enabled = true;
            btnEliminarM.Enabled = true;
            btnGuardarM.Enabled = true;
            btnNuevoU.Enabled = false;

            cargardatos();
            Limpiardatos();
        }

        private void btnActualizarM_Click(object sender, EventArgs e)
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                String Id = dgvUsuariosU.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                U = con.Usuarios.Where(VerificarID => VerificarID.IdUsuarios == Idc).First();
                U.Nombre = txtNombreU.Text;
                U.Direccion = txtDireccionU.Text;
                U.Dui = txtDuiU.Text;
                U.Nit = txtNitU.Text;
                U.Usuario = txtUserU.Text;                
                U.Clave = txtPassU.Text;
                U.Fecha = Convert.ToDateTime(dtFechaU.Text);       
                con.Entry(U).State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
                MessageBox.Show("Se han actualizado los datos del usuario seleccionado");
            }
            cargardatos();
            Limpiardatos();
        }

        private void dgvUsuariosU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dgvUsuariosU.CurrentRow.Cells[1].Value.ToString();
            String Direccion = dgvUsuariosU.CurrentRow.Cells[2].Value.ToString();
            String Dui = dgvUsuariosU.CurrentRow.Cells[3].Value.ToString();
            String Nit = dgvUsuariosU.CurrentRow.Cells[4].Value.ToString();
            String Usuario = dgvUsuariosU.CurrentRow.Cells[5].Value.ToString();
            String Clave = dgvUsuariosU.CurrentRow.Cells[6].Value.ToString();
            txtNombreU.Text = Nombre;
            txtDireccionU.Text = Direccion;
            txtDuiU.Text = Dui;
            txtNitU.Text = Nit;
            txtUserU.Text = Usuario;
            txtPassU.Text = Clave;
            
        }
    }
}

