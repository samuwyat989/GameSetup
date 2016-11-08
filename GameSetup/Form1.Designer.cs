namespace GameSetup
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
            this.draw = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(282, 341);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 0;
            this.draw.Text = "DRAW";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(213, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Please input name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 376);
            this.Controls.Add(this.name);
            this.Controls.Add(this.draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox name;
    }
}

