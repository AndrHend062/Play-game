using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Play_game
{
    public partial class playGame : Form
    {
        public playGame()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer(Properties.Resources.Alarm);
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.up);  

        private void PlayButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            counterLabel.Visible = true;

            player1.Play(); 

            counterLabel.Text = "Starting In 3";
            this.Refresh(); //refresh 
            Thread.Sleep(1000);

            player1.Play();
            counterLabel.Text = "Starting In 2";
            this.Refresh(); //refresh 
            Thread.Sleep(1000);

            player1.Play(); 
            counterLabel.Text = "Starting In 1";
            this.Refresh(); //refresh
            Thread.Sleep(1000);
           
            counterLabel.Text = "GO"; // display go 
            BackColor = Color.Green; //change background colour
            player.Play(); //play sound 
            Refresh();
            Thread.Sleep(2000);
            player.Stop();

            counterLabel.Visible = false;
            this.Refresh();
            //logo
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrushred = new SolidBrush(Color.Red);
            SolidBrush drawBrushBlack = new SolidBrush(Color.Black);
            formGraphics.Clear(Color.Green);

            Font drawFont = new Font("Arial", 16, FontStyle.Bold); // creat new font 
            Font drawFontBig = new Font("DejaVu Serif", 66, FontStyle.Bold);//create anouther font 


            formGraphics.FillEllipse(drawBrushred, 225, 100, 200, 200); // draw full ellipse

            formGraphics.DrawString("Rams", drawFont, drawBrushBlack, 265, 200);  // display rams
            formGraphics.DrawString("C", drawFontBig, drawBrushBlack, 230, 160);  // display C

            formGraphics.TranslateTransform(380, 330); // upsidedown text 
            formGraphics.RotateTransform(180);
            formGraphics.DrawString("Welcome", drawFont, drawBrushBlack, new Rectangle());
            formGraphics.ResetTransform();

        }
    }
}
