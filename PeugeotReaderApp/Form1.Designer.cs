namespace PeugeotReaderApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExport = new Button();
            txtInputFile = new TextBox();
            label1 = new Label();
            cmdBrowse = new Button();
            dlgOpen = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.Location = new Point(373, 72);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 0;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // txtInputFile
            // 
            txtInputFile.Location = new Point(117, 31);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.Size = new Size(331, 23);
            txtInputFile.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "XML MPM file:";
            // 
            // cmdBrowse
            // 
            cmdBrowse.Location = new Point(463, 31);
            cmdBrowse.Name = "cmdBrowse";
            cmdBrowse.Size = new Size(75, 23);
            cmdBrowse.TabIndex = 3;
            cmdBrowse.Text = "Browse...";
            cmdBrowse.UseVisualStyleBackColor = true;
            // 
            // dlgOpen
            // 
            dlgOpen.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            dlgOpen.Title = "Select Peugeot measurement file";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 117);
            Controls.Add(cmdBrowse);
            Controls.Add(label1);
            Controls.Add(txtInputFile);
            Controls.Add(btnExport);
            Name = "frmMain";
            Text = "Peugeot Reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExport;
        private TextBox txtInputFile;
        private Label label1;
        private Button cmdBrowse;
        private OpenFileDialog dlgOpen;
    }
}