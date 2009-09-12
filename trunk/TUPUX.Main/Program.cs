using System;
using System.Collections.Generic;
using System.Windows.Forms;
using log4net;
using TUPUX.Forms;
using TUPUX.Estimation;

[assembly: log4net.Config.XmlConfiguratorAttribute(Watch = true)]
namespace TUPUX.Main
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            log.Info("Start Application");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Application.Run(new TUPUX.Forms.Form2());
            if (args.Length > 0)
            {
                if (args[0].Equals("2"))
                {
                    Application.Run(new TUPUX.Forms.FactorsSettings());
                }
                else if (args[0].Equals("3"))
                {
                    Application.Run(new TUPUX.Forms.EstimationSettings());
                }
                else if (args[0].Equals("4"))
                {
                    Application.Run(new TUPUX.Forms.ImportExcel());
                }
                else if (args[0].Equals("5"))
                {
                    FormEdit edit = FormsFactory.GetCurrent();
                    if (edit != null)
                    {
                        Application.Run(edit);
                    }
                }
                else if (args[0].Equals("6"))
                {
                    new FileGenerator().CreateFiles(null);
                    MessageBox.Show("Files generated successfully!", "File Generation Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					//Application.Run(new TUPUX.Forms.frmFileGenerator());
                }
                else
                {
                    Application.Run(new TUPUX.Forms.MainForm());
                }
            }
            else
            {
                //Application.Run(new TUPUX.Forms.ImportExcel());
                //Application.Run(new TUPUX.Forms.FactorsSettings());
                //FormEdit edit = FormsFactory.GetCurrent();
                //if (edit != null)
                //{
                //    Application.Run(edit);
                //}
                Application.Run(new TUPUX.Forms.MainForm());                
            }
            
            log.Info("End Application");
        }
    }
}