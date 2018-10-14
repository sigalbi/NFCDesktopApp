using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace AppLogic
{
    class Requests
    {
        private string targetURL = "https://smartchip.herokuapp.com/";

        public string SendGetReq(string UserToken, string URL_Req)
        {
            var request = (HttpWebRequest)WebRequest.Create(targetURL + URL_Req);// amits given address
            string responseString = null;
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Headers.Add("x-auth-token", UserToken);
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch(WebException e)
            {
                WebResponse response_ = e.Response;
                HttpWebResponse httpResponse = (HttpWebResponse)response_;
                Stream Data = response_.GetResponseStream();
                var reader = new StreamReader(Data);
                responseString = reader.ReadToEnd();
                throw new Exception(responseString);
            }
            return responseString;
        }
        public string SendDeleteReq(string JsonString, string URL_Req ,string UserToken)
        {
            var request = (HttpWebRequest)WebRequest.Create(targetURL + URL_Req);// amits given address
            string responseString = null;
            var data = Encoding.ASCII.GetBytes(JsonString);

            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Headers.Add("x-auth-token", UserToken);

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch(WebException e)
            {
                WebResponse response_ = e.Response;
                HttpWebResponse httpResponse = (HttpWebResponse)response_;
                Stream Data = response_.GetResponseStream();
                var reader = new StreamReader(Data);
                responseString = reader.ReadToEnd();
                throw new Exception(responseString);
            }
            return responseString;
        }
        public string SendPostReq(string JsonString, string URL_Req, bool IsNewUser,bool AddToken = false ,string token = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(targetURL + URL_Req);// amits given address
            var data = Encoding.ASCII.GetBytes(JsonString);
            HttpWebResponse response;
            string responseString=null;

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            if (AddToken)
                request.Headers.Add("x-auth-token", token);

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                response =(HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                if (IsNewUser)
                   responseString = response.Headers.Get("x-auth-token");
            }
            catch (WebException e)
            {
                 WebResponse response_ = e.Response;
                 HttpWebResponse httpResponse = (HttpWebResponse)response_;
                 Stream Data = response_.GetResponseStream();
                 var reader = new StreamReader(Data);
                 responseString = reader.ReadToEnd();
                throw new Exception(responseString);
            }
            return responseString;
        }
        public string SendPutReq(string JsonString,string UserToken, string URL_Req)
        {
            var request = (HttpWebRequest)WebRequest.Create(targetURL + URL_Req);// amits given address
            var data = Encoding.ASCII.GetBytes(JsonString);
            string responseString = null;

            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Headers.Add("x-auth-token", UserToken);

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (WebException e)
            {
                WebResponse response_ = e.Response;
                HttpWebResponse httpResponse = (HttpWebResponse)response_;
                Stream Data = response_.GetResponseStream();
                var reader = new StreamReader(Data);
                responseString = reader.ReadToEnd();
                throw new Exception(responseString);
            }
            return responseString;
        }
    }
}
