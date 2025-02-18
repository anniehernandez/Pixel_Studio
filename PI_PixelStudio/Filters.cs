using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_PixelStudio
{
    public class Filters
    {
        public string FilterName { get; set; }
        public Image FilterImage { get; set; }
        public int FilterNumber { get; set; }

        public Filters(string name, Image img, int number)
        {
            FilterName = name;
            FilterImage = img;
            FilterNumber = number;
        }

        public void FilterPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = (Control)sender;

            Panel panel = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (panel != null && panel.Tag is Filters filter)
            {
                //ApplyFilter(filter.FilterNumber);
            }
        }
        //private void ApplyFilter(int filterNumber)
        //{
        //    switch (filterNumber)
        //    {
        //        case 0:
        //            Display.Image = originalImage;
        //            break;
        //        case 1:
        //            break;
        //    }
        //}
    }
}