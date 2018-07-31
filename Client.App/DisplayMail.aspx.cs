using ACME.EmplyeeBirthdayWish.CrossCutting.DTO;
using ACME.EmplyeeBirthdayWish.Service.Host.BirthDayServiceHost;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mail;
using System.Reflection;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Client.App
{
    public partial class DisplayMail : System.Web.UI.Page
    {
        
        protected void BtnDisplayMail_Click(object sender, EventArgs e)
        {
          List<MailMessage> msg = CreateMessage();
            foreach (MailMessage msgdata in msg)
            {
                PlaceHolder1.Controls.Add(ShowMessage(msgdata));
            }
            
        }
       
        HtmlTable ShowMessage(MailMessage msg)
        {
            HtmlTable table = new HtmlTable();
            HtmlTableRow topRow = new HtmlTableRow();
            HtmlTableCell fieldHeaderCell = new HtmlTableCell();
            HtmlTableCell valueHeaderCell = new HtmlTableCell();
            //fieldHeaderCell.InnerText = "Field";
            //topRow.Cells.Add(fieldHeaderCell);
            ////valueHeaderCell.InnerText = "Value";
            //topRow.Cells.Add(valueHeaderCell);
            //table.Rows.Add(topRow);

            foreach (PropertyInfo p in msg.GetType().GetProperties())
            {
                HtmlTableRow row = new HtmlTableRow();

                HtmlTableCell labelCell = new HtmlTableCell();

                HtmlTableCell valueCell = new HtmlTableCell();

                if (p.Name == "Body")
                {
                    //labelCell.InnerText = String.Format("{0}", p.Name);
                    //row.Cells.Add(labelCell);

                    valueCell.InnerText = String.Format("{0}", p.GetValue(msg, null));
                    row.Cells.Add(valueCell);
                }

                table.Rows.Add(row);
            }

            return table;
        }


        private List<MailMessage> CreateMessage()
        {
            MyProxy proxy;
            proxy = new MyProxy();
            //Console.WriteLine("Client is running at " + DateTime.Now.ToString());

            try
            {
                var result1 = proxy.GetBirthdays();
                List<MailMessage> msg = new List<MailMessage>();
                foreach (Employee emp in result1)
                {
                    MailDefinition md = new MailDefinition();
                    md.From = "Amit.Chourasia@fisglobal.com";
                    md.IsBodyHtml = true;
                    md.Subject = "Happy Birthday!";

                    ListDictionary replacements = new ListDictionary();
                    replacements.Add("{FirstName}", emp.Name);
                    replacements.Add("{LastName}", emp.Lastname);

                    string body = "Happy BirthDay  " + emp.Name + " " + emp.Lastname;

                     msg.Add(md.CreateMailMessage("Amit.Chourasia@fisglobal.com", replacements, body, new System.Web.UI.Control()));

                    //return msg;
                }


                return msg;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proxy.Close();
            }
        }

        
    }
}