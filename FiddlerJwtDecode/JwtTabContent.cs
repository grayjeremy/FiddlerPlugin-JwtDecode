using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace FiddlerJwtDecode
{
    public partial class JwtTabContent : UserControl
    {

        public JwtTabContent()
        {
            InitializeComponent();
        }

        private string body;
        private byte[] _HTTPBody;
        /// <summary>
        /// A list of the headers, occasionally there are duplicate keys in an HTTP header, hence this is not a dictionary.
        /// </summary>
        private List<KeyValuePair<string, string>> _HTTPHeaders;        

        public byte[] HTTPBody
        {
            get
            {
                return _HTTPBody;
            }
            set
            {
                _HTTPBody = value;

                if (null != value)
                {
                    body = Encoding.Default.GetString(value);                                        
                    AddBodyToList(body);
                }

            }
        }

        private void AddBodyToList(string body)
        {
            List<dynamic> bindingList = new List<dynamic>();
            
            JObject obj = JObject.Parse(body);

            //loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                if (JsonWebToken.IsJsonWebToken(token.Value.ToString()))
                {
                    bindingList.Add(new { Key = token.Key, Value = token.Value.ToString() });
                  
                }
            }            

            listBox1.DataSource = bindingList;
            listBox1.DisplayMember = "Key";
            listBox1.ValueMember = "Value";        
        }

        public List<KeyValuePair<string, string>> HTTPHeaders { get { return _HTTPHeaders; } set { _HTTPHeaders = value; } }        
       

        public void Clear()
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var json = listBox1.SelectedValue.ToString();

            if(JsonWebToken.IsJsonWebToken(json))
            {
                var jwt = JsonWebToken.GetTokenFromString(json);
                textBox1.Text = jwt.ToString();
                textBox2.Text = json;
            }
               
        }              
    }
}
