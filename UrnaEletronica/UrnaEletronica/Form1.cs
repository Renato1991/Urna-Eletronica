using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UrnaEletronica
{
    public partial class Form1 : Form
    {

        int votos_poderoso = 0, votos_danilo = 0, votos_rafinha = 0, votos_cortez = 0, candidatos = 0, branco = 0, nulo = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            box.Text += "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            box.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            box.Text += "2";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            box.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            box.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            box.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            box.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            box.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources.branco;
            branco += 1;
        }

        private void Contagem_Votos_Tick(object sender, EventArgs e)
        {
            button13.Enabled = false;         
            MessageBox.Show("Votos Rafinha: "+votos_rafinha + System.Environment.NewLine +  "Votos Poderoso: " +votos_poderoso+ System.Environment.NewLine + "Votos Danilo: " +votos_danilo + System.Environment.NewLine + "Votos Cortez: " +votos_cortez + System.Environment.NewLine + "Branco: " + branco + System.Environment.NewLine + "Votos Nulo: " + nulo, "VOTAÇÃO");
            Contagem_Votos.Stop();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            box.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            box.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            box.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            candidatos = Convert.ToInt16(box.Text);

            switch (candidatos)
            {
                case 10:
                    pictureBox1.Image = Properties.Resources.castiga_eduardo;
                    votos_poderoso += 1;
                    box.Clear();
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.Danilo_Gentili;
                    votos_danilo += 1;
                    box.Clear();
                    break;
                case 20:
                    pictureBox1.Image = Properties.Resources.rafinha;
                    votos_rafinha += 1;
                    box.Clear();
                    break;
                case 25:
                    pictureBox1.Image = Properties.Resources.rafael_cortez;
                    votos_cortez += 1;
                    box.Clear();
                    break;
                default:
                    nulo++;
                    pictureBox1.Image = Properties.Resources.voto_nulo;
                    break;
            }

            
            
        }
    }
}
