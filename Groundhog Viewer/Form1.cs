using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using Groundhog_Viewer.Properties;

namespace Groundhog_Viewer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        ResourceSet rsrcSet = Resources
            .ResourceManager
            .GetResourceSet(CultureInfo.CurrentCulture, true, true);
        Random rnd = new Random();
        System.Collections.Generic.List<String> lstGroundhogPictures = new System.Collections.Generic.List<String>();
        string[] arrGroundhogPictures;

        public Form1()
        {
            InitializeComponent();
            foreach(DictionaryEntry entry in rsrcSet)
            {
                lstGroundhogPictures.Add(entry.Key.ToString());
            }
            arrGroundhogPictures = lstGroundhogPictures.ToArray();
            pnlImage.BackgroundImage = (Image)Resources.ResourceManager.GetObject(arrGroundhogPictures[1]);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // Author: Dustin Hu
            // Date: October 20th, 2016
            // Purpose: To pull up a random groundhog

            pnlImage.BackgroundImage = (Image)Resources.ResourceManager.GetObject(arrGroundhogPictures[rnd.Next(0, arrGroundhogPictures.Length - 1)]);
        }
    }
}
