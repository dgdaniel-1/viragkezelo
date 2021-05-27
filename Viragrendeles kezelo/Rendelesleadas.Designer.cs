
namespace Viragrendeles_kezelo
{
    partial class Rendelesleadas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hanydarabCbx = new System.Windows.Forms.TextBox();
            this.viragvalasztoCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aktualisarLbl = new System.Windows.Forms.Label();
            this.megsemBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kerem, adja meg, hany darabot szeretne rendelni!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kerem, valassza ki a viragot!";
            // 
            // hanydarabCbx
            // 
            this.hanydarabCbx.Location = new System.Drawing.Point(352, 63);
            this.hanydarabCbx.Name = "hanydarabCbx";
            this.hanydarabCbx.Size = new System.Drawing.Size(162, 22);
            this.hanydarabCbx.TabIndex = 5;
            this.hanydarabCbx.TextChanged += new System.EventHandler(this.hanydarabCbx_TextChanged);
            this.hanydarabCbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hanydarabCbx_KeyPress);
            // 
            // viragvalasztoCbx
            // 
            this.viragvalasztoCbx.FormattingEnabled = true;
            this.viragvalasztoCbx.Location = new System.Drawing.Point(352, 18);
            this.viragvalasztoCbx.Name = "viragvalasztoCbx";
            this.viragvalasztoCbx.Size = new System.Drawing.Size(162, 24);
            this.viragvalasztoCbx.TabIndex = 4;
            this.viragvalasztoCbx.SelectedValueChanged += new System.EventHandler(this.viragvalasztoCbx_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rendelesenek jelenlegi ara:";
            // 
            // aktualisarLbl
            // 
            this.aktualisarLbl.AutoSize = true;
            this.aktualisarLbl.Location = new System.Drawing.Point(346, 112);
            this.aktualisarLbl.Name = "aktualisarLbl";
            this.aktualisarLbl.Size = new System.Drawing.Size(0, 17);
            this.aktualisarLbl.TabIndex = 9;
            // 
            // megsemBtn
            // 
            this.megsemBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.megsemBtn.Location = new System.Drawing.Point(340, 148);
            this.megsemBtn.Name = "megsemBtn";
            this.megsemBtn.Size = new System.Drawing.Size(116, 28);
            this.megsemBtn.TabIndex = 11;
            this.megsemBtn.Text = "Megsem";
            this.megsemBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(50, 148);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(116, 28);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // Rendelesleadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 201);
            this.Controls.Add(this.megsemBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.aktualisarLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hanydarabCbx);
            this.Controls.Add(this.viragvalasztoCbx);
            this.Name = "Rendelesleadas";
            this.Text = "Rendelesleadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hanydarabCbx;
        private System.Windows.Forms.ComboBox viragvalasztoCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aktualisarLbl;
        private System.Windows.Forms.Button megsemBtn;
        private System.Windows.Forms.Button okBtn;
    }
}