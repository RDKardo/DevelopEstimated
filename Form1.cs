using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevelopEstimated
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables que se utilizan en la formula para calcular el mejor tiempo
        ///
        /// </summary>
        public int Total = 0;
        public int Mejor = 0;
        public int Peor = 0;
        public int Probable = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Calculated();
        }
        /// <summary>
        /// Calculo de la formula
        /// </summary>
        /// <returns></returns>
        public object Calculated()
        {
            Mejor = Convert.ToInt32(txtMejor.Text);
            Peor = Convert.ToInt32(txtPeor.Text);
            Probable = Convert.ToInt32(txtMp.Text);
            Total = ((Mejor + Peor + 4) * Probable) / 6;
            txtTotal.AppendText(Convert.ToString(Total));



            return Total;


        }
    }
}
