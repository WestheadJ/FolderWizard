namespace folderSorting
{
    partial class frm_progress
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
            this.pbr_files_completed = new System.Windows.Forms.ProgressBar();
            this.lbl_progress_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_items_left_title = new System.Windows.Forms.Label();
            this.lbl_items_left = new System.Windows.Forms.Label();
            this.lbl_current_item_title = new System.Windows.Forms.Label();
            this.lbl_current_item = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbr_files_completed
            // 
            this.pbr_files_completed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbr_files_completed.ForeColor = System.Drawing.Color.Lime;
            this.pbr_files_completed.Location = new System.Drawing.Point(58, 112);
            this.pbr_files_completed.Name = "pbr_files_completed";
            this.pbr_files_completed.Size = new System.Drawing.Size(238, 23);
            this.pbr_files_completed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_files_completed.TabIndex = 0;
            // 
            // lbl_progress_title
            // 
            this.lbl_progress_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_progress_title.AutoSize = true;
            this.lbl_progress_title.Location = new System.Drawing.Point(58, 73);
            this.lbl_progress_title.Name = "lbl_progress_title";
            this.lbl_progress_title.Size = new System.Drawing.Size(55, 15);
            this.lbl_progress_title.TabIndex = 1;
            this.lbl_progress_title.Text = "Progress:";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(126, 226);
            this.btn_close.MaximumSize = new System.Drawing.Size(78, 23);
            this.btn_close.MinimumSize = new System.Drawing.Size(78, 23);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(78, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_items_left_title
            // 
            this.lbl_items_left_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_items_left_title.AutoSize = true;
            this.lbl_items_left_title.Location = new System.Drawing.Point(58, 151);
            this.lbl_items_left_title.Name = "lbl_items_left_title";
            this.lbl_items_left_title.Size = new System.Drawing.Size(62, 15);
            this.lbl_items_left_title.TabIndex = 4;
            this.lbl_items_left_title.Text = "Items Left:";
            // 
            // lbl_items_left
            // 
            this.lbl_items_left.AutoSize = true;
            this.lbl_items_left.Location = new System.Drawing.Point(126, 151);
            this.lbl_items_left.Name = "lbl_items_left";
            this.lbl_items_left.Size = new System.Drawing.Size(0, 15);
            this.lbl_items_left.TabIndex = 5;
            // 
            // lbl_current_item_title
            // 
            this.lbl_current_item_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_current_item_title.AutoSize = true;
            this.lbl_current_item_title.Location = new System.Drawing.Point(58, 177);
            this.lbl_current_item_title.Name = "lbl_current_item_title";
            this.lbl_current_item_title.Size = new System.Drawing.Size(77, 15);
            this.lbl_current_item_title.TabIndex = 6;
            this.lbl_current_item_title.Text = "Current Item:";
            // 
            // lbl_current_item
            // 
            this.lbl_current_item.AutoSize = true;
            this.lbl_current_item.Location = new System.Drawing.Point(141, 177);
            this.lbl_current_item.Name = "lbl_current_item";
            this.lbl_current_item.Size = new System.Drawing.Size(0, 15);
            this.lbl_current_item.TabIndex = 7;
            // 
            // frm_progress
            // 
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.lbl_current_item);
            this.Controls.Add(this.lbl_current_item_title);
            this.Controls.Add(this.lbl_items_left);
            this.Controls.Add(this.lbl_items_left_title);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_progress_title);
            this.Controls.Add(this.pbr_files_completed);
            this.Name = "frm_progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_progress_title;
        private ProgressBar pbr_files_completed;
        private Button btn_close;
        private Label lbl_items_left_title;
        private Label lbl_items_left;
        private Label lbl_current_item_title;
        private Label lbl_current_item;
    }
}