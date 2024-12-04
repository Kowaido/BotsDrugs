namespace Domain.Entities;

public class Profile
{
    public Guid Id { get; set; }
    public string ExternalId { get; set; }
    public List<FavoriteDrug> FavoriteDrugs { get; set; }
    public string? Email { get; set; }

    public Profile(Guid id, string externalId, List<FavoriteDrug> favoriteDrugs, string? email)
    {
        Id = id;
        ExternalId = externalId;
        Email = email;
        FavoriteDrugs = favoriteDrugs;
    }
}