namespace PresentationLayer.UI_elements
{
    partial class UC_books
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
            this.flowLayoutPanel_books = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_details = new System.Windows.Forms.Panel();
            this.label_details = new System.Windows.Forms.Label();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_books
            // 
            this.flowLayoutPanel_books.AutoScroll = true;
            this.flowLayoutPanel_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_books.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_books.Name = "flowLayoutPanel_books";
            this.flowLayoutPanel_books.Size = new System.Drawing.Size(523, 401);
            this.flowLayoutPanel_books.TabIndex = 0;
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.label_details);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(523, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Padding = new System.Windows.Forms.Padding(40);
            this.panel_details.Size = new System.Drawing.Size(421, 401);
            this.panel_details.TabIndex = 1;
            // 
            // label_details
            // 
            this.label_details.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_details.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_details.Location = new System.Drawing.Point(40, 40);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(341, 224);
            this.label_details.TabIndex = 0;
            this.label_details.Text = "Description";
            // 
            // UC_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.flowLayoutPanel_books);
            this.Name = "UC_books";
            this.Size = new System.Drawing.Size(944, 401);
            this.panel_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel_books;
        private Panel panel_details;
        private Label label_details;
    }
}
