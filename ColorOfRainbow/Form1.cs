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

namespace ColorOfRainbow
{
    public partial class Form1 : Form
    {
        // Define global vars
        Color selectedColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            DialogResult colorPickerDialog = colorDialog.ShowDialog();
            selectedColor = new Color();

            if (colorPickerDialog == DialogResult.OK)
            {
                // Retriving information into Object
                selectedColor.name = colorDialog.Color.Name;
                selectedColor.hexadecimal = "#" + (colorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("x6");
                selectedColor.rgba = String.Format("{0},{1},{2},{3}", colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B, colorDialog.Color.A);

                // Display selected color
                panelColor.BackColor = colorDialog.Color;

                tboxName.Text = selectedColor.name;
                tboxHexadecimal.Text = selectedColor.hexadecimal;
                tboxRGBA.Text = selectedColor.rgba;
            } // END IF
        } // END btnColorPicker_Click()

        
        private void btnSaveColor_Click(object sender, EventArgs e)
        {
            writeToJson();
        } // END btnSaveColor_Click()

        // Serialize
        private void writeToJson()
        {
            string jsonInfo = JsonConvert.SerializeObject(selectedColor);
            File.WriteAllText("color.json", jsonInfo);
        } // END writeToJson()
    }
}
