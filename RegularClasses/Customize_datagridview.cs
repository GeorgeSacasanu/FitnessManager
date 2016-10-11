using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_db;

namespace RegularClasses
{
    static public class customize_datagridview
    {
        public static void equalize_columns_size(DataGridView input)
        {
            int rowheadwidth = Int32.Parse(input.RowHeadersWidth.ToString());
            int scrollbarwidth = 0;
            foreach (var scroll in input.Controls.OfType<VScrollBar>())
            {
                if(scroll.Visible)
                {
                    scrollbarwidth = Int32.Parse(SystemInformation.VerticalScrollBarWidth.ToString());
                }
            }
            int visiblecolumns = 0;
            for (int i = 0; i < input.Columns.Count; i++)
            {
                if (input.Columns[i].Visible == true)
                {
                    visiblecolumns++;
                }
            }
            float availablespace = input.Width - (rowheadwidth + scrollbarwidth) - 2;
            for (int i = 0; i < input.Columns.Count; i++)
            {
                if (input.Columns[i].Visible == true)
                {
                    input.Columns[i].Width = Convert.ToInt32(Math.Round(availablespace / visiblecolumns));
                }

            }
        }
        public static void Trainings_firstload(DataGridView input, bool isadmin, string usern, ComboBox filter_user_cb, Label filter_description)
        {
            var db = new Model1();
            if (isadmin) // IS ADMIN
            {

                input.DataSource = db.Trainings.ToList();
                input.Columns.Add("username", "username");
                foreach (DataGridViewRow item in input.Rows)
                {
                    var user_id = Convert.ToInt32(input.Rows[item.Index].Cells[2].Value);
                    input.Rows[item.Index].Cells[5].Value = db.Users.Where(m => m.id == user_id).First().username;
                }

                filter_user_cb.Items.Add("--All Users--");
                foreach (var item in db.Users)
                {
                    filter_user_cb.Items.Add(item.username);
                }
                filter_user_cb.SelectedIndex = 0;
            }
            else // NOT ADMIN
            {
                input.DataSource = db.Trainings.Where(m => m.Users.username == usern).ToList();
                filter_description.Dispose();
                filter_user_cb.Dispose();
            }
            input.Columns[0].Visible = false;
            input.Columns[2].Visible = false;
            input.Columns[3].Visible = false;
            input.Columns[4].Visible = false;

            equalize_columns_size(input);
        }  
        public static void hide_all_columns(DataGridView input, int visible_col_index)
        {
            foreach(DataGridViewColumn column in input.Columns)
            {
                if(column.Index!= visible_col_index)
                {
                    column.Visible = false;
                }
            }
        }
        public static void hide_all_columns(DataGridView input, int visible_col_index1, int visible_col_index2)
        {
            foreach (DataGridViewColumn column in input.Columns)
            {
                if ((column.Index != visible_col_index1) && (column.Index != visible_col_index2))
                {
                    column.Visible = false;
                }
            }
        }
        public static void hide_all_columns(DataGridView input, int visible_col_index1, int visible_col_index2, int visible_col_index3)
        {
            foreach (DataGridViewColumn column in input.Columns)
            {
                if ((column.Index != visible_col_index1) && (column.Index != visible_col_index2) && (column.Index != visible_col_index3))
                {
                    column.Visible = false;
                }
            }
        }

    }
}
