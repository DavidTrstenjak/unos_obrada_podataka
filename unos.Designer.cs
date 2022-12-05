namespace LINQ_XML_dokumenti
{
    partial class unos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxGodRod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUNESI = new System.Windows.Forms.Button();
            this.snimiNoviDokument = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(12, 42);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(231, 20);
            this.textBoxIme.TabIndex = 0;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(12, 116);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(231, 20);
            this.textBoxPrezime.TabIndex = 1;
            // 
            // textBoxGodRod
            // 
            this.textBoxGodRod.Location = new System.Drawing.Point(12, 194);
            this.textBoxGodRod.Name = "textBoxGodRod";
            this.textBoxGodRod.Size = new System.Drawing.Size(231, 20);
            this.textBoxGodRod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesi ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unesi prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unesi godinu rođenja";
            // 
            // buttonUNESI
            // 
            this.buttonUNESI.Location = new System.Drawing.Point(329, 145);
            this.buttonUNESI.Name = "buttonUNESI";
            this.buttonUNESI.Size = new System.Drawing.Size(140, 69);
            this.buttonUNESI.TabIndex = 6;
            this.buttonUNESI.Text = "UNESI";
            this.buttonUNESI.UseVisualStyleBackColor = true;
            this.buttonUNESI.Click += new System.EventHandler(this.buttonUNESI_Click);
            // 
            // snimiNoviDokument
            // 
            this.snimiNoviDokument.DefaultExt = "xml";
            this.snimiNoviDokument.InitialDirectory = "C\\";
            this.snimiNoviDokument.Title = "Novi dokument";
            // 
            // unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 265);
            this.Controls.Add(this.buttonUNESI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGodRod);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Name = "unos";
            this.Text = "unos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxGodRod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUNESI;
        private System.Windows.Forms.SaveFileDialog snimiNoviDokument;
    }
}