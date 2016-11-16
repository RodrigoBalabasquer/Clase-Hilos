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
    public partial class Form4 : Form
    {
        private List<Thread> _hilos;
        private int contador;
        public Form4()
        {
            InitializeComponent();
            this._hilos = new List<Thread>();
            this.contador = 0;
            this.btnPausar.Click += new System.EventHandler(PausarPelotita);
            this.btnDestruir.Click += new System.EventHandler(DestruirPelotita);
            this.btnReanudar.Click += new System.EventHandler(ReanudarPelotita);
        }

        public void PausarPelotita(object sender, EventArgs e)
        {
            try
            {
                foreach (Thread item in this._hilos)
                {
                    item.Suspend();
                }
            }
            catch (Exception)
            {
                
            }
        }
        public void DestruirPelotita(object sender, EventArgs e)
        {
            try
            {
                this._hilos[this._hilos.Count - 1].Abort();
                this._hilos.RemoveAt(this._hilos.Count - 1);
                this.contador--;
                label1.Text = this.contador.ToString();
            }
            catch (Exception)
            {
                
            }
            Graphics G = this.pictureBox1.CreateGraphics();
            G.Clear(this.pictureBox1.BackColor);
        }

        public void ReanudarPelotita(object sender, EventArgs e)
        {
            try
            {
                foreach (Thread item in this._hilos)
                {
                    item.Resume();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Thread.Pelotita pelotita = new Pelotita_Con_Thread.Pelotita(this.pictureBox1);
            try
            {
                Thread Hilos = new Thread(pelotita.DoWork);
                this._hilos.Add(Hilos);
                Hilos.Start();
            }
            catch(Exception) 
            {

            }
            this.contador++;
            label1.Text = this.contador.ToString();
        }
    }
}
