using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Uppgift2._1
{
    public class ControllerUppgift2
    {
        WebServiceUppgift2__1 ws = new WebServiceUppgift2__1();

        public string GetFile()
        {
            return ws.GetFile();
        }
    }
}