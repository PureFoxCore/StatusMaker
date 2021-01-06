using System;
using System.Drawing;
using System.Windows.Forms;

namespace StatusMaker
{
    public partial class MainForm : Form
    {
        public MainForm() =>
            InitializeComponent();

        #region Quit
        
        private void QuitButton_Click(object sender, EventArgs e) =>
            Application.Exit();

        #endregion

        #region Movement

        private Point lastPoint;

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lastPoint = new Point(e.X, e.Y);
        }

        #endregion


    }
}
