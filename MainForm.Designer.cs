
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
            this.SheetA = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.SheetB = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.MainConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SheetA
            // 
            this.SheetA.Location = new System.Drawing.Point(12, 12);
            this.SheetA.Name = "SheetA";
            this.SheetA.Size = new System.Drawing.Size(536, 208);
            this.SheetA.TabIndex = 0;
            this.SheetA.Text = "spreadsheetControl1";
            this.SheetA.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(this.onSheetA_CellValueChanged);
            // 
            // SheetB
            // 
            this.SheetB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SheetB.Location = new System.Drawing.Point(12, 226);
            this.SheetB.Name = "SheetB";
            this.SheetB.Size = new System.Drawing.Size(536, 212);
            this.SheetB.TabIndex = 2;
            this.SheetB.Text = "spreadsheetControl1";
            // 
            // MainConsole
            // 
            this.MainConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainConsole.Location = new System.Drawing.Point(554, 12);
            this.MainConsole.Multiline = true;
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.ReadOnly = true;
            this.MainConsole.Size = new System.Drawing.Size(234, 426);
            this.MainConsole.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SheetB);
            this.Controls.Add(this.MainConsole);
            this.Controls.Add(this.SheetA);
            this.Name = "MainWindow";
            this.Text = "XCellDevPress";
            this.Shown += new System.EventHandler(this.onMainWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl SheetA;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl SheetB;
        private System.Windows.Forms.TextBox MainConsole;
    }
}

