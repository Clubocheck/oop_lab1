using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_laba1_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int PicNum = 0;
        Boolean flag = false;
        List<PictureBox> PB = new List<PictureBox>();
        PictureBox Slide = new PictureBox();
        int SP = 0;

        private void pb_kpop_MouseEnter(object sender, EventArgs e)
        {
            btn_pb_left.Location = new Point(btn_pb_left.Location.X, btn_pb_left.Location.Y + 200);
            btn_pb_right.Location = new Point(btn_pb_right.Location.X, btn_pb_right.Location.Y + 200);
            btn_timerPic.Location = new Point(btn_timerPic.Location.X, btn_timerPic.Location.Y + 200);
            MainTB.Text = "Забавно, правда?;)";
            pb_kpop.Size = new Size(pb_kpop.Size.Width, pb_kpop.Size.Height + 200);
            pb_kpop.Image = Image.FromFile("C:/oop/not.jpg");

        }

        private void pb_kpop_MouseLeave(object sender, EventArgs e)
        {
            btn_pb_left.Location = new Point(btn_pb_left.Location.X, btn_pb_left.Location.Y - 200);
            btn_pb_right.Location = new Point(btn_pb_right.Location.X, btn_pb_right.Location.Y - 200);
            pb_kpop.Size = new Size(pb_kpop.Size.Width, pb_kpop.Size.Height - 200);
            btn_timerPic.Location = new Point(btn_timerPic.Location.X, btn_timerPic.Location.Y - 200);
            pb_kpop.Image = Image.FromFile("C:/oop/" + PicNum.ToString() + ".jpg");
        }

        private void btn_pb_left_Click(object sender, EventArgs e)
        {
            MainTB.Text = "Можно полистать фоточки";
            if (PicNum > 0) 
                PicNum--;
            pb_kpop.Image = Image.FromFile("C:/oop/" + PicNum.ToString() + ".jpg");
        }

        private void btn_pb_right_Click(object sender, EventArgs e)
        {
            MainTB.Text = "Можно полистать фоточки";
            if (PicNum < 9) 
                PicNum++;
            pb_kpop.Image = Image.FromFile("C:/oop/" + PicNum.ToString() + ".jpg");
        }

        private void btn_CreatePicture_Click(object sender, EventArgs e)
        {
            MainTB.Text = "Теперь можно создавать картинки по щелчку мыши";
            flag = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 100);
                this.Controls.Add(pictureBox);
                pictureBox.Location = this.PointToClient(new Point(Control.MousePosition.X - 50, Control.MousePosition.Y - 50));
                pictureBox.Image = Image.FromFile("C:/oop/2.jpg");
                pictureBox.Click += new EventHandler(pictureBox_click);
                PB.Add(pictureBox);
            }
        }
      
        private void pictureBox_click(object sender, EventArgs e)
        {
            PictureBox Clicked_pictureBox = (PictureBox)sender;
            Clicked_pictureBox.Dispose();
        }

        private void btn_deletePicture_Click(object sender, EventArgs e)
        {
            MainTB.Text = "И удалить все:)";
            for (int i = 0; i < PB.Count; i++)
            {
                Controls.Remove(PB[i]);
            }
            PB.Clear();
            flag = false;
        }

        private void EndProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ws1_Click(object sender, EventArgs e)
        {
            Size = new Size(500, 1000);
        }

        private void ws2_Click(object sender, EventArgs e)
        {
            Size = new Size(1000, 500);
        }

        private void ws3_Click(object sender, EventArgs e)
        {
            Size = new Size(1000, 1000);
        }

        private void btn_timerPic_Click(object sender, EventArgs e)
        {
            MainTB.Text = "Небольшое слайдшоу:/";
            this.Controls.Add(Slide);
            Slide.Size = new Size(200, 200);
            Slide.Location = (new Point(300,150));
            Slide.Image = Image.FromFile("C:/oop/0.jpg");
            timer.Enabled = true;
            SP = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (SP<10)
            {
                Slide.Image = Image.FromFile("C:/oop/" + SP.ToString() + ".jpg");
                SP++;
            }
            else
            {
                timer.Enabled = false;
                Controls.Remove(Slide);
            }
        }

        private void WindowSize_MouseEnter(object sender, EventArgs e)
        {
            MainTB.Text = "Можно выбрать размер окна из 3х имеющихся";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Размер изменён!");
        }

        private void EndProgram_MouseEnter(object sender, EventArgs e)
        {
            MainTB.Text = "Вы уверены, что хотите завершить программу?";
        }


    }
}
