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
        /* Create an instance of the SpeedwayReader class.
        static SpeedwayReader Reader = new SpeedwayReader();
        static int i = 0;
        static int j = 0;
        static List<String> arr = new List<String>();
        static List<String> uni = new List<String>();
        static randomString random = new randomString();
        static String id_leitura = random.RandomString();
        static FormLeitura form = new FormLeitura();*/

        public static void Main(string[] args)
        {
            Application.Run(new FormLeitura());
            
        }

    }
}