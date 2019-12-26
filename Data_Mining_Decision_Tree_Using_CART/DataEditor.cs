using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Data_Mining_Decision_Tree_Using_CART
{
    static class  DataEditor
    {
        private static List<List<Data>> fullData = new List<List<Data>>();
        private static List<List<Data>> uniqueData = new List<List<Data>>();
        private static List<int> indexOfContinuousData = new List<int>();
        /// <summary>
        /// I got data in file.
        /// </summary>
        public static void GetData()
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\trainSet.csv";
            StreamReader file =  new  StreamReader(path);

            //determined the count of columns
            string[] columns = file.ReadLine().Split(',');

            //create columns 
            for(int i = 0; i < columns.Length; i++)
                fullData.Add(new List<Data>());

            //I placed data
            string temp;
            string[] pieces;
            bool continuousCheck = false;
            while((temp = file.ReadLine()) != null)
            {
               

                pieces = temp.Split(',');
                for (int i = 0; i < pieces.Length; i++)
                {
                    if(!continuousCheck)
                    {
                        try
                        {
                            //if it is a continuous value, I add the index to the list
                            //for dynamic app
                            Convert.ToInt32(pieces[i]);
                            indexOfContinuousData.Add(i);

                        }
                        catch (FormatException) { }
                        
                    }

                    fullData[i].Add(new Data(columns[i], pieces[i]));
                }
                continuousCheck = true;

            }

        }

        /// <summary>
        /// adds unique ones to the data structure
        /// </summary>
        public static void MakeDataUnique()
        {
            HashSet<Data> set;
            for (int i = 0; i < fullData.Count; i++)
            {
                set = new HashSet<Data>(fullData[i]);
                uniqueData.Add(new List<Data>(set.ToList()));
            }

        }

        public static List<List<Data>> getFullData()
        {
            return fullData;
        }

        public static List<List<Data>> getFullData()
        {
            return fullData;
        }















    }
}
