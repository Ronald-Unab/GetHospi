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
using GetHospi.Vista;

namespace GetHospi
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
            
           
        {
            using (GetHospiEntities con = new GetHospiEntities())
            {
                var lista = from Usuarios in con.Usuarios
                            where Usuarios.Usuario == txtUsuarioL.Text &&
                            Usuarios.Clave == txtClave.Text
                            select Usuarios;

                if (lista.Count() > 0)
                {
                    MessageBox.Show("Bienvenido " + txtUsuarioL.Text);
                    Hide();
                    Menú M = new Menú();
                    M.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o clave no es valido, favor de verificar");
                }
                    
            }
            
                   
        }
    }
}
