
namespace Viragrendeles_kezelo
{
    partial class Viraghozzaadas
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
            this.viragarTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viragnevTxb = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.megsemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viragarTxb
            // 
            this.viragarTxb.Location = new System.Drawing.Point(107, 55);
            this.viragarTxb.Name = "viragarTxb";
            this.viragarTxb.Size = new System.Drawing.Size(162, 22);
            this.viragarTxb.TabIndex = 2;
            this.viragarTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.viragarTxb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Virag Neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Virag Ara (Ft)";
            // 
            // viragnevTxb
            // 
            this.viragnevTxb.Location = new System.Drawing.Point(107, 13);
            this.viragnevTxb.Name = "viragnevTxb";
            this.viragnevTxb.Size = new System.Drawing.Size(162, 22);
            this.viragnevTxb.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(27, 92);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(116, 28);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // megsemBtn
            // 
            this.megsemBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.megsemBtn.Location = new System.Drawing.Point(149, 92);
            this.megsemBtn.Name = "megsemBtn";
            this.megsemBtn.Size = new System.Drawing.Size(116, 28);
            this.megsemBtn.TabIndex = 4;
            this.megsemBtn.Text = "Megsem";
            this.megsemBtn.UseVisualStyleBackColor = true;
            // 
            // Viraghozzaadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 132);
            this.Controls.Add(this.megsemBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.viragnevTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viragarTxb);
            this.Name = "Viraghozzaadas";
            this.Text = "Viraghozzaadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox viragarTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox viragnevTxb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button megsemBtn;
    }
}