
namespace petGarden
{
    partial class frmNewOrLoad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.lblNewInstruct = new System.Windows.Forms.Label();
            this.lblLoadInstruct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(256, 42);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Pet Garden: C# Edition!\r\nMake your selection below:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 70);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(12, 154);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGame.TabIndex = 2;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // lblNewInstruct
            // 
            this.lblNewInstruct.AutoSize = true;
            this.lblNewInstruct.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewInstruct.Location = new System.Drawing.Point(93, 74);
            this.lblNewInstruct.Name = "lblNewInstruct";
            this.lblNewInstruct.Size = new System.Drawing.Size(101, 15);
            this.lblNewInstruct.TabIndex = 3;
            this.lblNewInstruct.Text = "Start a new game.";
            // 
            // lblLoadInstruct
            // 
            this.lblLoadInstruct.AutoSize = true;
            this.lblLoadInstruct.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoadInstruct.Location = new System.Drawing.Point(93, 158);
            this.lblLoadInstruct.Name = "lblLoadInstruct";
            this.lblLoadInstruct.Size = new System.Drawing.Size(159, 15);
            this.lblLoadInstruct.TabIndex = 4;
            this.lblLoadInstruct.Text = "Load a game from save data.";
            // 
            // frmNewOrLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblLoadInstruct);
            this.Controls.Add(this.lblNewInstruct);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmNewOrLoad";
            this.Text = "Pet Garden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Label lblNewInstruct;
        private System.Windows.Forms.Label lblLoadInstruct;
    }
}

