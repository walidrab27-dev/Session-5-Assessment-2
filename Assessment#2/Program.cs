namespace Assessment_2
{
    class MyCookieCollection
    {
        private List<Dictionary<string,string>> cookies = new List<Dictionary<string, string>>();
        public string this[string key]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new ArgumentException("Invalid cookie key");
                foreach (var dict in cookies)
                    if (dict.ContainsKey(key))
                        return dict[key];
                return null;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(key))
                    throw new ArgumentException("Invalid cookie key");
                foreach (var dict in cookies)
                {
                    if (dict.ContainsKey(key))
                    {
                        dict[key] = value;
                        return;
                    }
                }
                cookies.Add(new Dictionary<string, string> { { key, value } });
            }
        }
        public void PrintAllCookies()
        {
            if (cookies.Count==0)
            {
                Console.WriteLine("No cookies found.");
                return;
            }
            foreach(var dict in cookies)
            {
                foreach (var cookie in dict)
                {
                    Console.WriteLine($"{cookie.Key} = {cookie.Value}");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           MyCookieCollection cookies = new MyCookieCollection();

            // Set cookies
            cookies["username"] = "MaiHesham";
            cookies["theme"] = "dark";

            //// Get cookies
            Console.WriteLine("Username: " + cookies["username"]);
            Console.WriteLine("Theme: " + cookies["theme"]);
            Console.WriteLine("Language: " + (cookies["language"] ?? "Not Set"));

            // Print all cookies
            cookies.PrintAllCookies();

        }
    }
}
