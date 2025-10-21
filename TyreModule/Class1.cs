namespace TyreModule
{
    public interface ITyre
    {
        public string manifacturer {  get; set; }
        public string material { get; set; }
        public int guarentee { get; set; }
        public int size { get; set; }
        public string GetTyreCertification();
    }
}
