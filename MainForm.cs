﻿/*
 * Created by SharpDevelop.
 * User: CC2-PC07
 * Date: 22/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RFC
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RFCClick(object sender, EventArgs e)
		{
			// se saca la primera letra del nombre
			string nom = txtn.Text.Substring(0, 1);
			// se saca las primeras dos letras del apellido
			string app = txta1.Text.Substring(0, 2);
			
			// se saca la primera letra del segundo apellido
			string apm = txta2.Text.Substring(0, 1);
			// se saca el año de nacimiento
			string an = txtf.Text.Substring(6, 2);
			// se saca el mes de nacimiento
			string ms = txtf.Text.Substring(3, 2);
			// se saca el dia de nacimiento
			string dd = txtf.Text.Substring(0,2);
			
			//se hacen mayusculas
			app = app.ToUpper();
			nom = nom.ToUpper();
			apm = apm.ToUpper();
			// se escribe el rfc
			MessageBox.Show("Su RFC es " + app + apm + nom + an + ms + dd);
			Form1 Form1 = new Form1();
			Form1.Show();
		}
	}
}
