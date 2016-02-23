namespace Trexis.House
{
    partial class formControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formControlPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listStatus = new System.Windows.Forms.ListView();
            this.columnIcon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListForStatus = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonListen = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.textBoxPassPhrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listStatus);
            this.groupBox1.Location = new System.Drawing.Point(100, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // listStatus
            // 
            this.listStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIcon,
            this.columnDetails});
            this.listStatus.FullRowSelect = true;
            this.listStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listStatus.Location = new System.Drawing.Point(7, 16);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(521, 281);
            this.listStatus.SmallImageList = this.imageListForStatus;
            this.listStatus.TabIndex = 0;
            this.listStatus.UseCompatibleStateImageBehavior = false;
            this.listStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnIcon
            // 
            this.columnIcon.Text = "";
            this.columnIcon.Width = 28;
            // 
            // columnDetails
            // 
            this.columnDetails.Text = "";
            this.columnDetails.Width = 413;
            // 
            // imageListForStatus
            // 
            this.imageListForStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForStatus.ImageStream")));
            this.imageListForStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForStatus.Images.SetKeyName(0, "info.png");
            this.imageListForStatus.Images.SetKeyName(1, "announcement.png");
            this.imageListForStatus.Images.SetKeyName(2, "warning.png");
            this.imageListForStatus.Images.SetKeyName(3, "error.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(13, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonListen
            // 
            this.buttonListen.BackgroundImage = global::Trexis.House.Properties.Resources.listenIcon;
            this.buttonListen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonListen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonListen.Location = new System.Drawing.Point(11, 228);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(82, 81);
            this.buttonListen.TabIndex = 4;
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.BackgroundImage = global::Trexis.House.Properties.Resources.unmuteIcon;
            this.buttonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMute.Location = new System.Drawing.Point(12, 141);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(82, 81);
            this.buttonMute.TabIndex = 3;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonActivate
            // 
            this.buttonActivate.BackgroundImage = global::Trexis.House.Properties.Resources.offIcon;
            this.buttonActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonActivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonActivate.Location = new System.Drawing.Point(12, 54);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(82, 81);
            this.buttonActivate.TabIndex = 0;
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // textBoxPassPhrase
            // 
            this.textBoxPassPhrase.Location = new System.Drawing.Point(12, 28);
            this.textBoxPassPhrase.Name = "textBoxPassPhrase";
            this.textBoxPassPhrase.Size = new System.Drawing.Size(81, 20);
            this.textBoxPassPhrase.TabIndex = 5;
            this.textBoxPassPhrase.Text = "123";
            this.textBoxPassPhrase.TextChanged += new System.EventHandler(this.textBoxPassPhrase_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pass Phrase:";
            // 
            // formControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassPhrase);
            this.Controls.Add(this.buttonListen);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonActivate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "formControlPanel";
            this.Text = "Trexis House Control Panel";
            this.Load += new System.EventHandler(this.formControlPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listStatus;
        private System.Windows.Forms.ColumnHeader columnIcon;
        private System.Windows.Forms.ColumnHeader columnDetails;
        private System.Windows.Forms.ImageList imageListForStatus;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.TextBox textBoxPassPhrase;
        private System.Windows.Forms.Label label1;
    }
}

