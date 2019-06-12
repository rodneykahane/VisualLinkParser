using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace VisualLinkParser
{
    class ExtractLinks
    {
        private String ProcessOption(String name, String value)
        {
            StringBuilder result = new StringBuilder();
            result.Append('\"');
            result.Append(name);
            result.Append("\",\"");
            result.Append(value);
            result.Append('\"');
            Console.WriteLine(result.ToString());
            String returnString = result.ToString();

            return returnString;
        }//end ProcessOption

        /// <summary>
        /// Process the specified URL.
        /// </summary>
        /// <param name="url">The URL to process.</param>
        /// <param name="optionList">Whcih option list
        /// to process.</param>
        public String Process(Uri url, int optionList)
        {
            String value = "";

            String finalReturn = "";

            //ignore bad cert code
            IgnoreBadCertificates();

            //code to allow program with work with different authentication schemes
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            WebRequest http = HttpWebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)http.GetResponse();
            Stream istream = response.GetResponseStream();
            ParseHTML parse = new ParseHTML(istream);
            StringBuilder buffer = new StringBuilder();
            int ch;
            while ((ch = parse.Read()) != -1)
            {
                if (ch == 0)
                {
                    HTMLTag tag = parse.Tag;
                    if (String.Compare(tag.Name, "a", true) == 0)
                    {
                        value = tag["href"];
                        Uri u = new Uri(url, value.ToString());
                        value = u.ToString();
                        buffer.Length = 0;
                        //return "";
                    }
                    else if (String.Compare(tag.Name, "/a", true) == 0)
                    {
                        
                        finalReturn = finalReturn +"\r\n" + ProcessOption(buffer.ToString(), value);
                        //Console.WriteLine("The value of finalReturn is:"+finalReturn);
                        //ProcessOption(buffer.ToString(), value);
                       


                    }
                    
                }
                else
                {
                    buffer.Append((char)ch);
                   // return "";
                }
            }
            return finalReturn;
        }


        //************   Formerly the Main() function ***************//
        static void ThisIsNotMain(string[] args)
        {
            //Uri u = new Uri("http://stealthgerbil.com/files/pdf");
            //Uri u = new Uri("http://10.0.0.17/link.php");
            Uri u = new Uri("http://10.0.0.17/stuff");
            ExtractLinks parse = new ExtractLinks();
            parse.Process(u, 1);
        }//end main

        //more bad cert code below

        /// <summary>
        /// Together with the AcceptAllCertifications method right
        /// below this causes to bypass errors caused by SLL-Errors.
        /// </summary>
        public static void IgnoreBadCertificates()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
        }

        /// <summary>
        /// In Short: the Method solves the Problem of broken Certificates.
        /// Sometime when requesting Data and the sending Webserverconnection
        /// is based on a SSL Connection, an Error is caused by Servers whoes
        /// Certificate(s) have Errors. Like when the Cert is out of date
        /// and much more... So at this point when calling the method,
        /// this behaviour is prevented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certification"></param>
        /// <param name="chain"></param>
        /// <param name="sslPolicyErrors"></param>
        /// <returns>true</returns>
        private static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }


    }
}//end namespace
