namespace Biblioteka.Forms
{
    partial class UserDebtForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDebt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kara do zapłacenia:";
            // 
            // txtBoxDebt
            // 
            this.txtBoxDebt.Enabled = false;
            this.txtBoxDebt.Location = new System.Drawing.Point(138, 29);
            this.txtBoxDebt.Name = "txtBoxDebt";
            this.txtBoxDebt.Size = new System.Drawing.Size(58, 20);
            this.txtBoxDebt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "zł.";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 67);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(129, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Potwierdź wpłatę kary";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(157, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 102);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDebt);
            this.Controls.Add(this.label1);
            this.Name = "UserDebtForm";
            this.Text = "Wpłacenie kary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDebt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}