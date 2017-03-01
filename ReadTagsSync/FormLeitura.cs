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

        // This delegate enables asynchronous calls for setting  
        // the text property on a TextBox control.  
        delegate void StringArgReturningVoidDelegate(string text);

        // This thread is used to demonstrate both thread-safe and  
        // unsafe ways to call a Windows Forms control.  
        private Thread demoThread = null;

        // This BackgroundWorker is used to demonstrate the   
        // preferred way of performing asynchronous operations.  
        //private BackgroundWorker backgroundWorker2 = null;  
        

        private void FormLeitura_Load(object sender, EventArgs e)
        {
            //Program program = new Program();
            

            
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
                            //lblProduto1.Text = nome;
                            con.Insert(nome, id_leitura);

                            nomeProduto = nome;

                            backgroundWorker1.RunWorkerAsync();
                            
                        }
                        else
                        {
                            uni_index = uni.Contains(leitura + unidade);

                            if (!uni_index)
                            {
                                uni.Insert(j, leitura + unidade);
                                j++;
                                con.Update(nome, id_leitura);
                            }

                        }

                    }

                    Console.WriteLine("EPC :{0}", tag.Epc);
                }

            }

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
                }
            }
            else if (lblProduto2.Text == "")
            {
                if (lblProduto2.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto2.Invoke(new MethodInvoker(delegate { lblProduto2.Text = nome; }));
                }
            }

            else if (lblProduto3.Text == "")
            {
                if (lblProduto3.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto3.Invoke(new MethodInvoker(delegate { lblProduto3.Text = nome; }));
                }
            }

            else if (lblProduto4.Text == "")
            {
                if (lblProduto4.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto4.Invoke(new MethodInvoker(delegate { lblProduto4.Text = nome; }));
                }
            }
            else if (lblProduto5.Text == "")
            {
                if (lblProduto5.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto5.Invoke(new MethodInvoker(delegate { lblProduto5.Text = nome; }));
                }

            }

            else if (lblProduto6.Text == "")
            {
                if (lblProduto6.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto6.Invoke(new MethodInvoker(delegate { lblProduto6.Text = nome; }));
                }
            }

            else if (lblProduto7.Text == "")
            {
                if (lblProduto7.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto7.Invoke(new MethodInvoker(delegate { lblProduto7.Text = nome; }));
                }
            }

            else if (lblProduto8.Text == "")
            {
                if (lblProduto8.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto8.Invoke(new MethodInvoker(delegate { lblProduto8.Text = nome; }));
                }
            }

            else if (lblProduto9.Text == "")
            {
                if (lblProduto9.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto9.Invoke(new MethodInvoker(delegate { lblProduto9.Text = nome; }));
                }
            }

            else if (lblProduto10.Text == "")
            {
                if (lblProduto10.InvokeRequired)
                {
                    //this.Invoke(new Action(() => lblProduto1.Text = "Produto"));
                    lblProduto10.Invoke(new MethodInvoker(delegate { lblProduto10.Text = nome; }));
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            //this.demoThread = new Thread(new ThreadStart(this.ThreadProcSafe));

            //this.demoThread.Start();

            //MessageBox.Show(lblProduto1.Text);

            try
            {
                // Create an instance of the SpeedwayReader class.
                SpeedwayReader Reader = new SpeedwayReader();

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


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            new Thread(mudarLabel).Start();
        }  
        

    }
}
