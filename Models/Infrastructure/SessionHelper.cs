using System.Text.Json;

namespace UKWShop.Models.Infrastructure
{
    public static class SessionHelper
    {
        public static void SetCart(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetCart<T>(this ISession session, string key)
        {
            var json = session.GetString(key);
            var value = JsonSerializer.Deserialize<T>(json);

            return value == null ? default(T) : value;
        }
    }
}
