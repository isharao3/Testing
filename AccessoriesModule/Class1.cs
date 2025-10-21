namespace AccessoriesModule
{
    public enum AccessoriesEnum { Carjack, SoundSystem, RearCamera, AC }

    public interface IAccessories
    {
       public List<AccessoriesEnum> accessories { get; set; }
        public string purchase();
        public string service();
        
        

    }

    //class PremiumAccessories : IAccessories
    //{
    //    public List<AccessoriesEnum> accessories{ get; set; }
    //    public PremiumAccessories() { 
    //    accessories = new List<AccessoriesEnum>();
    //        accessories.Add(AccessoriesEnum.Carjack);
    //        accessories.Add(AccessoriesEnum.SoundSystem);
    //    }
    //}
}
