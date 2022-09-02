namespace DR1_Coin_Editor
{
    public partial class MainForm : Form
    {
        #region Global Variables

        private const int COINS_OFFSET = 0x4A4;

        private string selectedSaveFileLocation = "";

        public string SelectedSaveFileLocation
        {
            get
            {
                return selectedSaveFileLocation;
            }
            set
            {
                selectedSaveFileLocation = value;
                saveFileLocationTextBox.Text = selectedSaveFileLocation;
            }
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void selectSaveFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "savedata|*.vfs";

                if (ofd.ShowDialog() == DialogResult.OK)
                    SelectedSaveFileLocation = ofd.FileName;
            }
        }

        private void modifySaveFileButton_Click(object sender, EventArgs e)
            => ModifySaveFile(SelectedSaveFileLocation, (ushort)coinsAmountNumericUpDown.Value);

        private void saveFileLocationTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                e.Effect = DragDropEffects.All;
        }

        private void saveFileLocationTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFileLocation = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (File.Exists(droppedFileLocation[0]))
                SelectedSaveFileLocation = droppedFileLocation[0];
        }

        #endregion

        #region Methods

        private async void ModifySaveFile(string saveFileLocation, ushort coinsAmount)
        {
            if (!File.Exists(saveFileLocation))
            {
                MessageBox.Show("Please select a valid save file for Daganronpa: Trigger Happy Havoc.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await Task.Run(() => 
            {
                using (FileStream fileStream = new FileStream(saveFileLocation, FileMode.Open))
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                    {
                        binaryWriter.Seek(COINS_OFFSET, SeekOrigin.Begin);
                        binaryWriter.Write(coinsAmount);
                    }
                }
            });

            MessageBox.Show("The save file was modified successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}