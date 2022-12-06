namespace PresentationLayer.UI_elements
{
    partial class UC_customers
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
            this.flowLayoutPanel_customers = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_customer_info = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_borrowed_books = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_validation = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_postal_code = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.button_borrow = new System.Windows.Forms.Button();
            this.panel_borrow_book = new System.Windows.Forms.Panel();
            this.label_error = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_book_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_customer_info.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel_borrow_book.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_customers
            // 
            this.flowLayoutPanel_customers.AutoScroll = true;
            this.flowLayoutPanel_customers.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_customers.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_customers.Name = "flowLayoutPanel_customers";
            this.flowLayoutPanel_customers.Size = new System.Drawing.Size(525, 401);
            this.flowLayoutPanel_customers.TabIndex = 0;
            // 
            // panel_customer_info
            // 
            this.panel_customer_info.Controls.Add(this.flowLayoutPanel_borrowed_books);
            this.panel_customer_info.Controls.Add(this.panel_info);
            this.panel_customer_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_customer_info.Location = new System.Drawing.Point(525, 0);
            this.panel_customer_info.Name = "panel_customer_info";
            this.panel_customer_info.Size = new System.Drawing.Size(419, 401);
            this.panel_customer_info.TabIndex = 1;
            // 
            // flowLayoutPanel_borrowed_books
            // 
            this.flowLayoutPanel_borrowed_books.AutoScroll = true;
            this.flowLayoutPanel_borrowed_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_borrowed_books.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_borrowed_books.Location = new System.Drawing.Point(0, 200);
            this.flowLayoutPanel_borrowed_books.Name = "flowLayoutPanel_borrowed_books";
            this.flowLayoutPanel_borrowed_books.Size = new System.Drawing.Size(419, 201);
            this.flowLayoutPanel_borrowed_books.TabIndex = 0;
            this.flowLayoutPanel_borrowed_books.WrapContents = false;
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.label_name);
            this.panel_info.Controls.Add(this.label_email);
            this.panel_info.Controls.Add(this.label_validation);
            this.panel_info.Controls.Add(this.label_address);
            this.panel_info.Controls.Add(this.label_postal_code);
            this.panel_info.Controls.Add(this.label_phone);
            this.panel_info.Controls.Add(this.button_borrow);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(419, 200);
            this.panel_info.TabIndex = 8;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(15, 15);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(157, 21);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "first_name last_name";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(15, 36);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(151, 21);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "first.last@gmail.com";
            // 
            // label_validation
            // 
            this.label_validation.AutoSize = true;
            this.label_validation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_validation.Location = new System.Drawing.Point(15, 163);
            this.label_validation.Name = "label_validation";
            this.label_validation.Size = new System.Drawing.Size(189, 21);
            this.label_validation.TabIndex = 3;
            this.label_validation.Text = "Validation date: 1.11.2022";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_address.Location = new System.Drawing.Point(15, 89);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(230, 21);
            this.label_address.TabIndex = 4;
            this.label_address.Text = "Lhota u Opavy, Komenského 48";
            // 
            // label_postal_code
            // 
            this.label_postal_code.AutoSize = true;
            this.label_postal_code.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_postal_code.Location = new System.Drawing.Point(15, 110);
            this.label_postal_code.Name = "label_postal_code";
            this.label_postal_code.Size = new System.Drawing.Size(55, 21);
            this.label_postal_code.TabIndex = 5;
            this.label_postal_code.Text = "74792";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_phone.Location = new System.Drawing.Point(15, 57);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(91, 21);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "603197038";
            // 
            // button_borrow
            // 
            this.button_borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(196)))), ((int)(((byte)(21)))));
            this.button_borrow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_borrow.Location = new System.Drawing.Point(249, 153);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(120, 40);
            this.button_borrow.TabIndex = 7;
            this.button_borrow.Text = "Borrow";
            this.button_borrow.UseVisualStyleBackColor = false;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // panel_borrow_book
            // 
            this.panel_borrow_book.BackColor = System.Drawing.Color.White;
            this.panel_borrow_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_borrow_book.Controls.Add(this.label_error);
            this.panel_borrow_book.Controls.Add(this.button_back);
            this.panel_borrow_book.Controls.Add(this.button_confirm);
            this.panel_borrow_book.Controls.Add(this.textBox_book_id);
            this.panel_borrow_book.Controls.Add(this.label2);
            this.panel_borrow_book.Controls.Add(this.label1);
            this.panel_borrow_book.Location = new System.Drawing.Point(100, 100);
            this.panel_borrow_book.Name = "panel_borrow_book";
            this.panel_borrow_book.Size = new System.Drawing.Size(250, 200);
            this.panel_borrow_book.TabIndex = 0;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(28, 157);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(105, 19);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "Book not found";
            this.label_error.Visible = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(49)))), ((int)(((byte)(13)))));
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(149, 106);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 30);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(193)))), ((int)(((byte)(11)))));
            this.button_confirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_confirm.Location = new System.Drawing.Point(28, 106);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 30);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "Borrow";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_book_id
            // 
            this.textBox_book_id.Location = new System.Drawing.Point(124, 58);
            this.textBox_book_id.Name = "textBox_book_id";
            this.textBox_book_id.Size = new System.Drawing.Size(40, 23);
            this.textBox_book_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow book";
            // 
            // UC_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_borrow_book);
            this.Controls.Add(this.panel_customer_info);
            this.Controls.Add(this.flowLayoutPanel_customers);
            this.Name = "UC_customers";
            this.Size = new System.Drawing.Size(944, 401);
            this.panel_customer_info.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_borrow_book.ResumeLayout(false);
            this.panel_borrow_book.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_customers;
        private Panel panel_customer_info;
        private Label label_email;
        private Label label_name;
        private FlowLayoutPanel flowLayoutPanel_borrowed_books;
        private Label label_phone;
        private Label label_postal_code;
        private Label label_address;
        private Label label_validation;
        private Button button_borrow;
        private Panel panel_borrow_book;
        private Button button_back;
        private Button button_confirm;
        private TextBox textBox_book_id;
        private Label label2;
        private Label label1;
        private Label label_error;
        private Panel panel_info;
    }
}
