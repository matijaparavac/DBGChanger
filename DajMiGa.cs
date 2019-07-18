using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.IO.Compression;
using System.Configuration;
using aejw.Network;


namespace DBGChanger
{
    public class DajMiGa
    {
        //Fetch images with random pick
        public String GetRadnomPicture() {


            string networkStorage = ConfigurationManager.AppSettings["pathToImages"];
            //MapNetworkDrive(veneraDir, "testUser", "test", "m", "hd");
            string[] images = System.IO.Directory.GetFiles(networkStorage, "*.*")
                .Where(file => 
                file.ToLower().EndsWith("jpg") || file.ToLower()
                              .EndsWith("jpeg") || file.ToLower()
                              .EndsWith("png")).ToArray();            
            int num_of_images = images.Length;
            Random rnd_img = new Random();
            int random_img = rnd_img.Next(0, num_of_images);
            return images[random_img];
        }

        //Setting background
        public void SetBackground(string file, int position) {
            Wallpaper.Set(file, (Wallpaper.Style)position);        
        }

        //Radnomize position of images
        public int GetRadnomStylePosition() { 
            Random rnd_position = new Random();
            int position = rnd_position.Next(5);
            return position;
        }

        public string GetAppPath(){
            string path = "";
            path = Application.StartupPath;
            return path;           
        }
        public bool MapNetworkDrive(string networkPath, string username, string password, string letter, string app)
        {

            //----drugi način mapiranja diska-----------------3. parametar je persistnat connection opcija
            //IWshNetwork_Class network = new IWshNetwork_Class();
            //network.MapNetworkDrive("k:", @"\\server\share", true, username, password);
            //network.RemoveNetworkDrive(networkPath);
            
            NetworkDrive mapit = new aejw.Network.NetworkDrive();
            try
            {

                mapit.LocalDrive = letter;
                mapit.ShareName = networkPath;
                mapit.MapDrive(username, password);
                return true;
            }
            catch (Exception err)
            {
                //File.AppendAllText(@"C:\Temp\sss.txt", err.Message + "!!!");
                return false;
            }

        }

        public bool UnmapNetworkDrive(string networkPath, string letter, string app)
        {

            NetworkDrive unmapit = new aejw.Network.NetworkDrive();
            try
            {
                unmapit.LocalDrive = letter;
                unmapit.Force = true;
                unmapit.ShareName = networkPath;
                unmapit.UnMapDrive();
                return true;
            }
            catch (Exception exc)
            {
                //File.AppendAllText(@"C:\Temp\sss.txt", exc.Message + "!!");
                return false;
            }
        }
    }
}
