namespace Entities
{
    public class Brand:StandartdEntity
    {
        public double Coef { get; set; }
        public Brand(int id, string title) : base(id, title)
        { }

        public Brand(int id, string title, double coef) : base(id, title)
        {
            Coef = coef;
        }
    }
}