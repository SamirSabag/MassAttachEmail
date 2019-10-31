using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Reflection;

namespace MassAttachEmail
{
    public partial class MainForm : Form
    {
        string signature;
        static string path;
        static DataTable dtMapping = new DataTable();
        string emailBody = Properties.Settings.Default.EmailBody;
        string emailSubject = Properties.Settings.Default.EmailSubject;

        public MainForm()
        {
            InitializeComponent();
            txtLoggText.Text += "To start upload the mapping table \r\n";
            tbBody.Text = emailBody;
            tbSubject.Text = emailSubject;
            path = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Signatures";
            var filenames = Directory
                .EnumerateFiles(path, "*htm", SearchOption.AllDirectories)
                .Select(Path.GetFileName).ToList(); // <-- note you can shorten the lambda
            cbSelectSignature.DataSource = filenames;
            wbSignDisplay.Navigate(path + "\\" + cbSelectSignature.SelectedItem.ToString());
            
            signature = File.OpenText(path + "\\" + cbSelectSignature.Text.ToString()).ReadToEnd();
        }
        public void SendEMailThroughOutlook(string fileName, string filePath, string email)
        {
            try
            {

                // Create the Outlook application.
                Outlook.Application oApp = new Outlook.Application();
                // Create a new mail item.
                Outlook.MailItem oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem);
                // Set HTMLBody. 
                //add the body of the email
                oMsg.HTMLBody = tbBody.Text + "\r\n" +signature;
                //Add an attachment.
                String sDisplayName = fileName;
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //now attached the file
                Outlook.Attachment oAttach = oMsg.Attachments.Add
                                             (filePath + "\\" + fileName, iAttachType, iPosition, sDisplayName);                
                //Subject line
                oMsg.Subject = tbSubject.Text;
                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(email);
                oRecip.Resolve();
                // Send.
                oMsg.Send();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (Exception ex)
            {
                txtLoggText.Text += "error: " + ex.Message + "\r\n" ;

            }//end of catch
        }//end of Email Method
        public void SaveEMailThroughOutlook(string fileName, string filePath, string email)
        {
            try
            {
                // Create the Outlook application.
                Outlook.Application oApp = new Outlook.Application();
                // Create a new mail item.
                Outlook.MailItem oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                // Set HTMLBody.                
                //add the body of the email
                oMsg.HTMLBody = tbBody.Text + "\r\n" + signature;
                //Add an attachment.
                String sDisplayName = fileName;
                int iPosition = (int)oMsg.Body.Length + 1;
                int iAttachType = (int)Outlook.OlAttachmentType.olByValue;
                //now attached the file
                Outlook.Attachment oAttach = oMsg.Attachments.Add
                                             (filePath, iAttachType, iPosition, sDisplayName);
                //Subject line
                oMsg.Subject = tbSubject.Text + " " + fileName+".pdf";
                // Add a recipient.
                Outlook.Recipients oRecips = (Outlook.Recipients)oMsg.Recipients;
                // Change the recipient in the next line if necessary.
                Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(email);
                oRecip.Resolve();
                // Send.
                oMsg.Save();
                // Clean up.
                oRecip = null;
                oRecips = null;
                oMsg = null;
                oApp = null;
            }//end of try block
            catch (Exception ex)
            {
                txtLoggText.Text += "error: " + ex.Message + "\r\n";
            }//end of catch
        }//end of Email Method

        private void BtnLoadMappingTable_Click(object sender, EventArgs e)
        {
            string inputPath = GetFilePath();
            dtMapping = ExcelFileToDataGridView("Mapping", inputPath);
            dgvDisplay.DataSource = dtMapping;
        }

        public DataTable ExcelFileToDataGridView(string sheetName, string path)
        {
            DataTable dataTable = new DataTable(sheetName);
            //string name = null;            
            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" + path + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";
                    using (OleDbCommand comm = new OleDbCommand())
                    {
                        comm.CommandText = "SELECT * FROM [" + sheetName + "$]";
                        comm.Connection = conn;
                        using (OleDbDataAdapter da = new OleDbDataAdapter())
                        {
                            da.SelectCommand = comm;
                            da.Fill(dataTable);                           
                        }
                    }
                    txtLoggText.Text += "Table loaded succesfully from file: " + path + "\r\n";
                    path = null;

                    btnSaveEmails.Enabled = true;
                    btnSendEmails.Enabled = true;

                    return dataTable;
                }
            }
            catch (System.Exception ex)
            {

                path = null;
                MessageBox.Show("error: " + ex.Message);
                btnSaveEmails.Enabled = false;
                btnSendEmails.Enabled = false;
                // name = null;
            }
            return dataTable;
        }
        public string GetFilePath()
        {
            string filePath = null;
            try
            {
                System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
                System.Windows.Forms.DialogResult dialog = new System.Windows.Forms.DialogResult();
                dialog = ofd.ShowDialog();
                if (dialog == System.Windows.Forms.DialogResult.OK)
                {
                    if (File.Exists(ofd.FileName))
                    {
                        return filePath = ofd.FileName;
                    }
                    else
                    {
                        return filePath = null;
                    }
                }
                else if (dialog == System.Windows.Forms.DialogResult.Cancel)
                {
                    return filePath = null;
                }
                else if (dialog == System.Windows.Forms.DialogResult.Ignore)
                {
                    return filePath = null;
                }
                else
                {
                    return filePath = null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Open File Dialog Error:" + ex.Message);
            }
            return filePath;
        }

        private void CbSelectSignature_SelectedIndexChanged(object sender, EventArgs e)
        {
            path = @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Signatures";
            wbSignDisplay.Navigate(path + "\\" + cbSelectSignature.Text.ToString());
            wbSignDisplay.Update();
        }

        private void BtnSendEmails_Click(object sender, EventArgs e)
        {
            string fileName;
            string filePath;
            string email;
            string subject;
            for (int i = 0; i < dtMapping.Rows.Count; i++)
            {
                fileName = dtMapping.Rows[i][0].ToString();
                filePath = dtMapping.Rows[i][1].ToString();
                email = dtMapping.Rows[i][2].ToString();
                subject = dtMapping.Rows[i][3].ToString();

                var files = Directory
                .EnumerateFiles(filePath, "*", SearchOption.AllDirectories)
                .Select(Path.GetFileName).ToList(); // <-- note you can shorten the lambda

                foreach (var file in files)
                {
                    SendEMailThroughOutlook(file, filePath, "samir.sabag.olague@hp.com");
                }


                
            }

            //try
            //{
            //    SendEMailThroughOutlook("9008879949", @"C:\Packages\Folder1\9008879949.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("923816", @"C:\Packages\Folder1\923816.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("3", @"C:\Packages\Folder2\3.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("4", @"C:\Packages\Folder2\4.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("5", @"C:\Packages\Folder3\5.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("6", @"C:\Packages\Folder3\6.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("7", @"C:\Packages\Folder4\7.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("8", @"C:\Packages\Folder4\8.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //    SendEMailThroughOutlook("9", @"C:\Packages\Folder5\9.PDF", "samir.sabag.olague@gmail.com");
            //    txtLoggText.Text += "Email sent \r\n";
            //}
            //catch (Exception)
            //{
            //    throw;
            //}

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.EmailBody = tbBody.Text;
            //Properties.Settings.Default.Save();

            //Properties.Settings.Default.EmailSubject = tbSubject.Text;
            //Properties.Settings.Default.Save();
        }

        private void BtnSaveEmails_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialog = MessageBox.Show("This action will send the emails to the APs contained in this report, this action cannot be undone, are you sure you want to continue?", "Send emails confirm", MessageBoxButtons.YesNo);
            if (dialog == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SaveEMailThroughOutlook("9008879949", @"C:\Packages\Folder1\9008879949.PDF", "samir.sabag.olague@gmail.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("923816", @"C:\Packages\Folder1\923816.PDF", "samir.sabag.olague@gmail.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("3", @"C:\Packages\Folder2\3.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("4", @"C:\Packages\Folder2\4.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("5", @"C:\Packages\Folder3\5.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("6", @"C:\Packages\Folder3\6.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("7", @"C:\Packages\Folder4\7.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("8", @"C:\Packages\Folder4\8.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                    SaveEMailThroughOutlook("9", @"C:\Packages\Folder5\9.PDF", "samir.sabag.olague@hp.com");
                    txtLoggText.Text += "Email saved \r\n";
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                //nothing to do
            }
        }
    }
}
