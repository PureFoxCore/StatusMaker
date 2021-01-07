using System;
using DiscordRPC;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace StatusMaker
{
    public partial class MainForm : Form
    {
        public DiscordRpcClient client;

        public MainForm() =>
            InitializeComponent();

        #region Quit

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (client.IsInitialized)
                client.Deinitialize();
            Application.Exit();
        }

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

        #region Launch & Update

        private void LaunchRPC()
        {
            #region Idiot Check

            if (string.IsNullOrWhiteSpace(CliendIdBox.Text))
            {
                MessageBox.Show("CliendID, can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(StateBox.Text))
            {
                MessageBox.Show("State can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(DetailsBox.Text))
            {
                MessageBox.Show("Details can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            client = new DiscordRpcClient(CliendIdBox.Text);

            if (!client.Initialize())
            {
                MessageBox.Show("Can't initialize client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Assets assets = new Assets()
            {
                LargeImageKey = LargeKeyBox.Text,
                LargeImageText = LargeTextBox.Text,
                SmallImageKey = SmallKeyBox.Text,
                SmallImageText = SmallTextBox.Text
            };

            RichPresence presence = new RichPresence()
            {
                Details = DetailsBox.Text,
                State = StateBox.Text,
                Assets = assets,
                Timestamps = HasTimeCheckBox.Checked ? new Timestamps(DateTime.UtcNow) : null
            };

            client.OnReady += (ORsender, ORe) =>
                InfoLabel.Text = $"Current User:\n{ORe.User.Username}";

            client.SetPresence(presence);

            LaunchButton.Enabled = false;
            UpdateButton.Enabled = true;

            Timer timer = new Timer(500);
            timer.Elapsed += (Tsender, Targs) =>
                client.Invoke();
            timer.Start();
        }

        private void LaunchButton_Click(object sender, EventArgs e) =>
            LaunchRPC();

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (client.IsInitialized)
                client.Deinitialize();

            LaunchRPC();
        }

        #endregion
    }
}
