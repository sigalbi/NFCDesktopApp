using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.CSharp;

namespace AppLogic
{
    public class AppLogicAPI
    {
        Requests ReqActivator = new Requests();

        public string LoginCheck(string Email, string Password)
        {
            JObject loginJson = new JObject();

            loginJson.Add("email", Email);
            loginJson.Add("password", Password);


            String jsonString = JsonConvert.SerializeObject(loginJson);
            
            string response = ReqActivator.SendPostReq(jsonString, "api/auth", false);

            return response;
      
        }
        public void SendForgotPassword(string Email)
        {
            JObject loginJson = new JObject();

            loginJson.Add("email", Email);
            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendPostReq(jsonString, "api/emails/password", false);
        }
        public void SendContectUsMessege(string Subject, string Body, string userToken)
        {
            JObject loginJson = new JObject();

            loginJson.Add("subject", Subject);
            loginJson.Add("text", Body);
          
            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendPostReq(jsonString, "api/emails/contact", false,true,userToken);
        }
        public string RegisterCheck(string UserName, string Email, string PhoneNum, string Password)//this action throws an exeption in the response field in sendpostreq func
        {                                                                                       // the exeption says : 400 bad request
            JObject loginJson = new JObject();

            loginJson.Add("name", UserName);
            loginJson.Add("email", Email);
            loginJson.Add("phone", PhoneNum);
            loginJson.Add("password", Password);

            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendPostReq(jsonString, "api/users", true);

            return response;
        }
        public void ChangePasswredInDataB(string OldPassword,string NewPassword, string userToken)
        {
            JObject loginJson = new JObject();

            loginJson.Add("oldPassword", OldPassword);
            loginJson.Add("newPassword", NewPassword);

            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendPutReq(jsonString, userToken, "api/auth/me/");

        }
        public void EditUserInDataB(string NewName,string NewEmail,string NewPhone,string userToken)
        {
            JObject loginJson = new JObject();

            loginJson.Add("name", NewName);
            loginJson.Add("email", NewEmail);
            loginJson.Add("phone", NewPhone);

            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendPutReq(jsonString, userToken, "api/users/me/");

        }
        public string EditChipInDataB(string name, string action, string id, string userToken,List<string> options,bool isGlobal)
        {
            JObject loginJson = new JObject();

            loginJson.Add("name", name);
            loginJson.Add("action", action);       
            loginJson.Add("options", JsonConvert.SerializeObject(options));
            loginJson.Add("isGlobal", isGlobal);

            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendPutReq(jsonString,userToken,"api/chips/"+id);

            return response;
        }
        public List<Chip> GetUserChips(string userToken)
        {
            string JsonString;
            List<Chip> chips;

            JsonString = ReqActivator.SendGetReq(userToken, "api/chips");
            chips = JsonConvert.DeserializeObject<List<Chip>>(JsonString);

            return chips;
        }
        public bool IsValidPhone(string PhoneNum)
        {
            int num;

            return int.TryParse(PhoneNum, out num);
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public Chip GetChip(string id, string userToken)
        {
            List<Chip> chips = GetUserChips(userToken);

            foreach (Chip c in chips)
            {
                if (c._id.Equals(id))
                    return c;
            }
            return null;
        }
        public User GetUserInfoByToken(string userToken)
        {
            User user = new User();
            string JsonString = null;

            JsonString = ReqActivator.SendGetReq(userToken, "api/users/me");
            user = JsonConvert.DeserializeObject<User>(JsonString);
            user.token = userToken;

            return user;
        }
        public void DeleteChipInDataB(Chip c , string userToken)
        {
            JObject loginJson = new JObject();

            loginJson.Add("createdAt", c.createdAt);
            loginJson.Add("updatedAt", c.updatedAt);
            loginJson.Add("_id", c._id);
            loginJson.Add("name", c.name);
            loginJson.Add("admin", userToken);
            loginJson.Add("action", c.action);

            String jsonString = JsonConvert.SerializeObject(loginJson);
            string response = ReqActivator.SendDeleteReq(jsonString, "api/chips/"+ c._id, userToken);

        }
    }
}
