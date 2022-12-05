namespace LINQ_XML_dokumenti
{
    partial class Form1
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
            this.btnUNESI = new System.Windows.Forms.Button();
            this.btnUCITAJ = new System.Windows.Forms.Button();
            this.btnFILTRIRAJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUNESI
            // 
            this.btnUNESI.Location = new System.Drawing.Point(12, 12);
            this.btnUNESI.Name = "btnUNESI";
            this.btnUNESI.Size = new System.Drawing.Size(606, 125);
            this.btnUNESI.TabIndex = 0;
            this.btnUNESI.Text = "UNESI";
            this.btnUNESI.UseVisualStyleBackColor = true;
            this.btnUNESI.Click += new System.EventHandler(this.btnUNESI_Click);
            // 
            // btnUCITAJ
            // 
            this.btnUCITAJ.Location = new System.Drawing.Point(12, 143);
            this.btnUCITAJ.Name = "btnUCITAJ";
            this.btnUCITAJ.Size = new System.Drawing.Size(606, 125);
            this.btnUCITAJ.TabIndex = 1;
            this.btnUCITAJ.Text = "UCITAJ";
            this.btnUCITAJ.UseVisualStyleBackColor = true;
            // 
            // btnFILTRIRAJ
            // 
            this.btnFILTRIRAJ.Location = new System.Drawing.Point(12, 274);
            this.btnFILTRIRAJ.Name = "btnFILTRIRAJ";
            this.btnFILTRIRAJ.Size = new System.Drawing.Size(606, 125);
            this.btnFILTRIRAJ.TabIndex = 2;
            this.btnFILTRIRAJ.Text = "FILTRIRAJ";
            this.btnFILTRIRAJ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFILTRIRAJ);
            this.Controls.Add(this.btnUCITAJ);
            this.Controls.Add(this.btnUNESI);
            this.Name = "Form1";
            this.Text = "Manipuliranje podacima u XML datotekama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUNESI;
        private System.Windows.Forms.Button btnUCITAJ;
        private System.Windows.Forms.Button btnFILTRIRAJ;
    }
}

