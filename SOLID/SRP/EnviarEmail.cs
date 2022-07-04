namespace MXTargetBank.SOLID.SRP
{
  public class EnviarEmail
  {
    public EnviarEmail()
    { }
    public EnviarEmail(string? emailFrom, string? emailTo, string? emailSubject, string? emailBody)
    {
      EmailFrom = emailFrom;
      EmailTo = emailTo;
      EmailSubject = emailSubject;
      EmailBody = emailBody;
    }

    public string? EmailFrom { get; set; }
    public string? EmailTo { get; set; }
    public string? EmailSubject { get; set; }
    public string? EmailBody { get; set; }

    public static void Enviar(string from, string to, string subject, string body)
    {
        Console.WriteLine($"E-mail de {from} para {to}. {body} - Autor do E-mail: {subject}");
    }
  }
}