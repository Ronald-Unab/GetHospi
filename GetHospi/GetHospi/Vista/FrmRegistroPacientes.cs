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
    public partial class FrmRegistroPacientes : Form
    {
        public FrmRegistroPacientes()
        {
            InitializeComponent();
        }
        void cargardatos()
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                dgvPacientes.DataSource = con.Pacientes.ToList();
            }
        }
        void limpiar()
        {
            txtCedulaP.Clear();
            txtDireccionP.Clear();
            txtNombreP.Clear();
            txtNombreMadreP.Clear();
            txtNombrePadreP.Clear();
            txtNumRegP.Clear();
            txtTelefonoP.Clear();
            txtTipoSangreP.Clear();
        }
        Pacientes P = new Pacientes();

        private void FrmRegistroPacientes_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnActualizarP.Enabled = false;
            btnGuardarP.Enabled = false;
            btnEliminarP.Enabled = false;
            cargardatos();
        }

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnActualizarP.Enabled = true;
            btnEliminarP.Enabled = true;
            btnGuardarP.Enabled = true;
            btnNuevoP.Enabled = false;
            limpiar();
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                P.CedulaPaciente = Convert.ToInt32(txtCedulaP.Text);
                P.NumeroRegistro = Convert.ToInt32(txtNumRegP.Text);
                P.Nombre = txtNombreP.Text;
                P.Direccion = txtDireccionP.Text;
                P.Telefono = txtTelefonoP.Text;
                P.FechaNacimiento = Convert.ToDateTime(dtFechaP.Text);
                P.Sexo = cbSexoP.Text;
                P.NombrePadre = txtNombrePadreP.Text;
                P.NombreMadre = txtNombreMadreP.Text;
                P.GrupoSanguineo = txtTipoSangreP.Text;
                con.Pacientes.Add(P);
                con.SaveChanges();
                limpiar();
                cargardatos();
            }
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                String Id = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                int IdP = int.Parse(Id);
                P = con.Pacientes.Where(VerificarID => VerificarID.IdPacientes == IdP).First();
                P.CedulaPaciente = Convert.ToInt32(txtCedulaP.Text);
                P.NumeroRegistro = Convert.ToInt32(txtNumRegP.Text);
                P.Nombre = txtNombreP.Text;
                P.Direccion = txtDireccionP.Text;
                P.Telefono = txtTelefonoP.Text;
                P.FechaNacimiento = Convert.ToDateTime(dtFechaP.Text);
                P.Sexo = cbSexoP.Text;
                P.NombrePadre = txtNombrePadreP.Text;
                P.NombreMadre = txtNombreMadreP.Text;
                P.GrupoSanguineo = txtTipoSangreP.Text;
                con.Entry(P).State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
                MessageBox.Show("Se han guardado los cambios del paciente seleccionado");
                limpiar();
                cargardatos();
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                String Id = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                P = con.Pacientes.Find(int.Parse(Id));
                con.Pacientes.Remove(P);
                con.SaveChanges();
                MessageBox.Show("Se ha eliminado la seleccion con exito");
                limpiar();
                cargardatos();
            }
        }
    }
}
