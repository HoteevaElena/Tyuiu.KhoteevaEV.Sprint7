using System.IO;
namespace Tyuiu.KhoteevaEV.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public int Row(string path)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }

            }
            return len;
        }

        public string[,] BasaD(string path, int row, int col)
        {
            string[,] mat = new string[row, col];
            int j = 0;
            String line = String.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                String[] parts_of_line = line.Split(';');
                for (int i = 0; i < parts_of_line.Length; i++)
                {
                    parts_of_line[i] = parts_of_line[i].Trim();
                    mat[j, i] = parts_of_line[i].Trim();
                }
                j++;
            }
            return mat;
        }

        public double Amount(string[,] mat, int row)
        {
            double value = 0;
            for (int i = 0; i < row - 1; i++)
            {
                value += Convert.ToDouble(mat[i, 2]);
            }
            return value;

        }

        public double AllCost(string[,] mat, int row)
        {
            double allcost = 0;
            for(int i = 0; i < row - 1; i++)
            {
                allcost += Convert.ToDouble(mat[i, 2]) * Convert.ToDouble(mat[i, 3]);
            }
            return allcost;
        }

        public double MaxCost(string[,] mat, int row)
        {
            double maxcost = -1000;
            for(int i = 0; i < row - 1; i++)
            {
                if(maxcost < Convert.ToDouble(mat[i, 3]))
                {
                    maxcost = Convert.ToDouble(mat[i, 3]);
                }
            }

            return maxcost;
        }

        public double MinCost(string[,] mat, int row)
        {
            double mincost = 10000000000000000000;
            for (int i = 0; i < row - 1; i++)
            {
                if (mincost > Convert.ToDouble(mat[i, 3]))
                {
                    mincost = Convert.ToDouble(mat[i, 3]);
                }
            }

            return mincost;
        }

        //public string[,] SortName(string[,] mat,int row)
        //{
        //    string[][] data = new string[row][];
        //    for(int i = 0; i < row; i++)
        //    {
        //        data[i] = new string[5] mat[i, j];
        //    }
        //}
    }

    
}
