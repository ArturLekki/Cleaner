namespace Cleaner
{
    public partial class Form1 : Form
    {
        private DirectoryInfo? di;
        private string directoryPath;
        private int filesCount;
        private string fileName;
        private string fileExtension;

        public Form1()
        {
            InitializeComponent();
            directoryPath = "C:";
            filesCount = 0;
            fileName = "";
            fileExtension = ".mkv";
            directoryLabel.Text = directoryPath;
            extensionLabel.Text = fileExtension;
        }


        private void ClearFolder(object sender, EventArgs e)
        {
            if (directoryPath != null && directoryPath != "")
            {
                di = new DirectoryInfo(directoryPath);

                if (di.Exists)
                {
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        if (fi.Extension == fileExtension)
                        {
                            fileName = fi.Name;
                            File.Delete(di + "\\" + fileName);
                            filesCount++;
                        }
                    }

                    MessageBox.Show($"Deleted: [{filesCount}] files with extension: [{fileExtension}] from: [{directoryPath}]");
                }
                else
                {
                    MessageBox.Show("Directory not found.");
                }
            }
            else
            {
                MessageBox.Show("You must choose directory first.");
            }
        }

        private void OpenDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select new directory to search for .mkv files.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directoryPath = dialog.SelectedPath;
                directoryLabel.Text = directoryPath;
            }

            dialog.Dispose();
        }

        private void ChangeExtension(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxExtension.Text))
            {
                fileExtension = textBoxExtension.Text;
                extensionLabel.Text = fileExtension;
                MessageBox.Show($"Extension changed to: {fileExtension}");
            }
            else
            {
                MessageBox.Show($"You must choose extension f.e. (.mkv)");
            }
        }
    }
}