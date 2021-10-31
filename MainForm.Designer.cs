
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
            this.MainNav = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // SheetA
            // 
            this.SheetA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetA.Location = new System.Drawing.Point(225, 12);
            this.SheetA.Name = "SheetA";
            this.SheetA.Size = new System.Drawing.Size(563, 208);
            this.SheetA.TabIndex = 0;
            this.SheetA.Text = "spreadsheetControl1";
            this.SheetA.CellValueChanged += new DevExpress.XtraSpreadsheet.CellValueChangedEventHandler(this.onSheetA_CellValueChanged);
            // 
            // SheetB
            // 
            this.SheetB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SheetB.Location = new System.Drawing.Point(225, 226);
            this.SheetB.Name = "SheetB";
            this.SheetB.Size = new System.Drawing.Size(563, 212);
            this.SheetB.TabIndex = 2;
            this.SheetB.Text = "spreadsheetControl1";
            // 
            // MainNav
            // 
            this.MainNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainNav.Location = new System.Drawing.Point(12, 12);
            this.MainNav.Name = "MainNav";
            this.MainNav.Size = new System.Drawing.Size(207, 426);
            this.MainNav.TabIndex = 3;
            this.MainNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainNav_AfterSelect);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SheetB);
            this.Controls.Add(this.SheetA);
            this.Controls.Add(this.MainNav);
            this.Name = "MainWindow";
            this.Text = "XCellDevPress";
            this.Load += new System.EventHandler(this.onMainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl SheetA;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl SheetB;
        private System.Windows.Forms.TreeView MainNav;
    }
}

