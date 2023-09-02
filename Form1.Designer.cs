namespace folderSorting
{
    partial class frm_main_window
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
            this.btn_select_source_folder = new System.Windows.Forms.Button();
            this.lbl_source_folder_title = new System.Windows.Forms.Label();
            this.lbl_source_folder_path = new System.Windows.Forms.Label();
            this.fbd_target = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_source_path_title = new System.Windows.Forms.Label();
            this.btn_select_target_folder = new System.Windows.Forms.Button();
            this.lbl_target_folder_title = new System.Windows.Forms.Label();
            this.lbl_target_folder_path = new System.Windows.Forms.Label();
            this.lbl_target_folder_path_title = new System.Windows.Forms.Label();
            this.fbd_source = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_file_count_title = new System.Windows.Forms.Label();
            this.lbl_file_count = new System.Windows.Forms.Label();
            this.rad_btn_move = new System.Windows.Forms.RadioButton();
            this.rad_btn_copy = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.rdb_sort_videos = new System.Windows.Forms.RadioButton();
            this.gpb_options = new System.Windows.Forms.GroupBox();
            this.rdb_sort_by_both = new System.Windows.Forms.RadioButton();
            this.ckb_sort_date = new System.Windows.Forms.CheckBox();
            this.rdb_sort_photos = new System.Windows.Forms.RadioButton();
            this.LLb_Github_Link = new System.Windows.Forms.LinkLabel();
            this.gpb_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_select_source_folder
            // 
            this.btn_select_source_folder.Location = new System.Drawing.Point(15, 37);
            this.btn_select_source_folder.Name = "btn_select_source_folder";
            this.btn_select_source_folder.Size = new System.Drawing.Size(101, 23);
            this.btn_select_source_folder.TabIndex = 3;
            this.btn_select_source_folder.Text = "Select";
            this.btn_select_source_folder.UseVisualStyleBackColor = true;
            this.btn_select_source_folder.Click += new System.EventHandler(this.btn_select_source_folder_Click);
            // 
            // lbl_source_folder_title
            // 
            this.lbl_source_folder_title.AutoSize = true;
            this.lbl_source_folder_title.Location = new System.Drawing.Point(24, 19);
            this.lbl_source_folder_title.Name = "lbl_source_folder_title";
            this.lbl_source_folder_title.Size = new System.Drawing.Size(82, 15);
            this.lbl_source_folder_title.TabIndex = 4;
            this.lbl_source_folder_title.Text = "Source Folder:";
            // 
            // lbl_source_folder_path
            // 
            this.lbl_source_folder_path.AutoSize = true;
            this.lbl_source_folder_path.Location = new System.Drawing.Point(162, 41);
            this.lbl_source_folder_path.Name = "lbl_source_folder_path";
            this.lbl_source_folder_path.Size = new System.Drawing.Size(90, 15);
            this.lbl_source_folder_path.TabIndex = 5;
            this.lbl_source_folder_path.Text = "<Not Selected>";
            // 
            // lbl_source_path_title
            // 
            this.lbl_source_path_title.AutoSize = true;
            this.lbl_source_path_title.Location = new System.Drawing.Point(122, 41);
            this.lbl_source_path_title.Name = "lbl_source_path_title";
            this.lbl_source_path_title.Size = new System.Drawing.Size(34, 15);
            this.lbl_source_path_title.TabIndex = 6;
            this.lbl_source_path_title.Text = "Path:";
            // 
            // btn_select_target_folder
            // 
            this.btn_select_target_folder.Location = new System.Drawing.Point(15, 102);
            this.btn_select_target_folder.Name = "btn_select_target_folder";
            this.btn_select_target_folder.Size = new System.Drawing.Size(101, 23);
            this.btn_select_target_folder.TabIndex = 3;
            this.btn_select_target_folder.Text = "Select";
            this.btn_select_target_folder.UseVisualStyleBackColor = true;
            this.btn_select_target_folder.Click += new System.EventHandler(this.btn_select_target_folder_click);
            // 
            // lbl_target_folder_title
            // 
            this.lbl_target_folder_title.AutoSize = true;
            this.lbl_target_folder_title.Location = new System.Drawing.Point(28, 84);
            this.lbl_target_folder_title.Name = "lbl_target_folder_title";
            this.lbl_target_folder_title.Size = new System.Drawing.Size(78, 15);
            this.lbl_target_folder_title.TabIndex = 4;
            this.lbl_target_folder_title.Text = "Target Folder:";
            // 
            // lbl_target_folder_path
            // 
            this.lbl_target_folder_path.AutoSize = true;
            this.lbl_target_folder_path.Location = new System.Drawing.Point(162, 106);
            this.lbl_target_folder_path.Name = "lbl_target_folder_path";
            this.lbl_target_folder_path.Size = new System.Drawing.Size(90, 15);
            this.lbl_target_folder_path.TabIndex = 5;
            this.lbl_target_folder_path.Text = "<Not Selected>";
            // 
            // lbl_target_folder_path_title
            // 
            this.lbl_target_folder_path_title.AutoSize = true;
            this.lbl_target_folder_path_title.Location = new System.Drawing.Point(122, 106);
            this.lbl_target_folder_path_title.Name = "lbl_target_folder_path_title";
            this.lbl_target_folder_path_title.Size = new System.Drawing.Size(34, 15);
            this.lbl_target_folder_path_title.TabIndex = 6;
            this.lbl_target_folder_path_title.Text = "Path:";
            // 
            // lb_file_count_title
            // 
            this.lb_file_count_title.AutoSize = true;
            this.lb_file_count_title.Location = new System.Drawing.Point(24, 141);
            this.lb_file_count_title.Name = "lb_file_count_title";
            this.lb_file_count_title.Size = new System.Drawing.Size(76, 15);
            this.lb_file_count_title.TabIndex = 7;
            this.lb_file_count_title.Text = "Files to copy:";
            // 
            // lbl_file_count
            // 
            this.lbl_file_count.AutoSize = true;
            this.lbl_file_count.Location = new System.Drawing.Point(106, 141);
            this.lbl_file_count.Name = "lbl_file_count";
            this.lbl_file_count.Size = new System.Drawing.Size(13, 15);
            this.lbl_file_count.TabIndex = 7;
            this.lbl_file_count.Text = "0";
            // 
            // rad_btn_move
            // 
            this.rad_btn_move.AutoSize = true;
            this.rad_btn_move.Checked = true;
            this.rad_btn_move.Location = new System.Drawing.Point(12, 182);
            this.rad_btn_move.Name = "rad_btn_move";
            this.rad_btn_move.Size = new System.Drawing.Size(127, 19);
            this.rad_btn_move.TabIndex = 9;
            this.rad_btn_move.TabStop = true;
            this.rad_btn_move.Text = "Move files to folder";
            this.rad_btn_move.UseVisualStyleBackColor = true;
            // 
            // rad_btn_copy
            // 
            this.rad_btn_copy.AutoSize = true;
            this.rad_btn_copy.Location = new System.Drawing.Point(12, 207);
            this.rad_btn_copy.Name = "rad_btn_copy";
            this.rad_btn_copy.Size = new System.Drawing.Size(125, 19);
            this.rad_btn_copy.TabIndex = 10;
            this.rad_btn_copy.TabStop = true;
            this.rad_btn_copy.Text = "Copy files to folder";
            this.rad_btn_copy.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(41, 249);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rdb_sort_videos
            // 
            this.rdb_sort_videos.AutoSize = true;
            this.rdb_sort_videos.Location = new System.Drawing.Point(8, 72);
            this.rdb_sort_videos.Name = "rdb_sort_videos";
            this.rdb_sort_videos.Size = new System.Drawing.Size(112, 19);
            this.rdb_sort_videos.TabIndex = 12;
            this.rdb_sort_videos.Text = "Sort Videos Only";
            this.rdb_sort_videos.UseVisualStyleBackColor = true;
            // 
            // gpb_options
            // 
            this.gpb_options.Controls.Add(this.rdb_sort_by_both);
            this.gpb_options.Controls.Add(this.ckb_sort_date);
            this.gpb_options.Controls.Add(this.rdb_sort_photos);
            this.gpb_options.Controls.Add(this.rdb_sort_videos);
            this.gpb_options.Location = new System.Drawing.Point(190, 141);
            this.gpb_options.Name = "gpb_options";
            this.gpb_options.Size = new System.Drawing.Size(220, 131);
            this.gpb_options.TabIndex = 13;
            this.gpb_options.TabStop = false;
            this.gpb_options.Text = "Options";
            // 
            // rdb_sort_by_both
            // 
            this.rdb_sort_by_both.AutoSize = true;
            this.rdb_sort_by_both.Checked = true;
            this.rdb_sort_by_both.Location = new System.Drawing.Point(8, 97);
            this.rdb_sort_by_both.Name = "rdb_sort_by_both";
            this.rdb_sort_by_both.Size = new System.Drawing.Size(149, 19);
            this.rdb_sort_by_both.TabIndex = 15;
            this.rdb_sort_by_both.TabStop = true;
            this.rdb_sort_by_both.Text = "Sort Photos And Videos";
            this.rdb_sort_by_both.UseVisualStyleBackColor = true;
            // 
            // ckb_sort_date
            // 
            this.ckb_sort_date.AutoSize = true;
            this.ckb_sort_date.Checked = true;
            this.ckb_sort_date.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_sort_date.Location = new System.Drawing.Point(8, 22);
            this.ckb_sort_date.Name = "ckb_sort_date";
            this.ckb_sort_date.Size = new System.Drawing.Size(134, 19);
            this.ckb_sort_date.TabIndex = 14;
            this.ckb_sort_date.Text = "Sort By Date Created";
            this.ckb_sort_date.UseVisualStyleBackColor = true;
            // 
            // rdb_sort_photos
            // 
            this.rdb_sort_photos.AutoSize = true;
            this.rdb_sort_photos.Location = new System.Drawing.Point(8, 47);
            this.rdb_sort_photos.Name = "rdb_sort_photos";
            this.rdb_sort_photos.Size = new System.Drawing.Size(114, 19);
            this.rdb_sort_photos.TabIndex = 13;
            this.rdb_sort_photos.Text = "Sort Photos Only";
            this.rdb_sort_photos.UseVisualStyleBackColor = true;
            // 
            // LLb_Github_Link
            // 
            this.LLb_Github_Link.AutoSize = true;
            this.LLb_Github_Link.LinkArea = new System.Windows.Forms.LinkArea(0, 55);
            this.LLb_Github_Link.Location = new System.Drawing.Point(610, 281);
            this.LLb_Github_Link.Name = "LLb_Github_Link";
            this.LLb_Github_Link.Size = new System.Drawing.Size(68, 21);
            this.LLb_Github_Link.TabIndex = 14;
            this.LLb_Github_Link.TabStop = true;
            this.LLb_Github_Link.Text = "Need Help?";
            this.LLb_Github_Link.UseCompatibleTextRendering = true;
            this.LLb_Github_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLb_Github_Link_LinkClicked);
            // 
            // frm_main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.LLb_Github_Link);
            this.Controls.Add(this.gpb_options);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.rad_btn_copy);
            this.Controls.Add(this.rad_btn_move);
            this.Controls.Add(this.lbl_file_count);
            this.Controls.Add(this.lb_file_count_title);
            this.Controls.Add(this.lbl_target_folder_path_title);
            this.Controls.Add(this.lbl_source_path_title);
            this.Controls.Add(this.lbl_target_folder_path);
            this.Controls.Add(this.lbl_target_folder_title);
            this.Controls.Add(this.lbl_source_folder_path);
            this.Controls.Add(this.btn_select_target_folder);
            this.Controls.Add(this.lbl_source_folder_title);
            this.Controls.Add(this.btn_select_source_folder);
            this.Name = "frm_main_window";
            this.Text = "Folder Wizard";
            this.gpb_options.ResumeLayout(false);
            this.gpb_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_select_source_folder;
        private Label lbl_source_folder_title;
        private Label lbl_source_folder_path;
        private FolderBrowserDialog fbd_target;
        private Label lbl_source_path_title;
        private Button btn_select_target_folder;
        private Label lbl_target_folder_title;
        private Label lbl_target_folder_path;
        private Label lbl_target_folder_path_title;
        private FolderBrowserDialog fbd_source;
        private Label lb_file_count_title;
        private Label lbl_file_count;
        private RadioButton rad_btn_copy;
        private Button btn_start;
        public RadioButton rad_btn_move;
        private RadioButton rdb_sort_videos;
        private GroupBox gpb_options;
        private RadioButton rdb_sort_photos;
        private CheckBox ckb_sort_date;
        private RadioButton rdb_sort_by_both;
        private LinkLabel LLb_Github_Link;
    }
}