using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.PL
{
    public partial class frm_type_of_add_employee : Form
    {
        BL.Client client = new BL.Client();
        public frm_type_of_add_employee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_add_employee frm = new frm_add_employee();
            frm.txt_emp_id.Text = client.get_last_client_id().Rows[0][0].ToString();

            for (int i = 0; i < client.get_role_and_department().Rows.Count; i++)
            {


                frm.combo_role.Items.Add(client.get_role_and_department().Rows[i][1]);
                frm.combo_department.Items.Add(client.get_role_and_department().Rows[i][2]);


            }


            List<object> departments = new List<object>();
            foreach (object o in frm.combo_department.Items)
            {
                if (!departments.Contains(o))
                {
                    departments.Add(o);
                }
            }
            frm.combo_department.Items.Clear();
            frm.combo_department.Items.AddRange(departments.ToArray());

            List<object> roles = new List<object>();
            foreach (object o in frm.combo_role.Items)
            {
                if (!roles.Contains(o))
                {
                    roles.Add(o);
                }
            }
            frm.combo_role.Items.Clear();
            frm.combo_role.Items.AddRange(roles.ToArray());


            for (int i = 0; i < client.get_type_of_salary().Rows.Count; i++)
            {

                frm.combo_type_of_salary.Items.Add(client.get_type_of_salary().Rows[i][0]);


            }

            frm.rd_new_employee.Checked = true;
            /*
            frm.combo_type_of_salary.SelectedIndex = 0;
            frm.combo_department.SelectedIndex = 0;
            frm.combo_role.SelectedIndex = 0;
            */
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_sheet_of_clients frm = new add_sheet_of_clients();
            frm.ShowDialog();
        }

        private void frm_type_of_add_employee_Load(object sender, EventArgs e)
        {

        }
    }
}
