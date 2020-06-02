using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetHospi.Vista;

namespace GetHospi.Vista
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void Menú_Load(object sender, EventArgs e)
        {
            
        }

        private void registrarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroMedicos frmMed = new FrmRegistroMedicos();
            frmMed.Show();
        }

       
        private void registrarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroEspecialidades frmEsp = new FrmRegistroEspecialidades();
            frmEsp.Show();
        }

        private void registrosDeArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroArchivos frmRDA = new FrmRegistroArchivos();
            frmRDA.Show();
        }

        private void registrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroPacientes frmRP = new FrmRegistroPacientes();
            frmRP.Show();
        }

        private void registrarDiagnosticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroDiagnostico frmDia = new FrmRegistroDiagnostico();
            frmDia.Show();
        }

        private void registrarConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario frmRU = new FrmRegistroUsuario();
            frmRU.Show();
        }
    }
}
