using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VmdIO;

namespace VMDtoEXOGenerator
{
    public partial class MainForm : Form
    {
        VocaloidMotionData vmd;
        List<StrBl> KeyAndBool;

        public MainForm()
        {
            InitializeComponent();

            // バージョン表記
            labelVersion.Text = "Version 1.0";
        }

        private void tabControlProperty_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //ユーザーによるタブ移動を禁止する
            e.Cancel = true;
        }

        private void buttonOpenVMD_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "VMDファイル(*.vmd)|*.vmd|すべてのファイル(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenVMD(ofd.FileNames);
                    SetCheckedListBoxKey();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCheckedListBoxKey()
        {
            if (vmd == null)
                throw new ArgumentNullException("nullから内包キー名を取り出そうとしました");
            checkedListBoxKey.Items.Clear();
            checkedListBoxKey.Items.AddRange(KeyAndBool.Select(k => k.Str).ToArray());
        }

        private void OpenVMD(string[] path)
        {
            vmd = new VocaloidMotionData();
            using (BinaryReader reader = new BinaryReader(File.Open(path[0], FileMode.Open)))
            {
                vmd.Read(reader);
            }
            if (path.Length > 1)
            {
                foreach (var s in path.Skip(1))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(s, FileMode.Open)))
                    {
                        vmd.Merge(new VocaloidMotionData(reader));
                    }
                }
            }
            KeyAndBool = vmd.GetKeyNames(VocaloidMotionData.GetKeyIgnoring.FirstFrame).ConvertAll(n => new StrBl(n));
        }

        private void buttonAllF_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxKey.Items.Count; i++)
            {
                checkedListBoxKey.SetItemChecked(i, false);
            }
        }

        private void buttonAllInv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxKey.Items.Count; i++)
            {
                checkedListBoxKey.SetItemChecked(i, checkedListBoxKey.GetItemChecked(i) ? false : true);
            }
        }
    }

    public class StrBl
    {
        public string Str { get; set; }
        public bool Bl { get; set; }

        public StrBl(string str = "", bool bl = false)
        {
            Str = str;
            Bl = bl;
        }
    }
}
