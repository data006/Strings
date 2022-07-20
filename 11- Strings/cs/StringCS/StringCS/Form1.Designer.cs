namespace StringCS
{
	partial class StringCS
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtSttring = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtSttring
			// 
			this.txtSttring.Location = new System.Drawing.Point(50, 40);
			this.txtSttring.Name = "txtSttring";
			this.txtSttring.Size = new System.Drawing.Size(100, 20);
			this.txtSttring.TabIndex = 1;
			this.txtSttring.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSttring_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Introduce una String y da Enter";
			// 
			// StringCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(348, 94);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSttring);
			this.Name = "StringCS";
			this.Text = "String";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.TextBox txtSttring;
		private System.Windows.Forms.Label label1;
	}
}

