using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace StringCS
{
	public partial class StringCS : Form
	{

		private int cantPalabras;
		private int cantVocales;
		private int cantConsonantes;
		private int cantEspacios;
		private int cantSimbolos;
		private int cantNumeros;



		public StringCS()
		{
			InitializeComponent();
		}

		private void txtSttring_KeyUp(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Enter)
			{
				cantVocales = 0;
				cantPalabras = 0;
				cantNumeros = 0;
				cantConsonantes = 0;
				cantEspacios = 0;
				cantSimbolos = 0;
				var palabras = txtSttring.Text.Split(' ');
				foreach (string palabra in palabras)
				{
					cantPalabras = cantPalabras + 1;
					foreach (char letra in palabra)
					{
						if (LikeOperator.LikeString(Conversions.ToString(letra), "[0-9]", CompareMethod.Binary))
						{
							cantNumeros = cantNumeros + 1;
						}
						else if (LikeOperator.LikeString(Conversions.ToString(letra), "[aeiou,AEIOU]", CompareMethod.Binary))
						{
							cantVocales = cantVocales + 1;
						}
						else if (LikeOperator.LikeString(Conversions.ToString(letra), "[QqWwRrTtYyPpSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm]", CompareMethod.Binary))
						{
							cantConsonantes = cantConsonantes + 1;
						}
						else
						{
							cantSimbolos = cantSimbolos + 1;
						}
					}
				}

				foreach (char letra in txtSttring.Text)
				{
					if (LikeOperator.LikeString(Conversions.ToString(letra), " ", CompareMethod.Binary))
					{
						cantEspacios = cantEspacios + 1;
					}
				}

				MessageBox.Show("Cantidad de palabras: " + Conversions.ToString(cantPalabras) + Constants.vbCrLf + "Cantidad de vocales: " + Conversions.ToString(cantVocales) + Constants.vbCrLf + "Cantidad de consonantes: " + Conversions.ToString(cantConsonantes) + Constants.vbCrLf + "Cantidad de numeros: " + Conversions.ToString(cantNumeros) + Constants.vbCrLf + "Cantidad de simbolos: " + Conversions.ToString(cantSimbolos) + Constants.vbCrLf + "Cantidad de espacios: " + Conversions.ToString(cantEspacios));
			}

		}
	}
}
