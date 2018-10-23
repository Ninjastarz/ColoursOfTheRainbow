using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace ColoursApp
{
    public partial class FrmMain : Form
    {
        int count;
        const string path = "../../Data/Colours.json";
        List<Colour> colours = new List<Colour>();
        public FrmMain()
        {
            InitializeComponent();
            ReadFile();
            lbxColours.DrawMode = DrawMode.OwnerDrawFixed;
            lbxColours.DrawItem += listBox_DrawItem;
            Populate();
        }

        private void ReadFile()
        {
            using (var file = File.OpenText(path))
            {
                var serialiser = new JsonSerializer();
                var temp = (RootObject)serialiser.Deserialize(file, typeof(RootObject));
                colours = temp.Colours;
            }
        }

        private void Populate()
        {
            count = 0;
            foreach (var Colour in colours)
            {
                lbxColours.Items.Add(Colour.ToString());
                
            }
        }

        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var item = lbxColours.Items[e.Index];

            if (item != null)
            {
                e.Graphics.DrawString(
                    item.ToString(),
                    e.Font,
                    new SolidBrush(Color.FromName(colours[e.Index].Name)),
                    e.Bounds);
            }
        }

        private void lbxColours_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
