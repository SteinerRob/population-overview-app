using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PopulationPresov
{
    public partial class Form1 : Form
    {
        private List<Day> listOfDays= new List<Day>();
        public Document Document= new Document("", );
        public SearchedDocument SearchedDocument;

              


        public Form1()
        {
            string path;
            InitializeComponent(out path);
            Document = new Document(path,FileNameLabel);
            SearchedDocument = new SearchedDocument(Document._totalDays, GenderBox, comboBox1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchedDocument = new SearchedDocument(Document._totalDays, GenderBox, comboBox1);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void drawBTN_Click(object sender, EventArgs e)
        {
            DrawingManager drawing = new DrawingManager();
            
                drawing.DrawGraph(chart1, listOfDays, GenderBox.SelectedIndex);


        }

        private void button1_Click(object sender, EventArgs e)
                    //Browse Button
        {
            openFileDialog1.ShowDialog();
            var temp = openFileDialog1.FileName;
            this.Document = new Document(temp,FileNameLabel);
            
        }

        private void FileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
