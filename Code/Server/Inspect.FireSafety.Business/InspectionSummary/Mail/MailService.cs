using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Inspect.FireSafety.Shared;
using Inspect.Mobile.Framework.Xamarin.Security;

namespace Inspect.FireSafety.Business.InspectionSummary.Mail
{
    public class MailService
    {

        private IMailConfiguration mConfiguration;
        


        public IMailConfiguration Configuration
        {
            get
            {
                return mConfiguration ?? (mConfiguration = new MailConfiguration());
            }
            set
            {
                mConfiguration = value;
            }
        }

        public List<EquipmentReportItem> ReportItems { get; set; }
        public string PLG_Mail;




        private void SendMailMessageToHost(string host, MailMessage mailMessage)
        {
            try
            {
                using (SmtpClient client = new SmtpClient(host))
                {
                    client.UseDefaultCredentials = true;
                    if (mailMessage.To.Count > 0 || mailMessage.CC.Count > 0 || mailMessage.Bcc.Count > 0)
                    {
                        client.Send(mailMessage);
                        //sLogger.Event(LogEvents.MailSent(mailMessage.Subject, mailMessage.To.ToString(), host));
                    }
                }
            }
            catch (Exception ex)
            {
                //sLogger.Event(LogEvents.ExceptionOccured(ex));
            }
        }

        internal void SendMails(Shared.InspectionSummary entity)
        {
            string operatorName = "<tr> <td style=\"border:1px dotted black\"> Operator </td> <td style=\"border: 1px dotted black\">" + ((entity.Operator != null) ? entity.Operator.FullName : "  /  ") + "</td > </ tr >";
            string backupOperator = "<tr> <td style=\"border:1px dotted black\"> Backup operator </td> <td style=\"border: 1px dotted black\">" + ((entity.BackupOperator != null) ? entity.BackupOperator.FullName : "  /  ") + "</td > </ tr >";
            string department = (entity.OrganisationUnit != null) ? "<tr> <td style=\"border:1px dotted black\"> Afdeling </td> <td style=\"border: 1px dotted black\">" + entity.OrganisationUnit.Name + "</td> </tr>" : "";
            string zone = (entity.Location != null) ? "<tr> <td style=\"border:1px dotted black\"> Zone </td> <td style=\"border: 1px dotted black\">" + entity.Location.Name + "</td> </tr>" : "";
            string startTime = (entity.DateStarted != null) ? "<tr> <td style=\"border:1px dotted black\"> Start tijd </td> <td style=\"border: 1px dotted black\">" + entity.DateStarted.ToString() + "</td> </tr>" : "";
            string stopTime = (entity.DateFinished != null) ? "<tr> <td style=\"border:1px dotted black\"> Stop tijd </td> <td style=\"border: 1px dotted black\">" + entity.DateFinished.ToString() + "</td> </tr>" : "";
            string totalTime = (entity.DateStarted != null && entity.DateFinished != null) ? "<tr> <td style=\"border:1px dotted black\"> Totale tijd</td> <td style=\"border: 1px dotted black\">" + new DateTime().Add(entity.DateFinished - entity.DateStarted).ToString("HH:mm") + "</td> </tr>" : "";
            string totalInspected = "<tr> <td style=\"border:1px dotted black\"> Totaal geïnspecteerd  </td> <td style=\"border: 1px dotted black\">" + entity.TotalInspected + "/" + entity.TotalToInspect + "</td> </tr>";
            string totalApproved = "<tr> <td style=\"border:1px dotted black\"> Totaal ok  </td> <td style=\"border: 1px dotted black\">" + entity.TotalApproved + "</td> </tr>";
            string totalDisApproved = "<tr> <td style=\"border:1px dotted black\"> Totaal niet ok </td> <td style=\"border: 1px dotted black\">" + entity.TotalDisApproved + "</td> </tr>";
            string status = "<tr> <td style=\"border:1px dotted black\"> Status </td> <td style=\"border: 1px dotted black\">" + ((entity.Completed) ? "complete" : "incomplete") + "</td> </tr>";
            string remark = "<tr> <td style=\"border:1px dotted black\"> Opmerking </td> <td style=\"border: 1px dotted black\">" + ((entity.Remarks != "") ? entity.Remarks : "  /  ") + "</td> </tr>";

            string notOkReport = "<p>Verslag van de niet ok toestellen.</p><table width=\"1000\"> <tr> <th>Toestel</th> <th>QR-code</th> <th>Locatie omschrijving</th>  <th>Feedback</th> <th>Opmerking</th> <th>Vera</th> </tr>";
            foreach (EquipmentReportItem reportItem in ReportItems)
            {
                notOkReport += "<tr> <td style = \"border:1px dotted black\">" + reportItem.Equipment + "</td> <td style =\"border: 1px dotted black\">" + reportItem.QRCode + "</td> <td style=\"border:1px dotted black\">" + reportItem.LocationDescription + "</td>  <td style=\"border: 1px dotted black\">" + reportItem.FeedBack + "</td><td style=\"border:1px dotted black\">" + ((reportItem.Remark == null) ? "/" : reportItem.Remark) + "</td> <td style=\"border:1px dotted black\">" + ((reportItem.Vera) ? "Ja" : "Neen") + "</td> </tr>";
            }
            string summeryTableItems = operatorName + backupOperator + department + zone + startTime + stopTime + totalTime + totalInspected + totalApproved + totalDisApproved + status + remark;
            string reportTableItems = operatorName + backupOperator + department + zone + totalInspected + totalApproved + totalDisApproved + status + remark;

            for (int i = 0; i < 2; i++)
            {
                MailMessage mailMessage = new MailMessage();
                string tableItems = "";
                switch (i)
                {
                    case 0:
                        {
                            tableItems = summeryTableItems;
                            mailMessage = new MailMessage(Configuration.From, (Configuration.SummeryTo.Contains(";") ? Configuration.SummeryTo.Replace(';', ',') : Configuration.SummeryTo));
                            mailMessage.Subject = "BBW - inspectieronde beëindigd (" + entity.OrganisationUnit.Code + " - zone " + entity.Location.Name + ") - POSTOVERSTE";
                        }
                        break;
                    case 1:
                        {
                            tableItems = reportTableItems;
                            mailMessage = new MailMessage(Configuration.From, (PLG_Mail.Contains(";") ? PLG_Mail.Replace(';', ',') : PLG_Mail));
                            mailMessage.Subject = "BBW - inspectieronde verslag (" + entity.OrganisationUnit.Code + " - zone " + entity.Location.Name + ")";
                        }
                        break;
                }

                mailMessage.Body = "<!DOCTYPE html> <html> <head> <style type=\"text / css\"> body{ text-align: left; width: 98%; font-size: 10pt; color: #696969; font-family: Arial; } .small-width { width: 400px;} .bold { font-weight: bold; }	h2 {color: #333333; font-size: 12pt; font-weight: bold; } h3 { color: #333333; font-size: 11pt; font-weight: bold; } .titlePerson{ padding: 0 0 15px 0;} .footer{ border-top: 2px solid #F87720; margin: 15px 0 0 0; width: 98%; font-size: 9pt; } a { color: #F87720; outline: medium none; text-decoration: underline; } a:active { color: #F87720; outline: medium none; text-decoration: underline;} a:hover {text-decoration: none;} a:visited {color: #F87720; outline: medium none; text-decoration: underline;}  .padding-bottom{padding: 0 0 15px 0; } table, td, tr { text-align:left; vertical-align:top;} </style> </head> <body> <table> <tr> <td colspan=\"2\" class=\"padding-bottom\"> Beste, </td> </tr>  <tr> <td colspan=\"2\" class=\"padding-bottom\">  <p>Er is een inspectieronde van BBW beëindigd:</p>  <table width=\"600\">" + tableItems + "</table> </td> </tr> </table>" + notOkReport + "</table> <br> <table class=\"footer\" > <tr> <td> <p>Opm: dit is een automatische mail vanuit de BBW Inspect App. <br> Op deze mail kan geen reply gegeven worden.</p> </td> </tr> </table> </body> </html>";
                mailMessage.IsBodyHtml = true;
                if (Configuration.Cc != "")
                {
                    mailMessage.CC.Add((Configuration.Cc.Contains(";") ? Configuration.Cc.Replace(';', ',') : Configuration.Cc));
                }

                SendMailMessageToHost("mail.sidmar.be", mailMessage);
            }

        }
    }
}
