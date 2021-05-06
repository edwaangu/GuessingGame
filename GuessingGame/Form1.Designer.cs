
namespace GuessingGame
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
            this.header = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.inputNumberBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.warmthOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Arial Rounded MT Bold", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(485, 80);
            this.header.TabIndex = 0;
            this.header.Text = "Guessing Game";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.Color.Transparent;
            this.header2.Font = new System.Drawing.Font("Consolas", 16F);
            this.header2.ForeColor = System.Drawing.Color.White;
            this.header2.Location = new System.Drawing.Point(0, 70);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(484, 38);
            this.header2.TabIndex = 1;
            this.header2.Text = "Enter a number between 1 and 100";
            this.header2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputNumberBox
            // 
            this.inputNumberBox.Font = new System.Drawing.Font("Consolas", 32F);
            this.inputNumberBox.Location = new System.Drawing.Point(191, 131);
            this.inputNumberBox.MaxLength = 3;
            this.inputNumberBox.Name = "inputNumberBox";
            this.inputNumberBox.Size = new System.Drawing.Size(100, 57);
            this.inputNumberBox.TabIndex = 2;
            this.inputNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(164, 215);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(155, 46);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel1.Font = new System.Drawing.Font("Consolas", 16F);
            this.outputLabel1.ForeColor = System.Drawing.Color.White;
            this.outputLabel1.Location = new System.Drawing.Point(111, 331);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(265, 38);
            this.outputLabel1.TabIndex = 4;
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warmthOutputLabel
            // 
            this.warmthOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.warmthOutputLabel.Font = new System.Drawing.Font("Consolas", 14F);
            this.warmthOutputLabel.ForeColor = System.Drawing.Color.White;
            this.warmthOutputLabel.Location = new System.Drawing.Point(112, 369);
            this.warmthOutputLabel.Name = "warmthOutputLabel";
            this.warmthOutputLabel.Size = new System.Drawing.Size(265, 25);
            this.warmthOutputLabel.TabIndex = 5;
            this.warmthOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.warmthOutputLabel);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.inputNumberBox);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.TextBox inputNumberBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label warmthOutputLabel;
    }
}

