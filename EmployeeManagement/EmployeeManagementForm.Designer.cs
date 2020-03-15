namespace EmployeeManagement
{
    partial class EmployeeManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.reportOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uploadButton = new System.Windows.Forms.Button();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(145, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(478, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Employee Management";
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(154, 376);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(140, 62);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate Data File";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // processButton
            // 
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(483, 376);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(140, 62);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process Census";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // reportOnlyCheckBox
            // 
            this.reportOnlyCheckBox.AutoSize = true;
            this.reportOnlyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportOnlyCheckBox.Location = new System.Drawing.Point(629, 376);
            this.reportOnlyCheckBox.Name = "reportOnlyCheckBox";
            this.reportOnlyCheckBox.Size = new System.Drawing.Size(112, 24);
            this.reportOnlyCheckBox.TabIndex = 3;
            this.reportOnlyCheckBox.Text = "Report Only";
            this.reportOnlyCheckBox.UseVisualStyleBackColor = true;
            this.reportOnlyCheckBox.CheckedChanged += new System.EventHandler(this.reportOnlyCheckBox_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "D:\\temp";
            this.openFileDialog.Title = "Dog";
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(316, 116);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(140, 56);
            this.uploadButton.TabIndex = 4;
            this.uploadButton.Text = "Upload Census";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Enabled = false;
            this.filePathTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextbox.Location = new System.Drawing.Point(204, 191);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.Size = new System.Drawing.Size(360, 23);
            this.filePathTextbox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.reportOnlyCheckBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "EmployeeManagementForm";
            this.Text = "Employee Mangement";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.CheckBox reportOnlyCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

