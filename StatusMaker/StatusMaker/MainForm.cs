using System;
using System.IO;
using DiscordRPC;
using System.Drawing;
using Newtonsoft.Json;
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

        private void QuitButton_Click(object sender, EventArgs e) =>
            Application.Exit();

        private void QuitToolStripButton_Click(object sender, EventArgs e) =>
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

        #region Hide & Show

        private void HideButton_Click(object sender, EventArgs e)
        {
            SysTrayIcon.Visible = true;
            SysTrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            SysTrayIcon.BalloonTipText = "Working in background";
            SysTrayIcon.BalloonTipTitle = "Status Maker";
            SysTrayIcon.ShowBalloonTip(5);
            Visible = false;
        }

        private void ShowToolStripButton_Click(object sender, EventArgs e) =>
            Visible = !Visible;

        private void SysTrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Visible = true;
            if (e.Button == MouseButtons.Right)
                TrayStripMenu.Show();
        }

        #endregion

        #region Launch & Update

        private bool IdiotCheck()
        {
            if (string.IsNullOrWhiteSpace(CliendIdBox.Text))
            {
                MessageBox.Show("CliendID, can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(StateBox.Text))
            {
                MessageBox.Show("State can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(DetailsBox.Text))
            {
                MessageBox.Show("Details can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LaunchRPC()
        {
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

            Timer timer = new Timer(500);
            timer.Elapsed += (Tsender, Targs) =>
                client.Invoke();
            timer.Start();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (IdiotCheck())
            {
                LaunchButton.Enabled = false;
                UpdateButton.Enabled = true;
                LaunchRPC();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IdiotCheck())
            {
                client.Deinitialize();
                LaunchRPC();
            }
        }

        #endregion

        #region Save & Load

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open Text File";
            fileDialog.Filter = "Config File|*.json";
            fileDialog.Multiselect = false;
            fileDialog.InitialDirectory = Application.ExecutablePath;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = File.OpenText(fileDialog.FileName);
                JsonSerializer serializer = new JsonSerializer();
                UserData data = serializer.Deserialize(file, typeof(UserData)) as UserData;
                file.Close();

                StateBox.Text = data.State;
                DetailsBox.Text = data.Details;
                CliendIdBox.Text = data.ClientID;
                LargeKeyBox.Text = data.LargeKey;
                SmallKeyBox.Text = data.SmallKey;
                LargeTextBox.Text = data.LargeText;
                SmallTextBox.Text = data.SmallText;
                HasTimeCheckBox.Checked = data.HasTime;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Config File|*.json";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                UserData data = new UserData()
                {
                    State = StateBox.Text,
                    Details = DetailsBox.Text,
                    ClientID = CliendIdBox.Text,
                    LargeKey = LargeKeyBox.Text,
                    SmallKey = SmallKeyBox.Text,
                    LargeText = LargeTextBox.Text,
                    SmallText = SmallTextBox.Text,
                    HasTime = HasTimeCheckBox.Checked
                };

                File.WriteAllText(fileDialog.FileName, JsonConvert.SerializeObject(data, Formatting.Indented));
            }

        }

        #endregion
    }
}
