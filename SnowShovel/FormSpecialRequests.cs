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
  public partial class FormSpecialRequests : Form
  {
    public bool saved = false;
    public FormSpecialRequests()
    {
      InitializeComponent();
    }

    private void FormSpecialRequests_Load(object sender, EventArgs e)
    {
      // Sets the inital text.
      txtRequests.Text = Tag.ToString();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      // Sets the current text to the tag to send to the other form, cleans up and closes.
      Tag = txtRequests.Text;
      DialogResult = DialogResult.OK;
      saved = true;
      Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      // You'll never guess what this one does.
      Close();
    }

    private void frmSpecialRequests_Close(Object sender, FormClosingEventArgs e)
    {
      // Modifies the default close method to test if the user has made any changes and ensure they really mean to close without saving those changes.
      bool userMadeChanges = Tag.ToString() != txtRequests.Text;

      if(!saved && userMadeChanges)
      {
        DialogResult closeResult = MessageBox.Show("Your changes are not saved, close anyway?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if(closeResult == DialogResult.No)
        {
          e.Cancel = true;
        }
      }
    }
  }
}
