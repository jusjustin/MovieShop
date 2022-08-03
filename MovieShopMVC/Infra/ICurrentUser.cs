namespace MovieShopMVC.Infra
{
    public interface ICurrentUser
    {
        public int UserId { get; }
        bool IsAdmin { get; }
        bool IsAuthenticated { get; }
        string Email { get; }
        string ProfilePicturesUrl { get; }
        string FullName { get; }

    }
}
