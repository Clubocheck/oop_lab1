namespace oop_laba1_2_
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
            this.btn_pb_left = new System.Windows.Forms.Button();
            this.pb_kpop = new System.Windows.Forms.PictureBox();
            this.btn_pb_right = new System.Windows.Forms.Button();
            this.MainTB = new System.Windows.Forms.TextBox();
            this.btn_CreatePicture = new System.Windows.Forms.Button();
            this.btn_deletePicture = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowSize = new System.Windows.Forms.ToolStripMenuItem();
            this.ws1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ws2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ws3 = new System.Windows.Forms.ToolStripMenuItem();
            this.EndProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_timerPic = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_kpop)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pb_left
            // 
            this.btn_pb_left.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pb_left.Location = new System.Drawing.Point(12, 237);
            this.btn_pb_left.Name = "btn_pb_left";
            this.btn_pb_left.Size = new System.Drawing.Size(95, 45);
            this.btn_pb_left.TabIndex = 0;
            this.btn_pb_left.Text = "Влево";
            this.btn_pb_left.UseVisualStyleBackColor = true;
            this.btn_pb_left.Click += new System.EventHandler(this.btn_pb_left_Click);
            // 
            // pb_kpop
            // 
            this.pb_kpop.Image = global::oop_laba1_2_.Properties.Resources._0;
            this.pb_kpop.Location = new System.Drawing.Point(12, 31);
            this.pb_kpop.Name = "pb_kpop";
            this.pb_kpop.Size = new System.Drawing.Size(200, 200);
            this.pb_kpop.TabIndex = 2;
            this.pb_kpop.TabStop = false;
            this.pb_kpop.MouseEnter += new System.EventHandler(this.pb_kpop_MouseEnter);
            this.pb_kpop.MouseLeave += new System.EventHandler(this.pb_kpop_MouseLeave);
            // 
            // btn_pb_right
            // 
            this.btn_pb_right.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pb_right.Location = new System.Drawing.Point(113, 237);
            this.btn_pb_right.Name = "btn_pb_right";
            this.btn_pb_right.Size = new System.Drawing.Size(95, 45);
            this.btn_pb_right.TabIndex = 3;
            this.btn_pb_right.Text = "Вправо";
            this.btn_pb_right.UseVisualStyleBackColor = true;
            this.btn_pb_right.Click += new System.EventHandler(this.btn_pb_right_Click);
            // 
            // MainTB
            // 
            this.MainTB.Font = new System.Drawing.Font("Roboto Thin", 20F, System.Drawing.FontStyle.Italic);
            this.MainTB.Location = new System.Drawing.Point(264, 31);
            this.MainTB.Multiline = true;
            this.MainTB.Name = "MainTB";
            this.MainTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainTB.Size = new System.Drawing.Size(484, 124);
            this.MainTB.TabIndex = 4;
            this.MainTB.Text = "Приветик)";
            this.MainTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_CreatePicture
            // 
            this.btn_CreatePicture.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CreatePicture.Location = new System.Drawing.Point(798, 31);
            this.btn_CreatePicture.Name = "btn_CreatePicture";
            this.btn_CreatePicture.Size = new System.Drawing.Size(137, 55);
            this.btn_CreatePicture.TabIndex = 5;
            this.btn_CreatePicture.Text = "Создать картинку";
            this.btn_CreatePicture.UseVisualStyleBackColor = true;
            this.btn_CreatePicture.Click += new System.EventHandler(this.btn_CreatePicture_Click);
            // 
            // btn_deletePicture
            // 
            this.btn_deletePicture.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deletePicture.Location = new System.Drawing.Point(798, 94);
            this.btn_deletePicture.Name = "btn_deletePicture";
            this.btn_deletePicture.Size = new System.Drawing.Size(137, 61);
            this.btn_deletePicture.TabIndex = 6;
            this.btn_deletePicture.Text = "Удалить картинки";
            this.btn_deletePicture.UseVisualStyleBackColor = true;
            this.btn_deletePicture.Click += new System.EventHandler(this.btn_deletePicture_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowSize,
            this.EndProgram});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // WindowSize
            // 
            this.WindowSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ws1,
            this.ws2,
            this.ws3});
            this.WindowSize.Name = "WindowSize";
            this.WindowSize.Size = new System.Drawing.Size(251, 26);
            this.WindowSize.Text = "Размер окна";
            this.WindowSize.MouseEnter += new System.EventHandler(this.WindowSize_MouseEnter);
            // 
            // ws1
            // 
            this.ws1.Name = "ws1";
            this.ws1.Size = new System.Drawing.Size(159, 26);
            this.ws1.Text = "500:1000";
            this.ws1.Click += new System.EventHandler(this.ws1_Click);
            // 
            // ws2
            // 
            this.ws2.Name = "ws2";
            this.ws2.Size = new System.Drawing.Size(159, 26);
            this.ws2.Text = "1000:500";
            this.ws2.Click += new System.EventHandler(this.ws2_Click);
            // 
            // ws3
            // 
            this.ws3.Name = "ws3";
            this.ws3.Size = new System.Drawing.Size(159, 26);
            this.ws3.Text = "1000:1000";
            this.ws3.Click += new System.EventHandler(this.ws3_Click);
            // 
            // EndProgram
            // 
            this.EndProgram.Name = "EndProgram";
            this.EndProgram.Size = new System.Drawing.Size(251, 26);
            this.EndProgram.Text = "Завершить программу";
            this.EndProgram.Click += new System.EventHandler(this.EndProgram_Click);
            this.EndProgram.MouseEnter += new System.EventHandler(this.EndProgram_MouseEnter);
            // 
            // btn_timerPic
            // 
            this.btn_timerPic.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_timerPic.Location = new System.Drawing.Point(12, 297);
            this.btn_timerPic.Name = "btn_timerPic";
            this.btn_timerPic.Size = new System.Drawing.Size(195, 51);
            this.btn_timerPic.TabIndex = 8;
            this.btn_timerPic.Text = "Слайдшоу";
            this.btn_timerPic.UseVisualStyleBackColor = true;
            this.btn_timerPic.Click += new System.EventHandler(this.btn_timerPic_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 561);
            this.Controls.Add(this.btn_timerPic);
            this.Controls.Add(this.btn_deletePicture);
            this.Controls.Add(this.btn_CreatePicture);
            this.Controls.Add(this.MainTB);
            this.Controls.Add(this.btn_pb_right);
            this.Controls.Add(this.pb_kpop);
            this.Controls.Add(this.btn_pb_left);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_kpop)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pb_left;
        private System.Windows.Forms.PictureBox pb_kpop;
        private System.Windows.Forms.Button btn_pb_right;
        private System.Windows.Forms.TextBox MainTB;
        private System.Windows.Forms.Button btn_CreatePicture;
        private System.Windows.Forms.Button btn_deletePicture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowSize;
        private System.Windows.Forms.ToolStripMenuItem EndProgram;
        private System.Windows.Forms.ToolStripMenuItem ws1;
        private System.Windows.Forms.ToolStripMenuItem ws3;
        private System.Windows.Forms.ToolStripMenuItem ws2;
        private System.Windows.Forms.Button btn_timerPic;
        private System.Windows.Forms.Timer timer;
    }
}

