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
    public partial class Form3 : Form
    {
        private Thread _miHilo;
        private int contador;
        public Form3()
        {
            InitializeComponent();
            this.btnPausar.Click += new System.EventHandler(PausarPelotita);
            this.btnDestruir.Click += new System.EventHandler(DestruirPelotita);
            this.btnReanudar.Click += new System.EventHandler(ReanudarPelotita);
            this.contador = 0;
        }

        public void PausarPelotita(object sender, EventArgs e)
        {
            //MessageBox.Show("bien ahì");
            this._miHilo.Suspend();
        }
        public void DestruirPelotita(object sender, EventArgs e)
        {
            this._miHilo.Abort();
        }

        public void ReanudarPelotita(object sender, EventArgs e)
        {
            this._miHilo.Resume();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Thread.Pelotita pelotita = new Pelotita_Con_Thread.Pelotita(this.pictureBox1);
            this._miHilo = new Thread(pelotita.DoWork);
            this._miHilo.Start();
            this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);//Esta linea quita el manejador al boton y evita que se creen mas pelotitas
            this.contador++;
            label1.Text = this.contador.ToString();
        }
    }
}
