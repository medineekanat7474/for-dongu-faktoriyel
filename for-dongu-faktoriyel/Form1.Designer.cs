namespace for_dongu_faktoriyel
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
            this.txtsayininfaktoriyeli = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsayininfaktoriyeli
            // 
            this.txtsayininfaktoriyeli.Location = new System.Drawing.Point(148, 32);
            this.txtsayininfaktoriyeli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsayininfaktoriyeli.Name = "txtsayininfaktoriyeli";
            this.txtsayininfaktoriyeli.Size = new System.Drawing.Size(109, 22);
            this.txtsayininfaktoriyeli.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(265, 112);
            this.lblsonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(52, 16);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = "sonuç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "sayinin faktöriyeli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsayininfaktoriyeli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsayininfaktoriyeli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label2;
    }
}

