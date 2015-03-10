namespace MobilePhone
{
    using System;

    public static class GSMTest
    {
        public static GSM[] GeneratePhones()
        {
            GSM[] mobilePhones = new GSM[4] {
                                                new GSM("KM900 Arena", "LG", 50, "Gosho", new Battery(Battery.Type.Li_Ion, 10, 200), new Display(3.5f, 16000000)),
                                                new GSM("Google Nexus 4", "LG", 300, "Ivo", new Battery(Battery.Type.Li_Ion, 15, 18), new Display(4.7f, 16000000)),
                                                new GSM("Galaxy S4", "Samsung", 500, "Pesho", new Battery(Battery.Type.Li_Ion, 300, 1), new Display(5.0f, 16000000)),
                                                GSM.IPhone4S
                                            };

            return mobilePhones;
        }
    }
}
