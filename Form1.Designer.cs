namespace ManyMinecraftMods
{
    partial class ManyMinecraftMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManyMinecraftMods));
            this.selMpk = new System.Windows.Forms.Button();
            this.push = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.clearpush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sec1title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metalabel = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.authorbox = new System.Windows.Forms.TextBox();
            this.versionbox = new System.Windows.Forms.TextBox();
            this.descbox = new System.Windows.Forms.TextBox();
            this.folderdiag = new System.Windows.Forms.FolderBrowserDialog();
            this.filediag = new System.Windows.Forms.OpenFileDialog();
            this.mpkcreat = new System.Windows.Forms.Button();
            this.savediag = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // selMpk
            // 
            this.selMpk.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selMpk.Location = new System.Drawing.Point(13, 36);
            this.selMpk.Name = "selMpk";
            this.selMpk.Size = new System.Drawing.Size(278, 28);
            this.selMpk.TabIndex = 0;
            this.selMpk.Text = "Select .mpk File";
            this.selMpk.UseVisualStyleBackColor = true;
            this.selMpk.Click += new System.EventHandler(this.selMpk_Click);
            // 
            // push
            // 
            this.push.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.push.Location = new System.Drawing.Point(13, 70);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(136, 28);
            this.push.TabIndex = 1;
            this.push.Text = "Push to mods folder";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(13, 104);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(278, 28);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear mods folder";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clearpush
            // 
            this.clearpush.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearpush.Location = new System.Drawing.Point(155, 70);
            this.clearpush.Name = "clearpush";
            this.clearpush.Size = new System.Drawing.Size(136, 28);
            this.clearpush.TabIndex = 3;
            this.clearpush.Text = "Clear then push";
            this.clearpush.UseVisualStyleBackColor = true;
            this.clearpush.Click += new System.EventHandler(this.clearpush_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 2);
            this.label1.TabIndex = 5;
            // 
            // sec1title
            // 
            this.sec1title.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec1title.Location = new System.Drawing.Point(13, 13);
            this.sec1title.Name = "sec1title";
            this.sec1title.Size = new System.Drawing.Size(278, 20);
            this.sec1title.TabIndex = 6;
            this.sec1title.Text = "Import ManyPack";
            this.sec1title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create ManyPack";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selFolder
            // 
            this.selFolder.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selFolder.Location = new System.Drawing.Point(13, 174);
            this.selFolder.Name = "selFolder";
            this.selFolder.Size = new System.Drawing.Size(278, 28);
            this.selFolder.TabIndex = 8;
            this.selFolder.Text = "Select Folder of Mods";
            this.selFolder.UseVisualStyleBackColor = true;
            this.selFolder.Click += new System.EventHandler(this.selFolder_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selected Pack";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 2);
            this.label4.TabIndex = 9;
            // 
            // metalabel
            // 
            this.metalabel.Location = new System.Drawing.Point(14, 382);
            this.metalabel.Name = "metalabel";
            this.metalabel.Size = new System.Drawing.Size(279, 76);
            this.metalabel.TabIndex = 11;
            this.metalabel.Text = "Name: ...\r\nAuthor: ...\r\nVersion: ...\r\nDescription: ...";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(13, 209);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(277, 20);
            this.namebox.TabIndex = 12;
            this.namebox.Text = "Name";
            // 
            // authorbox
            // 
            this.authorbox.Location = new System.Drawing.Point(13, 235);
            this.authorbox.Name = "authorbox";
            this.authorbox.Size = new System.Drawing.Size(277, 20);
            this.authorbox.TabIndex = 13;
            this.authorbox.Text = "Author";
            // 
            // versionbox
            // 
            this.versionbox.Location = new System.Drawing.Point(13, 261);
            this.versionbox.Name = "versionbox";
            this.versionbox.Size = new System.Drawing.Size(277, 20);
            this.versionbox.TabIndex = 14;
            this.versionbox.Text = "Version";
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(13, 287);
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(277, 20);
            this.descbox.TabIndex = 15;
            this.descbox.Text = "Description";
            // 
            // filediag
            // 
            this.filediag.FileName = "openFileDialog1";
            // 
            // mpkcreat
            // 
            this.mpkcreat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpkcreat.Location = new System.Drawing.Point(13, 313);
            this.mpkcreat.Name = "mpkcreat";
            this.mpkcreat.Size = new System.Drawing.Size(278, 28);
            this.mpkcreat.TabIndex = 16;
            this.mpkcreat.Text = "Create .mpk File";
            this.mpkcreat.UseVisualStyleBackColor = true;
            this.mpkcreat.Click += new System.EventHandler(this.mpkcreat_Click);
            // 
            // savediag
            // 
            this.savediag.DefaultExt = "mpk";
            this.savediag.Filter = "ManyPack|*.mpk";
            // 
            // ManyMinecraftMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 479);
            this.Controls.Add(this.mpkcreat);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.versionbox);
            this.Controls.Add(this.authorbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.metalabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sec1title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearpush);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.push);
            this.Controls.Add(this.selMpk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManyMinecraftMods";
            this.Text = "ManyMinecraftMods";
            this.Load += new System.EventHandler(this.ManyMinecraftMods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selMpk;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clearpush;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sec1title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label metalabel;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox authorbox;
        private System.Windows.Forms.TextBox versionbox;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.FolderBrowserDialog folderdiag;
        private System.Windows.Forms.OpenFileDialog filediag;
        private System.Windows.Forms.Button mpkcreat;
        private System.Windows.Forms.SaveFileDialog savediag;
    }
}

