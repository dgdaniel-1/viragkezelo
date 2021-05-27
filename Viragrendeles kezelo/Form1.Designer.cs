
namespace Viragrendeles_kezelo
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
            this.viragfajtaBtn = new System.Windows.Forms.Button();
            this.rendeleskezeloBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viragfajtaBtn
            // 
            this.viragfajtaBtn.Location = new System.Drawing.Point(59, 286);
            this.viragfajtaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viragfajtaBtn.Name = "viragfajtaBtn";
            this.viragfajtaBtn.Size = new System.Drawing.Size(245, 30);
            this.viragfajtaBtn.TabIndex = 0;
            this.viragfajtaBtn.Text = "Elérhető virágok";
            this.viragfajtaBtn.UseVisualStyleBackColor = true;
            this.viragfajtaBtn.Click += new System.EventHandler(this.viragfajtaBtn_Click);
            // 
            // rendeleskezeloBtn
            // 
            this.rendeleskezeloBtn.Location = new System.Drawing.Point(59, 332);
            this.rendeleskezeloBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rendeleskezeloBtn.Name = "rendeleskezeloBtn";
            this.rendeleskezeloBtn.Size = new System.Drawing.Size(245, 30);
            this.rendeleskezeloBtn.TabIndex = 1;
            this.rendeleskezeloBtn.Text = "Rendeléskezelő";
            this.rendeleskezeloBtn.UseVisualStyleBackColor = true;
            this.rendeleskezeloBtn.Click += new System.EventHandler(this.rendeleskezeloBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Viragrendeles_kezelo.Properties.Resources._1148229_200;
            this.pictureBox1.Location = new System.Drawing.Point(83, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 197);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üdvözlöm! A következő menüpontok közül választhat:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(371, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rendeleskezeloBtn);
            this.Controls.Add(this.viragfajtaBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Virágkezelő";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viragfajtaBtn;
        private System.Windows.Forms.Button rendeleskezeloBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

