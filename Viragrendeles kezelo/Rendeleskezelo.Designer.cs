
namespace Viragrendeles_kezelo
{
    partial class Rendeleskezelo
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
            this.rendelesekLbx = new System.Windows.Forms.ListBox();
            this.rendelestorlesBtn = new System.Windows.Forms.Button();
            this.rendelesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rendelesekLbx
            // 
            this.rendelesekLbx.FormattingEnabled = true;
            this.rendelesekLbx.ItemHeight = 16;
            this.rendelesekLbx.Location = new System.Drawing.Point(12, 12);
            this.rendelesekLbx.Name = "rendelesekLbx";
            this.rendelesekLbx.Size = new System.Drawing.Size(280, 276);
            this.rendelesekLbx.TabIndex = 1;
            // 
            // rendelestorlesBtn
            // 
            this.rendelestorlesBtn.Location = new System.Drawing.Point(69, 328);
            this.rendelestorlesBtn.Name = "rendelestorlesBtn";
            this.rendelestorlesBtn.Size = new System.Drawing.Size(163, 28);
            this.rendelestorlesBtn.TabIndex = 2;
            this.rendelestorlesBtn.Text = "Rendeles torlese";
            this.rendelestorlesBtn.UseVisualStyleBackColor = true;
            this.rendelestorlesBtn.Click += new System.EventHandler(this.rendelestorlesBtn_Click);
            // 
            // rendelesBtn
            // 
            this.rendelesBtn.Location = new System.Drawing.Point(69, 294);
            this.rendelesBtn.Name = "rendelesBtn";
            this.rendelesBtn.Size = new System.Drawing.Size(163, 28);
            this.rendelesBtn.TabIndex = 3;
            this.rendelesBtn.Text = "Rendeles leadasa";
            this.rendelesBtn.UseVisualStyleBackColor = true;
            this.rendelesBtn.Click += new System.EventHandler(this.rendelesBtn_Click);
            // 
            // Rendeleskezelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 377);
            this.Controls.Add(this.rendelesBtn);
            this.Controls.Add(this.rendelestorlesBtn);
            this.Controls.Add(this.rendelesekLbx);
            this.Name = "Rendeleskezelo";
            this.Text = "Rendeleskezelo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rendeleskezelo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rendelesekLbx;
        private System.Windows.Forms.Button rendelestorlesBtn;
        private System.Windows.Forms.Button rendelesBtn;
    }
}