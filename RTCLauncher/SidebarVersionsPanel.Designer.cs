namespace RTCV.Launcher
{
    partial class SidebarVersionsPanel
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
            this.lbVersions = new System.Windows.Forms.ListBox();
            this.lbDefaultText = new System.Windows.Forms.Label();
            this.lbNameVersions = new System.Windows.Forms.Label();
            this.btnRTCV = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVersions
            // 
            this.lbVersions.AllowDrop = true;
            this.lbVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.lbVersions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbVersions.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.lbVersions.ForeColor = System.Drawing.Color.White;
            this.lbVersions.FormattingEnabled = true;
            this.lbVersions.IntegralHeight = false;
            this.lbVersions.ItemHeight = 21;
            this.lbVersions.Location = new System.Drawing.Point(9, 168);
            this.lbVersions.Margin = new System.Windows.Forms.Padding(0);
            this.lbVersions.Name = "lbVersions";
            this.lbVersions.Size = new System.Drawing.Size(136, 332);
            this.lbVersions.TabIndex = 83;
            this.lbVersions.Tag = "";
            this.lbVersions.SelectedIndexChanged += new System.EventHandler(this.lbVersions_SelectedIndexChanged);
            this.lbVersions.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbVersions_DragDrop);
            this.lbVersions.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbVersions_DragEnter);
            this.lbVersions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbVersions_MouseDown);
            // 
            // lbDefaultText
            // 
            this.lbDefaultText.AutoSize = true;
            this.lbDefaultText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbDefaultText.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.lbDefaultText.ForeColor = System.Drawing.Color.White;
            this.lbDefaultText.Location = new System.Drawing.Point(16, 172);
            this.lbDefaultText.Name = "lbDefaultText";
            this.lbDefaultText.Size = new System.Drawing.Size(120, 21);
            this.lbDefaultText.TabIndex = 84;
            this.lbDefaultText.Text = "None Installed";
            this.lbDefaultText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbVersions_MouseDown);
            // 
            // lbNameVersions
            // 
            this.lbNameVersions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameVersions.AutoSize = true;
            this.lbNameVersions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbNameVersions.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameVersions.ForeColor = System.Drawing.Color.White;
            this.lbNameVersions.Location = new System.Drawing.Point(12, 143);
            this.lbNameVersions.Name = "lbNameVersions";
            this.lbNameVersions.Size = new System.Drawing.Size(94, 21);
            this.lbNameVersions.TabIndex = 140;
            this.lbNameVersions.Text = "RTC Versions";
            // 
            // btnRTCV
            // 
            this.btnRTCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRTCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRTCV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRTCV.FlatAppearance.BorderSize = 0;
            this.btnRTCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTCV.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.btnRTCV.ForeColor = System.Drawing.Color.White;
            this.btnRTCV.Image = global::RTCV.Launcher.Properties.Resources.RTCV_16x16;
            this.btnRTCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRTCV.Location = new System.Drawing.Point(9, 91);
            this.btnRTCV.Name = "btnRTCV";
            this.btnRTCV.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnRTCV.Size = new System.Drawing.Size(136, 31);
            this.btnRTCV.TabIndex = 133;
            this.btnRTCV.TabStop = false;
            this.btnRTCV.Tag = "";
            this.btnRTCV.Text = "   RTCV";
            this.btnRTCV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRTCV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRTCV.UseVisualStyleBackColor = false;
            this.btnRTCV.Click += new System.EventHandler(this.category_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.btnMusic.ForeColor = System.Drawing.Color.White;
            this.btnMusic.Image = global::RTCV.Launcher.Properties.Resources.Redscientist_16x16;
            this.btnMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusic.Location = new System.Drawing.Point(9, 51);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnMusic.Size = new System.Drawing.Size(136, 34);
            this.btnMusic.TabIndex = 139;
            this.btnMusic.TabStop = false;
            this.btnMusic.Tag = "";
            this.btnMusic.Text = "   Music";
            this.btnMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.category_Click);
            // 
            // btnGames
            // 
            this.btnGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGames.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGames.FlatAppearance.BorderSize = 0;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
            this.btnGames.ForeColor = System.Drawing.Color.White;
            this.btnGames.Image = global::RTCV.Launcher.Properties.Resources.VRUN_16x16;
            this.btnGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGames.Location = new System.Drawing.Point(9, 11);
            this.btnGames.Name = "btnGames";
            this.btnGames.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnGames.Size = new System.Drawing.Size(136, 34);
            this.btnGames.TabIndex = 138;
            this.btnGames.TabStop = false;
            this.btnGames.Tag = "";
            this.btnGames.Text = "   Games";
            this.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Click += new System.EventHandler(this.category_Click);
            // 
            // SidebarVersionsPanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(154, 509);
            this.Controls.Add(this.lbNameVersions);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnRTCV);
            this.Controls.Add(this.lbDefaultText);
            this.Controls.Add(this.lbVersions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SidebarVersionsPanel";
            this.Text = "VesionSelectPanel";
            this.Load += new System.EventHandler(this.SidebarVersionsPanel_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbVersions_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbVersions_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SidebarVersionsPanel_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbVersions;
        public System.Windows.Forms.Label lbDefaultText;
        public System.Windows.Forms.Button btnRTCV;
        public System.Windows.Forms.Button btnMusic;
        public System.Windows.Forms.Button btnGames;
        public System.Windows.Forms.Label lbNameVersions;
    }
}
