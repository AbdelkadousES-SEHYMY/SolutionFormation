using Formation.Models;

namespace Formation.Repository
{
    public class Repository
    {
        public static Repository? _instance;
        private Repository()
        {

        }
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>(){
            new Restaurant{Id=Guid.NewGuid().ToString(), Name="Resto 1",Address="Rabat Hay Ryad",PhoneNumber="09999889"},
            new Restaurant{Id=Guid.NewGuid().ToString(),Name="Resto 2" ,Address="Rabat Hay Ryad" ,PhoneNumber="09999889"},
            new Restaurant{Id=Guid.NewGuid().ToString(), Name="Resto 3",Address="Rabat Hay Ryad",PhoneNumber="09999889"},
            };

        public static Repository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Repository();
            }
            return _instance;
        }
    }
}
