using System.Diagnostics;

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
            bool videoFolderCheck = folder_Worker.videoFolderCheck(frm_main_window.targertDirectory);
            bool photosFolderCheck = folder_Worker.photosFolderCheck(frm_main_window.targertDirectory);
            folder_Worker.folderCreation(frm_main_window.targertDirectory, videoFolderCheck, photosFolderCheck);
            if (frm_main_window.selection)
            {
                folder_Worker.Move(frm_main_window.targertDirectory, frm_main_window.filesList, pbr_files_completed, lbl_items_left, lbl_current_item);

            }
            else
            {
                folder_Worker.Copy(frm_main_window.targertDirectory, frm_main_window.filesList, pbr_files_completed, lbl_items_left, lbl_current_item);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }

    public class Folder_Worker
    {
        public void Move(string targetPath, List<string> filesList, ProgressBar progressBar, Label lbl_files_left, Label lbl_current_item, bool vidAndPhoto = true, bool photoOnly = false, bool videoOnly = false, bool sortByDate = true)
        {

            for (int i = 0; i < frm_main_window.fileCount; i++)
            {
                try
                {
                    if (vidAndPhoto)
                    {
                        if (sortByDate)
                        {
                            string[] fileCreationTime = File.GetCreationTime(filesList[i]).ToString("yyyy-MM").Split('-');
                            string year = fileCreationTime[0];
                            string month = fileCreationTime[1];
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    if(Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year );
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    
       

                                    break;
                                case ".PNG":
                                    if (Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".MOV":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".MP4":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }


                        }
                        else
                        {
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();


                                    break;
                                case ".PNG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                case ".MOV":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                case ".MP4":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                default:
                                    break;
                            }


                        }
                    }
                    else if (photoOnly)
                    {
                        if (sortByDate)
                        {
                            string[] fileCreationTime = File.GetCreationTime(filesList[i]).ToString("yyyy-MM").Split('-');
                            string year = fileCreationTime[0];
                            string month = fileCreationTime[1];
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    if (Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".PNG":
                                    if(Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year );
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                            }

                        }
                        else
                        {

                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();


                                    break;
                                case ".PNG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                            }
                        }
                    }
                    else if (videoOnly)
                    {
                        if (sortByDate)
                        {
                            string[] fileCreationTime = File.GetCreationTime(filesList[i]).ToString("yyyy-MM").Split('-');
                            string year = fileCreationTime[0];
                            string month = fileCreationTime[1];
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".MOV":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".MP4":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Move(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".MOV":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                case ".MP4":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Move(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            lbl_files_left.Text = "Completed!";
            lbl_current_item.Text = "Completed!";

        }

        public void Copy(string targetPath, List<string> filesList, ProgressBar progressBar, Label lbl_files_left, Label lbl_current_item, bool vidAndPhoto = true, bool photoOnly = false, bool videoOnly = false, bool sortByDate = true)
        {
            for (int i = 0; i < frm_main_window.fileCount; i++)
            {
                try
                {
                    if (vidAndPhoto)
                    {
                        if (sortByDate)
                        {
                            string[] fileCreationTime = File.GetCreationTime(filesList[i]).ToString("yyyy-MM").Split('-');
                            string year = fileCreationTime[0];
                            string month = fileCreationTime[1];
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    if (Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }



                                    break;
                                case ".PNG":
                                    if (Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".MOV":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".MP4":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }


                        }
                        else
                        {
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();


                                    break;
                                case ".PNG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                case ".MOV":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                case ".MP4":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                default:
                                    break;
                            }


                        }
                    }
                    else if (photoOnly)
                    {
                        if (sortByDate)
                        {
                            string[] fileCreationTime = File.GetCreationTime(filesList[i]).ToString("yyyy-MM").Split('-');
                            string year = fileCreationTime[0];
                            string month = fileCreationTime[1];
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    if (Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".PNG":
                                    if (Directory.Exists(targetPath + "\\Photos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Photos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Photos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Photos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                            }

                        }
                        else
                        {

                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".JPG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();


                                    break;
                                case ".PNG":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Photos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                            }
                        }
                    }
                    else if (videoOnly)
                    {
                        if (sortByDate)
                        {
                            string[] fileCreationTime = File.GetCreationTime(filesList[i]).ToString("yyyy-MM").Split('-');
                            string year = fileCreationTime[0];
                            string month = fileCreationTime[1];
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".MOV":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                                case ".MP4":
                                    if (Directory.Exists(targetPath + "\\Videos\\" + year))
                                    {
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year);
                                        if (Directory.Exists(targetPath + "\\Videos\\" + year + "\\" + month))
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                        else
                                        {
                                            lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                            lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                            Directory.CreateDirectory(targetPath + "\\" + "Videos" + "\\" + year + "\\" + month);
                                            File.Copy(filesList[i], targetPath + "\\Videos\\" + year + "\\" + month + "\\" + Path.GetFileName(filesList[i]));
                                            progressBar.PerformStep();
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (Path.GetExtension(filesList[i]))
                            {
                                case ".MOV":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                case ".MP4":
                                    lbl_current_item.Text = targetPath + "\\" + Path.GetFileName(filesList[i]);
                                    lbl_files_left.Text = (frm_main_window.fileCount - i).ToString();
                                    File.Copy(filesList[i], targetPath + "\\Videos\\" + Path.GetFileName(filesList[i]));
                                    progressBar.PerformStep();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            lbl_files_left.Text = "Completed!";
            lbl_current_item.Text = "Completed!";
        }

        internal bool videoFolderCheck(string targetPath)
        {
            var dirs = from dir in
                Directory.EnumerateDirectories(targetPath)
                       select dir;
            foreach (var dir in dirs)
            {
                if (dir == "Videos") return true;
            }
            return false;

        }

        internal bool photosFolderCheck(string targetPath)
        {
            var dirs = from dir in
                Directory.EnumerateDirectories(targetPath)
                       select dir;
            foreach (var dir in dirs)
            {
                if (dir == "Photos") return true;
            }
            return false;

        }

        internal void folderCreation(string targetDirectory, bool videosFolderCheck, bool photosFolderCheck)
        {
            if (!videosFolderCheck)
            {
                Directory.CreateDirectory(targetDirectory + "\\Videos");
            }
            if (!photosFolderCheck)
            {
                Directory.CreateDirectory(targetDirectory + "\\Photos");

            }
        }
    }
}
