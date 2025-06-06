namespace RxCloseAPI.Conntracts.Pharmacies;

public record PharmacyResponse(
        int Id,
        int PhoneNumber,
        string Name,
        string UserName,
        string Password,
        string Email,
        string Location
    );