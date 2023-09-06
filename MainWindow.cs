using System.Diagnostics;
using System;
using System.IO;
namespace folderSorting


{
    // Main Window Form
    public partial class frm_main_window : Form
    {
        public static string sourceDirectory = "";
        public static string targetDirectory = "";
        public static List<string> filesList = new List<string>();
        public static int fileCount = 0;
        public static bool selection;
        public static bool sortByPhotos = false;
        public static bool sortByVideos = false;
        public static bool sortByBoth = true ;

        // Initializer
        public frm_main_window()
        {
            InitializeComponent();
            btn_start.Hide();
        }

        // Target Folder Button Click
        private void btn_select_target_folder_click(object sender, EventArgs e)
        {
            if (fbd_target.ShowDialog() == DialogResult.OK)
            {
                if (ckb_sort_date.Checked)
                {
                    if (!Directory.Exists(fbd_target.SelectedPath+"\\Photos"))
                    {
                        //Debug.WriteLine("Photos Folder don't exist");
                        Directory.CreateDirectory(fbd_target.SelectedPath + "\\Photos");
                    }
                    if (!Directory.Exists(fbd_target.SelectedPath + "\\Videos")){
                        //Debug.WriteLine("Videos Folder don't exist");
                        Directory.CreateDirectory(fbd_target.SelectedPath + "\\Videos");
                    }
                }
                targetDirectory = fbd_target.SelectedPath;
                lbl_target_folder_path.Text = targetDirectory.ToString();
                if (folders_selected(sourceDirectory))
                {
                    btn_start.Show();
                }
                fbd_target.Reset();
                fbd_target.Dispose();
                readFoldersInDirectory(targetDirectory);
            }
            else
            {
                return;
            }
            
        }

        // Source Folder Button Click
        private void btn_select_source_folder_Click(object sender, EventArgs e)
        {
            DialogResult sourceResult = fbd_source.ShowDialog();

            if (sourceResult == DialogResult.OK)
            {
                lbl_file_count.Text = "0";
                fileCount = 0;
                filesList = new List<string>();
                sourceDirectory = fbd_source.SelectedPath;

                lbl_source_folder_path.Text = sourceDirectory.ToString();
                Cursor.Current = Cursors.WaitCursor;
                readFilesInDirectory(sourceDirectory);
                Cursor.Current = Cursors.Default;
                if (folders_selected(sourceDirectory))
                {
                    btn_start.Show();
                }
                fbd_source.Reset();

                fbd_source.Dispose();
            }
            else
            {
                return;
            }
            

        }

        // Read files
        private void readFilesInDirectory(string targetDirectory)
        {
            
            var files = from file in Directory.EnumerateFiles(targetDirectory)
                        select file;
            foreach (var file in files)
            {
                fileCount += 1;
                filesList.Add(file);
            }

            var dirs = from dir in
                Directory.EnumerateDirectories(targetDirectory)
                select dir;
            foreach (var dir in dirs)
            {
                readFilesInDirectory(dir);
            }

            lbl_file_count.Text = fileCount.ToString();
        }

        private void readFoldersInDirectory(string targetDirectory)
        {
            var folders = from folder in Directory.EnumerateDirectories(targetDirectory)
                          select folder;
            foreach (var folder in folders)
            {
                Debug.WriteLine(folder);
            }
        }

        // Start the process
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rad_btn_move.Checked)
            {
                selection = true;
            }
            else
            {
                selection = false;
            } ;

            if(rdb_sort_photos.Checked)
            {
                sortByPhotos = true;
            }
            else
            {
                sortByPhotos = false;
            }

            if(rdb_sort_videos.Checked)
            {
                sortByVideos = true;
            }
            else
            {
                sortByVideos = false;
            }

            if (rdb_sort_by_both.Checked)
            {
                sortByBoth = true;
            }
            else
            {
                sortByBoth = false;
            }

            frm_progress progressWindow = new frm_progress();

            progressWindow.ShowDialog();
            targetDirectory = "<Not Selected>";
            lbl_target_folder_path.Text = targetDirectory;
            sourceDirectory = "<Not Selected>";
            lbl_source_folder_path.Text = sourceDirectory;
        }

        // See if both folders have a path
        private bool folders_selected(string selectedDirectory = "")
        {
            if (selectedDirectory != "" && targetDirectory != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Go to github through the link label
        private void LLb_Github_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLb_Github_Link.LinkVisited = true;
            Process.Start("cmd","/c start https://github.com/WestheadJ/FolderWizard");

        }
    }

    

}