using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining_Decision_Tree_Using_CART
{
    class Cart
    {
        private List<List<Data>> fullData;
        private List<List<Data>> uniqueData;
        private List<int> indexOfContinuousData;

        public Cart(List<List<Data>> fullData , List<List<Data>> uniqueData,List<int> indexOfContinuousData)
        {
            this.fullData = fullData;
            this.uniqueData = uniqueData;
            this.indexOfContinuousData = indexOfContinuousData;
        }


        public void applyCART()
        {



        }

        private double calculateTethaValue()
        {


        }
    }
}
