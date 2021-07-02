using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.IO.Compression;

namespace ManyMinecraftMods
{
    public partial class ManyMinecraftMods : System.Windows.Forms.Form
    {
        string modsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\mods";
        public string zipPath = "none selected";
        public string createPath = "none selected";

        public ManyMinecraftMods()
        {
            InitializeComponent();
            
        }

        private void ManyMinecraftMods_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(modsPath))
            {
                Directory.CreateDirectory(modsPath);
                Console.WriteLine("Minecraft is not installed.");
            }
            else
            {
                Console.WriteLine("Minecraft is installed.");
            }
        }

        private void selMpk_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == filediag.ShowDialog())
                {
                    string fileSelected = filediag.FileName;

                    try
                    {
                        using (var zipFile = ZipFile.OpenRead(fileSelected))
                        {
                            var entries = zipFile.Entries;
                        }

                    }
                    catch (InvalidDataException)
                    {
                        MessageBox.Show("Selected file is not properly formatted.");
                        return;
                    }

                    if (Path.GetExtension(fileSelected) != ".mpk")
                    {
                        MessageBox.Show("Selected file is not a ManyPack.");
                        return;
                    }

                    using (var archive = ZipFile.OpenRead(fileSelected))
                    {
                        var entries = archive.Entries;
                        ZipArchiveEntry metaentry = archive.GetEntry("meta.json");
                        StreamReader osr = new StreamReader(metaentry.Open(), Encoding.Default);
                        string scontents = osr.ReadToEnd();

                        JObject json = JsonConvert.DeserializeObject<JObject>(scontents);
                        
                        metalabel.Text = "Name: " + json["manypack"]["name"] + "\nAuthor: " + json["manypack"]["author"] + "\nVersion: " + json["manypack"]["version"] + "\nDescription: " + json["manypack"]["description"];
                        zipPath = fileSelected;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(modsPath);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        void Push()
        {
            if (zipPath == "none selected")
            {
                MessageBox.Show("Select a ManyPack first.");
                return;
            }

            ZipFile.ExtractToDirectory(zipPath, modsPath);
            File.Delete(modsPath + "\\meta.json");
        }

        private void push_Click(object sender, EventArgs e)
        {
            Push();
        }

        private void clearpush_Click(object sender, EventArgs e)
        {
            Clear();
            Push();
        }

        private void selFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == folderdiag.ShowDialog())
                {
                    createPath = folderdiag.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mpkcreat_Click(object sender, EventArgs e)
        {
            if (createPath == "none selected")
            {
                MessageBox.Show("Select a folder of mods first.");
                return;
            }

            try
            {
                string toSaveTo = "none selected";
                try
                {
                    if (DialogResult.OK == savediag.ShowDialog())
                    {
                        toSaveTo = savediag.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                using (FileStream fs = File.Create(createPath + "\\meta.json"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("{\"manypack\":{\"name\":\"" + namebox.Text + "\",\"author\":\"" + authorbox.Text + "\",\"version\":\"" + versionbox.Text + "\",\"description\":\"" + descbox.Text + "\"}}");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

                ZipFile.CreateFromDirectory(createPath, toSaveTo);

                File.Delete(createPath + "\\meta.json");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
