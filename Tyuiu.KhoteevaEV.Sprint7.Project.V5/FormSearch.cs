using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhoteevaEV.Sprint7.Project.V5.Lib;

namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_HEV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_HEV_Click(object sender, EventArgs e)
        {
            int col = 5;
            int row = ds.Row(openFilePath);
            string[,] mat = ds.BasaD(openFilePath, row, col);
            string str = textBoxFind_HEV.Text;

            int k = 1;

            for (int i = 0; i < mat.GetLength(0); i++)
            {

                if (mat[i, 0] == str)
                {
                    textBoxNameProduct_HEV.Text = mat[i, k];
                    k++;
                    textBoxAmount_HEV.Text = mat[i, k];
                    k++;
                    textBoxCost_HEV.Text = mat[i, k];
                    k++;
                    textBoxAbout_HEV.Text = mat[i, k];


                }

            }
        }

        private void buttonOpen_HEV_Click(object sender, EventArgs e)
        {
            openFileDialogSearch.ShowDialog();
            openFilePath = openFileDialogSearch.FileName;
            buttonSearch_HEV.Enabled = true;
        }

       
    }
}
