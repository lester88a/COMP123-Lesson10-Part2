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
    
    public partial class GalleryForm : Form
    {
        private Bitmap[] _imageArray = { Properties.Resources.Welcome_large, 
                                           Properties.Resources.welcome_balloons_banner, 
                                           Properties.Resources.welcome_dis};
        private int _imageIndex = 0;

        //private string _englishArray;

        //constructor+++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GalleryForm()
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

        //event handler back button - click event
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (this._imageIndex >0)
            {
                this._imageIndex--;
            }
            else
            {
                this._imageIndex = this._imageArray.Length - 1;
            }
            MainPictureBox.Image = this._imageArray[this._imageIndex];
        }

        //English radio button handler - checked changed event
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleBarStringE;
            LanguageGroupBox.Text = Properties.Resources.GroupBoxStringE;
            EnglishRadioButton.Text = Properties.Resources.EngilshRadioButtonE;
            SpanishRadioButton.Text = Properties.Resources.SpanishRadioButtonE;
            NextButton.Text = Properties.Resources.NextButtonStringE;
            BackButton.Text = Properties.Resources.BackButtonStringE;
        }

        //Spanish radio button handler - checked changed event
        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveForm.Text = Properties.Resources.TitleBarStringS;
            LanguageGroupBox.Text = Properties.Resources.GroupBoxStringS;
            EnglishRadioButton.Text = Properties.Resources.EngilshRadioButtonS;
            SpanishRadioButton.Text = Properties.Resources.SpanishRadioButtonS1;
            NextButton.Text = Properties.Resources.NextButtonStringS;
            BackButton.Text = Properties.Resources.BackButtonStringS;
        }
    }
}
