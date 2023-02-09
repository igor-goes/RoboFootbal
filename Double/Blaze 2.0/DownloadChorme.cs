using System.IO;

namespace Blaze_2._0 {
    static class DownloadChorme {        
        public static void DonwloadChorme() {


            if (!Directory.Exists(Path.Combine(Path.GetTempPath() + @"\V4"))) {
                Directory.CreateDirectory(Path.Combine(Path.GetTempPath() + @"\V4"));

            }
            if (!File.Exists(Path.Combine(Path.GetTempPath()+ @"\V4", "chromedriver.exe"))) {
                 File.WriteAllBytes(Path.Combine(Path.GetTempPath() + @"\V4", "chromedriver.exe"), Properties.Resources.chromedriver);
            }     

        }
    }
}
