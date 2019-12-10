using BookiDesktop.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookiDesktop.Helpers {
    public class CheckServiceConnection {


        public static bool ServiceExists() {
            BaseController bCtrl = new BaseController();
            string url = bCtrl.BaseUrl;
            bool res = false;
            try {
                HttpWebRequest request =
                    WebRequest.Create(url) as HttpWebRequest;
                request.Timeout = 30000;
                Debug.WriteLine("Trying to connect");
                using (HttpWebResponse response =
                           request.GetResponse() as HttpWebResponse) {
                    if (response.StatusCode != HttpStatusCode.OK) {
                        res = false;
                        Debug.WriteLine("Status code: " + response.StatusCode);
                    }
                }

            }
            catch {
                Exception e;
                res = false;
            }

            return res;   
        }
    }
}

