namespace PresentationLayer.UI_elements
{
    partial class BorrowedBookUI
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
            this.label_borrowed_book_title = new System.Windows.Forms.Label();
            this.label_return_date = new System.Windows.Forms.Label();
            this.label_borrowed_book_id = new System.Windows.Forms.Label();
            this.button_return_book = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_borrowed_book_title
            // 
            this.label_borrowed_book_title.AutoSize = true;
            this.label_borrowed_book_title.Location = new System.Drawing.Point(55, 11);
            this.label_borrowed_book_title.Name = "label_borrowed_book_title";
            this.label_borrowed_book_title.Size = new System.Drawing.Size(140, 15);
            this.label_borrowed_book_title.TabIndex = 0;
            this.label_borrowed_book_title.Text = "looooooooong book title";
            // 
            // label_return_date
            // 
            this.label_return_date.AutoSize = true;
            this.label_return_date.Location = new System.Drawing.Point(55, 27);
            this.label_return_date.Name = "label_return_date";
            this.label_return_date.Size = new System.Drawing.Size(125, 15);
            this.label_return_date.TabIndex = 1;
            this.label_return_date.Text = "return date: 11.11.2001";
            // 
            // label_borrowed_book_id
            // 
            this.label_borrowed_book_id.AutoSize = true;
            this.label_borrowed_book_id.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_borrowed_book_id.Location = new System.Drawing.Point(9, 13);
            this.label_borrowed_book_id.Name = "label_borrowed_book_id";
            this.label_borrowed_book_id.Size = new System.Drawing.Size(40, 25);
            this.label_borrowed_book_id.TabIndex = 2;
            this.label_borrowed_book_id.Text = "[id]";
            // 
            // button_return_book
            // 
            this.button_return_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(198)))), ((int)(((byte)(43)))));
            this.button_return_book.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_return_book.Location = new System.Drawing.Point(256, 11);
            this.button_return_book.Name = "button_return_book";
            this.button_return_book.Size = new System.Drawing.Size(100, 30);
            this.button_return_book.TabIndex = 3;
            this.button_return_book.Text = "Return";
            this.button_return_book.UseVisualStyleBackColor = false;
            this.button_return_book.Click += new System.EventHandler(this.button_return_book_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 5);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BorrowedBookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_return_book);
            this.Controls.Add(this.label_borrowed_book_id);
            this.Controls.Add(this.label_return_date);
            this.Controls.Add(this.label_borrowed_book_title);
            this.Name = "BorrowedBookUI";
            this.Size = new System.Drawing.Size(380, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_borrowed_book_title;
        private Label label_return_date;
        private Label label_borrowed_book_id;
        private Button button_return_book;
        private PictureBox pictureBox1;
    }
}
