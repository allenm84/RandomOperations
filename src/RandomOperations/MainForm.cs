using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomOperations
{
  public partial class MainForm : Form
  {
    private Operation operation;

    public MainForm()
    {
      InitializeComponent();
      InitializeList();
    }

    private void InitializeList()
    {
      gridOperations.SetPropertiesToList(false, false);
      gridOperations.SetDoubleBuffered(true);
      gridOperations.RowTemplate.Height = 20;
      gridOperations.AutoGenerateColumns = false;
      gridOperations.Columns.AddDataBoundColumn("DisplayName");
    }

    private void SetInputVisible(bool visible)
    {
      lblInput.Visible = visible;
      tblInputResult.SuspendLayout();
      tblInputResult.RowStyles[1] = visible ?
        new RowStyle(SizeType.Percent, 50) :
        new RowStyle(SizeType.AutoSize);
      tblInputResult.ResumeLayout(true);
      gridInput.Visible = visible;
    }

    private void LoadCurrentOperation()
    {
      operation = null;

      var row = gridOperations.CurrentRow;
      if (row != null)
      {
        operation = row.DataBoundItem as Operation;
      }

      bool inputNeeded = true;
      object inputObject = null;

      if (operation != null)
      {
        btnRun.Enabled = true;
        tblInputResult.Enabled = true;
        inputNeeded = operation.NeedsInput;
        inputObject = inputNeeded ? operation.DataSource : null;
      }
      else
      {
        btnRun.Enabled = false;
        tblInputResult.Enabled = false;
      }

      SetInputVisible(inputNeeded);
      gridInput.SelectedObject = inputObject;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      var type = typeof(Operation);
      gridOperations.DataSource = type
        .Assembly
        .GetTypes()
        .Where(t => t.IsSubclassOf(type))
        .Select(t => (Operation)Activator.CreateInstance(t))
        .OrderBy(o => o.DisplayName)
        .ToList();

      LoadCurrentOperation();
    }

    private void gridOperations_SelectionChanged(object sender, EventArgs e)
    {
      LoadCurrentOperation();
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
      if (operation != null)
      {
        try
        {
          string[] result = operation.GetResult();
          txtResult.Lines = result;
        }
        catch(Exception ex)
        {
          MessageBox.Show(this, ex.Message, "Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
