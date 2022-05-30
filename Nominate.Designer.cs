
namespace Kek
{
    partial class Nominate
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuantityVar = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            this.labelFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Промаркируйте все варианты вводя названия через запятую.";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 32);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(511, 23);
            this.textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество вариантов: ";
            // 
            // labelQuantityVar
            // 
            this.labelQuantityVar.AutoSize = true;
            this.labelQuantityVar.Location = new System.Drawing.Point(499, 13);
            this.labelQuantityVar.Name = "labelQuantityVar";
            this.labelQuantityVar.Size = new System.Drawing.Size(25, 15);
            this.labelQuantityVar.TabIndex = 3;
            this.labelQuantityVar.Text = "000";
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bReset.Location = new System.Drawing.Point(582, 13);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(46, 43);
            this.bReset.TabIndex = 35;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.BReset_Click);
            // 
            // bOk
            // 
            this.bOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bOk.Location = new System.Drawing.Point(530, 13);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(46, 42);
            this.bOk.TabIndex = 34;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = false;
            this.bOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Location = new System.Drawing.Point(13, 64);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(62, 15);
            this.labelFail.TabIndex = 36;
            this.labelFail.Text = "Ошибка...";
            // 
            // Nominate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 88);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.labelQuantityVar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "Nominate";
            this.Text = "Маркировака";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQuantityVar;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label labelFail;
    }
}