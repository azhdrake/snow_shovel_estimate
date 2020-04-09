using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowShovel
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // gets the date range.
      dtDateRequested.MinDate = DateTime.Today;
      dtDateRequested.MaxDate = DateTime.Today.AddDays(7);
    }

    private void btnAddRequest_Click(object sender, EventArgs e)
    {
      // Sets up the new form 
      FormSpecialRequests frmSpecialRequests = new FormSpecialRequests();
      frmSpecialRequests.Tag = lblSpecialRequests.Text;
      DialogResult specialRequestResult = frmSpecialRequests.ShowDialog();

      // Checks if the user submitted their changes and if so sets the special request label to the form's tag.
      if(specialRequestResult == DialogResult.OK)
      {
        if(frmSpecialRequests.Tag is string specialRequests)
        {
          lblSpecialRequests.Text = specialRequests;
        }
      }
    }

    private void btnGetEstimate_Click(object sender, EventArgs e)
    {
      string name = txtName.Text;
      string address = txtAddress.Text;
      DateTime date = dtDateRequested.Value;

      // Validate! That! Data!
      if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(address) || date == null)
      {
        MessageBox.Show("Please fill in all fields.", "Error");
        return;
      }

      // Caculate! That! Price!
      double price;
      if (rbSingle.Checked)
      {
        price = 20;
      }
      else if (rbCorner.Checked)
      {
        price = 30;
      }
      else
      {
        MessageBox.Show("Please select sidewalk type.", "Error");
        return;
      }

      if (date.Date == DateTime.Today)
      {
        price += 5;
      }

      txtEstimate.Text = $"{price:c}";

    }
  }
}
