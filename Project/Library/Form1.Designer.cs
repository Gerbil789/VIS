namespace Library
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
            this.searchButton = new System.Windows.Forms.Button();
            this.TopBar = new System.Windows.Forms.Panel();
            this.label_librarian = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_login_logout = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_login_form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_login_error = new System.Windows.Forms.Label();
            this.button_login_back = new System.Windows.Forms.Button();
            this.button_login_confirm = new System.Windows.Forms.Button();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.textBox_login_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            this.panel_login_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Orange;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(265, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 36);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.White;
            this.TopBar.Controls.Add(this.label_librarian);
            this.TopBar.Controls.Add(this.button_select);
            this.TopBar.Controls.Add(this.searchButton);
            this.TopBar.Controls.Add(this.searchBox);
            this.TopBar.Controls.Add(this.button_login_logout);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(20);
            this.TopBar.Name = "TopBar";
            this.TopBar.Padding = new System.Windows.Forms.Padding(35);
            this.TopBar.Size = new System.Drawing.Size(944, 100);
            this.TopBar.TabIndex = 3;
            // 
            // label_librarian
            // 
            this.label_librarian.AutoSize = true;
            this.label_librarian.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_librarian.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_librarian.Location = new System.Drawing.Point(605, 35);
            this.label_librarian.Name = "label_librarian";
            this.label_librarian.Size = new System.Drawing.Size(204, 25);
            this.label_librarian.TabIndex = 6;
            this.label_librarian.Text = "loong email address :D";
            this.label_librarian.Visible = false;
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_select.Location = new System.Drawing.Point(371, 35);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(100, 36);
            this.button_select.TabIndex = 5;
            this.button_select.Text = "Customers";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.Location = new System.Drawing.Point(29, 35);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(230, 36);
            this.searchBox.TabIndex = 2;
            // 
            // button_login_logout
            // 
            this.button_login_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_login_logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_login_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_login_logout.Location = new System.Drawing.Point(809, 35);
            this.button_login_logout.Name = "button_login_logout";
            this.button_login_logout.Size = new System.Drawing.Size(100, 30);
            this.button_login_logout.TabIndex = 7;
            this.button_login_logout.Text = "Log in";
            this.button_login_logout.UseVisualStyleBackColor = false;
            this.button_login_logout.Click += new System.EventHandler(this.button_login_logout_Click);
            // 
            // panel_container
            // 
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 100);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(944, 401);
            this.panel_container.TabIndex = 4;
            // 
            // panel_login_form
            // 
            this.panel_login_form.BackColor = System.Drawing.Color.White;
            this.panel_login_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login_form.Controls.Add(this.label3);
            this.panel_login_form.Controls.Add(this.label2);
            this.panel_login_form.Controls.Add(this.label_login_error);
            this.panel_login_form.Controls.Add(this.button_login_back);
            this.panel_login_form.Controls.Add(this.button_login_confirm);
            this.panel_login_form.Controls.Add(this.textBox_login_password);
            this.panel_login_form.Controls.Add(this.textBox_login_email);
            this.panel_login_form.Controls.Add(this.label1);
            this.panel_login_form.Location = new System.Drawing.Point(250, 100);
            this.panel_login_form.MaximumSize = new System.Drawing.Size(400, 300);
            this.panel_login_form.Name = "panel_login_form";
            this.panel_login_form.Size = new System.Drawing.Size(400, 300);
            this.panel_login_form.TabIndex = 0;
            this.panel_login_form.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "password";
            // 
            // label_login_error
            // 
            this.label_login_error.AutoSize = true;
            this.label_login_error.ForeColor = System.Drawing.Color.Red;
            this.label_login_error.Location = new System.Drawing.Point(47, 182);
            this.label_login_error.Name = "label_login_error";
            this.label_login_error.Size = new System.Drawing.Size(78, 15);
            this.label_login_error.TabIndex = 5;
            this.label_login_error.Text = "possible error";
            this.label_login_error.Visible = false;
            // 
            // button_login_back
            // 
            this.button_login_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_login_back.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login_back.ForeColor = System.Drawing.Color.Black;
            this.button_login_back.Location = new System.Drawing.Point(227, 213);
            this.button_login_back.Name = "button_login_back";
            this.button_login_back.Size = new System.Drawing.Size(120, 50);
            this.button_login_back.TabIndex = 4;
            this.button_login_back.Text = "Back";
            this.button_login_back.UseVisualStyleBackColor = false;
            this.button_login_back.Click += new System.EventHandler(this.button_login_back_Click);
            // 
            // button_login_confirm
            // 
            this.button_login_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_login_confirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_login_confirm.ForeColor = System.Drawing.Color.Black;
            this.button_login_confirm.Location = new System.Drawing.Point(47, 213);
            this.button_login_confirm.Name = "button_login_confirm";
            this.button_login_confirm.Size = new System.Drawing.Size(120, 50);
            this.button_login_confirm.TabIndex = 3;
            this.button_login_confirm.Text = "Log in";
            this.button_login_confirm.UseVisualStyleBackColor = false;
            this.button_login_confirm.Click += new System.EventHandler(this.button_login_confirm_Click);
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.Location = new System.Drawing.Point(47, 156);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.Size = new System.Drawing.Size(300, 23);
            this.textBox_login_password.TabIndex = 2;
            this.textBox_login_password.Text = "password";
            // 
            // textBox_login_email
            // 
            this.textBox_login_email.Location = new System.Drawing.Point(47, 111);
            this.textBox_login_email.Name = "textBox_login_email";
            this.textBox_login_email.Size = new System.Drawing.Size(300, 23);
            this.textBox_login_email.TabIndex = 1;
            this.textBox_login_email.Text = "xxxxxxx.xxxxxxx@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel_login_form);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library System";
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.panel_login_form.ResumeLayout(false);
            this.panel_login_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button searchButton;
        private Panel TopBar;
        private Button button_select;
        private Panel panel_container;
        private Label label_librarian;
        private TextBox searchBox;
        private Button button_login_logout;
        private Panel panel_login_form;
        private Label label_login_error;
        private Button button_login_back;
        private Button button_login_confirm;
        private TextBox textBox_login_password;
        private TextBox textBox_login_email;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}