namespace Play_game
{
    partial class playGame
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
            this.playButton = new System.Windows.Forms.Button();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(228, 47);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(211, 132);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(197, 245);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(275, 38);
            this.counterLabel.TabIndex = 1;
            this.counterLabel.Text = "Starting In 3";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.counterLabel.Visible = false;
            // 
            // playGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.playButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "playGame";
            this.Text = "Play Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label counterLabel;
    }
}

