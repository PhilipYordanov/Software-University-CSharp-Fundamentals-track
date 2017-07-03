namespace WindowsNavigator
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SoftUni = new System.Windows.Forms.Button();
            this.Judge = new System.Windows.Forms.Button();
            this.HackerRank = new System.Windows.Forms.Button();
            this.GitHub = new System.Windows.Forms.Button();
            this.VisualStudio2017 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.JSButton = new System.Windows.Forms.Button();
            this.EditButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SoftUni
            // 
            this.SoftUni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.SoftUni.FlatAppearance.BorderSize = 0;
            this.SoftUni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SoftUni.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftUni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SoftUni.Location = new System.Drawing.Point(30, 12);
            this.SoftUni.Name = "SoftUni";
            this.SoftUni.Size = new System.Drawing.Size(210, 100);
            this.SoftUni.TabIndex = 0;
            this.SoftUni.Text = "SoftUni";
            this.SoftUni.UseVisualStyleBackColor = false;
            this.SoftUni.Click += new System.EventHandler(this.SoftUni_Click);
            // 
            // Judge
            // 
            this.Judge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.Judge.FlatAppearance.BorderSize = 0;
            this.Judge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Judge.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.Judge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Judge.Location = new System.Drawing.Point(246, 12);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(210, 100);
            this.Judge.TabIndex = 1;
            this.Judge.Text = "Judge OOP basics";
            this.Judge.UseVisualStyleBackColor = false;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // HackerRank
            // 
            this.HackerRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(179)))), ((int)(((byte)(94)))));
            this.HackerRank.FlatAppearance.BorderSize = 0;
            this.HackerRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HackerRank.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.HackerRank.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HackerRank.Location = new System.Drawing.Point(246, 118);
            this.HackerRank.Name = "HackerRank";
            this.HackerRank.Size = new System.Drawing.Size(210, 100);
            this.HackerRank.TabIndex = 3;
            this.HackerRank.Text = "Hacker Rank";
            this.HackerRank.UseVisualStyleBackColor = false;
            this.HackerRank.Click += new System.EventHandler(this.HackerRank_Click);
            // 
            // GitHub
            // 
            this.GitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.GitHub.FlatAppearance.BorderSize = 0;
            this.GitHub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GitHub.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.GitHub.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GitHub.Location = new System.Drawing.Point(30, 118);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(210, 100);
            this.GitHub.TabIndex = 4;
            this.GitHub.Text = "Github";
            this.GitHub.UseVisualStyleBackColor = false;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // VisualStudio2017
            // 
            this.VisualStudio2017.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(77)))), ((int)(((byte)(135)))));
            this.VisualStudio2017.FlatAppearance.BorderSize = 0;
            this.VisualStudio2017.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VisualStudio2017.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.VisualStudio2017.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VisualStudio2017.Location = new System.Drawing.Point(459, 118);
            this.VisualStudio2017.Name = "VisualStudio2017";
            this.VisualStudio2017.Size = new System.Drawing.Size(210, 100);
            this.VisualStudio2017.TabIndex = 5;
            this.VisualStudio2017.Text = "Visual Studio 2017";
            this.VisualStudio2017.UseVisualStyleBackColor = false;
            this.VisualStudio2017.Click += new System.EventHandler(this.VisualStudio2017_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(149)))), ((int)(((byte)(81)))));
            this.EditButton.BackgroundImage = global::WindowsNavigator.Properties.Resources.icontwo;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(149)))), ((int)(((byte)(81)))));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(622, 326);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(47, 44);
            this.EditButton.TabIndex = 6;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.EditButtonToolTip.SetToolTip(this.EditButton, "Edit your Buttons ");
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // JSButton
            // 
            this.JSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.JSButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JSButton.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.JSButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JSButton.Location = new System.Drawing.Point(459, 12);
            this.JSButton.Name = "JSButton";
            this.JSButton.Size = new System.Drawing.Size(210, 100);
            this.JSButton.TabIndex = 7;
            this.JSButton.Text = "JS Basics";
            this.JSButton.UseVisualStyleBackColor = false;
            this.JSButton.Click += new System.EventHandler(this.JSButton_Click);
            // 
            // EditButtonToolTip
            // 
            this.EditButtonToolTip.AutoPopDelay = 5000;
            this.EditButtonToolTip.BackColor = System.Drawing.Color.White;
            this.EditButtonToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditButtonToolTip.InitialDelay = 100;
            this.EditButtonToolTip.IsBalloon = true;
            this.EditButtonToolTip.ReshowDelay = 100;
            this.EditButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.EditButtonToolTip.ToolTipTitle = "Edit your buttons";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WindowsNavigator.Properties.Resources.one;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 382);
            this.Controls.Add(this.JSButton);
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.SoftUni);
            this.Controls.Add(this.VisualStudio2017);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.HackerRank);
            this.Controls.Add(this.GitHub);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SoftUni;
        private System.Windows.Forms.Button Judge;
      //  private System.Windows.Forms.Button VisualStudio;
        private System.Windows.Forms.Button HackerRank;
        private System.Windows.Forms.Button GitHub;
        private System.Windows.Forms.Button VisualStudio2017;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button JSButton;
        private System.Windows.Forms.ToolTip EditButtonToolTip;
    }
}

