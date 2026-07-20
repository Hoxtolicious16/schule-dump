using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymreps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            set_add();
            rep_add();
            weight_add();
            list_columns();
        }

        private void list_columns()
        {
            box_results.Columns.Add("Set", "Set");
            box_results.Columns.Add("Reps", "Reps");
            box_results.Columns.Add("Gewicht", "Gewicht");
        }
        private void set_add()
        {
            int sets = 1;
            for (int i = 0; i <= 4; i++)
            {
                cbo_set.Items.Add(sets);
                sets++;
            }
                
        }
        private void rep_add()
        {
            int reps = 1;
            for (int i = 0; i <= 9; i++)
            {
                cbo_reps.Items.Add(reps);
                reps++;
            }

        }

        private void weight_add()
        {
            int gewicht = 10;
            for (int i = 0; i <= 29; i++)
            {
                cbo_weight.Items.Add(gewicht);
                gewicht += 10;
            }
        }
        private void add_result(string set, string rep, string weight)
        {
            int current_set = Convert.ToInt32(set);
            int reps = Convert.ToInt32(rep);

            for (int i = 1; i <= reps; i++)
            {
                if (i == 1)
                {
                    box_results.Rows.Add(current_set, i, weight);
                }
                else
                {
                    box_results.Rows.Add("", i, weight);
                }

            }
        }
        private void cbo_set_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_reps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_weight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            add_result(cbo_set.SelectedItem.ToString(), cbo_reps.SelectedItem.ToString(), cbo_weight.SelectedItem.ToString());
        }
    }
}
