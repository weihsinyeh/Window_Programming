namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.warrior2 = new System.Windows.Forms.Button();
            this.mage2 = new System.Windows.Forms.Button();
            this.archer2 = new System.Windows.Forms.Button();
            this.warrior1 = new System.Windows.Forms.Button();
            this.mage1 = new System.Windows.Forms.Button();
            this.archer1 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.normal2 = new System.Windows.Forms.Button();
            this.horizental2 = new System.Windows.Forms.Button();
            this.vertical2 = new System.Windows.Forms.Button();
            this.cover2 = new System.Windows.Forms.Button();
            this.normal1 = new System.Windows.Forms.Button();
            this.horizental1 = new System.Windows.Forms.Button();
            this.vertical1 = new System.Windows.Forms.Button();
            this.cover1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("新細明體", 15F);
            this.player2.Location = new System.Drawing.Point(54, 49);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(94, 25);
            this.player2.TabIndex = 0;
            this.player2.Text = "P2:戰士";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("新細明體", 15F);
            this.player1.Location = new System.Drawing.Point(828, 49);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(94, 25);
            this.player1.TabIndex = 1;
            this.player1.Text = "P1:戰士";
            // 
            // warrior2
            // 
            this.warrior2.Font = new System.Drawing.Font("新細明體", 15F);
            this.warrior2.Location = new System.Drawing.Point(45, 147);
            this.warrior2.Name = "warrior2";
            this.warrior2.Size = new System.Drawing.Size(112, 48);
            this.warrior2.TabIndex = 2;
            this.warrior2.Text = "戰士";
            this.warrior2.UseVisualStyleBackColor = true;
            this.warrior2.Click += new System.EventHandler(this.warrior2_Click);
            // 
            // mage2
            // 
            this.mage2.Font = new System.Drawing.Font("新細明體", 15F);
            this.mage2.Location = new System.Drawing.Point(45, 270);
            this.mage2.Name = "mage2";
            this.mage2.Size = new System.Drawing.Size(112, 48);
            this.mage2.TabIndex = 3;
            this.mage2.Text = "法師";
            this.mage2.UseVisualStyleBackColor = true;
            this.mage2.Click += new System.EventHandler(this.mage2_Click);
            // 
            // archer2
            // 
            this.archer2.Font = new System.Drawing.Font("新細明體", 15F);
            this.archer2.Location = new System.Drawing.Point(44, 375);
            this.archer2.Name = "archer2";
            this.archer2.Size = new System.Drawing.Size(113, 48);
            this.archer2.TabIndex = 4;
            this.archer2.Text = "弓箭手";
            this.archer2.UseVisualStyleBackColor = true;
            this.archer2.Click += new System.EventHandler(this.archer2_Click);
            // 
            // warrior1
            // 
            this.warrior1.Font = new System.Drawing.Font("新細明體", 15F);
            this.warrior1.Location = new System.Drawing.Point(823, 157);
            this.warrior1.Name = "warrior1";
            this.warrior1.Size = new System.Drawing.Size(110, 48);
            this.warrior1.TabIndex = 5;
            this.warrior1.Text = "戰士";
            this.warrior1.UseVisualStyleBackColor = true;
            this.warrior1.Click += new System.EventHandler(this.warrior1_Click);
            // 
            // mage1
            // 
            this.mage1.Font = new System.Drawing.Font("新細明體", 15F);
            this.mage1.Location = new System.Drawing.Point(823, 270);
            this.mage1.Name = "mage1";
            this.mage1.Size = new System.Drawing.Size(110, 48);
            this.mage1.TabIndex = 6;
            this.mage1.Text = "法師";
            this.mage1.UseVisualStyleBackColor = true;
            this.mage1.Click += new System.EventHandler(this.mage1_Click);
            // 
            // archer1
            // 
            this.archer1.Font = new System.Drawing.Font("新細明體", 15F);
            this.archer1.Location = new System.Drawing.Point(823, 375);
            this.archer1.Name = "archer1";
            this.archer1.Size = new System.Drawing.Size(110, 48);
            this.archer1.TabIndex = 7;
            this.archer1.Text = "弓箭手";
            this.archer1.UseVisualStyleBackColor = true;
            this.archer1.Click += new System.EventHandler(this.archer1_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(362, 518);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(145, 71);
            this.start.TabIndex = 8;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // normal2
            // 
            this.normal2.Font = new System.Drawing.Font("新細明體", 9F);
            this.normal2.Location = new System.Drawing.Point(47, 93);
            this.normal2.Name = "normal2";
            this.normal2.Size = new System.Drawing.Size(110, 48);
            this.normal2.TabIndex = 11;
            this.normal2.Text = "普通棋子";
            this.normal2.UseVisualStyleBackColor = true;
            this.normal2.Visible = false;
            this.normal2.Click += new System.EventHandler(this.normal2_Click);
            // 
            // horizental2
            // 
            this.horizental2.Font = new System.Drawing.Font("新細明體", 9F);
            this.horizental2.Location = new System.Drawing.Point(44, 216);
            this.horizental2.Name = "horizental2";
            this.horizental2.Size = new System.Drawing.Size(110, 48);
            this.horizental2.TabIndex = 12;
            this.horizental2.Text = "橫向棋子";
            this.horizental2.UseVisualStyleBackColor = true;
            this.horizental2.Visible = false;
            this.horizental2.Click += new System.EventHandler(this.horizental2_Click);
            // 
            // vertical2
            // 
            this.vertical2.Font = new System.Drawing.Font("新細明體", 9F);
            this.vertical2.Location = new System.Drawing.Point(44, 324);
            this.vertical2.Name = "vertical2";
            this.vertical2.Size = new System.Drawing.Size(110, 48);
            this.vertical2.TabIndex = 13;
            this.vertical2.Text = "縱向棋子";
            this.vertical2.UseVisualStyleBackColor = true;
            this.vertical2.Visible = false;
            this.vertical2.Click += new System.EventHandler(this.vertical2_Click);
            // 
            // cover2
            // 
            this.cover2.Font = new System.Drawing.Font("新細明體", 9F);
            this.cover2.Location = new System.Drawing.Point(44, 429);
            this.cover2.Name = "cover2";
            this.cover2.Size = new System.Drawing.Size(110, 48);
            this.cover2.TabIndex = 14;
            this.cover2.Text = "覆蓋棋子";
            this.cover2.UseVisualStyleBackColor = true;
            this.cover2.Visible = false;
            this.cover2.Click += new System.EventHandler(this.cover2_Click);
            // 
            // normal1
            // 
            this.normal1.Font = new System.Drawing.Font("新細明體", 9F);
            this.normal1.Location = new System.Drawing.Point(823, 93);
            this.normal1.Name = "normal1";
            this.normal1.Size = new System.Drawing.Size(110, 48);
            this.normal1.TabIndex = 15;
            this.normal1.Text = "普通棋子";
            this.normal1.UseVisualStyleBackColor = true;
            this.normal1.Visible = false;
            this.normal1.Click += new System.EventHandler(this.normal1_Click);
            // 
            // horizental1
            // 
            this.horizental1.Font = new System.Drawing.Font("新細明體", 9F);
            this.horizental1.Location = new System.Drawing.Point(823, 216);
            this.horizental1.Name = "horizental1";
            this.horizental1.Size = new System.Drawing.Size(110, 48);
            this.horizental1.TabIndex = 16;
            this.horizental1.Text = "橫向棋子";
            this.horizental1.UseVisualStyleBackColor = true;
            this.horizental1.Visible = false;
            this.horizental1.Click += new System.EventHandler(this.horizental1_Click);
            // 
            // vertical1
            // 
            this.vertical1.Font = new System.Drawing.Font("新細明體", 9F);
            this.vertical1.Location = new System.Drawing.Point(823, 321);
            this.vertical1.Name = "vertical1";
            this.vertical1.Size = new System.Drawing.Size(110, 48);
            this.vertical1.TabIndex = 17;
            this.vertical1.Text = "縱向棋子";
            this.vertical1.UseVisualStyleBackColor = true;
            this.vertical1.Visible = false;
            this.vertical1.Click += new System.EventHandler(this.vertical1_Click);
            // 
            // cover1
            // 
            this.cover1.Font = new System.Drawing.Font("新細明體", 9F);
            this.cover1.Location = new System.Drawing.Point(823, 429);
            this.cover1.Name = "cover1";
            this.cover1.Size = new System.Drawing.Size(110, 48);
            this.cover1.TabIndex = 18;
            this.cover1.Text = "覆蓋棋子";
            this.cover1.UseVisualStyleBackColor = true;
            this.cover1.Visible = false;
            this.cover1.Click += new System.EventHandler(this.cover1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 632);
            this.Controls.Add(this.cover1);
            this.Controls.Add(this.vertical1);
            this.Controls.Add(this.horizental1);
            this.Controls.Add(this.normal1);
            this.Controls.Add(this.cover2);
            this.Controls.Add(this.vertical2);
            this.Controls.Add(this.horizental2);
            this.Controls.Add(this.normal2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.archer1);
            this.Controls.Add(this.mage1);
            this.Controls.Add(this.warrior1);
            this.Controls.Add(this.archer2);
            this.Controls.Add(this.mage2);
            this.Controls.Add(this.warrior2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Button warrior2;
        private System.Windows.Forms.Button mage2;
        private System.Windows.Forms.Button archer2;
        private System.Windows.Forms.Button warrior1;
        private System.Windows.Forms.Button mage1;
        private System.Windows.Forms.Button archer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button normal2;
        private System.Windows.Forms.Button horizental2;
        private System.Windows.Forms.Button vertical2;
        private System.Windows.Forms.Button cover2;
        private System.Windows.Forms.Button normal1;
        private System.Windows.Forms.Button horizental1;
        private System.Windows.Forms.Button vertical1;
        private System.Windows.Forms.Button cover1;
    }
}

