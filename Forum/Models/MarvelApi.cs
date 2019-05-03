using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class MarvelApi
    {
        private const string BaseUrl = @"https://gateway.marvel.com:443/v1/public";
        private readonly string PublicApi = @"540dd840ad4822fcb2dc40530f114f69";
        private readonly string PrivateApi = @"6aa7b41cd9204d4f7b5369df2604bac7aa552d48";
        private static HttpClient client = new HttpClient();

        public async Task<CharacterDataWrapper> GetCharacters(string name = null,
                                                              string stratsWith = null,
                                                              DateTime? modifiedSince = null,
                                                              IEnumerable<int> comics = null,
                                                              IEnumerable<int> series = null,
                                                              IEnumerable<int> events = null,
                                                              IEnumerable<int> stories = null,
                                                              string order = null,
                                                              int? limit = null,
                                                              int? offset = null)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/characters?ts={0}&apikey={1}&hash={2}&name={3}", timestamp, PublicApi, hash, name);

            var url = new Uri(requestUrl);
            var response = await client.GetAsync(url);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            /*
            CharacterDataWrapper cdw = JsonConvert.DeserializeObject<CharacterDataWrapper>(json);
            return cdw;
            */

        }


        private string CreateHash(string input)
        {
            var hash = String.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                hash = sBuilder.ToString();
            }
            return hash;

        }

    }
}
