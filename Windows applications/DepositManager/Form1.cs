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
using static DepositManager.DataModels;

namespace DepositManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            SecurityPin originalPin = new SecurityPin(1234);
            SecurityPin copiedPin = originalPin; 

            copiedPin.PinCode = 9999; 

            CustomerProfile originalProfile = new CustomerProfile("Alice");
            CustomerProfile copiedProfile = originalProfile;

            copiedProfile.Name = "Bob";

            string resultText = $"=== STRUCT TEST ===\n" +
                                $"Original PIN: {originalPin.PinCode} (Should still be 1234)\n" +
                                $"Copied PIN: {copiedPin.PinCode} (Changed to 9999)\n\n" +
                                $"=== CLASS TEST ===\n" +
                                $"Original Name: {originalProfile.Name} (Changed to Bob!)\n" +
                                $"Copied Name: {copiedProfile.Name} (Changed to Bob!)";

            MessageBox.Show(resultText, "Class vs Struct Memory Test");
        }

        private void btnTestOverloads_Click(object sender, EventArgs e)
        {
            DepositBox myBox = new DepositBox();

            myBox.Deposit(500.00m);
            myBox.Deposit(250.50m); 

            string itemLog = myBox.Deposit("Family Diamond Ring");

            string message = $"Locker Owner: {myBox.Owner.Name}\n" +
                             $"Total Cash Stored: ${myBox.StoredCash}\n\n" +
                             $"Locker Item Status: \n{itemLog}";

            MessageBox.Show(message, "Method Overloading Test");
        }

        private void btnTestOverride_Click(object sender, EventArgs e)
        {
            DepositBox standardBox = new DepositBox("John Doe", LockerTier.Bronze, 4444);
            decimal standardFee = standardBox.CalculateAnnualFee();

            VIPDepositBox vipBox = new VIPDepositBox("Sarah Jenkins", 7777);
            decimal vipFee = vipBox.CalculateAnnualFee();

            string message = $"=== ANNUAL STORAGE FEES ===\n\n" +
                             $"Standard Account ({standardBox.Owner.Name}):\n" +
                             $"Tier: {standardBox.Tier}\n" +
                             $"Fee: ${standardFee}\n\n" +
                             $"VIP Account ({vipBox.Owner.Name}):\n" +
                             $"Tier: {vipBox.Tier}\n" +
                             $"Fee: {vipFee.ToString("C")} (20% VIP Discount Applied!)";

            MessageBox.Show(message, "Polymorphism & Override Test");
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            string filePath = "LockerLog.txt";

            string logData = $"--- SAFE DEPOSIT BOX TRANSACTION LOG ---\n" +
                             $"Timestamp: {DateTime.Now}\n" +
                             $"Action: Backup Created\n" +
                             $"Status: All lockers secured successfully.\n" +
                             $"---------------------------------------";

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.Write(logData);
                    }
                }
                MessageBox.Show($"Log exported successfully!\nSaved as: {filePath}", "FileStream Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "File Error");
            }
        }
    }
}
