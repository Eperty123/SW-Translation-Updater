using SWTranslationUpdater.Definition;
using System;
using System.IO;
using System.Windows.Forms;

namespace SWTranslationUpdater
{
    public partial class Form1 : Form
    {
        #region Private Variables
        protected TranslationList InputTranslation;
        protected TranslationList TargetTranslation;

        protected OpenFileDialog InputTranslationFileDialog;
        protected OpenFileDialog TargetTranslationFileDialog;

        protected string InputTranslationFileDirectory;
        protected string TargetTranslationFileDirectory;
        #endregion

        #region Constructors
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        #endregion

        #region Private, Protected Methods
        private void Initialize()
        {
            InputTranslation = new TranslationList();
            TargetTranslation = new TranslationList();
        }

        private void inputTransBtn_Click(object sender, EventArgs e)
        {
            InputTranslationFileDialog = new OpenFileDialog();
            InputTranslationFileDialog.Title = "Browse for input translation file";
            if (InputTranslationFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = InputTranslationFileDialog.FileName;
                InputTranslation.LoadFile(fileName);
                inputTransTextBox.Text = fileName;
                InputTranslationFileDirectory = Path.GetDirectoryName(fileName);
            }
        }

        private void targetTransBtn_Click(object sender, EventArgs e)
        {
            TargetTranslationFileDialog = new OpenFileDialog();
            TargetTranslationFileDialog.Title = "Browse for target translation file";

            if (!string.IsNullOrEmpty(TargetTranslationFileDirectory))
                TargetTranslationFileDialog.InitialDirectory = TargetTranslationFileDirectory;

            if (TargetTranslationFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = TargetTranslationFileDialog.FileName;
                TargetTranslation.LoadFile(fileName);
                targetTransTextBox.Text = fileName;
                TargetTranslationFileDirectory = Path.GetDirectoryName(fileName);
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if (InputTranslation != null && InputTranslation.Loaded && TargetTranslation != null && TargetTranslation.Loaded)
            {
                bool replaceExisting = MessageBox.Show("Replace existing translations?", "Replace existing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                InputTranslation.Import(TargetTranslation, replaceExisting);

                var sfd = new SaveFileDialog();
                sfd.Title = "Save modified translation file";
                sfd.Filter = "Translation file|*.txt";
                sfd.FileName = InputTranslation.FileName;

                if (!string.IsNullOrEmpty(InputTranslationFileDirectory))
                    sfd.InitialDirectory = InputTranslationFileDirectory;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    InputTranslation.SaveFile(sfd.FileName);
                }
            }
            else MessageBox.Show("Please load an input and target translation file!", "Input, target or both translation file missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        #endregion
    }
}
