using System;
using System.IO;
using System.Windows.Forms;

namespace PrimeNTSC_1_02_ScanDashPatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SourceISO_btn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "GC ISO File|*.iso";
                openFileDialog.FileName = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.SourceISO_txtBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void Patch_btn_Click(object sender, EventArgs e)
        {
            bool CanBePatched = true;
            String Filepath = this.SourceISO_txtBox.Text.Substring(0, this.SourceISO_txtBox.Text.LastIndexOf('\\'));
            String Filename = Path.GetFileName(this.SourceISO_txtBox.Text);
            using (var file = File.OpenRead(this.SourceISO_txtBox.Text))
            using (var BR = new BinaryReader(file))
            {
                file.Seek(0x0888CE90, SeekOrigin.Begin);
                ulong bytesToPatch = BitConverter.ToUInt32(BR.ReadBytes(4), 0);
                if (bytesToPatch == 0x18000048)
                {
                    MessageBox.Show("ISO is already patched");
                    CanBePatched = true;
                    return;
                }
                if (bytesToPatch != 0x10008241)
                {
                    MessageBox.Show("Unknown version used as source ISO\r\nMake sure that the SHA1 checksum is 1a737910b55b59c6ad91be9e3e3c43517fd52efb\r\nAlso this works only for PAL version");
                    CanBePatched = false;
                    return;
                }
            }
            if (CanBePatched)
            {
                Copier.CopyOneFile(this.SourceISO_txtBox.Text, Filepath + "\\[Scan Dash Enabled] " + Filename, new Action<int>((percent) =>
                {
                    copyProgressBar.Value = percent;
                    copyProgressBar.Visible = percent > 0 && percent < 100;
                }));
                using (var file = File.Open(Filepath + "\\[Scan Dash Enabled] " + Filename, FileMode.Open))
                using (var BW = new BinaryWriter(file))
                {
                    file.Seek(0x0888CE90, SeekOrigin.Begin);
                    BW.Write(0x18000048);
                }
                MessageBox.Show("Scan dash is now enabled for this ISO");
            }
        }
    }
}
