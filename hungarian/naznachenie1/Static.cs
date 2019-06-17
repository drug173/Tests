using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naznachenie1
{
    class Static
    {
        public static double[,] matr1 = new double[colEnd, rowEnd];
        public static double[,] matr2 = new double[colEnd, rowEnd];
        public static double[,] matr3;
        public static int colEnd, rowEnd;
        public static bool flagMatr = true;

        public static double[,] Matr(DataGridView grid13, int N)  //Получение матрицы из таблицы
        {
            double[,] matr = new double[N, N];
            
            try
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matr[i, j] = Convert.ToDouble(grid13[j, i].Value);
                    }
                }
                flagMatr = true;
            }
            catch
            {
             MessageBox.Show(
               "Проверьте правильность ввода, не во всех полях числа!",
               "Ошибка ввода",
               MessageBoxButtons.RetryCancel,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
                flagMatr = false;
            }
            
            return matr;
        }

        //получение таблицы из вектора
        public static void VectorToTable(DataGridView grid, List<int> markIndex)
        {
            for(int j= 0; j < colEnd; j++)
           {

                grid.Rows[0].Cells[j].Value = "Ц" + (markIndex[j] + 1).ToString();
            }

        }



        public static void MatrToTable(DataGridView grid, double[,] matr) //Получение таблицы из матрицы
        {
            for (int i = 0; i < colEnd; i++)
            {
                grid.Rows[i].HeaderCell.Value = "С" + (i + 1).ToString();
                for (int j = 0; j < rowEnd; j++)
                {
                    grid.Rows[i].Cells[j].Value = matr[i, j].ToString();
                    grid.Columns[j].HeaderText = "Ц" + (j + 1).ToString();
                }
            }
        }


        //Свёртка критериев
        public static void ConvolutionMatr(double[,]matr1,double[,]matr2,ref double[,]matr3)
        {
            matr3 = new double[colEnd, rowEnd];
            for (int i = 0; i < rowEnd; i++)
            {
                for(int j = 0; j < colEnd; j++)
                {
                    matr3[i, j] = matr1[i, j] + matr2[i, j];

                }

            }

        }

    }
}