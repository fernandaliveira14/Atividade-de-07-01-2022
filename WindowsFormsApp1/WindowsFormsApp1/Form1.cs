using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class Semaforo
        {
            private byte estado;

            public Semaforo()
            {
                // com rua1 = vd e rua2 = vm - situação inicial
            }

            public void setVerde(int rua)
            {
            }

            public void setAmarelo(int rua)
            {
            }

            public void setVermelho(int rua)
            {
            }

            public byte getEstado()
            {
                return this.estado;
            }

            public int getEstado(int rua)
            {
                // 1. Vd - 2. Am - 3. Vm
                byte aux = 0;
                return aux;
            }
        }

    }
}
