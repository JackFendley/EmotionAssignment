namespace WindowsFormsApplication3
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
            this.btnMad = new System.Windows.Forms.Button();
            this.btnSad = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMad
            // 
            this.btnMad.Location = new System.Drawing.Point(13, 100);
            this.btnMad.Name = "btnMad";
            this.btnMad.Size = new System.Drawing.Size(75, 23);
            this.btnMad.TabIndex = 0;
            this.btnMad.Text = "I\'m Mad";
            this.btnMad.UseVisualStyleBackColor = true;
            this.btnMad.Click += new System.EventHandler(this.btnMad_Click);
            // 
            // btnSad
            // 
            this.btnSad.Location = new System.Drawing.Point(95, 100);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(75, 23);
            this.btnSad.TabIndex = 1;
            this.btnSad.Text = "I\'m Sad";
            this.btnSad.UseVisualStyleBackColor = true;
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // btnHappy
            // 
            this.btnHappy.Location = new System.Drawing.Point(177, 100);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(75, 23);
            this.btnHappy.TabIndex = 2;
            this.btnHappy.Text = "I\'m Happy";
            this.btnHappy.UseVisualStyleBackColor = true;
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(81, 61);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(45, 13);
            this.lblClick.TabIndex = 3;
            this.lblClick.Text = "Emotion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.btnHappy);
            this.Controls.Add(this.btnSad);
            this.Controls.Add(this.btnMad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMad;
        private System.Windows.Forms.Button btnSad;
        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Label lblClick;
    }
}

