namespace EvenOrOdd
{
    partial class evenOrOdd
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
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.Location = new System.Drawing.Point(154, 120);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(140, 60);
            this.btnEvenOdd.TabIndex = 0;
            this.btnEvenOdd.Text = "Even or Odd";
            this.btnEvenOdd.UseVisualStyleBackColor = true;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // evenOrOdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 349);
            this.Controls.Add(this.btnEvenOdd);
            this.Name = "evenOrOdd";
            this.Text = "Even or Odd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvenOdd;
    }
}

