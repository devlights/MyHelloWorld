namespace HelloWorld.Win
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
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnExec = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(13, 13);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(259, 19);
      this.txtName.TabIndex = 0;
      // 
      // btnExec
      // 
      this.btnExec.Location = new System.Drawing.Point(196, 39);
      this.btnExec.Name = "btnExec";
      this.btnExec.Size = new System.Drawing.Size(75, 23);
      this.btnExec.TabIndex = 1;
      this.btnExec.Text = "PushMe";
      this.btnExec.UseVisualStyleBackColor = true;
      // 
      // txtResult
      // 
      this.txtResult.Location = new System.Drawing.Point(13, 121);
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(259, 19);
      this.txtResult.TabIndex = 2;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.txtResult);
      this.Controls.Add(this.btnExec);
      this.Controls.Add(this.txtName);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnExec;
    private System.Windows.Forms.TextBox txtResult;
  }
}