namespace astronaut_2D
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.PictureBox();
            this.MovingRight = new System.Windows.Forms.Timer(this.components);
            this.MovingTop = new System.Windows.Forms.Timer(this.components);
            this.MovingDown = new System.Windows.Forms.Timer(this.components);
            this.MovingLeft = new System.Windows.Forms.Timer(this.components);
            this.sky = new System.Windows.Forms.PictureBox();
            this.ShootingBullets = new System.Windows.Forms.Timer(this.components);
            this.MovingEnemies = new System.Windows.Forms.Timer(this.components);
            this.rocks_lightning = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::astronaut_2D.Properties.Resources.astronaut_shoot;
            this.Player.Location = new System.Drawing.Point(465, 386);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(145, 176);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // MovingRight
            // 
            this.MovingRight.Interval = 10;
            this.MovingRight.Tick += new System.EventHandler(this.MovingRight_Tick);
            // 
            // MovingTop
            // 
            this.MovingTop.Interval = 10;
            this.MovingTop.Tick += new System.EventHandler(this.MovingTop_Tick);
            // 
            // MovingDown
            // 
            this.MovingDown.Interval = 10;
            this.MovingDown.Tick += new System.EventHandler(this.MovingDown_Tick);
            // 
            // MovingLeft
            // 
            this.MovingLeft.Interval = 10;
            this.MovingLeft.Tick += new System.EventHandler(this.MovingLeft_Tick);
            // 
            // sky
            // 
            this.sky.BackColor = System.Drawing.Color.Transparent;
            this.sky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sky.Image = global::astronaut_2D.Properties.Resources.sky1;
            this.sky.Location = new System.Drawing.Point(-1, 0);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(1264, 281);
            this.sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sky.TabIndex = 1;
            this.sky.TabStop = false;
            // 
            // ShootingBullets
            // 
            this.ShootingBullets.Enabled = true;
            this.ShootingBullets.Interval = 10;
            this.ShootingBullets.Tick += new System.EventHandler(this.ShootingBullets_Tick);
            // 
            // MovingEnemies
            // 
            this.MovingEnemies.Enabled = true;
            this.MovingEnemies.Interval = 10;
            this.MovingEnemies.Tick += new System.EventHandler(this.MovingEnemies_Tick);
            // 
            // rocks_lightning
            // 
            this.rocks_lightning.Enabled = true;
            this.rocks_lightning.Interval = 10;
            this.rocks_lightning.Tick += new System.EventHandler(this.rocks_lightning_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 117);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 117);
            this.label2.TabIndex = 4;
            this.label2.Text = "label3";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(270, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(694, 237);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::astronaut_2D.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sky);
            this.Controls.Add(this.Player);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "astronaut 2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MovingRight;
        private System.Windows.Forms.Timer MovingTop;
        private System.Windows.Forms.Timer MovingDown;
        private System.Windows.Forms.Timer MovingLeft;
        private System.Windows.Forms.PictureBox sky;
        private System.Windows.Forms.Timer ShootingBullets;
        private System.Windows.Forms.Timer MovingEnemies;
        private System.Windows.Forms.Timer rocks_lightning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

