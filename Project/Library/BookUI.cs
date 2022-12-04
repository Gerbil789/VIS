using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class BookUI : UserControl
    {
        public BookUI()
        {
            InitializeComponent();
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseExit);
        }


        string title = "";
        string author = "";
        string genre = "";
        string language = "";
        bool borrowed;

        public string description { get; set; } = "";

        [Category("Custom Props")]
        public string Title
        {
            get { return title; }
            set { title = value; label_title.Text = value; }
        }

        [Category("Custom Props")]
        public string Author
        {
            get { return author; }
            set { author = value; label_author.Text = value; }
        }

        [Category("Custom Props")]
        public string Genre
        {
            get { return genre; }
            set { genre = value; label_genre.Text = value; }
        }

        [Category("Custom Props")]
        public string Language
        {
            get { return language; }
            set { language = value; label_language.Text = value; }
        }

        [Category("Custom Props")]
        public bool Borrowed
        {
            get { return borrowed; }
            set { borrowed = value;
                if(value == true)
                {
                    label_borrowed.Text = "Borrowed";
                }
                else
                {
                    label_borrowed.Text = "Available";
                }
            }
        }

        

        void OnMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        void OnMouseExit(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
