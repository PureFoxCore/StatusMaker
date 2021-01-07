
namespace StatusMaker
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
            this.QuitButton = new System.Windows.Forms.Button();
            this.HideButton = new System.Windows.Forms.Button();
            this.SysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showStatusMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitStatusMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.LargeKeyPanel = new System.Windows.Forms.Panel();
            this.LargeKeyLabel = new System.Windows.Forms.Label();
            this.LargeKeyBox = new System.Windows.Forms.TextBox();
            this.LargeTextPanel = new System.Windows.Forms.Panel();
            this.LargeTextLabel = new System.Windows.Forms.Label();
            this.LargeTextBox = new System.Windows.Forms.TextBox();
            this.SmallTextPanel = new System.Windows.Forms.Panel();
            this.SmallTextLabel = new System.Windows.Forms.Label();
            this.SmallTextBox = new System.Windows.Forms.TextBox();
            this.SmallKeyPanel = new System.Windows.Forms.Panel();
            this.SmallKeyLabel = new System.Windows.Forms.Label();
            this.SmallKeyBox = new System.Windows.Forms.TextBox();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.DetailsBox = new System.Windows.Forms.TextBox();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.HasTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StatePanel = new System.Windows.Forms.Panel();
            this.ClientIdPanel = new System.Windows.Forms.Panel();
            this.CliendIdLabel = new System.Windows.Forms.Label();
            this.CliendIdBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.TrayStripMenu.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.LargeKeyPanel.SuspendLayout();
            this.LargeTextPanel.SuspendLayout();
            this.SmallTextPanel.SuspendLayout();
            this.SmallKeyPanel.SuspendLayout();
            this.DetailsPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.StatePanel.SuspendLayout();
            this.ClientIdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(216, 2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(28, 28);
            this.QuitButton.TabIndex = 99;
            this.QuitButton.TabStop = false;
            this.QuitButton.Text = "X";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // HideButton
            // 
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Location = new System.Drawing.Point(182, 2);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(28, 28);
            this.HideButton.TabIndex = 99;
            this.HideButton.TabStop = false;
            this.HideButton.Text = "—";
            this.HideButton.UseVisualStyleBackColor = false;
            // 
            // SysTrayIcon
            // 
            this.SysTrayIcon.ContextMenuStrip = this.TrayStripMenu;
            this.SysTrayIcon.Text = "StatusMaker";
            this.SysTrayIcon.Visible = true;
            // 
            // TrayStripMenu
            // 
            this.TrayStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TrayStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStatusMakerToolStripMenuItem,
            this.quitStatusMakerToolStripMenuItem});
            this.TrayStripMenu.Name = "TrayStripMenu";
            this.TrayStripMenu.Size = new System.Drawing.Size(172, 48);
            // 
            // showStatusMakerToolStripMenuItem
            // 
            this.showStatusMakerToolStripMenuItem.Name = "showStatusMakerToolStripMenuItem";
            this.showStatusMakerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showStatusMakerToolStripMenuItem.Text = "Show StatusMaker";
            // 
            // quitStatusMakerToolStripMenuItem
            // 
            this.quitStatusMakerToolStripMenuItem.Name = "quitStatusMakerToolStripMenuItem";
            this.quitStatusMakerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.quitStatusMakerToolStripMenuItem.Text = "Quit StatusMaker";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TopPanel.Controls.Add(this.ProgramNameLabel);
            this.TopPanel.Controls.Add(this.HideButton);
            this.TopPanel.Controls.Add(this.QuitButton);
            this.TopPanel.Location = new System.Drawing.Point(12, 12);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(244, 32);
            this.TopPanel.TabIndex = 99;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramNameLabel.Location = new System.Drawing.Point(4, 3);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(114, 25);
            this.ProgramNameLabel.TabIndex = 99;
            this.ProgramNameLabel.Text = "Status Maker";
            // 
            // LargeKeyPanel
            // 
            this.LargeKeyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LargeKeyPanel.Controls.Add(this.LargeKeyLabel);
            this.LargeKeyPanel.Controls.Add(this.LargeKeyBox);
            this.LargeKeyPanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeKeyPanel.Location = new System.Drawing.Point(12, 194);
            this.LargeKeyPanel.Name = "LargeKeyPanel";
            this.LargeKeyPanel.Size = new System.Drawing.Size(119, 66);
            this.LargeKeyPanel.TabIndex = 99;
            // 
            // LargeKeyLabel
            // 
            this.LargeKeyLabel.AutoSize = true;
            this.LargeKeyLabel.Location = new System.Drawing.Point(4, 4);
            this.LargeKeyLabel.Name = "LargeKeyLabel";
            this.LargeKeyLabel.Size = new System.Drawing.Size(83, 25);
            this.LargeKeyLabel.TabIndex = 99;
            this.LargeKeyLabel.Text = "LargeKey";
            // 
            // LargeKeyBox
            // 
            this.LargeKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LargeKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LargeKeyBox.ForeColor = System.Drawing.Color.White;
            this.LargeKeyBox.Location = new System.Drawing.Point(9, 32);
            this.LargeKeyBox.Name = "LargeKeyBox";
            this.LargeKeyBox.Size = new System.Drawing.Size(100, 24);
            this.LargeKeyBox.TabIndex = 2;
            this.LargeKeyBox.TabStop = false;
            // 
            // LargeTextPanel
            // 
            this.LargeTextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LargeTextPanel.Controls.Add(this.LargeTextLabel);
            this.LargeTextPanel.Controls.Add(this.LargeTextBox);
            this.LargeTextPanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeTextPanel.Location = new System.Drawing.Point(12, 266);
            this.LargeTextPanel.Name = "LargeTextPanel";
            this.LargeTextPanel.Size = new System.Drawing.Size(119, 66);
            this.LargeTextPanel.TabIndex = 99;
            // 
            // LargeTextLabel
            // 
            this.LargeTextLabel.AutoSize = true;
            this.LargeTextLabel.Location = new System.Drawing.Point(4, 4);
            this.LargeTextLabel.Name = "LargeTextLabel";
            this.LargeTextLabel.Size = new System.Drawing.Size(85, 25);
            this.LargeTextLabel.TabIndex = 99;
            this.LargeTextLabel.Text = "LargeText";
            // 
            // LargeTextBox
            // 
            this.LargeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LargeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LargeTextBox.ForeColor = System.Drawing.Color.White;
            this.LargeTextBox.Location = new System.Drawing.Point(9, 32);
            this.LargeTextBox.Name = "LargeTextBox";
            this.LargeTextBox.Size = new System.Drawing.Size(100, 24);
            this.LargeTextBox.TabIndex = 4;
            this.LargeTextBox.TabStop = false;
            // 
            // SmallTextPanel
            // 
            this.SmallTextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SmallTextPanel.Controls.Add(this.SmallTextLabel);
            this.SmallTextPanel.Controls.Add(this.SmallTextBox);
            this.SmallTextPanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallTextPanel.Location = new System.Drawing.Point(137, 266);
            this.SmallTextPanel.Name = "SmallTextPanel";
            this.SmallTextPanel.Size = new System.Drawing.Size(119, 66);
            this.SmallTextPanel.TabIndex = 99;
            // 
            // SmallTextLabel
            // 
            this.SmallTextLabel.AutoSize = true;
            this.SmallTextLabel.Location = new System.Drawing.Point(4, 4);
            this.SmallTextLabel.Name = "SmallTextLabel";
            this.SmallTextLabel.Size = new System.Drawing.Size(85, 25);
            this.SmallTextLabel.TabIndex = 99;
            this.SmallTextLabel.Text = "SmallText";
            // 
            // SmallTextBox
            // 
            this.SmallTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SmallTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SmallTextBox.ForeColor = System.Drawing.Color.White;
            this.SmallTextBox.Location = new System.Drawing.Point(9, 32);
            this.SmallTextBox.Name = "SmallTextBox";
            this.SmallTextBox.Size = new System.Drawing.Size(100, 24);
            this.SmallTextBox.TabIndex = 5;
            this.SmallTextBox.TabStop = false;
            // 
            // SmallKeyPanel
            // 
            this.SmallKeyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SmallKeyPanel.Controls.Add(this.SmallKeyLabel);
            this.SmallKeyPanel.Controls.Add(this.SmallKeyBox);
            this.SmallKeyPanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallKeyPanel.Location = new System.Drawing.Point(137, 194);
            this.SmallKeyPanel.Name = "SmallKeyPanel";
            this.SmallKeyPanel.Size = new System.Drawing.Size(119, 66);
            this.SmallKeyPanel.TabIndex = 99;
            // 
            // SmallKeyLabel
            // 
            this.SmallKeyLabel.AutoSize = true;
            this.SmallKeyLabel.Location = new System.Drawing.Point(4, 4);
            this.SmallKeyLabel.Name = "SmallKeyLabel";
            this.SmallKeyLabel.Size = new System.Drawing.Size(83, 25);
            this.SmallKeyLabel.TabIndex = 99;
            this.SmallKeyLabel.Text = "SmallKey";
            // 
            // SmallKeyBox
            // 
            this.SmallKeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SmallKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SmallKeyBox.ForeColor = System.Drawing.Color.White;
            this.SmallKeyBox.Location = new System.Drawing.Point(9, 32);
            this.SmallKeyBox.Name = "SmallKeyBox";
            this.SmallKeyBox.Size = new System.Drawing.Size(100, 24);
            this.SmallKeyBox.TabIndex = 3;
            this.SmallKeyBox.TabStop = false;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DetailsPanel.Controls.Add(this.DetailsLabel);
            this.DetailsPanel.Controls.Add(this.DetailsBox);
            this.DetailsPanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsPanel.Location = new System.Drawing.Point(137, 122);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(119, 66);
            this.DetailsPanel.TabIndex = 99;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(4, 4);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(65, 25);
            this.DetailsLabel.TabIndex = 99;
            this.DetailsLabel.Text = "Details";
            // 
            // DetailsBox
            // 
            this.DetailsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DetailsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsBox.ForeColor = System.Drawing.Color.White;
            this.DetailsBox.Location = new System.Drawing.Point(9, 32);
            this.DetailsBox.Name = "DetailsBox";
            this.DetailsBox.Size = new System.Drawing.Size(100, 24);
            this.DetailsBox.TabIndex = 1;
            this.DetailsBox.TabStop = false;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.OptionsPanel.Controls.Add(this.InfoLabel);
            this.OptionsPanel.Controls.Add(this.HasTimeCheckBox);
            this.OptionsPanel.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsPanel.Location = new System.Drawing.Point(11, 338);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(120, 66);
            this.OptionsPanel.TabIndex = 100;
            // 
            // HasTimeCheckBox
            // 
            this.HasTimeCheckBox.AutoSize = true;
            this.HasTimeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HasTimeCheckBox.Location = new System.Drawing.Point(10, 11);
            this.HasTimeCheckBox.Name = "HasTimeCheckBox";
            this.HasTimeCheckBox.Size = new System.Drawing.Size(51, 17);
            this.HasTimeCheckBox.TabIndex = 0;
            this.HasTimeCheckBox.TabStop = false;
            this.HasTimeCheckBox.Text = "Time?";
            this.HasTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ButtonsPanel.Controls.Add(this.UpdateButton);
            this.ButtonsPanel.Controls.Add(this.LaunchButton);
            this.ButtonsPanel.Controls.Add(this.LoadButton);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonsPanel.Location = new System.Drawing.Point(137, 338);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(120, 66);
            this.ButtonsPanel.TabIndex = 101;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.UpdateButton.Enabled = false;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(56, 8);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(59, 22);
            this.UpdateButton.TabIndex = 103;
            this.UpdateButton.TabStop = false;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchButton.Location = new System.Drawing.Point(56, 36);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(59, 22);
            this.LaunchButton.TabIndex = 100;
            this.LaunchButton.TabStop = false;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = false;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Location = new System.Drawing.Point(7, 36);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(43, 22);
            this.LoadButton.TabIndex = 102;
            this.LoadButton.TabStop = false;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(7, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 22);
            this.SaveButton.TabIndex = 101;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // StateBox
            // 
            this.StateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StateBox.ForeColor = System.Drawing.Color.White;
            this.StateBox.Location = new System.Drawing.Point(9, 32);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(100, 24);
            this.StateBox.TabIndex = 0;
            this.StateBox.TabStop = false;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(4, 4);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(51, 25);
            this.StateLabel.TabIndex = 99;
            this.StateLabel.Text = "State";
            // 
            // StatePanel
            // 
            this.StatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.StatePanel.Controls.Add(this.StateLabel);
            this.StatePanel.Controls.Add(this.StateBox);
            this.StatePanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatePanel.Location = new System.Drawing.Point(12, 122);
            this.StatePanel.Name = "StatePanel";
            this.StatePanel.Size = new System.Drawing.Size(119, 66);
            this.StatePanel.TabIndex = 99;
            // 
            // ClientIdPanel
            // 
            this.ClientIdPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientIdPanel.Controls.Add(this.CliendIdLabel);
            this.ClientIdPanel.Controls.Add(this.CliendIdBox);
            this.ClientIdPanel.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientIdPanel.Location = new System.Drawing.Point(12, 50);
            this.ClientIdPanel.Name = "ClientIdPanel";
            this.ClientIdPanel.Size = new System.Drawing.Size(244, 66);
            this.ClientIdPanel.TabIndex = 100;
            // 
            // CliendIdLabel
            // 
            this.CliendIdLabel.AutoSize = true;
            this.CliendIdLabel.Location = new System.Drawing.Point(4, 4);
            this.CliendIdLabel.Name = "CliendIdLabel";
            this.CliendIdLabel.Size = new System.Drawing.Size(79, 25);
            this.CliendIdLabel.TabIndex = 99;
            this.CliendIdLabel.Text = "CliendID";
            // 
            // CliendIdBox
            // 
            this.CliendIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CliendIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CliendIdBox.ForeColor = System.Drawing.Color.White;
            this.CliendIdBox.Location = new System.Drawing.Point(9, 32);
            this.CliendIdBox.Name = "CliendIdBox";
            this.CliendIdBox.Size = new System.Drawing.Size(225, 24);
            this.CliendIdBox.TabIndex = 0;
            this.CliendIdBox.TabStop = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Nirmala UI", 8F);
            this.InfoLabel.Location = new System.Drawing.Point(7, 32);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(75, 26);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Current User:\r\nNULL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(268, 418);
            this.ControlBox = false;
            this.Controls.Add(this.ClientIdPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.SmallTextPanel);
            this.Controls.Add(this.SmallKeyPanel);
            this.Controls.Add(this.LargeTextPanel);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.LargeKeyPanel);
            this.Controls.Add(this.StatePanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TrayStripMenu.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.LargeKeyPanel.ResumeLayout(false);
            this.LargeKeyPanel.PerformLayout();
            this.LargeTextPanel.ResumeLayout(false);
            this.LargeTextPanel.PerformLayout();
            this.SmallTextPanel.ResumeLayout(false);
            this.SmallTextPanel.PerformLayout();
            this.SmallKeyPanel.ResumeLayout(false);
            this.SmallKeyPanel.PerformLayout();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.StatePanel.ResumeLayout(false);
            this.StatePanel.PerformLayout();
            this.ClientIdPanel.ResumeLayout(false);
            this.ClientIdPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.NotifyIcon SysTrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayStripMenu;
        private System.Windows.Forms.ToolStripMenuItem showStatusMakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitStatusMakerToolStripMenuItem;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.Panel LargeKeyPanel;
        private System.Windows.Forms.Label LargeKeyLabel;
        private System.Windows.Forms.TextBox LargeKeyBox;
        private System.Windows.Forms.Panel LargeTextPanel;
        private System.Windows.Forms.Label LargeTextLabel;
        private System.Windows.Forms.TextBox LargeTextBox;
        private System.Windows.Forms.Panel SmallTextPanel;
        private System.Windows.Forms.Label SmallTextLabel;
        private System.Windows.Forms.TextBox SmallTextBox;
        private System.Windows.Forms.Panel SmallKeyPanel;
        private System.Windows.Forms.Label SmallKeyLabel;
        private System.Windows.Forms.TextBox SmallKeyBox;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TextBox DetailsBox;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.CheckBox HasTimeCheckBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Panel StatePanel;
        private System.Windows.Forms.Panel ClientIdPanel;
        private System.Windows.Forms.Label CliendIdLabel;
        private System.Windows.Forms.TextBox CliendIdBox;
        private System.Windows.Forms.Label InfoLabel;
    }
}

