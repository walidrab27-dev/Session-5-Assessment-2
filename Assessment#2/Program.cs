namespace Assessment_2
{
    class MyCookieCollection
    {
        private Dictionary<string,string> cookies = new Dictionary<string, string>();
        public string this[string key]
        {
            get
            {
                cookies.TryGetValue(key, out string value);
                return value;
            }
            set
            {
               cookies[key] = value;
            }
        }
        public void PrintAllCookies()
        {
            foreach (var cookie in cookies)
            {
                Console.WriteLine($"{cookie.Key}: {cookie.Value}");
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
