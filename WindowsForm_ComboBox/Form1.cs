using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ComboBox
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            comboBoxShow();
        }
        void comboBoxShow()
        {
            comboBox1.DataSource = database.products;
        }


        // COMBOBOX İÇİNDE HERHANGİ BİR DEĞERE TIKLANDIĞINDA ÇALIŞIR.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            object o1 = comboBox1.SelectedItem;
            product p1 = (product)o1;

            pictureBox1.Image = Image.FromFile(p1.productImage);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            textName.Text = p1.productName;
            textStock.Text = p1.stockQuantity.ToString();
            textWriter.Text = p1.writer;
            textCategory.Text = p1.productCategory;

            richTextBox1.Text = p1.explanation;

        }


    }
}
