using System;
namespace  interface_tuto
{
  public class SmsLogger: ILogger{
    public void WriteLog()
    {
      // throw 
      Console.WriteLine("Sms Logger");
    }
  }
}