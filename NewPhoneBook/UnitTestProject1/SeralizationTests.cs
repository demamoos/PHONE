using System;
using System.Collections.Generic;
using System.IO;
using Electronic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void End2EndSerializationTest()
        {
            var electro = new Choice
            {
                NewTime = DateTime.Now,
                FullName = "Savva Baranovsky",
                Price = 50000,
                Currency = Currency.Rubles,
               
                Additions = new List<Addition>()
                        {
                            new Addition ()
                            {
                                Name = "MSI",
                                Memory = '8',
                                VideoCard = "Nvidia",
                                Processor = "Intel Core I7"
                            }
                            
                        }

            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                ElectronicHelper.WriteToFile(tempFileName, electro);
                var readElectro = ElectronicHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(electro.Additions.Count, readElectro.Additions.Count);
                Assert.AreEqual(electro.NewTime, readElectro.NewTime);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}
