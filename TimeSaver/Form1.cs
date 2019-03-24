using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSaver
{
    public partial class Form1 : Form
    {
        string filePath1 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                filePath1 = openFileDialog1.FileName;
            textBox1.Text = filePath1.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void transformation_Click(object sender, EventArgs e)
        {
            try
            {
                string buff = "";
                string buffFilter = "";
                int fromIterI = 7, fromIterJ = 0;
                int toIterI = 1, toIterJ = 0;
                int filterIterI = 7, filterIterJ = 3;
                int sheetNumber = 0;
                int gatiAmount = 0;

                sheetNumber = Convert.ToInt32(textBox2.Text);
                Excel excel = new Excel(filePath1);
                excel.SelectWorkSheet(sheetNumber);
                excel.CreateNewSheet();

                for (int i = 0; i < 8; i++)
                {
                    if (i == 1)
                        continue;
                    for (int j = fromIterI - 4; j != fromIterI; j++)
                    {
                        if (i == 2 && j == 4)
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, "Уточнение");
                            toIterJ++;
                        }

                        if (i == 7)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(j, 1);
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, buff);
                            toIterJ++;
                        }

                        excel.SelectWorkSheet(sheetNumber);
                        buff = excel.FromTo(j, i);
                        if (buff == null)
                            continue;
                        else
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, buff);
                        }
                        toIterJ++;
                    }
                }

                toIterJ = 0;

                while (true)
                {
                    excel.SelectWorkSheet(sheetNumber);
                    buff = excel.FromTo(fromIterI, fromIterJ);
                    if (buff == null)
                        break;
                    gatiAmount++;
                    fromIterI++;
                }

                for (int i = filterIterI; i != gatiAmount + filterIterI; i += 4)
                {
                    fromIterI = i;
                    excel.SelectWorkSheet(sheetNumber);
                    buffFilter = excel.FromTo(i, filterIterJ);
                    if (buffFilter == comboBox1.Text)
                    {
                        for (int j = toIterJ; j < 4; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI++;   
                        }                        
                        toIterJ = 4;
                        fromIterJ = 2;
                        fromIterI = i;

                        for (int j = toIterJ; j < 6 ; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI++;
                        }
                        toIterJ = 6;
                        fromIterJ = 3;
                        fromIterI = i;

                        for (int j = toIterJ; j < 8; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI+=2;
                        }
                        toIterJ = 8;
                        fromIterJ = 4;
                        fromIterI = i;

                        for (int j = toIterJ; j < 10; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI++;
                        }
                        toIterJ = 10;
                        fromIterJ = 5;
                        fromIterI = i;

                        for (int j = toIterJ; j < 13; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI++;
                        }
                        toIterJ = 13;
                        fromIterJ = 6;
                        fromIterI = i;

                        for (int j = toIterJ; j < 16; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI++;
                        }
                        toIterJ = 16;
                        fromIterJ = 1;
                        fromIterI = i;

                        for (int j = toIterJ; j < 19; j++)
                        {
                            excel.SelectWorkSheet(sheetNumber);
                            buff = excel.FromTo(fromIterI, fromIterJ);

                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, buff);
                            toIterJ++;
                            fromIterI++;
                        }
                        toIterI++;
                        toIterJ = 0;
                        fromIterJ = 0;
                    }
                }
                excel.VisibleOff();
                excel.Save();
                excel.Close();
                Comparison.Enabled = true;
            }
            catch
            {

            }      
        }

        private void Comparison_Click(object sender, EventArgs e)
        {
            try
            {
                int sheetNumberViborca = 0;
                int sheetNumber = 0;
                string buff = "";
                string buffFilter = "";
                string temp = "";
                int fromIterI = 1, fromIterJ = 2;
                int toIterI = 2, toIterJ = 25;
                int filterIterI = 1, filterIterJ = 1;
                int indicator = 0;
                int fromAmount = 0, filterAmount = 0;

                sheetNumber = Convert.ToInt32(textBox2.Text);
                sheetNumberViborca = Convert.ToInt32(textBox3.Text);

                Excel excel = new Excel(filePath1);
                excel.SelectWorkSheet(sheetNumber + 1);

                excel.SelectWorkSheet(sheetNumber + 1);
                excel.WriteToCell(0, 25, "Уходящие ордера");
                /*
                for (int i = 0; i < 4; i++)
                {
                    if (i == 1)
                        continue;
                    for (int j = fromIterI - 4; j != fromIterI; j++)
                    {
                        if (i == 2 && j == 4)
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, "Уточнение");
                            toIterJ++;
                        }

                        excel.SelectWorkSheet(sheetNumber);
                        buff = excel.FromTo(j, i);
                        if (buff == null)
                            continue;
                        else
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, buff);
                        }
                        toIterJ++;
                    }
                }
                */
                while (true)
                {
                    excel.SelectWorkSheet(sheetNumberViborca);
                    buff = excel.FromTo(fromIterI, fromIterJ);
                    if (buff == null)
                        break;
                    fromAmount++;
                    fromIterI++;
                }

                while (true)
                {
                    excel.SelectWorkSheet(sheetNumber + 1);
                    buffFilter = excel.FromTo(filterIterI, filterIterJ);
                    if (buffFilter == null)
                        break;
                    filterAmount++;
                    filterIterI++;
                }
                
                fromIterI = 1;
                filterIterI = 0;

                for (int i = 1; i != fromAmount + 1; i++)
                {
                    excel.SelectWorkSheet(sheetNumberViborca);
                    buff = excel.FromTo(i, fromIterJ);
                    
                    for (int j = 1; j != filterAmount + 1; j++)
                    {
                        excel.SelectWorkSheet(sheetNumber + 1);
                        buffFilter = excel.FromTo(j, filterIterJ);

                        if (buff == buffFilter)
                        {
                            indicator++;
                        }                       
                    }

                    if (indicator == 0)
                    {
                        for (int k = 0; k < 11; k++)
                        { 
                            excel.SelectWorkSheet(sheetNumberViborca);
                            temp = excel.FromTo(i, fromIterJ - 1);
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(toIterI, toIterJ, temp);
                            fromIterJ++;
                            toIterJ++;
                        }
                        fromIterJ = 2;
                        toIterI++;
                        toIterJ = 25;
                    }
                    indicator = 0;
                }
                
                toIterI++;
                fromIterI = 1;
                fromIterJ = 2;
                filterIterI = 1;
                filterIterJ = 1;

                excel.SelectWorkSheet(sheetNumber + 1);
                excel.WriteToCell(toIterI, toIterJ, "Приходящие ордера");
                toIterI += 2;
                /*
                for (int i = 0; i < 4; i++)
                {
                    if (i == 1)
                        continue;
                    for (int j = fromIterI - 4; j != fromIterI; j++)
                    {
                        if (i == 2 && j == 4)
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, "Уточнение");
                            toIterJ++;
                        }

                        excel.SelectWorkSheet(sheetNumber);
                        buff = excel.FromTo(j, i);
                        if (buff == null)
                            continue;
                        else
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            excel.WriteToCell(0, toIterJ, buff);
                        }
                        toIterJ++;
                    }
                }
                */
                for (int i = 1; i != filterAmount + 1; i++) 
                {
                    excel.SelectWorkSheet(sheetNumber + 1);
                    buff = excel.FromTo(i, filterIterJ); 

                    for (int j = 1; j != fromAmount + 1; j++)
                    {
                        excel.SelectWorkSheet(sheetNumberViborca);
                        buffFilter = excel.FromTo(j, fromIterJ);

                        if (buff == buffFilter)
                        {
                            indicator++;                            
                        }
                    }

                    if (indicator == 0)
                    {                      
                        for (int k = 0; k < 8; k++)
                        {
                            excel.SelectWorkSheet(sheetNumber + 1);
                            temp = excel.FromTo(i, filterIterJ - 1);
                            excel.WriteToCell(toIterI, toIterJ, temp);
                            filterIterJ++;
                            toIterJ++;
                        }
                        filterIterJ = 1;
                        toIterI++;
                        toIterJ = 25;
                    }
                    indicator = 0;
                }
                excel.VisibleOff();
                excel.Save();
                excel.Close();
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0) transformation.Enabled = false;
            else transformation.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox2.Text.Length == 0) transformation.Enabled = false;
            else transformation.Enabled = true;
            if (textBox3.Text.Length == 0) Comparison.Enabled = false;
            else Comparison.Enabled = true;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0) transformation.Enabled = false;
            else transformation.Enabled = true;
            Comparison.Enabled = false;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Excel excel = new Excel(filePath1);
            }
            catch
            {

            }
        }
    }
}