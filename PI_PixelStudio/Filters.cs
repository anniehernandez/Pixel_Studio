using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_PixelStudio
{
    public class Filters
    {
        public string FilterName {  get; set; }
        public Image FilterImage {  get; set; }
        public int FilterNumber {  get; set; }

        public Filters(string name, Image img, int number)
        {
            FilterName = name; 
            FilterImage = img;
            FilterNumber = number;
        }
    }
}