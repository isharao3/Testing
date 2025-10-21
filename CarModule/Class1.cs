using AccessoriesModule;
using EngineModule;
using System;
using TyreModule;

namespace CarModule
{
    public class Car
    {
        public IEngine CarEngine { get; set; }
        public ITyre CarTyres { get; set; }
        public IAccessories CarAccessories { get; set; }
        public Car(IEngine carEngine)
        {
            CarEngine = carEngine;
        }
        public Car(ITyre carTyres, IAccessories carAccessories)
        {
            CarTyres = carTyres;
            CarAccessories = carAccessories;

        }
    }
}
/* IType: manifacturer, material, guarentee, size, GetTyreCertification()
 IAccessories: List<Accessories>, Purchase(), Service()
public enum AccessoriesEnum { Carjack, SoundSystem, Rear Camera, AC}

Integration test:
1. Car Instance creation using IEngine, ITyre, IAccessories
2. Setup GetTyreCertificate()
 */