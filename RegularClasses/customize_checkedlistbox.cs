using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegularClasses
{
    public static class customize_checkedlistbox
    {
        public static void clear(CheckedListBox lbox)
        {
            for (int i = 0; i < lbox.Items.Count; i++)
            {
                lbox.SetItemChecked(i, false);

            }
        }
        public static void check_common_ellements(CheckedListBox lbox, Chart result_bySeries)
        {
            for (int i = 0; i < lbox.Items.Count; i++)
            {
                for (int j = 0; j < result_bySeries.Series.Count; j++)
                {

                    if (result_bySeries.Series[j].ToString() == ("Series-" + lbox.Items[i].ToString()))
                    {
                        lbox.SetItemChecked(i, true);
                    }
                }
            }
        }
        public static List<string> output_list(CheckedListBox lbox)
        {
            var list = new List<string>();
            foreach(var item in lbox.Items)
            {
                list.Add(item.ToString());
            }
            return list;
        }
    }
}
