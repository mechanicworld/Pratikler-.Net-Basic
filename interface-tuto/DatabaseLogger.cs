using System;

namespace interface_tuto
{
    public class DatabaseLogger:ILogger {
      public void WriteLog(){
        Console.WriteLine("Database Logger");
      }
    }
}