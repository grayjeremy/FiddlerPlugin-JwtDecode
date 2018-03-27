using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

[assembly: Fiddler.RequiredVersion("4.4.4.8")]

namespace FiddlerJwtDecode
{
    public class FiddlerJwt : IAutoTamper
    {
        public void AutoTamperRequestAfter(Session oSession)
        {
           
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
           
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
           
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
          
        }

        public void OnBeforeReturningError(Session oSession)
        {
          
        }

        public void OnBeforeUnload()
        {
           
        }

        public void OnLoad()
        {
          
        }
    }
}
