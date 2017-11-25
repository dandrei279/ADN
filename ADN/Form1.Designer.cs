namespace ADN {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nButton
            // 
            this.nButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nButton.Location = new System.Drawing.Point(13, 12);
            this.nButton.Name = "nButton";
            this.nButton.Size = new System.Drawing.Size(259, 79);
            this.nButton.TabIndex = 0;
            this.nButton.Text = "Calcul nucleotide";
            this.nButton.UseVisualStyleBackColor = true;
            this.nButton.Click += new System.EventHandler(this.nButton_Click);
            // 
            // cButton
            // 
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cButton.Location = new System.Drawing.Point(12, 97);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(259, 79);
            this.cButton.TabIndex = 1;
            this.cButton.Text = "Replicare Catenă";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ADN.Properties.Resources.Untitled_2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(57, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 38);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ADN.Properties.Resources.Untitled_1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(13, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 38);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.exitButton.Location = new System.Drawing.Point(148, 182);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(123, 38);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.nButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ADN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exitButton;
    }
}

