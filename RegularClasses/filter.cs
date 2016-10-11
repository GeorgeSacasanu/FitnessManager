using EntityFramework_db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularClasses
{
    public static class filter
    {
        public static void filter_trainings_by_user(DataGridView input_data, ComboBox cbox)
        {
            var db = new Model1();
            if (cbox.SelectedIndex != 0)
            {
                input_data.Columns.Remove("username");
                var user_filter = db.Users.Where(m => m.username == cbox.Text).First();
                input_data.DataSource = db.Trainings.Where(m => m.id_users == user_filter.id).ToList();
                input_data.Columns.Add("username", "username");
                foreach (DataGridViewRow item in input_data.Rows)
                {
                    var user_id = Convert.ToInt32(input_data.Rows[item.Index].Cells[2].Value);
                    input_data.Rows[item.Index].Cells[5].Value = db.Users.Where(m => m.id == user_id).First().username;
                }
            }
            else
            {
                input_data.Columns.Remove("username");
                input_data.DataSource = db.Trainings.ToList();
                input_data.Columns.Add("username", "username");
                foreach (DataGridViewRow item in input_data.Rows)
                {
                    var user_id = Convert.ToInt32(input_data.Rows[item.Index].Cells[2].Value);
                    input_data.Rows[item.Index].Cells[5].Value = db.Users.Where(m => m.id == user_id).First().username;
                }
            }

        }
    }
}
