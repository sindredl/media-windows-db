using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ImageBoxForm : Form
    {
        public ImageBoxForm(Image img)
        {
            InitializeComponent();
           // posterPicBox.Load(picUrl);
            posterPicBox.Image = img;
            posterPicBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
