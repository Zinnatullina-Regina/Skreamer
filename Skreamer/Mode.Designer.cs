
namespace Skreamer
{
    partial class Mode
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
            this.Easy = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите сложность игры";
            // 
            // Easy
            // 
            this.Easy.BackColor = System.Drawing.Color.DarkRed;
            this.Easy.ForeColor = System.Drawing.Color.Black;
            this.Easy.Location = new System.Drawing.Point(12, 128);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(188, 56);
            this.Easy.TabIndex = 1;
            this.Easy.Text = "Легко";
            this.Easy.UseVisualStyleBackColor = false;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Normal
            // 
            this.Normal.BackColor = System.Drawing.Color.DarkRed;
            this.Normal.ForeColor = System.Drawing.Color.Black;
            this.Normal.Location = new System.Drawing.Point(206, 128);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(183, 56);
            this.Normal.TabIndex = 2;
            this.Normal.Text = "Нормально";
            this.Normal.UseVisualStyleBackColor = false;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Hard
            // 
            this.Hard.BackColor = System.Drawing.Color.DarkRed;
            this.Hard.ForeColor = System.Drawing.Color.Black;
            this.Hard.Location = new System.Drawing.Point(395, 128);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(198, 56);
            this.Hard.TabIndex = 3;
            this.Hard.Text = "Сложно";
            this.Hard.UseVisualStyleBackColor = false;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(620, 265);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.MaximizeBox = false;
            this.Name = "Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Hard;
    }
}