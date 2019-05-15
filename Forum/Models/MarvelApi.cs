using Newtonsoft.Json;
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

        public async Task<CharacterDataWrapper> GetCharacters()
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/characters?orderBy=name&limit=3&ts={0}&apikey={1}&hash={2}", timestamp, PublicApi, hash);

            var url = new Uri(requestUrl);
            var response = await client.GetAsync(url);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            
            CharacterDataWrapper jsonData = JsonConvert.DeserializeObject<CharacterDataWrapper>(json);
            return jsonData;
         
        }

        public async Task<CharacterDataWrapper> GetCharacterById(int? id)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/characters/{0}?ts={1}&apikey={2}&hash={3}", id,timestamp, PublicApi, hash);
            var url = new Uri(requestUrl);
            var response = await client.GetAsync(url);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }


            CharacterDataWrapper jsonData = JsonConvert.DeserializeObject<CharacterDataWrapper>(json);
            return jsonData;
        }

        public async Task<CharacterDataWrapper> GetCharacterByName(string name)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/characters?nameStartsWith={0}&ts={1}&apikey={2}&hash={3}", name,timestamp, PublicApi, hash);

            var url = new Uri(requestUrl);
            var response = await client.GetAsync(url);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }


            CharacterDataWrapper jsonData = JsonConvert.DeserializeObject<CharacterDataWrapper>(json);
            return jsonData;
        }

        public async Task<ComicDataWrapper> GetComics()
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/comics?orderBy=title&limit=3&ts={0}&apikey={1}&hash={2}", timestamp, PublicApi, hash);

            var uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            ComicDataWrapper jsonData = JsonConvert.DeserializeObject<ComicDataWrapper>(json);

            return jsonData;
        }

        public async Task<ComicDataWrapper> GetComicId(int? id)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/comics/{0}?ts={1}&apikey={2}&hash={3}", id, timestamp, PublicApi, hash);

            var uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync(); 
            }

            ComicDataWrapper jsonData = JsonConvert.DeserializeObject<ComicDataWrapper>(json);

            return jsonData;
        }

        public async Task<ComicDataWrapper> GetComicByTitle(string title)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/comics?titleStartsWith={0}&ts={1}&apikey={2}&hash={3}", title, timestamp, PublicApi, hash);

            Uri uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            ComicDataWrapper jsonData = JsonConvert.DeserializeObject<ComicDataWrapper>(json);

            return jsonData;
        }

        public async Task<CreatorDataWrapper> GetCreators()
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/creators?orderBy=modified&limit=3&ts={0}&apikey={1}&hash={2}", timestamp, PublicApi, hash);

            var uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            CreatorDataWrapper jsonData = JsonConvert.DeserializeObject<CreatorDataWrapper>(json);

            return jsonData;
        }

        public async Task<CreatorDataWrapper> GetCreatorById(int? id)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            var requestUrl = String.Format(BaseUrl + "/creators/{0}?ts={1}&apikey={2}&hash={3}", id, timestamp, PublicApi, hash);

            Uri uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            CreatorDataWrapper jsonData = JsonConvert.DeserializeObject<CreatorDataWrapper>(json);

            return jsonData;
        }

        public async Task<CreatorDataWrapper> GetCreatorByName(string name)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            var requestUrl = String.Format(BaseUrl + "/creators?nameStartsWith={0}&ts={1}&apikey={2}&hash={3}", name, timestamp, PublicApi, hash);

            Uri uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            CreatorDataWrapper jsonData = JsonConvert.DeserializeObject<CreatorDataWrapper>(json);

            return jsonData;
        }

        public async Task<SeriesDataWrapper> GetSeries()
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            string requestUrl = String.Format(BaseUrl + "/series?orderBy=modified&limit=3&ts={0}&apikey={1}&hash={2}", timestamp, PublicApi, hash);

            Uri uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            SeriesDataWrapper jsonData = JsonConvert.DeserializeObject<SeriesDataWrapper>(json);

            return jsonData;
        }

        public async Task<SeriesDataWrapper> GetSerieById(int? id)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            var requestUrl = String.Format(BaseUrl + "/series/{0}?ts={1}&apikey={2}&hash={3}", id, timestamp, PublicApi, hash);

            Uri uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            SeriesDataWrapper jsonData = JsonConvert.DeserializeObject<SeriesDataWrapper>(json);

            return jsonData;
        }

        public async Task<SeriesDataWrapper> GetSerieByTitle(string title)
        {
            string timestamp = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds.ToString();
            string s = String.Format("{0}{1}{2}", timestamp, PrivateApi, PublicApi);
            string hash = CreateHash(s);

            var requestUrl = String.Format(BaseUrl + "/series?titleStartsWith={0}&ts={1}&apikey={2}&hash={3}", title, timestamp, PublicApi, hash);

            Uri uri = new Uri(requestUrl);
            var response = await client.GetAsync(uri);

            string json;
            using (var content = response.Content)
            {
                json = await content.ReadAsStringAsync();
            }

            SeriesDataWrapper jsonData = JsonConvert.DeserializeObject<SeriesDataWrapper>(json);

            return jsonData;
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
