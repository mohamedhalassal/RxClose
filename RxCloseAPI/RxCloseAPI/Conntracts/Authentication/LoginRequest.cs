namespace RxCloseAPI.Conntracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);
