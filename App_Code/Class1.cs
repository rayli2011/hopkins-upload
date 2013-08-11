using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;



/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{

       public enum area
        {
          NWS=1,
          DB=2,
          HCI=3,
          NWS_DB=4,
          DB_HCI=5,
          NWS_HCI=6,
          DB_NWS_HCI=7
	     }
       public enum categry
       { 
           Faculty=1,
           Student=2,
           TA=3,
           Admin=0
       }
       
 public void writelog(String s) 
 {
     string path = HttpContext.Current.Server.MapPath("history_log") + "\\history.txt";

   if (!File.Exists(path))
   {
       // Create a file to write to. 
       using (StreamWriter sw = File.CreateText(path))
       {
       }
   }

   // This text is always added, making the file longer over time 
   // if it is not deleted. 
   using (StreamWriter sw = File.AppendText(path))
   {
       sw.WriteLine(s);

   }	


   
 } 

}