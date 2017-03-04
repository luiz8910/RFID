using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Impinj.OctaneSdk;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using System.Threading;
using System.Reflection;


namespace ReadTagsSync
{
    public partial class FormLeitura : Form
    {
        public FormLeitura()
        {
            InitializeComponent();
        }

       
        int i = 0;
        int j = 0;
        List<String> arr = new List<String>();
        List<String> uni = new List<String>();
        static randomString random = new randomString();
        String id_leitura = random.RandomString();
        String nomeProduto = "";
        int qtde = 0;
        double total = 0;


        // Create an instance of the SpeedwayReader class.
        static SpeedwayReader Reader = new SpeedwayReader();
        

        private void FormLeitura_Load(object sender, EventArgs e)
        {
            this.ActiveControl = rTxtLeituraEsperada;
        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnTagsReported(object sender, TagsReportedEventArgs args)
        {
            var con = new dbConnection();

            foreach (Tag tag in args.TagReport.Tags)
            {
                var length = tag.Epc.Length;

                var leitura = "";

                var unidade = "";

                var nome = "";

                var indice = false;

                var uni_index = false;

                if (length == 24)
                {
                    leitura = tag.Epc.Substring(12, 4);
                    unidade = tag.Epc.Substring(16, 8);

                    nome = con.exibirNomeProduto(leitura);

                    if (nome != "")
                    {
                        indice = arr.Contains(nome);

                        if (!indice)
                        {
                            arr.Insert(i, nome);
                            uni.Insert(j, leitura + unidade);
                            i++;
                            j++;
                            
                            con.Insert(nome, id_leitura);

                            nomeProduto = nome;
                            
                            total++;

                            backgroundWorker1.RunWorkerAsync();

                            
                        }
                        else
                        {
                            uni_index = uni.Contains(leitura + unidade);

                            if (!uni_index)
                            {
                                uni.Insert(j, leitura + unidade);
                                j++;
                                qtde = con.Update(nome, id_leitura);

                                nomeProduto = nome;

                                total++;

                                backgroundWorker2.RunWorkerAsync();
                            }

                        }

                    }

                    Console.WriteLine("EPC :{0}", tag.Epc);
                }

            }

        }

        private void mudarQtde()
        {
            var text = "";
            
            
            lblProduto1.Invoke(new MethodInvoker(delegate { text = lblProduto1.Text; }));

            if (text == nomeProduto)
            {
                lblQtde1.Invoke(new MethodInvoker(delegate { lblQtde1.Text = qtde.ToString(); }));
            }
            

            
            lblProduto2.Invoke(new MethodInvoker(delegate { text = lblProduto2.Text; }));

            if (text == nomeProduto)
            {
                lblQtde2.Invoke(new MethodInvoker(delegate { lblQtde2.Text = qtde.ToString(); }));
            }
            

            
            lblProduto3.Invoke(new MethodInvoker(delegate { text = lblProduto3.Text; }));

            if (text == nomeProduto)
            {
                lblQtde3.Invoke(new MethodInvoker(delegate { lblQtde3.Text = qtde.ToString(); }));
            }
            

            
            lblProduto4.Invoke(new MethodInvoker(delegate { text = lblProduto4.Text; }));

            if (text == nomeProduto)
            {
                lblQtde4.Invoke(new MethodInvoker(delegate { lblQtde4.Text = qtde.ToString(); }));
            }
            

            
            lblProduto5.Invoke(new MethodInvoker(delegate { text = lblProduto5.Text; }));

            if (text == nomeProduto)
            {
                lblQtde5.Invoke(new MethodInvoker(delegate { lblQtde5.Text = qtde.ToString(); }));
            }
            

            
            lblProduto6.Invoke(new MethodInvoker(delegate { text = lblProduto6.Text; }));

            if (text == nomeProduto)
            {
                lblQtde6.Invoke(new MethodInvoker(delegate { lblQtde6.Text = qtde.ToString(); }));
            }
            

            
            lblProduto7.Invoke(new MethodInvoker(delegate { text = lblProduto7.Text; }));

            if (text == nomeProduto)
            {
                lblQtde7.Invoke(new MethodInvoker(delegate { lblQtde7.Text = qtde.ToString(); }));
            }
            

            
            lblProduto8.Invoke(new MethodInvoker(delegate { text = lblProduto8.Text; }));

            if (text == nomeProduto)
            {
                lblQtde8.Invoke(new MethodInvoker(delegate { lblQtde8.Text = qtde.ToString(); }));
            }
            

            
            lblProduto9.Invoke(new MethodInvoker(delegate { text = lblProduto9.Text; }));

            if (text == nomeProduto)
            {
                lblQtde9.Invoke(new MethodInvoker(delegate { lblQtde9.Text = qtde.ToString(); }));
            }
            

            
            lblProduto10.Invoke(new MethodInvoker(delegate { text = lblProduto10.Text; }));

            if (text == nomeProduto)
            {
                lblQtde10.Invoke(new MethodInvoker(delegate { lblQtde10.Text = qtde.ToString(); }));
            }

            lblProduto11.Invoke(new MethodInvoker(delegate { text = lblProduto11.Text; }));

            if (text == nomeProduto)
            {
                lblQtde11.Invoke(new MethodInvoker(delegate { lblQtde11.Text = qtde.ToString(); }));
            }
            

            /*

            Label[] lray = { lblQtde1, lblQtde2, lblQtde3, lblQtde4, lblQtde5, lblQtde6, lblQtde7, lblQtde8, lblQtde9, lblQtde10 };
            Label[] lbl = { lblProduto1, lblProduto2, lblProduto3, lblProduto4, lblProduto5, lblProduto6, lblProduto7, 
                              lblProduto8, lblProduto9, lblProduto10 };
            
            foreach (Label label in lray)
            {
                foreach (Label l in lbl)
                { 
                    if(l.InvokeRequired)
                    {
                        l.Invoke(new MethodInvoker(delegate { text = l.Text; }));

                        if (text == nomeProduto)
                        { 
                            label.Invoke(new MethodInvoker(delegate { label.Text = qtde.ToString() ; }));
                            break;
                        }
                        
                    }
                }
                
                 
            }  

        if (lbl.Text == nomeProduto)
        { 
                        
        }
        */
                        
        }

        private void mudarLabel()
        {
            var nome = nomeProduto;

            if (lblProduto1.Text == "")
            {
                if (lblProduto1.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto1.Invoke(new MethodInvoker(delegate { lblProduto1.Text = nome; }));
                    lblQtde1.Invoke(new MethodInvoker(delegate { lblQtde1.Text = "1"; }));
                }
            }
            else if (lblProduto2.Text == "")
            {
                if (lblProduto2.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto2.Invoke(new MethodInvoker(delegate { lblProduto2.Text = nome; }));
                    lblQtde2.Invoke(new MethodInvoker(delegate { lblQtde2.Text = "1"; }));
                }
            }

            else if (lblProduto3.Text == "")
            {
                if (lblProduto3.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto3.Invoke(new MethodInvoker(delegate { lblProduto3.Text = nome; }));
                    lblQtde3.Invoke(new MethodInvoker(delegate { lblQtde3.Text = "1"; }));
                }
            }

            else if (lblProduto4.Text == "")
            {
                if (lblProduto4.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto4.Invoke(new MethodInvoker(delegate { lblProduto4.Text = nome; }));
                    lblQtde4.Invoke(new MethodInvoker(delegate { lblQtde4.Text = "1"; }));
                }
            }
            else if (lblProduto5.Text == "")
            {
                if (lblProduto5.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto5.Invoke(new MethodInvoker(delegate { lblProduto5.Text = nome; }));
                    lblQtde5.Invoke(new MethodInvoker(delegate { lblQtde5.Text = "1"; }));
                }

            }

            else if (lblProduto6.Text == "")
            {
                if (lblProduto6.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto6.Invoke(new MethodInvoker(delegate { lblProduto6.Text = nome; }));
                    lblQtde6.Invoke(new MethodInvoker(delegate { lblQtde6.Text = "1"; }));
                }
            }

            else if (lblProduto7.Text == "")
            {
                if (lblProduto7.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto7.Invoke(new MethodInvoker(delegate { lblProduto7.Text = nome; }));
                    lblQtde7.Invoke(new MethodInvoker(delegate { lblQtde7.Text = "1"; }));
                }
            }

            else if (lblProduto8.Text == "")
            {
                if (lblProduto8.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto8.Invoke(new MethodInvoker(delegate { lblProduto8.Text = nome; }));
                    lblQtde8.Invoke(new MethodInvoker(delegate { lblQtde8.Text = "1"; }));
                }
            }

            else if (lblProduto9.Text == "")
            {
                if (lblProduto9.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto9.Invoke(new MethodInvoker(delegate { lblProduto9.Text = nome; }));
                    lblQtde9.Invoke(new MethodInvoker(delegate { lblQtde9.Text = "1"; }));
                }
            }

            else if (lblProduto10.Text == "")
            {
                if (lblProduto10.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto10.Invoke(new MethodInvoker(delegate { lblProduto10.Text = nome; }));
                    lblQtde10.Invoke(new MethodInvoker(delegate { lblQtde10.Text = "1"; }));
                }
            }

            else if (lblProduto11.Text == "")
            {
                if (lblProduto11.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto11.Invoke(new MethodInvoker(delegate { lblProduto11.Text = nome; }));
                    lblQtde11.Invoke(new MethodInvoker(delegate { lblQtde11.Text = "1"; }));
                }
            }
        }

        private void MudarImagem()
        {
            Image image;

            var url = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            var path = Path.GetFullPath(Path.Combine(url, @"..\..\img\"));

            if (pictureBoxProduto1.ImageLocation == "" && pictureBoxProduto1.Image == null)
            {
                if (pictureBoxProduto1.InvokeRequired)
                { 
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto1.Invoke(new MethodInvoker(delegate { pictureBoxProduto1.Image = image; }));
                }
            }

            else if (pictureBoxProduto2.ImageLocation == "" && pictureBoxProduto2.Image == null)
            {
                if (pictureBoxProduto2.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto2.Invoke(new MethodInvoker(delegate { pictureBoxProduto2.Image = image; }));
                }
            }

            else if (pictureBoxProduto3.ImageLocation == "" && pictureBoxProduto3.Image == null)
            {
                if (pictureBoxProduto3.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto3.Invoke(new MethodInvoker(delegate { pictureBoxProduto3.Image = image; }));
                }
            }

            else if (pictureBoxProduto4.ImageLocation == "" && pictureBoxProduto4.Image == null)
            {
                if (pictureBoxProduto4.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto4.Invoke(new MethodInvoker(delegate { pictureBoxProduto4.Image = image; }));
                }
            }

            else if (pictureBoxProduto5.ImageLocation == "" && pictureBoxProduto5.Image == null)
            {
                if (pictureBoxProduto5.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto5.Invoke(new MethodInvoker(delegate { pictureBoxProduto5.Image = image; }));
                }
            }

            else if (pictureBoxProduto6.ImageLocation == "" && pictureBoxProduto6.Image == null)
            {
                if (pictureBoxProduto6.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto6.Invoke(new MethodInvoker(delegate { pictureBoxProduto6.Image = image; }));
                }
            }

            else if (pictureBoxProduto7.ImageLocation == "" && pictureBoxProduto7.Image == null)
            {
                if (pictureBoxProduto7.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto7.Invoke(new MethodInvoker(delegate { pictureBoxProduto7.Image = image; }));
                }
            }

            else if (pictureBoxProduto8.ImageLocation == "" && pictureBoxProduto8.Image == null)
            {
                if (pictureBoxProduto8.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto8.Invoke(new MethodInvoker(delegate { pictureBoxProduto8.Image = image; }));
                }
            }


            else if (pictureBoxProduto9.ImageLocation == "" && pictureBoxProduto9.Image == null)
            {
                if (pictureBoxProduto9.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto9.Invoke(new MethodInvoker(delegate { pictureBoxProduto9.Image = image; }));
                }
            }

            else if (pictureBoxProduto10.ImageLocation == "" && pictureBoxProduto10.Image == null)
            {
                if (pictureBoxProduto10.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto10.Invoke(new MethodInvoker(delegate { pictureBoxProduto10.Image = image; }));
                }
            }

            else if (pictureBoxProduto11.ImageLocation == "" && pictureBoxProduto11.Image == null)
            {
                if (pictureBoxProduto11.InvokeRequired)
                {
                    image = Image.FromFile(path + nomeProduto + ".png");

                    pictureBoxProduto11.Invoke(new MethodInvoker(delegate { pictureBoxProduto11.Image = image; }));
                }
            }

            

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rTxtLeituraEsperada.Text == "")
            {
                MessageBox.Show("Insira a leitura esperada");
                
            }
            else { 
                total = 0;
                btnStop.Enabled = true;
                btnStop.BackColor = Color.Maroon;

                btnStart.Enabled = false;
                btnStart.BackColor = Color.Gray;

                LimparLeitura();

                try
                {
                

                    // Connect to the reader.
                    // Replace "SpeedwayR-10-25-32" with your 
                    // reader's host name or IP address.
                    Reader.Connect("SpeedwayR-11-d4-d2.local");

                    // Remove all settings from the reader.
                    Reader.ClearSettings();


                    // Get the factory default settings
                    // We'll use these as a starting point
                    // and then modify the settings we're 
                    // interested in
                    Settings settings = Reader.QueryFactorySettings();

                    // Transmit power for each antenna
                    settings.Antennas[1].TxPowerInDbm = 15;

                    settings.Antennas[2].TxPowerInDbm = 15;
                    //settings.Antennas[3].TxPowerInDbm = 15;
                    settings.SearchMode = SearchMode.DualTarget;
                    settings.ReaderMode = ReaderMode.MaxThroughput;

                    // Tell the reader to include the antenna number
                    // in all tag reports. Other fields can be added
                    // to the reports in the same way by setting the 
                    // appropriate Report.IncludeXXXXXXX property.

                    /*settings.Report.IncludeAntennaPortNumber = true;
                    settings.Report.IncludeFirstSeenTime = true;  
                    settings.Report.IncludeSeenCount = true; */



                    // Send a tag report for every tag read.
                    settings.Report.Mode = ReportMode.Individual;
                    //Console.WriteLine(settings.Report.Mode);

                    // Apply the newly modified settings.
                    Reader.ApplySettings(settings);

                    //Application.Run(new FormLeitura());

                    // Assign the TagsReported handler.
                    // This specifies which function to call
                    // when tags reports are available.
                    Reader.TagsReported += new EventHandler
                        <TagsReportedEventArgs>(OnTagsReported);

                    // Start reading.
                    Reader.Start();

                    // Wait for the user to press enter.

                    //Console.WriteLine("Press enter when done.");
                    //Console.ReadLine();

                
                    // Stop reading.
                    //Reader.Stop();

                    // Disconnect from the reader.
                    //Reader.Disconnect();

                    //Stop(Reader);
                
                }
                catch (OctaneSdkException ex)
                {
                    Console.WriteLine("Octane SDK exception: {0}", ex.Message);
                    Console.Read();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception : {0}", ex.Message);
                }
            }
            
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            new Thread(mudarLabel).Start();
            new Thread(MudarImagem).Start();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            new Thread(mudarQtde).Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop reading.
            Reader.Stop();

            // Disconnect from the reader.
            Reader.Disconnect();

            btnStart.Enabled = true;
            btnStart.BackColor = Color.SeaGreen;

            btnStop.Enabled = false;
            btnStop.BackColor = Color.Gray;

            rTxtLeituraObtida.Text = total.ToString();

            //Obtém Porcentagem Lida
            ObterPorcentagem();
            
        }

        private void LimparLeitura()
        {
            
            rTxtLeituraObtida.Text = "";
            
            rTxtPorcen.Text = "";
            

            lblProduto1.Text = "";
            lblQtde1.Text = "";
            pictureBoxProduto1.Image = null;

            lblProduto2.Text = "";
            lblQtde2.Text = "";
            pictureBoxProduto2.Image = null;

            lblProduto3.Text = "";
            lblQtde3.Text = "";
            pictureBoxProduto3.Image = null;

            lblProduto4.Text = "";
            lblQtde4.Text = "";
            pictureBoxProduto4.Image = null;

            lblProduto5.Text = "";
            lblQtde5.Text = "";
            pictureBoxProduto5.Image = null;

            lblProduto6.Text = "";
            lblQtde6.Text = "";
            pictureBoxProduto6.Image = null;

            lblProduto7.Text = "";
            lblQtde7.Text = "";
            pictureBoxProduto7.Image = null;

            lblProduto8.Text = "";
            lblQtde8.Text = "";
            pictureBoxProduto8.Image = null;

            lblProduto9.Text = "";
            lblQtde9.Text = "";
            pictureBoxProduto9.Image = null;

            lblProduto10.Text = "";
            lblQtde10.Text = "";
            pictureBoxProduto10.Image = null;

            lblProduto11.Text = "";
            lblQtde11.Text = "";
            pictureBoxProduto11.Image = null;

        }

        private void ObterPorcentagem()
        {
            double leituraEsp = Convert.ToInt32(rTxtLeituraEsperada.Text);

            double porcentagem = total > leituraEsp ? 0 : (total / leituraEsp) * 100;

            rTxtPorcen.Text = porcentagem.ToString() + "%";

            rTxtLeituraEsperada.Focus();
        }

        private void rTxtLeituraEsperada_MouseEnter(object sender, EventArgs e)
        {
            this.AcceptButton = btnStart;
        }

        private void FormLeitura_Shown(object sender, EventArgs e)
        {
            rTxtLeituraEsperada.Select();
            rTxtLeituraEsperada.Focus();
        }

        private void rTxtLeituraEsperada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        

        
    }
}
