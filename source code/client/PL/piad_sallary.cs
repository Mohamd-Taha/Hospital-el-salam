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
    public partial class piad_sallary : Form
    {BL.Client client=new BL.Client();
  
        public piad_sallary()
        {
          
            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_client_search_TextChanged(object sender, EventArgs e)
        {
               if (txt_client_search.Text != string.Empty)
            {
                dataGridView1.DataSource = client.search_in_clients(txt_client_search.Text);
            }
            else
                dataGridView1.DataSource = client.getCleint();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            { 

                bool is_checked=Convert.ToBoolean( dataGridView1.Rows[i].Cells[0].Value);
                if (is_checked == true)
                { 
                client.add_piad_sallary(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),dateTimePicker1.Value,Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value),comb_month.SelectedItem.ToString(),combo_year.SelectedItem.ToString());
                client.update_client_sallary_state(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString(), "received");
                }
              
            }
            MessageBox.Show("تم");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            frm_employee frm = new frm_employee();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                bool is_checked = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                if (is_checked == true)
                {
                    client.add_piad_sallary(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value, Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value), comb_month.SelectedItem.ToString(), combo_year.SelectedItem.ToString());
                    client.update_client_sallary_state(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString(), "received");
                }

            }
            
            dataGridView1.Update();
            MessageBox.Show("تم التسليم بنجاح");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void piad_sallary_Load(object sender, EventArgs e)
        {

        }
    }
        }
        
    

