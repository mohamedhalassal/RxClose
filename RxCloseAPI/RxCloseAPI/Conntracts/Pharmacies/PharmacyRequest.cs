namespace RxCloseAPI.Conntracts.Pharmacies;
public record PharmacyRequest(
        int PhoneNumber,
        string Name,
        string UserName,
        string Password,
        string Email,
        string Location
    );