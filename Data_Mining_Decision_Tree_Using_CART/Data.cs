using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining_Decision_Tree_Using_CART
{
    class Data : IComparable
    {
        public string type { get;}
        public string content { get;}

        /// <summary>
        /// data construcutor 
        /// </summary>
        /// <param name="type"> the column to which the data belongs </param>
        /// <param name="content">data </param>
        public Data(string type , string content)
        {
            this.type = type;
            this.content = content;
        }

        /// <summary>
        ///  get data information
        /// </summary>
        /// <returns>info</returns>
        public override string ToString()
        {
            return "Type : " + type + "  Content : " + content;
        }


        /// <summary>
        /// using hash set 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (type + content).GetHashCode();
        }

        /// <summary>
        /// to obtain unique data
        /// </summary>
        /// <param name="obj">other data</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Data other = obj as Data;
            if (other == null)
            {
                return false;
            }
            return type == other.type && content == other.content;
        }

        /// <summary>
        /// for ascending order 
        /// </summary>
        /// <param name="obj"> other data</param>
        /// <returns> priority status </returns>
        public int CompareTo(object obj)
        {
            Data other = obj as Data;
            try
            {
                int x = Convert.ToInt32(content);
                int y = Convert.ToInt32(other.content);

                if (x > y) return 1;
                return -1;
            }
            catch(Exception) // generally format exception
            {
                return 0;
            }
            
        }
    }
}
