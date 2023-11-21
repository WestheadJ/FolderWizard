using System.Diagnostics;
namespace folderSorting


{
    public partial class frm_main_window : Form
    {
        public static string sourceDirectory = "";
        public static string targertDirectory = "";

        public static List<string> filesList = new List<string>();

        public static int fileCount = 0;

        public static bool selection;

        public frm_main_window()
        {
            InitializeComponent();
            btn_start.Hide();
        }


        private void btn_select_target_folder_click(object sender, EventArgs e)
        {
            ;
            if (fbd_target.ShowDialog() == DialogResult.OK)
            {
                targertDirectory = fbd_target.SelectedPath;
                lbl_target_folder_path.Text = targertDirectory.ToString();
                if (folders_selected(sourceDirectory))
                {
                    btn_start.Show();
                }
                fbd_target.Reset();
                fbd_target.Dispose();
            }
            else
            {
                return;
            }

        }
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



        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rad_btn_move.Checked == true)
            {
                selection = true;
            }
            else
            {
                selection = false;
            };
            frm_progress progressWindow = new frm_progress();

            progressWindow.ShowDialog();

            clearUp();


        }

        private bool folders_selected(string selectedDirectory = "")
        {
            if (selectedDirectory != "" && targertDirectory != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LLb_Github_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLb_Github_Link.LinkVisited = true;
            Process.Start("cmd", "/c start https://github.com/WestheadJ/FolderWizard");

        }

        // Function for resting all labels and variables through the program
        private void clearUp()
        {
            targertDirectory = "<Not Selected>";
            lbl_target_folder_path.Text = targertDirectory;
            sourceDirectory = "<Not Selected>";
            lbl_source_folder_path.Text = sourceDirectory;

        }
    }



}