using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'betaMartDataSet.Beta_Mart' table. You can move, or remove it, as needed.
            this.beta_MartTableAdapter.Fill(this.betaMartDataSet.Beta_Mart);
            betaMartBindingSource.DataSource = this.betaMartDataSet.Beta_Mart;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaMartBindingSource.ResetBindings(false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.betaMartDataSet.Beta_Mart.AddBeta_MartRow(this.betaMartDataSet.Beta_Mart.NewBeta_MartRow());
                betaMartBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaMartBindingSource.ResetBindings(false);

            }
        
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaMartBindingSource.ResetBindings(false);
            }
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.betaMartDataSet.Beta_Mart.AddBeta_MartRow(this.betaMartDataSet.Beta_Mart.NewBeta_MartRow());
                betaMartBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaMartBindingSource.ResetBindings(false);

            }

        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            betaMartBindingSource.ResetBindings(false);

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                betaMartBindingSource.EndEdit();
                beta_MartTableAdapter.Update(this.betaMartDataSet.Beta_Mart);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betaMartBindingSource.ResetBindings(false);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Yakin Ingin Menghapus Produk Ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    betaMartBindingSource.RemoveCurrent();
                betaMartBindingSource.EndEdit();
                beta_MartTableAdapter.Update(this.betaMartDataSet.Beta_Mart);
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Produk Ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                betaMartBindingSource.RemoveCurrent();
                beta_MartTableAdapter.Update(this.betaMartDataSet.Beta_Mart);
                betaMartBindingSource.EndEdit();
                betaMartBindingSource.ResetBindings(false);
            }
        }
    }
}
    