namespace Entities
{
    public class Model:StandartdEntity
    {
        public Brand Brand { get; set; }
        public Model(int id, string title) : base(id, title)
        { }

        public Model(int id, string title, int idBrand, string titleBrand) : base(id, title)
        {
            Brand = new Brand(idBrand, titleBrand);
        }
    }
}