namespace MemoryUsage
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
            this.firstFitbtn = new System.Windows.Forms.Button();
            this.bestFitbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstFitbtn
            // 
            this.firstFitbtn.Location = new System.Drawing.Point(424, 31);
            this.firstFitbtn.Name = "firstFitbtn";
            this.firstFitbtn.Size = new System.Drawing.Size(89, 55);
            this.firstFitbtn.TabIndex = 0;
            this.firstFitbtn.Text = "FirstFit";
            this.firstFitbtn.UseVisualStyleBackColor = true;
            this.firstFitbtn.Click += new System.EventHandler(this.firstFitbtn_Click);
            // 
            // bestFitbtn
            // 
            this.bestFitbtn.Location = new System.Drawing.Point(424, 133);
            this.bestFitbtn.Name = "bestFitbtn";
            this.bestFitbtn.Size = new System.Drawing.Size(89, 53);
            this.bestFitbtn.TabIndex = 1;
            this.bestFitbtn.Text = "BestFit";
            this.bestFitbtn.UseVisualStyleBackColor = true;
            this.bestFitbtn.Click += new System.EventHandler(this.bestFitbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(424, 241);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(89, 51);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 305);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.bestFitbtn);
            this.Controls.Add(this.firstFitbtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstFitbtn;
        private System.Windows.Forms.Button bestFitbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

