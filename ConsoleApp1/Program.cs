// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("Hello, World!");

var createClientRequest = new CreateClientRequest()
{                
                    CurrencyId = "GBP",
                    IBAN = "GB82WEST12345698765432",
                    FirstName = "Michael",
                    LastName = "Johnson",
                    MiddleName = "Peter",
                    Login = "michaeljohnson",
                    RegionCode = "GB",
                    Gender = 1, // Male
                    ProfileId = 303,
                    DocNumber = "C5678901",
                    PersonalId = "5678901234",
                    Address = "789 Another Place, Newtown, UK",
                    Email = "michaeljohnson@example.com",
                    Language = "en", // English
                    Phone = "+441234567890",
                    MobilePhone = "+447654321098",
                    BirthDateStamp = 410244480, // Unix timestamp for 1983-01-01
                    City = "Newtown",
                    PromoCode = "PROMO2025UK",
                    BTag = "BTAG789",
                    ExtAgentId = "AGENT003",
                    TimeZone = 0.0m, // Greenwich Mean Time (GMT)
                    IsLocked = false,
                    IsSubscribedToNewsletter = false,
                    CreatedStamp = 1672531200, // Unix timestamp for 2023-01-01
                    ModifiedStamp = 1672617600, // Unix timestamp for 2023-01-02
                    ExcludedStamp = null,
                    RFId = "RFID789012",
                    NickName = "Mike",
                    ResetCode = "RESET789",
                    ResetExpireDateStamp = 1672704000, // Unix timestamp for 2023-01-03
                    DocIssuedBy = "UK Government",
                    Balance = 1500.25m,
                    LastLoginIp = "192.168.1.3",
                    LastLoginTimeStamp = 1672790400, // Unix timestamp for 2023-01-04
                    PreMatchSelectionLimit = 800.00m,
                    LiveSelectionLimit = 400.00m,
                    IsVerified = true,
                    SportsbookProfileId = 404,
                    GlobalLiveDelay = 7,
                    ExcludedLastStamp = null,
                    UnplayedBalance = 300.00m,
                    IsTest = false,
                    Password = "Alinka98*",
                    ExternalId = "EXT789012",
                    MaxMonthlyDeposit = 15000.00m,
                    MaxWeeklyDeposit = 3500.00m,
                    MaxYearlyDeposit = 75000.00m,
                    MaxSingleDeposit = 1500.00m,
                    MaxDailyDeposit = 750.00m,
                    CanLogin = true,
                    CanDeposit = true,
                    CanWithdraw = true,
                    CanBet = true
                
};

var changeClientPasswordRequest = new ChangeClientPasswordRequest()
{
    RequestHash = "",
    Login = "johndoe",
    ClientId = 1,
    NewPassword = "Alinka98*"
};

var filterClientRequest = new FilterClientRequest
{
    Id = 1,
    RequestHash = "",
    RegistrationFromStamp = 1609459200, // UNIX timestamp for 2021-01-01
    RegistrationToStamp = 1672531200, // UNIX timestamp for 2023-01-01
    NickName = "Johnny",
    FirstName = "John",
    LastName = "Doe",
    MiddleName = "Michael",
    Gender = 1, // Male
    BirthDateStamp = 315532800, // UNIX timestamp for 1980-01-01
    DocumentNumber = "D1234567",
    PersonalId = "1234567890",
    Email = "john.doe@example.com",
    Phone = "1234567890",
    MobilePhone = "1987654321",
    IsLocked = false,
    RegionCode = "US",
    City = "Anytown",
    Login = "johndoe",
    CurrencyId = "USD",
    ExternalId = "EXT123456",
    IsWithRestrictions = true // If true client will be returned with the restrictions params (CanLogin, CanBet, CanDeposit, CanWithdraw)
};

var filterClientRequestEmail = new FilterClientRequest()
{
    //Id = null,
    //RequestHash = null,
    //RegistrationFromStamp = null,
    //RegistrationToStamp = null,
    //NickName = null,
    //FirstName = null,
    //LastName = null,
    //MiddleName = null,
    //Gender = null,
    //BirthDateStamp = null,
    //DocumentNumber = null,
    //PersonalId = null,
    Email = "1johndoe@example.com",
    //Phone = null,
    //MobilePhone = null,
    //IsLocked = null,
    //RegionCode = null,
    //City = null,
    //Login = null,
    //CurrencyId = null,
    //ExternalId = null,
    //IsWithRestrictions = null
};

var filterClientRequestID = new FilterClientRequest()
{
    Id = 8,
    //RequestHash = null,
    //RegistrationFromStamp = null,
    //RegistrationToStamp = null,
    //NickName = null,
    //FirstName = null,
    //LastName = null,
    //MiddleName = null,
    //Gender = null,
    //BirthDateStamp = null,
    //DocumentNumber = null,
    //PersonalId = null,
    //Email = "johndoe@example.com",
    //Phone = null,
    //MobilePhone = null,
    //IsLocked = null,
    //RegionCode = null,
    //City = null,
    //Login = null,
    //CurrencyId = null,
    //ExternalId = null,
    //IsWithRestrictions = null
};

var filterClientRequestLogin = new FilterClientRequest()
{
    //Id = 2,
    //RequestHash = null,
    //RegistrationFromStamp = null,
    //RegistrationToStamp = null,
    //NickName = null,
    //FirstName = null,
    //LastName = null,
    //MiddleName = null,
    //Gender = null,
    //BirthDateStamp = null,
    //DocumentNumber = null,
    //PersonalId = null,
    //Email = "johndoe@example.com",
    //Phone = null,
    //MobilePhone = null,
    //IsLocked = null,
    //RegionCode = null,
    //City = null,
    Login = "alicesmith",
    //CurrencyId = null,
    //ExternalId = null,
    //IsWithRestrictions = null
};

var filterClientRequestFIO = new FilterClientRequest()
{
    //Id = 2,
    //RequestHash = null,
    //RegistrationFromStamp = null,
    //RegistrationToStamp = null,
    //NickName = null,
    FirstName = "Michael",
    LastName = "Johnson",
    MiddleName = "1Peter"
    //Gender = null,
    //BirthDateStamp = null,
    //DocumentNumber = null,
    //PersonalId = null,
    //Email = "johndoe@example.com",
    //Phone = null,
    //MobilePhone = null,
    //IsLocked = null,
    //RegionCode = null,
    //City = null,
    //Login = "alicesmith",
    //CurrencyId = null,
    //ExternalId = null,
    //IsWithRestrictions = null
};

string secretKey = "Zg9m9fUqcnuPOg8";



string requestHashForCreateClient = CalculateRequestHash(createClientRequest, secretKey);

string requestHashForChangePassword = CalculateRequestHash(changeClientPasswordRequest, secretKey);

string requestHashForFilterClient = CalculateRequestHash(filterClientRequest, secretKey);

string requestHashForFilterClientEmail = CalculateRequestHash(filterClientRequestEmail, secretKey);

string requestHashForFilterClientID = CalculateRequestHash(filterClientRequestID, secretKey);

string requestHashForFilterClientLogin = CalculateRequestHash(filterClientRequestLogin, secretKey);

string requestHashForFilterClientFIO = CalculateRequestHash(filterClientRequestFIO, secretKey);


Console.WriteLine("ForCreateClient " + requestHashForCreateClient);

Console.WriteLine("ForChangePassword " + requestHashForChangePassword);

Console.WriteLine("ForFilterClient " + requestHashForFilterClient);

Console.WriteLine("ForFilterClientEmail " + requestHashForFilterClientEmail);

Console.WriteLine("ForFilterClientID " + requestHashForFilterClientID);

Console.WriteLine("ForFilterClientLogin " + requestHashForFilterClientLogin);

Console.WriteLine("ForFilterClientFIO " + requestHashForFilterClientFIO);

static string CalculateRequestHash(object obj, string key)
{
    var properties = obj.GetType().GetProperties();
    Dictionary<string, object> objectmap = new Dictionary<string, object>();

    foreach (var property in properties)
    {
        var value = property.GetValue(obj, null);
        if (value != null && property.Name != "RequestHash" && property.CanWrite)
        {
            objectmap.Add(property.Name, value);
        }
    }

    var jsonString = JsonConvert.SerializeObject(objectmap);

    return ComputeHMACSHAT256(jsonString, key);
}

 static string ComputeHMACSHAT256(string data, string key)
{
    var secretKey =
    Encoding.ASCII.GetBytes(key); var
    message =
    Encoding.ASCII.GetBytes(data);
    using (HMACSHA256 hash = new HMACSHA256(secretKey))
    {
        var hashArray = hash.ComputeHash(message);
        return string.Concat(Array.ConvertAll(hashArray, b => b.ToString("x2")));
    }
}

public class FilterClientRequest
{
    public int? Id { get; set; } //Client Id
    public string? RequestHash { get; set; } //required for partner verification
    public long? RegistrationFromStamp { get; set; }
    public long? RegistrationToStamp { get; set; }
    public string? NickName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public int? Gender { get; set; } // Male = 1, Female = 2
    public long? BirthDateStamp { get; set; } // UNIX timestamp representation of registration date
    public string? DocumentNumber { get; set; }
    public string? PersonalId { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? MobilePhone { get; set; }
    public bool? IsLocked { get; set; }
    public string? RegionCode { get; set; }
    public string? City { get; set; }
    public string? Login { get; set; }
    public string? CurrencyId { get; set; }
    public string? ExternalId { get; set; }
    public bool? IsWithRestrictions { get; set; } //If true client will be returned with the restrictions params (CanLogin, CanBet, CanDeposit, CanWithdraw)
}

public class ChangeClientPasswordRequest
{
    public string RequestHash { get; set; } //required for partner verification
    public string Login { get; set; }
    public int ClientId { get; set; }
    public string NewPassword { get; set; }
}

public class CreateClientRequest
{
    public int? Id { get; set; } //Client Id
    public string RequestHash { get; set; } //required for partner verification
    public string CurrencyId { get; set; } //ISO 4217 code of currency (USD, EUR, RUB, ..)
    public string IBAN { get; set; } //international bank account number of client
   // public string Name { get; set; } //LastName + FirstName + MiddleName
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Login { get; set; } //username of client in website
    public string RegionCode { get; set; } //ISO ALPHA-2 Code of country (FR, GB, RU)
    public int? Gender { get; set; } // Male = 1, Female = 2
    public int? ProfileId { get; set; }
    public string DocNumber { get; set; } // Passport Number of client
    public string PersonalId { get; set; } //Unique identity number of client
    public string Address { get; set; }
    public string Email { get; set; }
    public string Language { get; set; } //prefered language of client, ISO 639-1 codes
    public string Phone { get; set; }
    public string MobilePhone { get; set; }
    public long? BirthDateStamp { get; set; } // UNIX timestamp representation of registration date
    public string City { get; set; } // City where client lives
    public string PromoCode { get; set; } //Promotional code by which client was registered
    public string BTag { get; set; }
    public string ExtAgentId { get; set; }
    public decimal? TimeZone { get; set; } // Timezone of client (in hours)
    public bool? IsLocked { get; set; }
    public bool? IsSubscribedToNewsletter { get; set; }
    public long? CreatedStamp { get; set; }
    public long? ModifiedStamp { get; set; }
    public long? ExcludedStamp { get; set; }
    public string RFId { get; set; }
    public string NickName { get; set; }
    public string ResetCode { get; set; }
    public long? ResetExpireDateStamp { get; set; }
    public string DocIssuedBy { get; set; }
    public decimal Balance { get; set; }
    public string LastLoginIp { get; set; }
    public long? LastLoginTimeStamp { get; set; }
    public decimal? PreMatchSelectionLimit { get; set; }
    public decimal? LiveSelectionLimit { get; set; }
    public bool? IsVerified { get; set; }
    public int? SportsbookProfileId { get; set; }
    public int? GlobalLiveDelay { get; set; }
    public long? ExcludedLastStamp { get; set; }
    public decimal UnplayedBalance { get; set; }
    public bool? IsTest { get; set; }
    public string Password { get; set; }
    public string ExternalId { get; set; }
    public decimal? MaxMonthlyDeposit { get; set; } // Set limit during create client
    public decimal? MaxWeeklyDeposit { get; set; } // Set limit during create client
    public decimal? MaxYearlyDeposit { get; set; } // Set limit during create client
    public decimal? MaxSingleDeposit { get; set; } // Set limit during create client
    public decimal? MaxDailyDeposit { get; set; } // Set limit during create client
    public bool? CanLogin { get; set; }
    public bool? CanDeposit { get; set; }
    public bool? CanWithdraw { get; set; }
    public bool? CanBet { get; set; }
}