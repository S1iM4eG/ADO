namespace Academy
{
    partial class TeacherForm
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
            this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpWorkSince
            // 
            this.dtpWorkSince.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpWorkSince.CustomFormat = "dd.MMMM.yyyy";
            this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkSince.Location = new System.Drawing.Point(179, 180);
            this.dtpWorkSince.Name = "dtpWorkSince";
            this.dtpWorkSince.Size = new System.Drawing.Size(235, 29);
            this.dtpWorkSince.TabIndex = 17;
            // 
            // textBoxRate
            // 
            this.textBoxRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxRate.Location = new System.Drawing.Point(179, 209);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 29);
            this.textBoxRate.TabIndex = 18;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 240);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.dtpWorkSince);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Controls.SetChildIndex(this.dtpWorkSince, 0);
            this.Controls.SetChildIndex(this.textBoxRate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWorkSince;
        private System.Windows.Forms.TextBox textBoxRate;
    }
}