namespace Contoso.API.Dtos.CustomerDtos
{
    public class CustomerWithoutAddressDto
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string IdentificationCard { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string FullName => $"{Name} {LastName}";

        private DateTime _registerDate;

        public string RegisterDate
        {
            get
            {
                return (_registerDate == DateTime.MinValue) ?
                    DateTime.Now.ToShortDateString() :
                    _registerDate.ToShortDateString();
            }
        }

    }
}
