using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pelotitas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Thread.Pelotita pelotita = new Pelotita_Con_Thread.Pelotita(this.pictureBox1);

            Thread NuevoHilo = new Thread(pelotita.DoWork);
            NuevoHilo.Start();
        }
    }
}
