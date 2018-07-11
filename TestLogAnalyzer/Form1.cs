using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogAnalyzer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            PrismaErrLabel.ForeColor = System.Drawing.Color.Gray;
            CommMgrErrLabel.ForeColor = System.Drawing.Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // connect to and read in the log files
            // 1. make sure all log files are found
            // prisma error log
            string prismaErrLogPath = @"C:\Users\lauren.arfaras\Documents\Logging\Runtime\Prisma_2014\Prisma_Error.Log";
            bool prismaErrLogExists = File.Exists(prismaErrLogPath);
            if (prismaErrLogExists)
            {
                Console.WriteLine("Prisma Error Log File Exists.");
                PrismaErrLabel.Text = PrismaErrLabel.Text + "\t \u2713";
                PrismaErrLabel.ForeColor = Color.Green;
            }
            else
            {
                Console.WriteLine("Prisma Error Log File Does Not Exist.");
                PrismaErrLabel.Text = PrismaErrLabel.Text + "\t \u2717";
                PrismaErrLabel.ForeColor = Color.Red;
            }
            // commmgr error log
            string commMgrErrLogPath = @"C:\Users\lauren.arfaras\Documents\Logging\Runtime\Prisma_2014\CommMgr_Error.log";
            bool commMgrErrLogExists = File.Exists(commMgrErrLogPath);
            if (commMgrErrLogExists)
            {
                Console.WriteLine("CommMgr Error Log File Exists.");
                CommMgrErrLabel.Text = CommMgrErrLabel.Text + "\t \u2713";
                CommMgrErrLabel.ForeColor = Color.Green;
            }
            else
            {
                Console.WriteLine("CommMgr Error Log File Does Not Exist.");
                CommMgrErrLabel.Text = CommMgrErrLabel.Text + "\t \u2717";
                CommMgrErrLabel.ForeColor = Color.Red;
            }

            // continue or retry to find files
            string message = "";
            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (prismaErrLogExists && commMgrErrLogExists)
            {
                message = "All log files found.";
            }
            else if (prismaErrLogExists)
            {
                message = "The error log file for CommMgr has not been found.\n" +
                    "Would you like to retry?";
                //buttons = MessageBoxButtons.YesNo;
            }
            else if (commMgrErrLogExists)
            {
                message = "The error log file for Prisma has not been found.\n" +
                    "Would you like to retry?";
                //buttons = MessageBoxButtons.YesNo;
            }
            else if (!prismaErrLogExists || !commMgrErrLogExists)
            {
                message = "No log files have been found.";
                //buttons = MessageBoxButtons.RetryCancel;
            }
            toolStripStatusLabel1.Text = message;
            //DialogResult result = MessageBox.Show(message, "", buttons, MessageBoxIcon.Information);
            //if (result == System.Windows.Forms.DialogResult.Yes)
            //{
            //    Console.WriteLine("here");
            //}
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
