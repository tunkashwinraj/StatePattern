namespace StatePattern_1262774
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
            this.btnTestStatePattern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestStatePattern
            // 
            this.btnTestStatePattern.Location = new System.Drawing.Point(289, 155);
            this.btnTestStatePattern.Name = "btnTestStatePattern";
            this.btnTestStatePattern.Size = new System.Drawing.Size(124, 23);
            this.btnTestStatePattern.TabIndex = 0;
            this.btnTestStatePattern.Text = "btnTestStatePattern";
            this.btnTestStatePattern.UseVisualStyleBackColor = true;
            this.btnTestStatePattern.Click += new System.EventHandler(this.btnTestStatePattern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestStatePattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestStatePattern;
    }
}

