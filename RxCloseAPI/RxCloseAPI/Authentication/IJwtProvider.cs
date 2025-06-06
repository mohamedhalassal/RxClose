namespace RxCloseAPI.Authentication
{
    public interface IJwtProvider
    {
        (string token, int expiresIn) GnerateToken(User user);
    }
}
