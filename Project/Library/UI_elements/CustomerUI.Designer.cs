namespace PresentationLayer
{
    partial class CustomerUI
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_borrowed_books_count = new System.Windows.Forms.Label();
            this.label_past_return_date_count = new System.Windows.Forms.Label();
            this.shadow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shadow)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(15, 14);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(72, 19);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "first_name";
            // 
            // label_borrowed_books_count
            // 
            this.label_borrowed_books_count.AutoSize = true;
            this.label_borrowed_books_count.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_borrowed_books_count.Location = new System.Drawing.Point(311, 14);
            this.label_borrowed_books_count.Name = "label_borrowed_books_count";
            this.label_borrowed_books_count.Size = new System.Drawing.Size(124, 19);
            this.label_borrowed_books_count.TabIndex = 2;
            this.label_borrowed_books_count.Text = "borrowed books: 3";
            // 
            // label_past_return_date_count
            // 
            this.label_past_return_date_count.AutoSize = true;
            this.label_past_return_date_count.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_past_return_date_count.ForeColor = System.Drawing.Color.Red;
            this.label_past_return_date_count.Location = new System.Drawing.Point(441, 14);
            this.label_past_return_date_count.Name = "label_past_return_date_count";
            this.label_past_return_date_count.Size = new System.Drawing.Size(25, 19);
            this.label_past_return_date_count.TabIndex = 1;
            this.label_past_return_date_count.Text = "[1]";
            // 
            // shadow
            // 
            this.shadow.BackColor = System.Drawing.Color.LightGray;
            this.shadow.Location = new System.Drawing.Point(0, 45);
            this.shadow.Name = "shadow";
            this.shadow.Size = new System.Drawing.Size(500, 5);
            this.shadow.TabIndex = 3;
            this.shadow.TabStop = false;
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shadow);
            this.Controls.Add(this.label_past_return_date_count);
            this.Controls.Add(this.label_borrowed_books_count);
            this.Controls.Add(this.label_name);
            this.Name = "CustomerUI";
            this.Size = new System.Drawing.Size(500, 50);
            ((System.ComponentModel.ISupportInitialize)(this.shadow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_name;
        private Label label_borrowed_books_count;
        private Label label_past_return_date_count;
        private PictureBox shadow;
    }
}
