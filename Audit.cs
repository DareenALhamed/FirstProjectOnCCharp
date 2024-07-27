using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Audit
    {

        private readonly string auditFilePath = "audit_log.txt"; // Path to the audit log file

        public Audit(string auditFilePath)
        {
            this.auditFilePath = auditFilePath;
        }
        

        public void  WriteToFile(Audit content)
        {
           
                using (StreamWriter writer = new StreamWriter(auditFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}:content");
                }
            
        }

        //public static void ReadFromFile()
        //{
            
              //  using (StreamReader reader = new StreamReader(auditFilePath))
               // {
               //     string line;
                 //   while ((line = reader.ReadLine()) != null)
                  //  {
                  //      Console.WriteLine(line);
                    //}
              //  }
          
       // }

    }
}
