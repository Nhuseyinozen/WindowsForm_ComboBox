using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_ComboBox
{
    public class product
    {
        public int id { get; set; }
        public int stockQuantity { get; set; }
        public string productImage { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string writer { get; set; }
        public string explanation { get; set; }

        public override string ToString()
        {
            return productName;
        }
    }
}
