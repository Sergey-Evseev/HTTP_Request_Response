using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTP_Request_Response
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            URL.KeyPress += new KeyPressEventHandler(URL_KeyPress);
        }

        private async void URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //e.Handled = true; // To prevent beep sound on Enter key press
                await SendRequest();
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            await SendRequest();
        }

        private async Task SendRequest()
        {
            // creates a new HttpWebRequest object and initializes it with the URL
            // specified in the URL TextBox control
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(URL.Text);

            // sets the Method property of the HttpWebRequest object to "GET"
            // request will use the HTTP GET method to retrieve the resource
            req.Method = "GET";

            if (ifProxy.Checked)
            {
                // initializes a new WebProxy object
                WebProxy proxy = new WebProxy(proxyAddr.Text);

                // credentials are passed as a NetworkCredential object
                proxy.Credentials = new NetworkCredential(proxyUser.Text,
                    proxyPassword.Text);
                // setting proxy property of a web request object (req) to the WebProxy object (proxy)
                req.Proxy = proxy;
            }

            try
            {
                // calling GetResponseAsync() method on the HttpWebRequest object (req) 
                // method GetResponseAsync() returns a Task<WebResponse> object
                // that represents the asynchronous operation of getting the response from the server
                HttpWebResponse rez = (HttpWebResponse)await req.GetResponseAsync();

                // creating a StreamReader object (sr) and initializes it
                // with the response stream from the HttpWebResponse object
                StreamReader sr = new StreamReader(rez.GetResponseStream(),
                    Encoding.Default);
                // reads the entire response from the server as a string using the ReadToEnd()
                // method on the StreamReader object (sr) and sets the resulting string
                // as the text of a control named 'response'
                response.Text = await sr.ReadToEndAsync();
            }
            catch (WebException ex)
            {
                // display a warning message box with the error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }

        }

    }
    
}
