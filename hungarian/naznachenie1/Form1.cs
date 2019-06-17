using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naznachenie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           int rowCount = Convert.ToInt32(numeric1.Value);
            if (rowCount < 1) { rowCount = 1; } numeric1.Value = rowCount;
            grid1.RowCount = rowCount;
            int colCount = rowCount;
            
            grid1.ColumnCount = colCount;

            grid2.RowCount = rowCount;
         
            grid2.ColumnCount = colCount;

            grid1.Rows[rowCount - 1].HeaderCell.Value = "С" + rowCount.ToString();
            grid1.Columns[colCount - 1].HeaderCell.Value = "Ц" + colCount.ToString();

            grid2.Rows[rowCount - 1].HeaderCell.Value = "С" + rowCount.ToString();
            grid2.Columns[colCount - 1].HeaderCell.Value = "Ц" + colCount.ToString();

            Static.colEnd = colCount;
            Static.rowEnd = rowCount;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProg newForm = new FormProg();
            newForm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Static.matr1 = Static.Matr(grid1, Static.colEnd);
            if (Static.flagMatr == true)
            {
                Static.matr2 = Static.Matr(grid2, Static.colEnd);
                if (Static.flagMatr == true)
                {
                    FormEnd newForm = new FormEnd();


                    newForm.Show();
                }
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProg newForm = new FormProg();
            newForm.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
