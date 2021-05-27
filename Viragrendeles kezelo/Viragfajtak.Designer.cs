
namespace Viragrendeles_kezelo
{
    partial class Viragfajtak
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
            this.viragokLbx = new System.Windows.Forms.ListBox();
            this.hozzaadasBtn = new System.Windows.Forms.Button();
            this.eltavolitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viragokLbx
            // 
            this.viragokLbx.FormattingEnabled = true;
            this.viragokLbx.ItemHeight = 16;
            this.viragokLbx.Location = new System.Drawing.Point(12, 12);
            this.viragokLbx.Name = "viragokLbx";
            this.viragokLbx.Size = new System.Drawing.Size(241, 276);
            this.viragokLbx.TabIndex = 0;
            // 
            // hozzaadasBtn
            // 
            this.hozzaadasBtn.Location = new System.Drawing.Point(49, 302);
            this.hozzaadasBtn.Name = "hozzaadasBtn";
            this.hozzaadasBtn.Size = new System.Drawing.Size(163, 28);
            this.hozzaadasBtn.TabIndex = 1;
            this.hozzaadasBtn.Text = "Hozzaadas";
            this.hozzaadasBtn.UseVisualStyleBackColor = true;
            this.hozzaadasBtn.Click += new System.EventHandler(this.hozzaadasBtn_Click);
            // 
            // eltavolitBtn
            // 
            this.eltavolitBtn.Location = new System.Drawing.Point(49, 337);
            this.eltavolitBtn.Name = "eltavolitBtn";
            this.eltavolitBtn.Size = new System.Drawing.Size(163, 28);
            this.eltavolitBtn.TabIndex = 2;
            this.eltavolitBtn.Text = "Eltavolitas";
            this.eltavolitBtn.UseVisualStyleBackColor = true;
            this.eltavolitBtn.Click += new System.EventHandler(this.eltavolitBtn_Click);
            // 
            // Viragfajtak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 377);
            this.Controls.Add(this.eltavolitBtn);
            this.Controls.Add(this.hozzaadasBtn);
            this.Controls.Add(this.viragokLbx);
            this.Name = "Viragfajtak";
            this.Text = "Viragfajtak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Viragfajtak_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox viragokLbx;
        private System.Windows.Forms.Button hozzaadasBtn;
        private System.Windows.Forms.Button eltavolitBtn;
    }
}