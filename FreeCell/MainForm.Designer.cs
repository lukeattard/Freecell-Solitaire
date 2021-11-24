namespace FreeCell
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewGameplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMoveText = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.Label();
            this.timeRecorder = new System.Windows.Forms.Timer(this.components);
            this.txtMinute = new System.Windows.Forms.Label();
            this.txtColon = new System.Windows.Forms.Label();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtBoxCardMove = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.pnlHomeCell4 = new FreeCell.HomeCellCardPanel();
            this.pnlHomeCell3 = new FreeCell.HomeCellCardPanel();
            this.pnlHomeCell2 = new FreeCell.HomeCellCardPanel();
            this.pnlHomeCell1 = new FreeCell.HomeCellCardPanel();
            this.pnlFreeCell4 = new FreeCell.FreeCellCardPanel();
            this.pnlFreeCell3 = new FreeCell.FreeCellCardPanel();
            this.pnlFreeCell2 = new FreeCell.FreeCellCardPanel();
            this.pnlFreeCell1 = new FreeCell.FreeCellCardPanel();
            this.pnlTableau8 = new FreeCell.GamePanel();
            this.pnlTableau7 = new FreeCell.GamePanel();
            this.pnlTableau6 = new FreeCell.GamePanel();
            this.pnlTableau5 = new FreeCell.GamePanel();
            this.pnlTableau4 = new FreeCell.GamePanel();
            this.pnlTableau3 = new FreeCell.GamePanel();
            this.pnlTableau2 = new FreeCell.GamePanel();
            this.pnlTableau1 = new FreeCell.GamePanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(733, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.translateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1508, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.reviewGameplayToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newGameToolStripMenuItem.Text = "Reset";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // reviewGameplayToolStripMenuItem
            // 
            this.reviewGameplayToolStripMenuItem.Name = "reviewGameplayToolStripMenuItem";
            this.reviewGameplayToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.reviewGameplayToolStripMenuItem.Text = "Review Gameplay";
            this.reviewGameplayToolStripMenuItem.Click += new System.EventHandler(this.reviewGameplayToolStripMenuItem_Click);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.translateToolStripMenuItem.Text = "Translate";
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.translateToolStripMenuItem_Click);
            // 
            // lblMoveText
            // 
            this.lblMoveText.AutoSize = true;
            this.lblMoveText.BackColor = System.Drawing.Color.Transparent;
            this.lblMoveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveText.Location = new System.Drawing.Point(648, 30);
            this.lblMoveText.Name = "lblMoveText";
            this.lblMoveText.Size = new System.Drawing.Size(29, 31);
            this.lblMoveText.TabIndex = 18;
            this.lblMoveText.Text = "0";
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BackColor = System.Drawing.Color.Transparent;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.Location = new System.Drawing.Point(540, 30);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(102, 31);
            this.lblMove.TabIndex = 17;
            this.lblMove.Text = "Moves:";
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.Location = new System.Drawing.Point(930, 30);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(29, 31);
            this.lblScoreText.TabIndex = 20;
            this.lblScoreText.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(828, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 31);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "Score:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(12, 30);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 31);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "Time:";
            // 
            // txtSecond
            // 
            this.txtSecond.AutoSize = true;
            this.txtSecond.BackColor = System.Drawing.Color.Transparent;
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(153, 30);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(44, 31);
            this.txtSecond.TabIndex = 26;
            this.txtSecond.Text = "00";
            // 
            // timeRecorder
            // 
            this.timeRecorder.Interval = 1000;
            this.timeRecorder.Tick += new System.EventHandler(this.timeRecorder_Tick);
            // 
            // txtMinute
            // 
            this.txtMinute.AutoSize = true;
            this.txtMinute.BackColor = System.Drawing.Color.Transparent;
            this.txtMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(100, 30);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(44, 31);
            this.txtMinute.TabIndex = 27;
            this.txtMinute.Text = "00";
            // 
            // txtColon
            // 
            this.txtColon.AutoSize = true;
            this.txtColon.BackColor = System.Drawing.Color.Transparent;
            this.txtColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColon.Location = new System.Drawing.Point(136, 30);
            this.txtColon.Name = "txtColon";
            this.txtColon.Size = new System.Drawing.Size(22, 31);
            this.txtColon.TabIndex = 28;
            this.txtColon.Text = ":";
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHide.Location = new System.Drawing.Point(684, 64);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(144, 42);
            this.btnShowHide.TabIndex = 29;
            this.btnShowHide.Text = "Show/Hidden";
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtBoxCardMove
            // 
            this.txtBoxCardMove.BackColor = System.Drawing.Color.SeaGreen;
            this.txtBoxCardMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCardMove.Location = new System.Drawing.Point(684, 113);
            this.txtBoxCardMove.Multiline = true;
            this.txtBoxCardMove.Name = "txtBoxCardMove";
            this.txtBoxCardMove.ReadOnly = true;
            this.txtBoxCardMove.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCardMove.Size = new System.Drawing.Size(144, 152);
            this.txtBoxCardMove.TabIndex = 30;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // animation
            // 
            this.animation.Interval = 1000;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // pnlHomeCell4
            // 
            this.pnlHomeCell4.AllowDrop = true;
            this.pnlHomeCell4.BackColor = System.Drawing.Color.Transparent;
            this.pnlHomeCell4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomeCell4.BackgroundImage")));
            this.pnlHomeCell4.Location = new System.Drawing.Point(1346, 67);
            this.pnlHomeCell4.Name = "pnlHomeCell4";
            this.pnlHomeCell4.Size = new System.Drawing.Size(146, 198);
            this.pnlHomeCell4.TabIndex = 34;
            // 
            // pnlHomeCell3
            // 
            this.pnlHomeCell3.AllowDrop = true;
            this.pnlHomeCell3.BackColor = System.Drawing.Color.Transparent;
            this.pnlHomeCell3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomeCell3.BackgroundImage")));
            this.pnlHomeCell3.Location = new System.Drawing.Point(1179, 67);
            this.pnlHomeCell3.Name = "pnlHomeCell3";
            this.pnlHomeCell3.Size = new System.Drawing.Size(146, 198);
            this.pnlHomeCell3.TabIndex = 33;
            // 
            // pnlHomeCell2
            // 
            this.pnlHomeCell2.AllowDrop = true;
            this.pnlHomeCell2.BackColor = System.Drawing.Color.Transparent;
            this.pnlHomeCell2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomeCell2.BackgroundImage")));
            this.pnlHomeCell2.Location = new System.Drawing.Point(1009, 67);
            this.pnlHomeCell2.Name = "pnlHomeCell2";
            this.pnlHomeCell2.Size = new System.Drawing.Size(146, 198);
            this.pnlHomeCell2.TabIndex = 32;
            // 
            // pnlHomeCell1
            // 
            this.pnlHomeCell1.AllowDrop = true;
            this.pnlHomeCell1.BackColor = System.Drawing.Color.Transparent;
            this.pnlHomeCell1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomeCell1.BackgroundImage")));
            this.pnlHomeCell1.Location = new System.Drawing.Point(843, 67);
            this.pnlHomeCell1.Name = "pnlHomeCell1";
            this.pnlHomeCell1.Size = new System.Drawing.Size(146, 198);
            this.pnlHomeCell1.TabIndex = 31;
            // 
            // pnlFreeCell4
            // 
            this.pnlFreeCell4.AllowDrop = true;
            this.pnlFreeCell4.BackColor = System.Drawing.Color.Transparent;
            this.pnlFreeCell4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFreeCell4.BackgroundImage")));
            this.pnlFreeCell4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFreeCell4.Location = new System.Drawing.Point(531, 64);
            this.pnlFreeCell4.Name = "pnlFreeCell4";
            this.pnlFreeCell4.Size = new System.Drawing.Size(146, 201);
            this.pnlFreeCell4.TabIndex = 24;
            // 
            // pnlFreeCell3
            // 
            this.pnlFreeCell3.AllowDrop = true;
            this.pnlFreeCell3.BackColor = System.Drawing.Color.Transparent;
            this.pnlFreeCell3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFreeCell3.BackgroundImage")));
            this.pnlFreeCell3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFreeCell3.Location = new System.Drawing.Point(360, 64);
            this.pnlFreeCell3.Name = "pnlFreeCell3";
            this.pnlFreeCell3.Size = new System.Drawing.Size(146, 201);
            this.pnlFreeCell3.TabIndex = 23;
            // 
            // pnlFreeCell2
            // 
            this.pnlFreeCell2.AllowDrop = true;
            this.pnlFreeCell2.BackColor = System.Drawing.Color.Transparent;
            this.pnlFreeCell2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFreeCell2.BackgroundImage")));
            this.pnlFreeCell2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFreeCell2.Location = new System.Drawing.Point(186, 64);
            this.pnlFreeCell2.Name = "pnlFreeCell2";
            this.pnlFreeCell2.Size = new System.Drawing.Size(146, 201);
            this.pnlFreeCell2.TabIndex = 22;
            // 
            // pnlFreeCell1
            // 
            this.pnlFreeCell1.AllowDrop = true;
            this.pnlFreeCell1.BackColor = System.Drawing.Color.Transparent;
            this.pnlFreeCell1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFreeCell1.BackgroundImage")));
            this.pnlFreeCell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFreeCell1.Location = new System.Drawing.Point(12, 64);
            this.pnlFreeCell1.Name = "pnlFreeCell1";
            this.pnlFreeCell1.Size = new System.Drawing.Size(146, 201);
            this.pnlFreeCell1.TabIndex = 21;
            // 
            // pnlTableau8
            // 
            this.pnlTableau8.AllowDrop = true;
            this.pnlTableau8.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau8.BackgroundImage")));
            this.pnlTableau8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau8.Location = new System.Drawing.Point(1299, 296);
            this.pnlTableau8.Name = "pnlTableau8";
            this.pnlTableau8.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau8.TabIndex = 7;
            // 
            // pnlTableau7
            // 
            this.pnlTableau7.AllowDrop = true;
            this.pnlTableau7.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau7.BackgroundImage")));
            this.pnlTableau7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau7.Location = new System.Drawing.Point(1120, 296);
            this.pnlTableau7.Name = "pnlTableau7";
            this.pnlTableau7.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau7.TabIndex = 6;
            // 
            // pnlTableau6
            // 
            this.pnlTableau6.AllowDrop = true;
            this.pnlTableau6.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau6.BackgroundImage")));
            this.pnlTableau6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau6.Location = new System.Drawing.Point(945, 296);
            this.pnlTableau6.Name = "pnlTableau6";
            this.pnlTableau6.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau6.TabIndex = 5;
            // 
            // pnlTableau5
            // 
            this.pnlTableau5.AllowDrop = true;
            this.pnlTableau5.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau5.BackgroundImage")));
            this.pnlTableau5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau5.Location = new System.Drawing.Point(767, 296);
            this.pnlTableau5.Name = "pnlTableau5";
            this.pnlTableau5.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau5.TabIndex = 4;
            // 
            // pnlTableau4
            // 
            this.pnlTableau4.AllowDrop = true;
            this.pnlTableau4.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau4.BackgroundImage")));
            this.pnlTableau4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau4.Location = new System.Drawing.Point(587, 296);
            this.pnlTableau4.Name = "pnlTableau4";
            this.pnlTableau4.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau4.TabIndex = 3;
            // 
            // pnlTableau3
            // 
            this.pnlTableau3.AllowDrop = true;
            this.pnlTableau3.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau3.BackgroundImage")));
            this.pnlTableau3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau3.Location = new System.Drawing.Point(412, 296);
            this.pnlTableau3.Name = "pnlTableau3";
            this.pnlTableau3.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau3.TabIndex = 2;
            // 
            // pnlTableau2
            // 
            this.pnlTableau2.AllowDrop = true;
            this.pnlTableau2.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau2.BackgroundImage")));
            this.pnlTableau2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau2.Location = new System.Drawing.Point(231, 296);
            this.pnlTableau2.Name = "pnlTableau2";
            this.pnlTableau2.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau2.TabIndex = 1;
            // 
            // pnlTableau1
            // 
            this.pnlTableau1.AllowDrop = true;
            this.pnlTableau1.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableau1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTableau1.BackgroundImage")));
            this.pnlTableau1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTableau1.Location = new System.Drawing.Point(51, 296);
            this.pnlTableau1.Name = "pnlTableau1";
            this.pnlTableau1.Size = new System.Drawing.Size(146, 468);
            this.pnlTableau1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1508, 861);
            this.Controls.Add(this.pnlHomeCell4);
            this.Controls.Add(this.pnlHomeCell3);
            this.Controls.Add(this.pnlHomeCell2);
            this.Controls.Add(this.pnlHomeCell1);
            this.Controls.Add(this.txtBoxCardMove);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.txtColon);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pnlFreeCell4);
            this.Controls.Add(this.pnlFreeCell3);
            this.Controls.Add(this.pnlFreeCell2);
            this.Controls.Add(this.pnlFreeCell1);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMoveText);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.pnlTableau8);
            this.Controls.Add(this.pnlTableau7);
            this.Controls.Add(this.pnlTableau6);
            this.Controls.Add(this.pnlTableau5);
            this.Controls.Add(this.pnlTableau4);
            this.Controls.Add(this.pnlTableau3);
            this.Controls.Add(this.pnlTableau2);
            this.Controls.Add(this.pnlTableau1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "FreeCell";
            //refractor the name of Form1_load to mainForm_load to compile with the current naming scheme
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private GamePanel pnlTableau1;
        private GamePanel pnlTableau3;
        private GamePanel pnlTableau4;
        private GamePanel pnlTableau2;
        private GamePanel pnlTableau5;
        private GamePanel pnlTableau6;
        private GamePanel pnlTableau7;
        private GamePanel pnlTableau8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.Label lblMoveText;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Label lblScore;
        private FreeCellCardPanel pnlFreeCell1;
        private FreeCellCardPanel pnlFreeCell2;
        private FreeCellCardPanel pnlFreeCell3;
        private FreeCellCardPanel pnlFreeCell4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label txtSecond;
        private System.Windows.Forms.Timer timeRecorder;
        private System.Windows.Forms.Label txtMinute;
        private System.Windows.Forms.Label txtColon;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox txtBoxCardMove;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private HomeCellCardPanel pnlHomeCell1;
        private HomeCellCardPanel pnlHomeCell2;
        private HomeCellCardPanel pnlHomeCell3;
        private HomeCellCardPanel pnlHomeCell4;
        private System.Windows.Forms.ToolStripMenuItem reviewGameplayToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer animation;
    }
}

