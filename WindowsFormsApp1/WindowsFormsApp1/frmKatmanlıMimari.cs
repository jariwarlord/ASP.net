using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class frmKatmanlıMimari : Form
    {
        public frmKatmanlıMimari()
        {
            InitializeComponent();
        }
       viewPersonelBirimDAL vpbdal = new viewPersonelBirimDAL();
        BirimDAL bdal = new BirimDAL();
        public void Yenile()
        {

            dataGridView1.DataSource=vpbdal.GetList();
            cmbBirim.DataSource = bdal.GetList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vpbdal.GetList(x=>x.AdiSoyadi.Contains(txtAra.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Birimler model = new Birimler
            {
                Aciklama = "Test",
                BirimAdi ="erere",
            };
        }
    }
}
