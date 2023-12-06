using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineIS
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }
        //hhm
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Statistika_Load(object sender, EventArgs e)
        {
            //parodom skaicius
            STUDENTAS studentas = new STUDENTAS();
            double visiStud = Convert.ToDouble(studentas.VisiStud());
            double VyraiStud = Convert.ToDouble(studentas.VyrStud());
            double MoterysStud = Convert.ToDouble(studentas.MotStud());
            double NeStud = Convert.ToDouble(studentas.NeStud());

            //sskaiciuojam %

            double VyraiProc = VyraiStud * 100 / visiStud;
            double MoterysProc = MoterysStud * 100 / visiStud;
            double NeProc = NeStud * 100 / visiStud;

            label1Visi.Text = "Studentu kiekis:" + visiStud.ToString();
            labelVyrai.Text = "Vyrai: " + VyraiProc.ToString("0,0")+"%";
            labelMoterys.Text = "Moterys: " + MoterysProc.ToString("0,0") + "%";
            labelNesake.Text = "Nesake: " + NeProc.ToString("0,0") + "%";
        }
    }
}
