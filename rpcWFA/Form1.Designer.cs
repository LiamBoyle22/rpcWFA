namespace rpcWFA
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
            this.ExitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.ListBox();
            this.ScissorsBTN = new System.Windows.Forms.Button();
            this.PaperBTN = new System.Windows.Forms.Button();
            this.RockBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(12, 281);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 23);
            this.ExitBTN.TabIndex = 1;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick a number 1-3";
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 16;
            this.Results.Location = new System.Drawing.Point(12, 73);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(297, 116);
            this.Results.TabIndex = 5;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // ScissorsBTN
            // 
            this.ScissorsBTN.Location = new System.Drawing.Point(177, 44);
            this.ScissorsBTN.Name = "ScissorsBTN";
            this.ScissorsBTN.Size = new System.Drawing.Size(75, 23);
            this.ScissorsBTN.TabIndex = 6;
            this.ScissorsBTN.Text = "Scissors";
            this.ScissorsBTN.UseVisualStyleBackColor = true;
            this.ScissorsBTN.Click += new System.EventHandler(this.ScissorsBTN_Click);
            // 
            // PaperBTN
            // 
            this.PaperBTN.Location = new System.Drawing.Point(96, 44);
            this.PaperBTN.Name = "PaperBTN";
            this.PaperBTN.Size = new System.Drawing.Size(75, 23);
            this.PaperBTN.TabIndex = 7;
            this.PaperBTN.Text = "Paper";
            this.PaperBTN.UseVisualStyleBackColor = true;
            this.PaperBTN.Click += new System.EventHandler(this.PaperBTN_Click);
            // 
            // RockBTN
            // 
            this.RockBTN.Location = new System.Drawing.Point(15, 44);
            this.RockBTN.Name = "RockBTN";
            this.RockBTN.Size = new System.Drawing.Size(75, 23);
            this.RockBTN.TabIndex = 8;
            this.RockBTN.Text = "Rock";
            this.RockBTN.UseVisualStyleBackColor = true;
            this.RockBTN.Click += new System.EventHandler(this.RockBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 316);
            this.Controls.Add(this.RockBTN);
            this.Controls.Add(this.PaperBTN);
            this.Controls.Add(this.ScissorsBTN);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button ScissorsBTN;
        private System.Windows.Forms.Button PaperBTN;
        private System.Windows.Forms.Button RockBTN;
    }
}

