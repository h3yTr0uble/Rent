namespace Entities
{
    public class DrivingCategory:StandartdEntity
    {
        public TransportType TransportType { get; set; }

        public DrivingCategory()
        { }

        public DrivingCategory(int id, string title) : base(id, title)
        { }

        public DrivingCategory(int id, string title, int idType, string typeTitle) : base(id, title)
        {
            TransportType = new TransportType(idType, typeTitle);
        }
    }
}