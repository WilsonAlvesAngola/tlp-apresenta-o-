using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Jogo : Form
    {
        int xpontos = 0,opontos = 0,empates = 0, rodadas = 0 ;
        bool turno = true, jogofinal = false;
        string[] texto = new string[9];
        public Jogo()
        {
            InitializeComponent();
        }
        
        private void JogoDaVelha_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            bt5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = ""; 
            button9.Text = ""; 
          
            rodadas = 0;
            jogofinal=false;
            for(int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            int buttonindex = button1.TabIndex;

            if (button1.Text == "" && jogofinal ==false )
            {
                if (turno)
                {
                    button1.Text = "X";
                    texto[buttonindex] = button1.Text;
                    rodadas++;
                    turno = !turno;
                    Ver(1);
                }
                else
                {
                    button1.Text = "O";
                    texto[buttonindex] = button1.Text;
                    rodadas++;
                    turno = !turno;
                    Ver(2);
                }
            }
        }

       void vencendor (int ganhador)
        {
            jogofinal = true;

            if (ganhador==1) 
            {
                xpontos++;
                label3.Text = Convert.ToString(xpontos);
                MessageBox.Show("Jogador X gahou!");
                turno = true;
            }
            else
            {
                opontos++;
                label5.Text = Convert.ToString(opontos);
                MessageBox.Show("Jogador O gahou!");
                turno = false;
            }
        }


        void Ver(int checagemplayer)
        {

            string suporte = "";

            if (checagemplayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }
            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if(suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal+1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        vencendor(checagemplayer);
                        return;
                    }
                }
            }
            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        vencendor(checagemplayer);
                        return;
                    }
                }

            }
            if (texto[0] == suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    vencendor(checagemplayer);
                    return;
                }
            }
            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    vencendor(checagemplayer);
                    return;
                }
            }
            if(rodadas == 9 && jogofinal == false)
            {
                empates++;
                label4.Text=Convert.ToString(empates);

                MessageBox.Show("Empate!");
                jogofinal = true;
            }
        }
            
        
        
    }
    

}
s