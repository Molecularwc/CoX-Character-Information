using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoX_Character_Information
{
    public partial class LoadSplash : Form
    {
        public LoadSplash()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(this.BackgroundImage);
            b.MakeTransparent(b.GetPixel(1, 1));
            //this.TransparencyKey = b.GetPixel(1,1);		
            this.BackgroundImage = b;
        }
    }
}
