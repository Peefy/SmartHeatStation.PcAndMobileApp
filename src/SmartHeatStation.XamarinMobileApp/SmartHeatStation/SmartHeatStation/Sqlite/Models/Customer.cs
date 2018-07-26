
using SQLite;

namespace SmartHeatStation.Sqlite.Models
{
    [Table("Customer")]
    public class Customer : BaseSqliteModel
    {
        int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; OnPropertyChanged(nameof(UserId)); }
        }

        string companyName;
        [NotNull]
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; OnPropertyChanged(nameof(CompanyName)); }
        }

        string physicalAddress;
        public string PhysicalAddress
        {
            get { return physicalAddress; }
            set { physicalAddress = value; OnPropertyChanged(nameof(PhysicalAddress)); }
        }

        string country;
        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(nameof(Country)); }
        }
        

    }
}
