/*
 * Created by SharpDevelop.
 * User: Rm20222930090
 * Date: 15/08/2022
 * Time: 13:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogodaforca_alt1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		int contErros = 0;
		string palavra, aux, i;
		void Button1Click(object sender, EventArgs e)
		{
			Button bt = (sender as Button);
			bt.Enabled = false;
			char letra = bt.Text[0];
			int cont=0;
			string aux = "";

			for (int pos = 0; pos < palavra.Length; pos++)
			{
				if (letra == palavra[pos])
				{
					cont++;
					aux += letra;
				}
				else
				{
					aux += label1.Text[pos];
				}
			}
				label1.Text = aux;
				if (cont == 0)
				{
					//errou
					contErros++;
					bt.BackColor = Color.Red;
					pictureBox1.Load("forca" + contErros + ".png");
					if (contErros == 7)
					{
						//errou
						panel1.Enabled = false;
						MessageBox.Show ("PERDEUU, PLAYBOY");
						button5.Visible = true;
					}
				}
				else
				{
					//acertou 
					bt.BackColor = Color.LightGreen;
					if (label1.Text == palavra)
					{
						
						MessageBox.Show ("Você acertou!!");
						button5.Visible = true;
					}
				}
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			contErros++;
			Button bt = (sender as Button);
			this.Text = "erros: " + contErros;
			pictureBox1.Load("forca" + contErros + ".png");
			if (contErros == 7)
			{
				panel1.Enabled = false;
				MessageBox.Show (" perdeu, playboy!");
				bt.Visible = true;
			}
			else
			{
				panel1.Enabled = false;
				bt.Visible = true;
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
			Button bt = sender as Button;
			
			Button[] bot = {button1, button3, button4};
			for (int i = 0; i < 3; i++)
			{
				bot[i].BackColor = Color.White;
				bot[i].Enabled = true;
				
				pictureBox1.Load ("forca0.png");
			panel1.Visible = true;
			textBox1.Text = "";
			label1.Text = "";
			panel1.Enabled = true;
			contErros = 0;
			textBox1.Visible = true;
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			palavra = textBox1.Text;
			string aux = "";
			for (int i=0; i < palavra.Length; i++)
			{
				aux += "?";
			}
			label1.Text = aux;
		}
	}
}