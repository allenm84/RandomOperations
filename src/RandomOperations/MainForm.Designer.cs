namespace RandomOperations
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.gridOperations = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.tblInputResult = new System.Windows.Forms.TableLayoutPanel();
      this.txtResult = new System.Windows.Forms.RichTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblInput = new System.Windows.Forms.Label();
      this.gridInput = new System.Windows.Forms.PropertyGrid();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnRun = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridOperations)).BeginInit();
      this.tblInputResult.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.gridOperations);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tblInputResult);
      this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(1);
      this.splitContainer1.Size = new System.Drawing.Size(449, 302);
      this.splitContainer1.SplitterDistance = 200;
      this.splitContainer1.TabIndex = 0;
      // 
      // gridOperations
      // 
      this.gridOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridOperations.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridOperations.Location = new System.Drawing.Point(1, 20);
      this.gridOperations.Name = "gridOperations";
      this.gridOperations.Size = new System.Drawing.Size(198, 281);
      this.gridOperations.TabIndex = 2;
      this.gridOperations.SelectionChanged += new System.EventHandler(this.gridOperations_SelectionChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(1, 1);
      this.label1.Margin = new System.Windows.Forms.Padding(3);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(3);
      this.label1.Size = new System.Drawing.Size(70, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Operations:";
      // 
      // tblInputResult
      // 
      this.tblInputResult.ColumnCount = 1;
      this.tblInputResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tblInputResult.Controls.Add(this.txtResult, 0, 3);
      this.tblInputResult.Controls.Add(this.label3, 0, 2);
      this.tblInputResult.Controls.Add(this.lblInput, 0, 0);
      this.tblInputResult.Controls.Add(this.gridInput, 0, 1);
      this.tblInputResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tblInputResult.Location = new System.Drawing.Point(1, 1);
      this.tblInputResult.Margin = new System.Windows.Forms.Padding(0);
      this.tblInputResult.Name = "tblInputResult";
      this.tblInputResult.RowCount = 4;
      this.tblInputResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblInputResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tblInputResult.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tblInputResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tblInputResult.Size = new System.Drawing.Size(243, 300);
      this.tblInputResult.TabIndex = 2;
      // 
      // txtResult
      // 
      this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtResult.Location = new System.Drawing.Point(3, 178);
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(237, 119);
      this.txtResult.TabIndex = 3;
      this.txtResult.Text = "";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 153);
      this.label3.Margin = new System.Windows.Forms.Padding(3);
      this.label3.Name = "label3";
      this.label3.Padding = new System.Windows.Forms.Padding(3);
      this.label3.Size = new System.Drawing.Size(47, 19);
      this.label3.TabIndex = 2;
      this.label3.Text = "Result:";
      // 
      // lblInput
      // 
      this.lblInput.AutoSize = true;
      this.lblInput.Location = new System.Drawing.Point(3, 3);
      this.lblInput.Margin = new System.Windows.Forms.Padding(3);
      this.lblInput.Name = "lblInput";
      this.lblInput.Padding = new System.Windows.Forms.Padding(3);
      this.lblInput.Size = new System.Drawing.Size(43, 19);
      this.lblInput.TabIndex = 0;
      this.lblInput.Text = "Input:";
      // 
      // gridInput
      // 
      this.gridInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridInput.HelpVisible = false;
      this.gridInput.Location = new System.Drawing.Point(3, 28);
      this.gridInput.Name = "gridInput";
      this.gridInput.PropertySort = System.Windows.Forms.PropertySort.NoSort;
      this.gridInput.Size = new System.Drawing.Size(237, 119);
      this.gridInput.TabIndex = 4;
      this.gridInput.ToolbarVisible = false;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnRun, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 332);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // btnRun
      // 
      this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnRun.Location = new System.Drawing.Point(187, 305);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(75, 23);
      this.btnRun.TabIndex = 1;
      this.btnRun.Text = "Run";
      this.btnRun.UseVisualStyleBackColor = true;
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(455, 338);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(3);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Random Operations";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridOperations)).EndInit();
      this.tblInputResult.ResumeLayout(false);
      this.tblInputResult.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblInput;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.TableLayoutPanel tblInputResult;
    private System.Windows.Forms.RichTextBox txtResult;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView gridOperations;
    private System.Windows.Forms.PropertyGrid gridInput;

  }
}

