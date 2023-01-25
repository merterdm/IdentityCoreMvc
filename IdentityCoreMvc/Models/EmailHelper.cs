using System.Net.Mail;

namespace IdentityCoreMvc.Models
{
    public class EmailHelper
    {
        public async Task<bool> SendEmail(string email, string message)
        {



            #region Mail Mesaj Ayarlari

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("uskudarweb@yandex.com");
            mailMessage.To.Add(email);
            mailMessage.Subject = "REGİSTER İSLEMİNİ ONAYLAYİN";
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            #endregion


            #region SMTP Ayarlari

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.yandex.com";
            smtpClient.Port = 465;

            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new System.Net.NetworkCredential("uskudarweb@yandex.com", "1q2w3E*");
            #endregion


            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {

                return false;
            }



            return true;
        }
    }
}
