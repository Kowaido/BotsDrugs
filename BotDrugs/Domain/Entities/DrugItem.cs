namespace Domain.Entities
{
    /// <summary>
    /// Связь между препаратом и аптекой
    /// </summary>
    public class DrugItem : BaseEntity<DrugItem>
    {
        public DrugItem(Guid drugId, Guid drugStoreId, decimal cost, double count, Drug drug, DrugStore drugStore)
        {
            DrugId = drugId;
            DrugStoreId = drugStoreId;
            Cost = cost;
            Count = count;
            Drug = drug;
            DrugStore = drugStore;
        }

        /// <summary>
        /// Идентификатор препарата.
        /// </summary>
        public Guid DrugId { get; private set; }
        
        /// <summary>
        /// Идентификатор аптеки.
        /// </summary>
        public Guid DrugStoreId { get; private set; }
        
        /// <summary>
        /// Стоимость препарата в данной аптеке.
        /// </summary>
        public decimal Cost { get; private set; }
        
        /// <summary>
        /// Количество препарата на складе.
        /// </summary>
        public double Count { get; private set; }
        
        // Навигационные свойства
        public Drug Drug { get; private set; }
        public DrugStore DrugStore { get; private set; }


        public void UpdateDrugCount(double count)
        {
            Count = count;
        }
    }
}