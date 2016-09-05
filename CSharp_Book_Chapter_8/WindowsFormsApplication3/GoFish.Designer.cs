namespace WindowsFormsApplication3
{
    partial class GoFish
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
            this.textBoxGameProgress = new System.Windows.Forms.TextBox();
            this.textBoxBooks = new System.Windows.Forms.TextBox();
            this.labelBooks = new System.Windows.Forms.Label();
            this.labelYourName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonStartTheGame = new System.Windows.Forms.Button();
            this.labelYourHand = new System.Windows.Forms.Label();
            this.listBoxCardsInHand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAskForCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGameProgress
            // 
            this.textBoxGameProgress.Location = new System.Drawing.Point(12, 76);
            this.textBoxGameProgress.Multiline = true;
            this.textBoxGameProgress.Name = "textBoxGameProgress";
            this.textBoxGameProgress.ReadOnly = true;
            this.textBoxGameProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGameProgress.Size = new System.Drawing.Size(409, 429);
            this.textBoxGameProgress.TabIndex = 0;
            // 
            // textBoxBooks
            // 
            this.textBoxBooks.Location = new System.Drawing.Point(12, 528);
            this.textBoxBooks.Multiline = true;
            this.textBoxBooks.Name = "textBoxBooks";
            this.textBoxBooks.ReadOnly = true;
            this.textBoxBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBooks.Size = new System.Drawing.Size(409, 150);
            this.textBoxBooks.TabIndex = 1;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(12, 512);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(37, 13);
            this.labelBooks.TabIndex = 2;
            this.labelBooks.Text = "Books";
            // 
            // labelYourName
            // 
            this.labelYourName.AutoSize = true;
            this.labelYourName.Location = new System.Drawing.Point(12, 9);
            this.labelYourName.Name = "labelYourName";
            this.labelYourName.Size = new System.Drawing.Size(58, 13);
            this.labelYourName.TabIndex = 3;
            this.labelYourName.Text = "Your name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(206, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // buttonStartTheGame
            // 
            this.buttonStartTheGame.Location = new System.Drawing.Point(227, 12);
            this.buttonStartTheGame.Name = "buttonStartTheGame";
            this.buttonStartTheGame.Size = new System.Drawing.Size(194, 33);
            this.buttonStartTheGame.TabIndex = 5;
            this.buttonStartTheGame.Text = "Start the game!";
            this.buttonStartTheGame.UseVisualStyleBackColor = true;
            this.buttonStartTheGame.Click += new System.EventHandler(this.OnButtonStartTheGameClick);
            // 
            // labelYourHand
            // 
            this.labelYourHand.AutoSize = true;
            this.labelYourHand.Location = new System.Drawing.Point(424, 4);
            this.labelYourHand.Name = "labelYourHand";
            this.labelYourHand.Size = new System.Drawing.Size(56, 13);
            this.labelYourHand.TabIndex = 6;
            this.labelYourHand.Text = "Your hand";
            // 
            // listBoxCardsInHand
            // 
            this.listBoxCardsInHand.Enabled = false;
            this.listBoxCardsInHand.FormattingEnabled = true;
            this.listBoxCardsInHand.Location = new System.Drawing.Point(427, 25);
            this.listBoxCardsInHand.Name = "listBoxCardsInHand";
            this.listBoxCardsInHand.Size = new System.Drawing.Size(194, 602);
            this.listBoxCardsInHand.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Game Progress";
            // 
            // buttonAskForCard
            // 
            this.buttonAskForCard.Enabled = false;
            this.buttonAskForCard.Location = new System.Drawing.Point(427, 641);
            this.buttonAskForCard.Name = "buttonAskForCard";
            this.buttonAskForCard.Size = new System.Drawing.Size(194, 32);
            this.buttonAskForCard.TabIndex = 9;
            this.buttonAskForCard.Text = "Ask fo a card";
            this.buttonAskForCard.UseVisualStyleBackColor = true;
            this.buttonAskForCard.Click += new System.EventHandler(this.OnButtonAskForCardClick);
            // 
            // GoFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 687);
            this.Controls.Add(this.buttonAskForCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCardsInHand);
            this.Controls.Add(this.labelYourHand);
            this.Controls.Add(this.buttonStartTheGame);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelYourName);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.textBoxBooks);
            this.Controls.Add(this.textBoxGameProgress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoFish";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGameProgress;
        private System.Windows.Forms.TextBox textBoxBooks;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Label labelYourName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonStartTheGame;
        private System.Windows.Forms.Label labelYourHand;
        private System.Windows.Forms.ListBox listBoxCardsInHand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAskForCard;
    }
}

