using Modificabilidade.Domain.Entities.ValuesObjects;

namespace Modificabilidade.Domain.Entities;

public class User : ValueObject
{
    public Guid UserId { get; set; }
    public Name NameUser { get; set; }
    public Email Email { get; set; }
    public string HashPassword { get; set; }
    public string UrlPhotoProfile { get; set; }

    public User(Name nameUser, Email email, string hashPassword, string urlPhotoProfile)
    {
        UserId = Guid.NewGuid();
        NameUser = nameUser;
        Email = email;
        HashPassword = hashPassword;
    }
    
    public void SetProfile(Name newNameUser, string newUrlPhotoProfile, Email newEmail)
    {
        NameUser = newNameUser;
        UrlPhotoProfile = newUrlPhotoProfile;
        Email = newEmail;
    }
    
    public void GhangePassword(string newPassword)
        => HashPassword = newPassword;
}