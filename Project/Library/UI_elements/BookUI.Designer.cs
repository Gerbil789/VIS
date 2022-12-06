namespace PresentationLayer
{
    partial class BookUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUI));
            this.picture_icon = new System.Windows.Forms.PictureBox();
            this.panel_icon_bg = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_language = new System.Windows.Forms.Label();
            this.label_borrowed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).BeginInit();
            this.panel_icon_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_icon
            // 
            this.picture_icon.Image = ((System.Drawing.Image)(resources.GetObject("picture_icon.Image")));
            this.picture_icon.Location = new System.Drawing.Point(25, 25);
            this.picture_icon.Name = "picture_icon";
            this.picture_icon.Size = new System.Drawing.Size(100, 100);
            this.picture_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_icon.TabIndex = 0;
            this.picture_icon.TabStop = false;
            // 
            // panel_icon_bg
            // 
            this.panel_icon_bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(183)))), ((int)(((byte)(33)))));
            this.panel_icon_bg.Controls.Add(this.picture_icon);
            this.panel_icon_bg.Location = new System.Drawing.Point(0, 0);
            this.panel_icon_bg.Name = "panel_icon_bg";
            this.panel_icon_bg.Size = new System.Drawing.Size(150, 150);
            this.panel_icon_bg.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.CausesValidation = false;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(170, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(46, 25);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "title";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_author.Location = new System.Drawing.Point(170, 58);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(50, 19);
            this.label_author.TabIndex = 4;
            this.label_author.Text = "author";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_genre.Location = new System.Drawing.Point(170, 77);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(44, 19);
            this.label_genre.TabIndex = 5;
            this.label_genre.Text = "genre";
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_language.Location = new System.Drawing.Point(170, 96);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(65, 19);
            this.label_language.TabIndex = 6;
            this.label_language.Text = "language";
            // 
            // label_borrowed
            // 
            this.label_borrowed.AutoSize = true;
            this.label_borrowed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_borrowed.Location = new System.Drawing.Point(170, 115);
            this.label_borrowed.Name = "label_borrowed";
            this.label_borrowed.Size = new System.Drawing.Size(68, 19);
            this.label_borrowed.TabIndex = 7;
            this.label_borrowed.Text = "borrowed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 5);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.Location = new System.Drawing.Point(170, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(28, 19);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "[id]";
            // 
            // BookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_borrowed);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_icon_bg);
            this.Name = "BookUI";
            this.Size = new System.Drawing.Size(500, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picture_icon)).EndInit();
            this.panel_icon_bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picture_icon;
        private Panel panel_icon_bg;
        private Label label_title;
        private Label label_author;
        private Label label_genre;
        private Label label_language;
        private Label label_borrowed;
        private PictureBox pictureBox1;
        private Label label_id;
    }
}
