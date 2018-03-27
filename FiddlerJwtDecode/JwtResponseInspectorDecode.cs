using Fiddler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FiddlerJwtDecode
{
    public class JwtResponseInspectorDecode : Inspector2, IResponseInspector2
    {        
        private byte[] _body;
        JwtTabContent _displayControl;
        HTTPResponseHeaders _headers;

        public HTTPResponseHeaders headers
        {
            get
            {
                return _headers;
            }
            set
            {

                _headers = value;

                List<KeyValuePair<string, string>> httpHeaders = new List<KeyValuePair<string, string>>();
                
                foreach (var item in headers)
                {
                    httpHeaders.Add(new KeyValuePair<string,string>(item.Name, item.Value));
                }
                _displayControl.HTTPHeaders = httpHeaders;
            }
        }

        public byte[] body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
               _displayControl.HTTPBody = body;
            }
        }

        public bool bDirty { get { return false; } }

        public bool bReadOnly { get; set; }

        public override void AddToTab(TabPage o)
        {
            _displayControl = new JwtTabContent();
            o.Text = "JWT Decode";
            o.Controls.Add(_displayControl);
            o.Controls[0].Dock = DockStyle.Fill;          
        }
    
        public void Clear()
        {
            _displayControl.Clear();
        }

        public override int GetOrder()
        {
            return 0;
        }
    }
}
