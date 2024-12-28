using System.Windows.Forms;
using System.IO;
using Tyuiu.KhoteevaEV.Sprint7.Project.V5.Lib;
using static System.Net.WebRequestMethods;
namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();

        static int rows;
        static int columns;
        public string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonOpen_HEV_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            int col = 5;
            int row = ds.Row(openFilePath);
            dataGridViewBase_HEV.RowCount = row;
            dataGridViewBase_HEV.ColumnCount = col;
            dataGridViewBase_HEV.Columns[0].HeaderText = "Код";
            dataGridViewBase_HEV.Columns[1].HeaderText = "Название";
            dataGridViewBase_HEV.Columns[2].HeaderText = "Кол-во";
            dataGridViewBase_HEV.Columns[3].HeaderText = "Стоимость";
            dataGridViewBase_HEV.Columns[4].HeaderText = "Прим.";
            string[,] mat = new string[row, col];
            mat = ds.BasaD(openFilePath, row, col);
            int c = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewBase_HEV.Rows[c].Cells[j].Value = mat[i, j];
                }
                c++;
            }


            this.chartCostData_HEV.ChartAreas[0].AxisX.Title = "Код товара";
            this.chartCostData_HEV.ChartAreas[0].AxisY.Title = "Стоимость товара";
            chartCostData_HEV.Series[0].Points.Clear();
            for (int i = 0; i < row - 1; i++)
            {
                this.chartCostData_HEV.Series[0].Points.AddXY(Convert.ToDouble(mat[i, 0]), Convert.ToDouble(mat[i, 3]));
            }

            //textBoxMinAmount_HEV.Text = Convert.ToString(ds.MinAmount(mat, row));
            //textBoxMaxAmount_HEV.Text = Convert.ToString(ds.MaxAmount(mat, row));
            //textBoxMeanStep_BYS.Text = Convert.ToString(ds.Mean(mat, row));
            textBoxAmountProducts_HEV.Text = Convert.ToString(ds.Amount(mat, row));
            textBoxCostAllProducts_HEV.Text = Convert.ToString(ds.AllCost(mat, row));
            textBoxAverageCost_HEV.Text = Convert.ToString(ds.AllCost(mat, row) / ds.Amount(mat, row));
            textBoxMaxCostUnit_HEV.Text = Convert.ToString(ds.MaxCost(mat, row));
            textBoxMinCostUnit_HEV.Text = Convert.ToString(ds.MinCost(mat, row));

            buttonSearch_HEV.Enabled = true;
            buttonSave_HEV.Enabled = true;
            buttonAddRow_HEV.Enabled = true;
            buttonDeleteRow_HEV.Enabled = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_HEV_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutFileDataBase.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                System.IO.File.Delete(path);
            }
            int rows = dataGridViewBase_HEV.RowCount;
            int columns = dataGridViewBase_HEV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_HEV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_HEV.Rows[i].Cells[j].Value;
                    }
                }
                System.IO.File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAddRow_HEV_Click(object sender, EventArgs e)
        {
            dataGridViewBase_HEV.AllowUserToAddRows = false;
            this.dataGridViewBase_HEV.Rows.Add();
            dataGridViewBase_HEV.AllowUserToAddRows = true;
        }

        private void buttonDeleteRow_HEV_Click(object sender, EventArgs e)
        {
            dataGridViewBase_HEV.AllowUserToAddRows = false;
            this.dataGridViewBase_HEV.Rows.RemoveAt(dataGridViewBase_HEV.RowCount - 1);
            dataGridViewBase_HEV.AllowUserToAddRows = true;
        }

        private void buttonSort_HEV_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_HEV_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();
        }

        private void buttonInfo_HEV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
