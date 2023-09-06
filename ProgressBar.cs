using System.Diagnostics;
using System.Net.Security;

namespace folderSorting
{
    public partial class frm_progress : Form
    {
        public int progress = 0;
        public bool completed = false;
        


        public frm_progress()
        {
            InitializeComponent();
            pbr_files_completed.Maximum = frm_main_window.fileCount;
            Folder_Worker folder_Worker = new Folder_Worker();

            if (frm_main_window.selection)
            {
                folder_Worker.Move(frm_main_window.targetDirectory, frm_main_window.filesList, pbr_files_completed,lbl_items_left,lbl_current_item);
                
            }
            else
            {
                folder_Worker.Copy(frm_main_window.targetDirectory, frm_main_window.filesList, pbr_files_completed, lbl_items_left, lbl_current_item);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }

    public class Folder_Worker
    {
        public void Move(string targetPath, List<string> filesList,ProgressBar progressBar,Label lbl_files_left, Label lbl_current_item)
        {

            for (int i = 0; i < frm_main_window.fileCount; i++)
            {
                try
                {

                    if (frm_main_window.sortByPhotos)
                    {
                        if (Path.GetExtension(filesList[i]) == ".JPG" || Path.GetExtension(filesList[i]) == ".PNG" || Path.GetExtension(filesList[i]) == ".JPEG")
                        {
                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                            File.Move(filesList[i], targetPath + "\\" + Path.GetFileName(filesList[i]));
                            progressBar.PerformStep();

                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                        }
                    }
                    else if (frm_main_window.sortByVideos)
                    {
                        if (Path.GetExtension(filesList[i]) == ".MOV" || Path.GetExtension(filesList[i]) == ".MP4")
                        {
                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                            File.Move(filesList[i], targetPath + "\\" + Path.GetFileName(filesList[i]));
                            progressBar.PerformStep();

                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                        }
                    }
                    else if (frm_main_window.sortByBoth) {
                        lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                        File.Move(filesList[i], targetPath + "\\" + Path.GetFileName(filesList[i]));
                        progressBar.PerformStep();

                        lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            //lbl_files_left.Text = "Completed!";
            //lbl_current_item.Text = "Completed!";

        }

        public void Copy(string targetPath, List<string> filesList, ProgressBar progressBar, Label lbl_files_left, Label lbl_current_item)
        {
            for (int i = 0; i < frm_main_window.fileCount; i++)
            {
                try
                {
                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                    File.Copy(filesList[i], targetPath + "\\" + Path.GetFileName(filesList[i]));
                    progressBar.PerformStep();

                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            lbl_files_left.Text = "Completed!";
            lbl_current_item.Text = "Completed!";
        }
    }
}
