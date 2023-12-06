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
    public partial class Pagrindinis : Form
    {
        public Pagrindinis()
        {
            InitializeComponent();
        }

        private void studentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemNaujasST_Click_1(object sender, EventArgs e)
        {
            PridetiST pridetiST_Load = new PridetiST();
            pridetiST_Load.Show(this);

        }

        private void MenuItemSTsar_Click(object sender, EventArgs e)
        {
            StudSar stdListF = new StudSar();
            stdListF.Show(this);
        }

        private void redaguotiStudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtnaujintIstrintStud AtStud = new AtnaujintIstrintStud();
            AtStud.Show(this);
        }

        private void MenuItemSTATS_Click(object sender, EventArgs e)
        {
            Statistika stcF = new Statistika();
            stcF.Show(this);
        }

        private void pridetiDalykaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PridetiDalyka pridDal = new PridetiDalyka();
            pridDal.Show(this);
        }

        private void istrintiDalykaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstrintiDal istrintiDal = new IstrintiDal();
            istrintiDal.Show(this);
        }

        private void redaguotiDalykaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedagDal redagDal = new RedagDal();
            redagDal.Show(this);
        }

        private void tvarkytiIvertinimusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvarkytiPAZ tvarkytipaz = new TvarkytiPAZ();
            tvarkytipaz.Show(this);
        }

        private void pRIDETIDESTYTOJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PridetiDestytoja pridetiDestytoja = new PridetiDestytoja();
            pridetiDestytoja.Show(this);
        }

        /*private void tvarkytiDalykusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDalykus manageDalykus = new ManageDalykus();
            manageDalykus.Show(this);
        }
        */
    }
}
