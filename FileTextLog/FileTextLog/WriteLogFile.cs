using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileTextLog
{
    public class WriteLogFile
    {

        public bool WriteLog(string strFileName, string strMessage)
        {
            bool rval = false;
            try
            {
                using (StreamWriter w = File.AppendText(strFileName))
                {
                    w.WriteLine(strMessage);
                }
                rval = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening file to append...");
            }
            return rval;
        }

        public bool PrintLogToConsole(string strFileName)
        {
            bool rval = false;
            try
            {
                using (StreamReader r = File.OpenText(strFileName))
                {
                    Console.WriteLine("Content of logfile '" + strFileName + "':");
                    string logentry;
                    while ((logentry = r.ReadLine()) != null)
                    {
                        Console.WriteLine(logentry);
                    }
                }
                rval = true;
            }
            catch (Exception ex)
            {
                // ...
            }
            return rval;
        }


    }
}
