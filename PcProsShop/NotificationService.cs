using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;



namespace PcProsShop
{
    internal static class NotificationService
    {
        /*
         * Mail address from mail account used to send Mails
         */
        private static string mailAccount = "PC_Pros@gmx.de";
        
        /*
        * Password from mail account used to send Mails
        */
        private static string password = "22FFHh8qSheVJvk";
        /*
         *  smtp domain mail service provider
         */
        private static string mailServer = "mail.gmx.net";
        /*
         * smtp Port mail service provider
         */
        private static int serverPort = 587;

        /*
         * Formats double to format x..x,xx.
         * Used in sendOrderInvoice(Order newOrder, Account user).
         * Input price: Double value to be formated into the price formate.
         * Return value: String containing formated price value.
         */
        public static string formatPrice(double price)
        {
            String priceText = price.ToString();
            int index = price.ToString().IndexOf(",");
           // Console.WriteLine(index);
            if(index == -1)
            {
                priceText += ",00";
            }
            else if(priceText.Length -1 -index == 1)
            {
                priceText += "0";
            }
            return priceText;
        }

        /*
         * Creates MailMessage object and sends it via smtp protocol.
         * Input destMail: String containing valid mail address of receiver.
         * Input subject: String containing the subject text for the MailMessage.
         * Input text: String containing the message of the Email. Message must be HTML formated.
         */
        private static void sendMail(String destMail, String subject, String text)
        {
            Console.WriteLine("Preparing Mail");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(mailAccount);
            mail.To.Add(destMail);
            mail.Subject = subject;
            mail.Body = text;
            mail.IsBodyHtml = true;
            
            SmtpClient smtpClient = new SmtpClient(mailServer);
            smtpClient.Port = serverPort;
            smtpClient.Credentials = new NetworkCredential(mailAccount, password);
            smtpClient.EnableSsl = true;
            Console.WriteLine("Sending Mail");
            try
            {
                smtpClient.Send(mail);
                Console.WriteLine("Mail send\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Mail Exception :" + e.Message);
            }
        }

        /*
         * Creates Account created message and sends it via sendMail() methode.
         * Input userAccount: Account Object containing the destination mail address.
         */
        public static void sendAccoundCreated(Account userAccount)
        {
            Console.WriteLine("Sending Account Creation Notification\n");
            String subject = "Welcome To PC Pros " + userAccount.Name;
            String text = "<!DOCTYPE html><html><body style = background-color:#81b6ff><h2>"
                + "Welcome to PC Pros " + userAccount.Name 
                + "</h2><p> You're account was succesfully created." 
                + "<br>Check our store for best price deals" 
                + "</p></ body ></ html > ";
            //Console.WriteLine(subject + "\n" + text);
            
            sendMail(userAccount.Mail, subject, text);
        }

        /*
         * Creates Order Invoice Message and sends it via sendMail() methode.
         * Input newOrder: Order Object from which the Message is creeated. Must contain at least one orderItem.
         * Input userAccount: Account object containing the destination mail address
         */
        public static void sendOrderInvoice(Order newOrder, Account userAccount)
        {
            Console.WriteLine("Sending Order Invoice Notification\n");
            String subject = "PC Pros: Order Confirmation";
            String text = "<!DOCTYPE html><html><body style = background-color:#81b6ff>"
                + "<br><br><h2>PC Pros: Order Confirmation</h2>"
                + "<p>Dear " + userAccount.Name + ", <br>"
                + " we are happy to inform you that your order was approved by the system.<br>"
                + "<br> The details of your order are:</p>"
                + "<table border = 1  cellpadding= 0 cellspacing= 0 width = 500 > "
                + "<tr><th><b>Article</b></th><th><b>Quantity</b></th><th><b>Price per item</b></th><th><b>Total price</b></th></tr>";
            
            for(int i = 0; i < newOrder.OrderItem.Length; i++)
            {
                double singlePrice = newOrder.OrderItem[i].Cartitem.Price;
                double totalPrice = newOrder.OrderItem[i].Cartitem.Price * newOrder.OrderItem[i].Amount;
                
                

                text += "<tr> <td>" + newOrder.OrderItem[i].Cartitem.Name 
                    + "</td> <td align=center>" + newOrder.OrderItem[i].Amount
                    + "</td> <td align=right>" + formatPrice(singlePrice) + " €"
                    + "</td> <td align=right>" + formatPrice(totalPrice) + " €</td> </tr>";
            }
            text += "</table><p><b>Total price: " + newOrder.calcTotalPrice() + " €<br></b></p>"
                + "<p><br>Your ordered items will arrive shortly.<br><br></p>"
                + "<p>Thank you for buying at PC Pros</p>"
                + "<p>We'll be happy to hear from you again</p>"
                + "<p>Your PC Pros Team<br><br><br></p> </body></html>";

            //Console.WriteLine(text);
            sendMail(userAccount.Mail, subject, text);
        }

    }
}
