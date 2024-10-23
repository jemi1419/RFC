/*
 * Created by SharpDevelop.
 * User: CC2-PC07
 * Date: 22/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtn = new System.Windows.Forms.TextBox();
			this.txta1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txta2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtf = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.RFC = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1er Semestre",
									"2do Semestre",
									"3er Semestre",
									"4to Semestre",
									"5to Semestre",
									"6yo Semestre"});
			this.comboBox1.Location = new System.Drawing.Point(369, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// txtn
			// 
			this.txtn.AcceptsReturn = true;
			this.txtn.Location = new System.Drawing.Point(192, 40);
			this.txtn.Name = "txtn";
			this.txtn.Size = new System.Drawing.Size(100, 20);
			this.txtn.TabIndex = 2;
			// 
			// txta1
			// 
			this.txta1.AcceptsReturn = true;
			this.txta1.Location = new System.Drawing.Point(192, 76);
			this.txta1.Name = "txta1";
			this.txta1.Size = new System.Drawing.Size(100, 20);
			this.txta1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Apellido1";
			// 
			// txta2
			// 
			this.txta2.AcceptsReturn = true;
			this.txta2.Location = new System.Drawing.Point(192, 110);
			this.txta2.Name = "txta2";
			this.txta2.Size = new System.Drawing.Size(100, 20);
			this.txta2.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Apellido2";
			// 
			// txtf
			// 
			this.txtf.AcceptsReturn = true;
			this.txtf.Location = new System.Drawing.Point(192, 148);
			this.txtf.Name = "txtf";
			this.txtf.Size = new System.Drawing.Size(100, 20);
			this.txtf.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(165, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Fecha de nacimiento dd/mm/aa";
			// 
			// RFC
			// 
			this.RFC.Location = new System.Drawing.Point(399, 278);
			this.RFC.Name = "RFC";
			this.RFC.Size = new System.Drawing.Size(75, 23);
			this.RFC.TabIndex = 9;
			this.RFC.Text = "RFC";
			this.RFC.UseVisualStyleBackColor = true;
			this.RFC.Click += new System.EventHandler(this.RFCClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 364);
			this.Controls.Add(this.RFC);
			this.Controls.Add(this.txtf);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txta2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txta1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "MainForm";
			this.Text = "RFC";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button RFC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtf;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txta2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txta1;
		private System.Windows.Forms.TextBox txtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
