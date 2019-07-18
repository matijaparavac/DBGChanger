using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGChanger
{
    public class StaviGa
    {

        public static async Task BackgroundChanger() {
            bool beskonacno = true;
            while (beskonacno)
            {
                
                DajMiGa HD = new DajMiGa();
                string slikaHD=HD.GetRadnomPicture();
                int imgLookPosition = HD.GetRadnomStylePosition();
                try
                {
                                      
                    HD.SetBackground(slikaHD, imgLookPosition);
                    
                }
                catch (Exception e)
                {
                  //  File.AppendAllText(@"C:\Temp\sss.txt", e.Message);
                }                              

                Task.Delay(5000);
            }
        
        }

    }
}
