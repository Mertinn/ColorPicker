using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace ColorPickerV2
{
    public partial class Form1 : Form
    {
        private string path = "history.txt";
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
            imageGetter.RunWorkerAsync();
            RefreshTable();
            historyTable.AllowUserToAddRows = false;

        }

        private void Main(int mouseX, int mouseY)
        {
            Bitmap bm = new Bitmap(10, 10);
            Graphics g = Graphics.FromImage(bm);

            g.CopyFromScreen(mouseX - 5, mouseY - 5, 0, 0, bm.Size);

            Bitmap resizedBitmap = ResizeBitmap(bm, 150, 150);
            g = Graphics.FromImage(resizedBitmap);
            Pen pen = new Pen(Brushes.White, 1f);

            g.DrawLine(pen, 0, 75, 150, 75);
            g.DrawLine(pen, 75, 0, 75, 150);

            pictureBox1.Image = resizedBitmap;

            Bitmap screenshot = MakeScreenshot();

            Color pixelColor = GetColorFromImage(screenshot, mouseX, mouseY);

            SetCopyButtonsColor(pixelColor);
        }

        private Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.SmoothingMode = SmoothingMode.None;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;          
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }

        private int[] GetMousePosition()
        {
            int[] positions = { Control.MousePosition.X, Control.MousePosition.Y };
            return positions;
        }

        private Bitmap MakeScreenshot()
        {
            Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
            Graphics g = Graphics.FromImage(bm);
            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            return bm;
        }

        private Color GetColorFromImage(Bitmap image, int mouseX, int mouseY)
        {
            Graphics g = Graphics.FromImage(image);
            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            Color pixelColor = image.GetPixel(mouseX, mouseY);

            return pixelColor;
        }

        private void SetCopyButtonsColor(Color color)
        {
            rgbCopyBtn.BackColor = color;
            hexCopyBtn.BackColor = color;
        }

        private void imageGetter_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                int[] positions = GetMousePosition();

                if(Control.ModifierKeys == Keys.Control)
                {
                    Main(positions[0], positions[1]);
                }
            }
        }

        private string ReplaceColorChars(string colorString)
        {
            colorString = colorString.Replace("Color ", "").Replace("[", "").Replace("]", "").Replace("A=", "").Replace("R=", "").Replace("G=", "");
            colorString = colorString.Replace("B=", "");
            return colorString;
        }

        private void RefreshTable()
        {
            historyTable.Rows.Clear();

            string[] lines = File.ReadAllLines(path);

            foreach(string line in lines)
            {
                string[] rgbHex = line.Split(new string[] { "|||" }, StringSplitOptions.RemoveEmptyEntries);
                historyTable.Rows.Add(rgbHex[0], rgbHex[1]);
            }

        }

        private void rgbCopyBtn_Click(object sender, EventArgs e)
        {
            Color rgbColor = rgbCopyBtn.BackColor;

            string rgbColorString = ReplaceColorChars(rgbColor.ToString());
            string hexColor = ConvertToHex(rgbColorString);

            SaveToFile(rgbColorString, hexColor);

            Clipboard.SetText(rgbColorString);

            RefreshTable();
        }

        private void hexCopyBtn_Click(object sender, EventArgs e)
        {
            Color rgbColor = rgbCopyBtn.BackColor;

            string rgbColorString = ReplaceColorChars(rgbColor.ToString());
            string hexColor = ConvertToHex(rgbColorString);

            SaveToFile(rgbColorString, hexColor);

            Clipboard.SetText(hexColor);

            RefreshTable();
        }

        private string ConvertToHex(string rgbColorString)
        {
            string[] rgbColors = rgbColorString.Split(',');
            rgbColors[0] = "";

            List<string> hexColors = new List<string>();
            foreach (string color in rgbColors)
            {
                if (color != "")
                {
                    int colorInt = Convert.ToInt32(color);
                    string hex = Convert.ToString(colorInt, 16);
                    hexColors.Add(hex);
                }
            }

            string hexColor = "";
            foreach (string color in hexColors)
            {
                hexColor = hexColor + color;
            }

            for(int i = 0; i < 5; i++)
            {
                if (hexColor.Length != 6)
                {
                    hexColor = "0" + hexColor;
                }
            }
            return hexColor;
        }

        private void historyTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historyTable.Columns[e.ColumnIndex].Name == "loadColor")
            {
                SetCopyButtonsColor(GetRGBFromTable(e.RowIndex));
            }
        }

        private Color GetRGBFromTable(int index)
        {
            string colorString = historyTable.Rows[index].Cells[0].Value.ToString();
            string[] rgb = colorString.Split(',');
            

            Color color = Color.FromArgb(Convert.ToInt32(rgb[0]), Convert.ToInt32(rgb[1]), Convert.ToInt32(rgb[2]),
            Convert.ToInt32(rgb[3]));

            return color;
        }

        private void SaveToFile(string rgbColor, string hexColor)
        {
            string[] lines = File.ReadAllLines(path);
            List<string> linesList = new List<string>(lines);

            if(lines.Length > 4)
            {
                linesList[counter] = rgbColor + "|||" + hexColor;
            }
            else
            {
                linesList.Add(rgbColor + "|||" + hexColor);
            }

            File.WriteAllText(path, string.Empty);
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (string line in linesList)
                {
                    sw.WriteLine(line);
                }
            }

            counter++;
            if(counter > 4)
            {
                counter = 0;
            }
        }
    }
}
