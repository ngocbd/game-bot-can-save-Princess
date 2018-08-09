using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botcansaveprincess
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
        public class player
        {
            public static int x { get; set; }
            public static int y { get; set; }
        }
        public class princess
        {
            public static int x { get; set; }
            public static int y { get; set; }
        }
        public class wall
        {
            public static int x { get; set; }
            public static int y { get; set; }
        }
        public class monster
        {
            public static int x { get; set; }
            public static int y { get; set; }
        }
    }
}
