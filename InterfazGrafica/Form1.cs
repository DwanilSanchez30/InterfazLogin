using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signBTN_Click(object sender, EventArgs e)
        {
            using(var con= new conEntity())
            {

                    var usEx = from us in con.Users where us.username == userTX.Text && us.passw == passTX.Text select us;
                    if(usEx.Count() > 0)
                    {
                        MessageBox.Show("La session del usuario " + userTX.Text + " se inició correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró al usuario " + userTX.Text+" : Verifique su nombre de usuario o contraseña");
                    }
                   

                

            }

        }
    }
}
