using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DougieMcDungeons
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    /*public struct Stats
    {
        public string statistic;
        public int magnitude;
        public Stats(string sta, int mag)
        {
            statistic = sta;
            magnitude = mag;
        }
    }*/
}
