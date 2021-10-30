
namespace XCellDevPress
{
    partial class MainWindow
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
            this.MainSpreadsheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.MainConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainSpreadsheet
            // 
            this.MainSpreadsheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSpreadsheet.Location = new System.Drawing.Point(0, 0);
            this.MainSpreadsheet.Name = "MainSpreadsheet";
            this.MainSpreadsheet.Size = new System.Drawing.Size(800, 424);
            this.MainSpreadsheet.TabIndex = 0;
            this.MainSpreadsheet.Text = "spreadsheetControl1";
            this.MainSpreadsheet.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(this.spreadsheetControl1_CellValueChanged);
            // 
            // MainConsole
            // 
            this.MainConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainConsole.Location = new System.Drawing.Point(0, 430);
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.ReadOnly = true;
            this.MainConsole.Size = new System.Drawing.Size(800, 20);
            this.MainConsole.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainConsole);
            this.Controls.Add(this.MainSpreadsheet);
            this.Name = "MainWindow";
            this.Text = "XCellDevPress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl MainSpreadsheet;
        private System.Windows.Forms.TextBox MainConsole;
    }
}

