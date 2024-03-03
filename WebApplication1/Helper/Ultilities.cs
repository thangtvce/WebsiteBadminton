using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public static class Ultilities
    {
        public static string SEOUrl(string url)
        {
            var result = url.ToLower().Trim();
            result = Regex.Replace(result, "áàạảãâấầậẩẫăắằặẳẵ", "a");
            result = Regex.Replace(result, "éèẹẻẽêếềệễể", "e");
            result = Regex.Replace(result, "óòọỏõôốồộổỗơớợởỡờ ", "o");
            result = Regex.Replace(result, "úùụủũưứừựửữ", "u");
            result = Regex.Replace(result, "íìỉĩị", "i");
            result = Regex.Replace(result, "ýỳỵỷỹ", "y");
            result = Regex.Replace(result, "đ", "d");
            result = Regex.Replace(result, "[^a-z0-9-]", "");
            result = Regex.Replace(result, "(-)+", "-");

            return result;
        }
        public static void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
            {
                
            }
        }
        public static string ToTitleCase(string str)
        {
            string result = str;
            if(!string.IsNullOrEmpty(str)) {
                var words = str.Split(' ');
                for(int index =0; index < words.Length; index++)
                {
                    var s = words[index];
                    if (s.Length > 0) 
                    {
                        words[index] = s[0].ToString().ToUpper() + s.Substring(1);
                    }
                }
                result = string.Join(" ", words);   

            }
            return result;
        }
        public static string GetRandomKey(int length=5)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(validChars.Length);
                sb.Append(validChars[index]);
            }

            return sb.ToString();
        }
        public static bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false;

            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }catch
            {
                return false;
            }
        }
        public static async Task<string> UploadFile(Microsoft.AspNetCore.Http.IFormFile file , string sDirectory , string newname = null) 
            { 
                try 
                {
                    if (newname == null) newname = file.FileName;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sDirectory);
                    CreateIfMissing(path);
                    string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sDirectory , newname);
                    var supportedTypes = new[] { "jpg", "jpeg", "png", "gif" };
                    var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
                    if (!supportedTypes.Contains(fileExt.ToLower()))
                    {
                        return null;
                    }
                    else
                    {
                        using (var stream = new FileStream(pathFile, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        return newname;
                    }
                }
                catch (Exception ex) {
                    return null;
                }
            }
    }
  

}
