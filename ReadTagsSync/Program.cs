using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Impinj.OctaneSdk;
using System.IO;
using System.Data;
using MySql.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ReadTagsSync
{
    class Program
    {
        // Create an instance of the SpeedwayReader class.
        static SpeedwayReader Reader = new SpeedwayReader();
        static int i = 0;
        static int j = 0;
        static List<String> arr = new List<String>();
        static List<String> uni = new List<String>();
        static randomString random = new randomString();
        static String id_leitura = random.RandomString();
        static FormLeitura form = new FormLeitura();

        public void inicio() 
        {
            MessageBox.Show("Aqui");
        }
        

        public static void Main(string[] args)
        {
            try
            {
                Application.Run(new FormLeitura());
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
                settings.Antennas[1].TxPowerInDbm = 27;

                settings.Antennas[2].TxPowerInDbm = 27;
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

                

                // Assign the TagsReported handler.
                // This specifies which function to call
                // when tags reports are available.
                Reader.TagsReported += new EventHandler
                    <TagsReportedEventArgs>(OnTagsReported);

                // Start reading.
                Reader.Start();

                // Wait for the user to press enter.

                Console.WriteLine("Press enter when done.");
                Console.ReadLine();

                // Stop reading.
                Reader.Stop();

                // Disconnect from the reader.
                Reader.Disconnect();
            }
            catch (OctaneSdkException e)
            {
                Console.WriteLine("Octane SDK exception: {0}", e.Message);
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e.Message);
            }
        }

        static void OnTagsReported(object sender, TagsReportedEventArgs args)
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
                            form.lblProduto1.Text = nome;
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
    }
}