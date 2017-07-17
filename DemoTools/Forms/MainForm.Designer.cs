namespace DemoTools.Forms
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
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.linkMain = new MetroFramework.Controls.MetroLink();
            this.linkSettings = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(13, 97);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(618, 347);
            this.panelMain.TabIndex = 0;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // linkMain
            // 
            this.linkMain.Image = global::DemoTools.Properties.Resources.Start_Menu_Computer_icon;
            this.linkMain.ImageSize = 32;
            this.linkMain.Location = new System.Drawing.Point(13, 59);
            this.linkMain.Name = "linkMain";
            this.linkMain.Size = new System.Drawing.Size(32, 32);
            this.linkMain.TabIndex = 1;
            this.linkMain.UseSelectable = true;
            this.linkMain.Click += new System.EventHandler(this.linkMain_Click);
            // 
            // linkSettings
            // 
            this.linkSettings.Image = global::DemoTools.Properties.Resources.Actions_configure_shortcuts_icon;
            this.linkSettings.ImageSize = 32;
            this.linkSettings.Location = new System.Drawing.Point(51, 59);
            this.linkSettings.Name = "linkSettings";
            this.linkSettings.Size = new System.Drawing.Size(32, 32);
            this.linkSettings.TabIndex = 2;
            this.linkSettings.UseSelectable = true;
            this.linkSettings.Click += new System.EventHandler(this.linkSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 455);
            this.Controls.Add(this.linkSettings);
            this.Controls.Add(this.linkMain);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "Demo Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelMain;
        private MetroFramework.Controls.MetroLink linkMain;
        private MetroFramework.Controls.MetroLink linkSettings;
    }
}

