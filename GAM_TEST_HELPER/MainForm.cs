using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GAM_TEST_HELPER
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> dictionary;

        public MainForm()
        {
            InitializeComponent();
            gbCode.Controls.Remove(tbCode);
            tbCode = new CColoredTextBox();
            gbCode.Controls.Add(tbCode);

            a = new List<int>();
            a.Add(-1);
            try
            {
                string[] dim = File.ReadAllLines("layout.txt");
                foreach (string item in dim)
                    a.Add(int.Parse(item));
            }
            catch (Exception)
            {
                a.Clear();
                a.AddRange(new int[] { -1, 750, 35, 75, 230, 211, 100, 15, 675, 240 });
            }

            notifyIcon.Icon = this.Icon;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "UNIT_TEST_HELPER";
            notifyIcon.BalloonTipText = "Code généré et Copié";

            foreach (string template in (Directory.GetFiles("./", "*_template.txt", SearchOption.TopDirectoryOnly)))
                cbTemplate.Items.Add(Path.GetFileName(template));
            charger();

            tbDeclarationParametres.TextChanged += TbMultiligne_TextChanged;
            tbParametres.TextChanged += TbMultiligne_TextChanged;
            tbNomFichier.TextChanged += TbNomFichier_Validated;

            bGenererAjouter.Click += BGenererAjouter_Click;
            bGenerer.Click += BGenerer_Click;
            bCopier.Click += BCopier_Click;
            bMinimize.Click += BMinimize_Click;
            notifyIcon.Click += NotifyIcon_Click;
            this.FormClosing += MainForm_FormClosing;

            scContainer.Panel1.SizeChanged += Panel1_SizeChanged;
            cbTop.CheckedChanged += CbTop_CheckedChanged;
        }

        private void CbTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cbTop.Checked;
        }

        List<int> a;
        private void Panel1_SizeChanged(object sender, EventArgs e)
        {
            cbTemplate.Size = new Size(a[2] + (scContainer.Panel1.ClientSize.Width - scContainer.Panel1MinSize + a[3]), cbTemplate.Size.Height);
            groupBox1.Size = new Size(a[4] + (scContainer.Panel1.ClientSize.Width - scContainer.Panel1MinSize + a[3]), groupBox1.Size.Height);
            tbTypeFichierBinaire.Size = new Size(a[5] + (scContainer.Panel1.ClientSize.Width - scContainer.Panel1MinSize + a[3]), tbTypeFichierBinaire.Size.Height);

            tbDeclarationParametres.Size = new Size(tbTypeFichierBinaire.Size.Width, a[6] + (scContainer.Panel1.ClientSize.Height - a[1]));
            tbNomFonction.Size = new Size(tbTypeFichierBinaire.Size.Width, tbNomFonction.Size.Height);
            tbParametres.Size = new Size(tbTypeFichierBinaire.Size.Width, tbParametres.Size.Height);
            dgvValidationSortie.Size = new Size(tbTypeFichierBinaire.Size.Width, dgvValidationSortie.Size.Height);

            gbFonction.Size = new Size(groupBox1.Size.Width, scContainer.Panel1.ClientSize.Height - pButtons.Height - gbFonction.Location.Y - a[7]);
            pButtons.Location = new Point(pButtons.Location.X, a[8] + (scContainer.Panel1.ClientSize.Height - a[1]));
            pPanel.Size = new Size(groupBox1.Size.Width - a[7], pPanel.Size.Height);
            pPanel.Location = new Point(pPanel.Location.X, a[9] + (scContainer.Panel1.ClientSize.Height - a[1]));
        }

        private void TbNomFichier_Validated(object sender, EventArgs e)
        {
            if (dictionary.ContainsKey(tbNomFichier.Text))
                tbTypeFichierBinaire.Text = dictionary[tbNomFichier.Text];
        }

        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
            sauver();
        }

        private void charger(string file = "sauvegarde.uth")
        {
            TextReader textReader = null;
            if (dictionary == null)
                dictionary = new Dictionary<string, string>();

            try
            {
                if (File.Exists("TypeFichierBinaire_Dictionaire.txt"))
                {
                    textReader = new StreamReader("TypeFichierBinaire_Dictionaire.txt");
                    string line = textReader.ReadLine();

                    tbNomFichier.AutoCompleteCustomSource.Clear();
                    dictionary.Clear();

                    while (!String.IsNullOrEmpty(line))
                    {
                        string[] data = line.Split(',');
                        dictionary[data[0]] = data[1];

                        line = textReader.ReadLine();
                    }
                    textReader.Close();

                    tbNomFichier.AutoCompleteCustomSource.AddRange(dictionary.Keys.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(file))
            {
                tbNomFichier.Text = "";
                tbVersion.Text = "";
                tbTypeFichierBinaire.Text = "";
                nudNumeroFonction.Value = 0;
                nudNumeroCas.Value = 0;
                tbNomFonction.Text = "";
                tbDeclarationParametres.Text = "";
                tbParametres.Text = "";
                dgvValidationSortie.Rows.Clear();
                cbTemplate.Text = "";
                tbCode.Text = "";

                return;
            }

            try
            {
                textReader = new StreamReader(file);
                string[] lines = textReader.ReadToEnd().Split('¤');
                textReader.Close();

                tbNomFichier.Text = lines[0];
                tbVersion.Text = lines[1];
                tbTypeFichierBinaire.Text = lines[2];
                nudNumeroFonction.Value = int.Parse(lines[3]);
                nudNumeroCas.Value = int.Parse(lines[4]);
                tbNomFonction.Text = lines[5];
                tbDeclarationParametres.Text = lines[6];
                tbParametres.Text = lines[7];
                string[] validationsSortie = lines[8].Split('\n');
                dgvValidationSortie.Rows.Clear();
                foreach (string line in validationsSortie)
                {
                    if (line == "" || line.StartsWith(",") || line.EndsWith(","))
                        continue;
                    dgvValidationSortie.Rows.Add(line.Split(','));
                }
                cbTemplate.Text = lines[9];
                tbCode.Text = lines[10].Replace("\r", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        string fileToSave = "";
        private void sauver(string file = "sauvegarde.uth")
        {
            TextWriter textWriter = null;

            if (file == "" && fileToSave == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichier UNIT_TEST_HELPER|*.uth";
                saveFileDialog.Title = "Enregistrer";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                fileToSave = saveFileDialog.FileName;
            }
            if (file == "")
                file = fileToSave;

            try
            {
                textWriter = new StreamWriter("TypeFichierBinaire_Dictionaire.txt");
                foreach (var item in dictionary)
                    textWriter.WriteLine(item.Key + "," + item.Value);
                
                textWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                textWriter = new StreamWriter(file);
                textWriter.Write(tbNomFichier.Text + "¤");
                textWriter.Write(tbVersion.Text + "¤");
                textWriter.Write(tbTypeFichierBinaire.Text + "¤");
                textWriter.Write(nudNumeroFonction.Value + "¤");
                textWriter.Write(nudNumeroCas.Value + "¤");
                textWriter.Write(tbNomFonction.Text + "¤");
                textWriter.Write(tbDeclarationParametres.Text + "¤");
                textWriter.Write(tbParametres.Text + "¤");
                string validationsSortie = "";
                foreach (DataGridViewRow row in dgvValidationSortie.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[0].Value.ToString() == "" || row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                        continue;
                    validationsSortie += row.Cells[0].Value + "," + row.Cells[1].Value + "\n";
                }
                textWriter.Write(validationsSortie + "¤");
                textWriter.Write(cbTemplate.Text + "¤");
                textWriter.Write(tbCode.Text + "¤");
                textWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TbMultiligne_TextChanged(object sender, EventArgs e)
        {
            TextBox Sender = (TextBox)sender;

            Sender.Text = Sender.Text.Replace("\t", "");
        }

        private void BCopier_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCode.Text);
            this.WindowState = FormWindowState.Minimized;
            notifyIcon.ShowBalloonTip(1000);
        }

        private string generer()
        {
            if (!isValide())
            {
                MessageBox.Show("Un ou plusieurs champs sont vides.\nVeuillez les remplir.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            try
            {
                TextReader textReader = new StreamReader(cbTemplate.Text);
                string test = textReader.ReadToEnd().Replace("\r", "");
                textReader.Close();

                test = test.Replace("{{_NOM_FICHIER_}}", tbNomFichier.Text);
                test = test.Replace("{{_VERSION_}}", tbVersion.Text);
                test = test.Replace("{{_NUMERO_FONCTION_}}", nudNumeroFonction.Value.ToString());
                test = test.Replace("{{_NUMERO_CAS_}}", nudNumeroCas.Value.ToString("00"));
                test = test.Replace("{{_TYPE_FICHIER_BINAIRE_}}", tbTypeFichierBinaire.Text);
                test = test.Replace("{{_NOM_FONCTION_}}", tbNomFonction.Text);
                test = test.Replace("{{_DECLARATION_PARAMETRES_}}", tbDeclarationParametres.Text.Replace("\n", "\n\t"));
                int indent = ("ret_" + tbNomFichier.Text + "_Recherche = " + tbNomFonction.Text + "(").Length;
                string indentation = "";
                for (int i = 0; i < indent; i++)
                    indentation += " ";

                string parameters = "";
                string[] param = tbParametres.Text.Replace("\r", "").Split('\n');
                foreach (string p in param)
                    parameters += "\t\t" + indentation + p + "\n";
                parameters = parameters.Substring(0, parameters.Length - 1);

                test = test.Replace("{{_PARAMETRES_}}", parameters != "" ? "\n" + parameters.Replace("\n", ",\n") : "");
                string validationsSortie = "";
                foreach (DataGridViewRow row in dgvValidationSortie.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[0].Value.ToString() == "" || row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                        continue;
                    validationsSortie += "\n\tEXPECT_EQ(" + row.Cells[0].Value + ", " + row.Cells[1].Value + ");";
                }
                test = test.Replace("{{_VALIDATION_SORTIE_}}", validationsSortie);

                if (!dictionary.ContainsKey(tbNomFichier.Text))
                    dictionary[tbNomFichier.Text] = tbTypeFichierBinaire.Text;

                return test.Replace("\r", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void BGenerer_Click(object sender, EventArgs e)
        {
            string code = generer();
            if (code == "")
                return;

            tbCode.Text = code.Replace("\r", "");
        }

        private void BGenererAjouter_Click(object sender, EventArgs e)
        {
            string code = generer();
            if (code == "")
                return;

            tbCode.Text += "\n\n" + code.Replace("\r", "");
        }

        private bool isValide()
        {
            while (tbDeclarationParametres.Text.EndsWith("\n"))
                tbDeclarationParametres.Text = tbDeclarationParametres.Text.Substring(0, tbDeclarationParametres.Text.Length - 2);
            while (tbParametres.Text.EndsWith("\n") || tbParametres.Text.EndsWith(");"))
                tbParametres.Text = tbParametres.Text.Substring(0, tbParametres.Text.Length - 2);

            return tbNomFichier.Text.Length
                * tbVersion.Text.Length
                * tbTypeFichierBinaire.Text.Length
                //* nudNumeroFonction.Value
                //* nudNumeroCas.Value
                * tbNomFonction.Text.Length
                != 0
                && cbTemplate.Items.Contains(cbTemplate.Text);
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charger("");
            fileToSave = "";
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = "Fichier UNIT_TEST_HELPER|*.uth";
            saveFileDialog.Title = "Ouvrir";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            fileToSave = saveFileDialog.FileName;

            charger(fileToSave);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sauver(fileToSave);
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToSave = "";
            sauver(fileToSave);
        }

        private void exporterCommeTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier Template UNIT_TEST_HELPER|*_template.txt";
            saveFileDialog.Title = "Exporter comme Template";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (!saveFileDialog.FileName.EndsWith("_template.txt"))
                    saveFileDialog.FileName = saveFileDialog.FileName.Replace(".txt", "_template.txt");

                TextWriter textWriter = new StreamWriter(saveFileDialog.FileName);
                textWriter.Write(tbCode.Text);
                textWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbTemplate.Items.Clear();
            foreach (string template in (Directory.GetFiles("./", "*_template.txt", SearchOption.TopDirectoryOnly)))
                cbTemplate.Items.Add(Path.GetFileName(template));
        }

        private void importerUnTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog = new OpenFileDialog();
            saveFileDialog.Filter = "Fichier Template UNIT_TEST_HELPER|*_template.txt";
            saveFileDialog.Title = "Importer un Template";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                File.Copy(saveFileDialog.FileName, Path.GetFileName(saveFileDialog.FileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbTemplate.Items.Clear();
            foreach (string template in (Directory.GetFiles("./", "*_template.txt", SearchOption.TopDirectoryOnly)))
                cbTemplate.Items.Add(Path.GetFileName(template));
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void developpéParYassinLOKHATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/yassin-lokhat");
        }
    }
}
