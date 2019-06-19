using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace Multisports
{
    public partial class Multisport : Form
    {
        public Multisport()
        {
            
            InitializeComponent();
            
        }
        
        private void refresh()
        {
            try
            {
                base.Hide();
                Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(base.Location.X, base.Location.Y, 0, 0, base.Size, CopyPixelOperation.SourceCopy);
                bitmap.Save("spls.bin", ImageFormat.Png);
                this.BackgroundImage = bitmap;
                base.Show();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            refresh();
            timer1.Start();
            
            Login obj = new Login();
            obj.Show();
            

        }
        int step = 0;       
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    this.Enabled = false;
                    timer1.Interval = 1000;
                    break;

                case 1:
                    lbl_Loading.Text = "Initializing Modules...100%";
                    break;

                case 2:
                    lbl_Loading.Text = "Initializing UI...100%";
                    break;

                case 3:
                    lbl_Loading.Text = "Initializing Plugins...100%";
                    break;

                case 4:
                    this.Hide();
                    break;

            }

            this.Enabled = false;
            step++;

            
        }
        int dir = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(bunifuCircleProgressbar1.Value==90)
            {
                dir = -1;   //reduce
                bunifuCircleProgressbar1.animationSpeed = 4;
            }
            else if(bunifuCircleProgressbar1.Value == 10)
            {
                dir = +1;   //expand
                bunifuCircleProgressbar1.animationSpeed = 2;
            }

            bunifuCircleProgressbar1.Value += dir;
        }
        
    }
    

}
