using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class jogovelha : Form
    {
       
        public jogovelha()
        {
            InitializeComponent();
        }

        private void jogovelha_Load(object sender, EventArgs e)
        {
            but11.Click += new EventHandler(Bclick);
            but12.Click += new EventHandler(Bclick);
            but13.Click += new EventHandler(Bclick);
            but21.Click += new EventHandler(Bclick);
            but22.Click += new EventHandler(Bclick);
            but23.Click += new EventHandler(Bclick);
            but31.Click += new EventHandler(Bclick);
            but32.Click += new EventHandler(Bclick);
            but33.Click += new EventHandler(Bclick);

            label4.Text = textBox2.Text;
            label3.Text = textBox1.Text;
        }
        bool Vez= true;
        private void Bclick(object sender, EventArgs e)
        {
           Button bto = ((Button)sender);

           if (bto.Text == "")
           {
               if (Vez)
               {
                   bto.Text = "X";
                   label6.Text = " O é a sua vez";

                   Vez = false;
               }
               else
               {
                   bto.Text = "O";
                   label6.Text = "X é a sua vez";

                   Vez = true;
               }
           }

           //Horizontal
           if (but11.Text == but12.Text && but11.Text == but13.Text && but11.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else if (but21.Text == but22.Text && but21.Text == but23.Text && but21.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else if (but31.Text == but32.Text && but31.Text == but33.Text && but31.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }

          //diagonal
           else if (but11.Text == but22.Text && but11.Text == but33.Text && but11.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else if (but13.Text == but22.Text && but13.Text == but31.Text && but13.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }

          //Vertical
           else if (but11.Text == but21.Text && but11.Text == but31.Text && but11.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else if (but12.Text == but22.Text && but12.Text == but32.Text && but12.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else if (but13.Text == but23.Text && but13.Text == but33.Text && but13.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else if (but11.Text == but12.Text && but11.Text == but13.Text && but11.Text != "")
           {
               paneljogo.Enabled = false;
               MessageBox.Show("O  " + bto.Text + " é o vencedor", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
               bool empate = true;

           foreach (Control bot in this.Controls)
           {
              if (bto is Button && bto.Enabled)
              {
                   empate = false;
              }
           }
           if (empate)
           {
                  MessageBox.Show("Empate trouxa!!!");
           }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            paneljogo.Enabled = true;
            but11.Text = "";
            but12.Text = "";
            but13.Text = "";
            but21.Text = "";
            but22.Text = "";
            but23.Text = "";
            but31.Text = "";
            but32.Text = "";
            but33.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label11.Text = textBox2.Text + ", você será X";
                label12.Text = textBox3.Text + ", você será O";
            }
            else
            {
                label11.Text = textBox2.Text + ", você será O";
                label12.Text = textBox3.Text + ", você será X";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Você precisa preencher os campos", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panelescolha.Visible = false;
                label4.Text = textBox2.Text;
                label3.Text = textBox3.Text;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label13.Text = textBox2.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label11.Text = textBox2.Text + ", você será O";
                label12.Text = textBox3.Text + ", você será X";
            }
            else
            {
                label11.Text = textBox2.Text + ", você será X";
                label12.Text = textBox3.Text + ", você será O";
            }
        }
    }
}
