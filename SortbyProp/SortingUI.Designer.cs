namespace SortbyProp
{
    partial class SortingUI
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.SortingProp = new System.Windows.Forms.ComboBox();
            this.SortBy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(500, 313);
            this.dgv.TabIndex = 0;
            // 
            // SortingProp
            // 
            this.SortingProp.FormattingEnabled = true;
            this.SortingProp.Location = new System.Drawing.Point(518, 12);
            this.SortingProp.Name = "SortingProp";
            this.SortingProp.Size = new System.Drawing.Size(140, 21);
            this.SortingProp.TabIndex = 1;
            this.SortingProp.SelectedIndexChanged += new System.EventHandler(this.SortingProp_SelectedIndexChanged);
            // 
            // SortBy
            // 
            this.SortBy.AutoSize = true;
            this.SortBy.Location = new System.Drawing.Point(586, 39);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(15, 14);
            this.SortBy.TabIndex = 2;
            this.SortBy.UseVisualStyleBackColor = true;
            // 
            // SortingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 337);
            this.Controls.Add(this.SortBy);
            this.Controls.Add(this.SortingProp);
            this.Controls.Add(this.dgv);
            this.Name = "SortingUI";
            this.Text = "SortingUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox SortingProp;
        private System.Windows.Forms.CheckBox SortBy;
    }
}