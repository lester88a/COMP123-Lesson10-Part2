using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace COMP123_Lesson10_Part2
{
    
    public partial class NewForm : Form
    {
        private Bitmap[] _imageArray = { Properties.Resources.Welcome_large, 
                                           Properties.Resources.welcome_balloons_banner, 
                                           Properties.Resources.welcome_dis};
        private int _imageIndex = 0;
        //constructor+++++++++++++++++++++++++++++++++++++++++++++++++++++
        public NewForm()
        {
            InitializeComponent();

            
        }

        //event handler form - form load event
        private void NewForm_Load(object sender, EventArgs e)
        {
            //NextButton.Text = Properties.Resources.NextButtonStringS;
            //this._immageArry[0] = Properties.Resources.welcome_balloons_banner;
            MainPictureBox.Image = this._imageArray[this._imageIndex];

        }

        //event handler next button - click next
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (this._imageIndex<this._imageArray.Length-1)
            {
                this._imageIndex++;
            }
            else
            {
                this._imageIndex = 0;
            }
            MainPictureBox.Image = this._imageArray[this._imageIndex];
        }
    }
}
