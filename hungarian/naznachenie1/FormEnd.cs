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
    public partial class FormEnd : Form
    {
 

        public FormEnd()
        {
            InitializeComponent();
            List<int> markIndex = new List<int>();// Индекс помеченного столбца в строке
            gridSupport.RowCount = Static.rowEnd;
            gridSupport.ColumnCount = Static.colEnd;
            gridFinal.RowCount = Static.rowEnd;
            gridFinal.ColumnCount = Static.colEnd;
            Static.ConvolutionMatr(Static.matr1, Static.matr2,ref Static.matr3);
            Hungarian hungarian = new Hungarian(Static.matr3);
            
            SupportGrid(gridSupport, Static.matr3);
            SupportGrid(gridFinal, hungarian.HungarianMethod(ref markIndex));
            dataGridView1.ColumnCount = Static.colEnd;
            dataGridView1.RowCount = 1;
            Static.VectorToTable(dataGridView1, markIndex);

        }

        private void SupportGrid(DataGridView grid, double[,] matr)  //Получение таблицы из матрицы 
        {
            Static.MatrToTable(grid, matr);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridSupport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
