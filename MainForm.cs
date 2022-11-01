/*
 * Criado por SharpDevelop.
 * Usuário: José Roberto
 * Data: 18/10/2022
 * Hora: 21:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_Do_Dado13
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		void inicio()
		{
			pictureBox5.Enabled = true;
			pictureBox6.Enabled = true;
			pictureBox7.Enabled = true;
			string normal = "0";
			pictureBox7.Load("ponto.jpg");
			pictureBox6.Load("ponto.jpg");
			pictureBox5.Load("ponto.jpg");
			pictureBox4.Load("ponto.jpg");
			pictureBox3.Load("ponto.jpg");
			pictureBox2.Load("ponto.jpg");
			pictureBox1.Load("ponto.jpg");
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			label2.Text = normal;
			label1.Text = normal;
		}
		public MainForm()
		{
			InitializeComponent();
		}
		int n6;
		int n7;
		Random rnd = new Random();
		void Button1Click(object sender, EventArgs e)
		{
			inicio();
			button3.Visible = false;
			button2.Visible = true;
			button1.Visible = false;
			int n2 = rnd.Next(1,7);
			int n1 = rnd.Next(1,7);
			pictureBox3.Load("dado" + n1 + ".png");
			pictureBox4.Load("dado" + n2 + ".png");
			n6 = rnd.Next(1,7);
			n7 = rnd.Next(1,7);
			int soma = n2 + n1;
			label2.Text = soma.ToString();
			
		}
		void PictureBox5Click(object sender, EventArgs e)
		{
			int placarC = int.Parse(label8.Text);
			int placarP = int.Parse(label9.Text);
			pictureBox5.Enabled = false;
			int n3 = rnd.Next(1,7);
			pictureBox5.Load("dado" + n3 + ".png");
			int soma = int.Parse(label2.Text) + n3;
			label2.Text = soma.ToString();
			if (soma <= 13)
			{
				pictureBox6.Visible = true;
			}
			else
			{
				placarC++;
				label8.Text = placarC.ToString();
				button2.Visible = false;
				MessageBox.Show("Estourou pato!");
				button3.Visible = true;
			}
			if (int.Parse(label8.Text) == 3)
			{
				button2.Visible = false;
				MessageBox.Show("O computador ganhou!");
			}
		}
		void PictureBox6Click(object sender, EventArgs e)
		{
			int placarC = int.Parse(label8.Text);
			int placarP = int.Parse(label9.Text);
			pictureBox6.Enabled = false;
			int n4 = rnd.Next(1,7);
			pictureBox6.Load("dado" + n4 + ".png");
			int soma = int.Parse(label2.Text) + n4;
			label2.Text = soma.ToString();
			if (soma <= 13)
			{
				pictureBox7.Visible = true;
			}
			else
			{
				placarC++;
				label8.Text = placarC.ToString();
				button2.Visible = false;
				MessageBox.Show("Estourou pato!");
				button3.Visible = true;
			}
			if (int.Parse(label8.Text) == 3)
			{
				button2.Visible = false;
				MessageBox.Show("O computador ganhou!");
			}
		}
		void PictureBox7Click(object sender, EventArgs e)
		{
			int placarC = int.Parse(label8.Text);
			int placarP = int.Parse(label9.Text);
			int n5 = rnd.Next(1,7);
			pictureBox7.Load("dado" + n5 + ".png");
			int soma = int.Parse(label2.Text) + n5;
			label2.Text = soma.ToString();
			pictureBox7.Enabled = false;
			if(soma > 13)
			{
				button2.Visible = false;
				placarC++;
				label8.Text = placarC.ToString();
				MessageBox.Show("Estourou pato!");
				button3.Visible = true;
			}
			if (int.Parse(label8.Text) == 3)
			{
				button2.Visible = false;
				MessageBox.Show("O computador ganhou!");
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			int placarC = int.Parse(label8.Text);
			int placarP = int.Parse(label9.Text);
			button2.Visible = false;
			n6 = rnd.Next(4,7);
			n7 = rnd.Next(4,7);
			int soma = n7 + n6;
			pictureBox1.Load("dado" + n6 + ".png");
			pictureBox2.Load("dado" + n7 + ".png");
			label1.Text = soma.ToString();
			button3.Visible = true;
			if (int.Parse(label1.Text) >= int.Parse(label2.Text))
			{
				placarC++;
				label8.Text = placarC.ToString();
				MessageBox.Show("Perdeu pato");
			}
			else
			{
				placarP++;
				label9.Text = placarP.ToString();
				MessageBox.Show("Você ganhou!!");
			}
			if (int.Parse(label8.Text) == 3)
			{
				MessageBox.Show("O computador ganhou!");
			}
			if (int.Parse(label9.Text) == 3)
			{
				MessageBox.Show("Parabéns, vc venceu de uma máquina");
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			inicio();
			button3.Visible = false;
			button2.Visible = false;
			button1.Visible = true;
			if (int.Parse(label8.Text) == 3)
			{
				label8.Text = "0";
				label9.Text = "0";
			}
			if (int.Parse(label9.Text) == 3)
			{
				label8.Text = "0";
				label9.Text = "0";
			}
		}
		
	}
}
