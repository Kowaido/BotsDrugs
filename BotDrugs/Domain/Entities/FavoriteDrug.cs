namespace Domain.Entities;

public class FavoriteDrug : BaseEntity<FavoriteDrug>
{
    public FavoriteDrug(string externalId, Guid drugId, Drug drug, Guid? drugStoreId, DrugStore? drugStore)
    {
        ExternalId = externalId;
        DrugId = drugId;
        Drug = drug;
        DrugStoreId = drugStoreId;
        DrugStore = drugStore;
    }
    
    public string ExternalId { get; private set; }
    public Guid DrugId { get; private set; }
    public Drug Drug { get; private set; }
    public Guid? DrugStoreId { get; private set; }
    public DrugStore? DrugStore { get; private set; }
}