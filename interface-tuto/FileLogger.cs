using System;

namespace interface_tuto
{
  public class FileLogger : ILogger {

    public void WriteLog(){
      Console.WriteLine("File Logger");
    }
  }
    
}