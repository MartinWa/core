using Microsoft.Extensions.Configuration;

namespace core.services
{
    public interface IGreeter
    {
        string GetGreeting();
    }
    public class Greeter : IGreeter
    {
        private readonly string _greeter;

        public Greeter(IConfiguration configuration)
        {
            _greeter = configuration["greeting"];
        }

        public string GetGreeting()
        {
            return _greeter;
        }
    }
}
