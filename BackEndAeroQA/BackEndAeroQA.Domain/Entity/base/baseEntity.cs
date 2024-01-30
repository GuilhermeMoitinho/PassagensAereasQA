namespace BackEndAeroQA.Domain.Entity
{
    public abstract class baseEntity
    {
        public Guid Id { get; set; }

        public baseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
