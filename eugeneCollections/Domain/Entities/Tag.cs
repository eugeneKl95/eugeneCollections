namespace eugeneCollections.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public string TextTag { get; set; }
    }
}