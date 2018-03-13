using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{

    public partial class FormGame : Form
    {

        //Player move
        int score = 0;
        int enemymove = 1;
        int speedbullet = 20;
        bool shoot = false;
        int times = 0;

        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            prbEnemy1.Parent = prbBackground;
            prbEnemy2.Parent = prbBackground;
            prbEnemy3.Parent = prbBackground;
            prbEnemy4.Parent = prbBackground;
            prbPlayer.Parent = prbBackground;
            prbBullet.Parent = prbBackground;
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            //Nhấn phím phải
            if (e.KeyCode == Keys.Right)
            {
                prbPlayer.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                prbBullet.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                prbBullet.Refresh();
                prbPlayer.Refresh();
                // lưu tọa độ vào biến Times
                if (times < 3)
                {
                    times += 1;

                }
                else
                    times = 0;

            }
            // nhấn phím trái
            else if (e.KeyCode == Keys.Left)
            {
                prbPlayer.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                prbBullet.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                prbPlayer.Refresh();
                prbBullet.Refresh();
                // gán tọa độ vào biến times
                if (times <= 0)
                {
                    times = 3;
                }
                else
                    times -= 1;

            }
            //Nhấn Space để bắn
            else if (e.KeyCode == Keys.Space)
            {

                if (shoot == false && times == 0)
                {
                    speedbullet = 20;
                    prbBullet.Top = prbPlayer.Top - 10;
                    prbBullet.Left = prbPlayer.Left + 10;
                    shoot = true;
                }
                else if (shoot == false && times == 1)
                {
                    speedbullet = 20;
                    prbBullet.Top = prbPlayer.Top + 15;
                    prbBullet.Left = prbPlayer.Left + 10;
                    shoot = true;
                }
                else if (shoot == false && times == 2)
                {
                    speedbullet = 20;
                    prbBullet.Top = prbPlayer.Bottom + 15;
                    prbBullet.Left = prbPlayer.Left + 10;
                    shoot = true;
                }
                else if (shoot == false && times == 3)
                {
                    speedbullet = 20;
                    prbBullet.Top = prbPlayer.Top + 15;
                    prbBullet.Left = prbPlayer.Left - 10;
                    shoot = true;
                }
         


            }
        }


       

        private void playtimer_Tick(object sender, EventArgs e)
        {
            // điều kiện hướng bay cho viên đạn
            if (times == 0)
            {
                prbBullet.Top -= speedbullet;
            }
            else if (times == 1)
            {
                prbBullet.Left += speedbullet;            
            }
            else if (times == 2)
            {
                prbBullet.Top += speedbullet;            
            }
            else if (times == 3)
            {
                prbBullet.Left -= speedbullet;             
            }
        
           
            //hướng di chuyển của xe tăng địch
            prbEnemy1.Top += enemymove;
            prbEnemy2.Left -= enemymove;
            prbEnemy3.Top -= enemymove;
            prbEnemy4.Left += enemymove;
            ScoreText.Text = "" + score;
            // điều kiện trò chơi kêt thúc
            if (prbEnemy1.Bottom == prbPlayer.Top || prbEnemy2.Left == prbPlayer.Right || prbEnemy3.Top == prbPlayer.Bottom || prbEnemy4.Right == prbPlayer.Left)
            {
                GameOver();
            }
            // Reset vị trí đạn khi ra ngoài form
            if (shoot && prbBullet.Top < 0 || prbBullet.Left < 0 || prbBullet.Right > 1100 || prbBullet.Bottom > 666)
            {
                shoot = false;
                speedbullet = 0;
                prbBullet.Top = -100;
                prbBullet.Left = -100;


            }

            EnemyHit();
        }

        private void EnemyHit()
        {
            if (prbBullet.Bounds.IntersectsWith(prbEnemy1.Bounds))
            {
                score += 1;
                prbEnemy1.Top = -50;
                shoot = false;
                speedbullet = 0;
                prbBullet.Top = -100;
                prbBullet.Left = -100;
            }
            else if (prbBullet.Bounds.IntersectsWith(prbEnemy2.Bounds))
            {
                score += 1;
                prbEnemy2.Left = 1100;
                shoot = false;
                speedbullet = 0;
                prbBullet.Top = -100;
                prbBullet.Left = -100;
            }
            else if (prbBullet.Bounds.IntersectsWith(prbEnemy3.Bounds))
            {
                score += 1;
                prbEnemy3.Top = 666;
                shoot = false;
                speedbullet = 0;
                prbBullet.Top = -100;
                prbBullet.Left = -100;
            }
            else if (prbBullet.Bounds.IntersectsWith(prbEnemy4.Bounds))
            {
                score += 1;
                prbEnemy4.Left = -40;
                shoot = false;
                speedbullet = 0;
                prbBullet.Top = -100;
                prbBullet.Left = -100;
            }

        }

        private void GameOver()
        {
            playtimer.Enabled = false;
            DialogResult dl = MessageBox.Show(" You Score " + score + "\n" + " Click Yes to play again ", " Game over !! ", MessageBoxButtons.YesNo);

            Table diem = new Table();
            diem.Date = DateTime.Now;
            diem.Score = score;

            DiemEntities db = new DiemEntities();
            db.Tables.Add(diem);
            db.SaveChanges();

            if (dl == DialogResult.Yes)
            {
                score = 0;
                ScoreText.Text = "0";
                prbEnemy1.Top = -50;
                prbEnemy2.Left = 1150;
                prbEnemy3.Top = 550;
                prbEnemy4.Left = -50;
                prbBullet.Top = -100;
                prbBullet.Left = -100;
                playtimer.Enabled = true;
            }
            else
                Application.Exit();




        }

       

        
    }
}
