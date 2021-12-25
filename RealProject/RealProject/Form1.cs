using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Formgetir(Form a)
        {
            PnlMother.Controls.Clear();
            a.MdiParent = this;
            a.FormBorderStyle = FormBorderStyle.None;
            PnlMother.Controls.Add(a);
            a.Show();

        }
       


       

        private void SmplSorgu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Formgetir(form2);

        }

        private void SmplGrafik_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Formgetir(form3);

        }

        private void SmplYönetici_Click(object sender, EventArgs e)
        {
            BölümYönetim bölüm = new BölümYönetim();
            Formgetir(bölüm);

        }

        private void smplÖgrenciKontrol_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Formgetir(form4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

       
    }
}
