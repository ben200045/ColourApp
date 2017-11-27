using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ColourApp


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colourToJson_Click(object sender, EventArgs e)
        {
            Colour[] colour1 = new Colour[6];
            Colour colour = new Colour();

            Colour newColour = new Colour();

            newColour.ColourName = "Red";
            newColour.ColourHex = "#FF0000";
            newColour.ColourRGB = "rbga(255, 0, 0, 1)";
            colour1[0] = newColour;

            newColour = new Colour();
            newColour.ColourName = "Green";
            newColour.ColourHex = "#008000";
            newColour.ColourRGB = "rbga(0, 128, 0, 1)";
            colour1[1] = newColour;

            newColour = new Colour();
            newColour.ColourName = "Yellow";
            newColour.ColourHex = "#FFFF00";
            newColour.ColourRGB = "rbga(255, 255, 0, 1)";
            colour1[2] = newColour;

            newColour = new Colour();
            newColour.ColourName = "Lime";
            newColour.ColourHex = "#00FF00";
            newColour.ColourRGB = "rbga(0, 255, 0, 1)";
            colour1[3] = newColour;

            newColour = new Colour();
            newColour.ColourName = "Blue";
            newColour.ColourHex = "#0000FF";
            newColour.ColourRGB = "rbga(0, 0, 255, 1)";
            colour1[4] = newColour;

            newColour = new Colour();
            newColour.ColourName = "Purple";
            newColour.ColourHex = "#800080";
            newColour.ColourRGB = "rbga(128, 0, 128, 1)";
            colour1[5] = newColour;

            string conversion = JsonConvert.SerializeObject(colour1);
            jsonBox.Text = conversion;

            using (StreamWriter file = File.CreateText(@"JSON Colours.txt"))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(file, conversion);
            }

            Colour[] JsonColourArray = JsonConvert.DeserializeObject<Colour[]>(conversion);

            colourBox.View = View.Details;
            colourBox.GridLines = true;
            foreach (var c in JsonColourArray)
                colourBox.Items.Add(new ListViewItem(new string[] {c.ColourName,c.ColourHex,c.ColourRGB}));

            colourToJson.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colours_Click(object sender, EventArgs e)
        {
            string JsonFile = File.ReadAllText(@"coloursReadMe.txt");
            Colour[] JsonColourArray = JsonConvert.DeserializeObject<Colour[]>(JsonFile);
            jsonBox.Text = JsonFile;

            colourBox.View = View.Details;
            colourBox.GridLines = true;

            foreach (var c in JsonColourArray)
                colourBox.Items.Add
                    (new ListViewItem(new string[] { c.ColourName, c.ColourHex, c.ColourRGB }));
            colours.Enabled = false;
        }
    }


    class Colour
    {
        public string ColourName { get; set; }
        public string ColourHex { get; set; }
        public string ColourRGB { get; set; }
    }
}
