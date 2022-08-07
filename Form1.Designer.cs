
namespace _2_Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelStart = new System.Windows.Forms.Label();
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonImage = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.labelAudio = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBrowsing = new System.Windows.Forms.TextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tickProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(248, 75);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(260, 28);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = "Choose type of convertation";
            // 
            // buttonAudio
            // 
            this.buttonAudio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAudio.Location = new System.Drawing.Point(132, 199);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(127, 53);
            this.buttonAudio.TabIndex = 1;
            this.buttonAudio.Text = "Audio";
            this.buttonAudio.UseVisualStyleBackColor = true;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonImage.Location = new System.Drawing.Point(341, 199);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(127, 53);
            this.buttonImage.TabIndex = 2;
            this.buttonImage.Text = "Image";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFile.Location = new System.Drawing.Point(549, 199);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(127, 53);
            this.buttonFile.TabIndex = 3;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // labelAudio
            // 
            this.labelAudio.AutoSize = true;
            this.labelAudio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAudio.Location = new System.Drawing.Point(145, 255);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Size = new System.Drawing.Size(98, 21);
            this.labelAudio.TabIndex = 4;
            this.labelAudio.Text = "mp3<->wav";
            this.labelAudio.Click += new System.EventHandler(this.labelAudio_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImage.Location = new System.Drawing.Point(353, 255);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(95, 21);
            this.labelImage.TabIndex = 5;
            this.labelImage.Text = "jpeg<->png";
            this.labelImage.Click += new System.EventHandler(this.labelImage_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFile.Location = new System.Drawing.Point(564, 255);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(93, 21);
            this.labelFile.TabIndex = 6;
            this.labelFile.Text = "pdf<->docx";
            this.labelFile.Click += new System.EventHandler(this.labelFile_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowse.Location = new System.Drawing.Point(526, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(150, 46);
            this.buttonBrowse.TabIndex = 7;
            this.buttonBrowse.Text = "Browse..";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBrowsing
            // 
            this.textBrowsing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBrowsing.Location = new System.Drawing.Point(30, 23);
            this.textBrowsing.Name = "textBrowsing";
            this.textBrowsing.Size = new System.Drawing.Size(478, 29);
            this.textBrowsing.TabIndex = 9;
            // 
            // imageBox
            // 
            this.imageBox.Image = ((System.Drawing.Image)(resources.GetObject("imageBox.Image")));
            this.imageBox.Location = new System.Drawing.Point(30, 75);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(478, 295);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 10;
            this.imageBox.TabStop = false;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConvert.Location = new System.Drawing.Point(524, 316);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(150, 54);
            this.buttonConvert.TabIndex = 11;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(701, 366);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 72);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseFolder.Location = new System.Drawing.Point(526, 75);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(150, 67);
            this.buttonChooseFolder.TabIndex = 13;
            this.buttonChooseFolder.Text = "Choose folder to save";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tickProvider
            // 
            this.tickProvider.ContainerControl = this;
            this.tickProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("tickProvider.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChooseFolder);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBrowsing);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelAudio);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.buttonAudio);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.imageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBrowsing;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider tickProvider;
    }
}

