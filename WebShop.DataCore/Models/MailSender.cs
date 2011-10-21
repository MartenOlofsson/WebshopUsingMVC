using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace WebShop.DataCore.Models
{
    public class MailSender
    {

    public void SendMail(){
    
                MailMessage message = new MailMessage();
                message.From = new MailAddress("mailtest@valtech.se");
               
                message.To.Add(new MailAddress("martenolofsson@gmail.com"));
                message.Body = "Test";
                SmtpClient mailclient = new SmtpClient();
                mailclient.Send(message);

    
    }
    
    
    }
}
