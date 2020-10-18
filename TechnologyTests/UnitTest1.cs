using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        Computer computer1 = new Computer(1024, 768, 1000, "Desktop");
        Computer computer2 = new Computer(1080, 1920, 2000, "Tower");
        Laptop laptop = new Laptop(1024, 768, 500);
        SmartPhone smartPhone = new SmartPhone(1024, 768, 256);

        // Ensure Id starts at 1 and increments with each new device
        [TestMethod]
        public void AbstractEntityIdSet()
        {
            Assert.IsTrue(computer1.Id == 1 &&
                          computer2.Id == 2 &&
                          laptop.Id == 3 &&
                          smartPhone.Id == 4);
        }

        [TestMethod]
        public void DeviceWidthConstructorsSet()
        {
            Assert.AreEqual(computer1.DisplayWidth, 1024);
        }

        [TestMethod]
        public void DeviceHeightConstructorSet()
        {
            Assert.AreEqual(computer1.DisplayHeight, 768);
        }

        [TestMethod]
        public void MaxStorageSpaceSet()
        {
            Assert.AreEqual(computer1.MaxStorageSpace, 1000);
        }

        [TestMethod]
        public void InitialStorageUsedIsZero()
        {
            Assert.AreEqual(computer1.CurrentStorage, 0);
        }

        [TestMethod]
        public void DeviceStorageSet()
        {
            Assert.AreEqual(1000, computer1.MaxStorageSpace);
        }

        [TestMethod]
        public void ValidStorageUpdateReturnsTrue()
        {
            Assert.IsTrue(computer1.StoreData(100));
        }

        [TestMethod]
        public void DeviceStorageUpdated()
        {
            computer1.StoreData(500);
            Assert.AreEqual(500, computer1.CurrentStorage);
        }

        [TestMethod]
        public void PowerStartsOff()
        {
            Assert.IsFalse(computer1.IsPoweredOn);
        }

        [TestMethod]
        public void PowerTogglesOn()
        {
            computer1.TogglePower();
            Assert.IsTrue(computer1.IsPoweredOn);
        }

        [TestMethod]
        public void FalseWhenExceedsMaxStorage()
        {
            Assert.IsFalse(computer1.StoreData(1001));
        }

        [TestMethod]
        public void ComputerCaseStyleSet()
        {
            Assert.IsTrue(computer1.CaseStyle == "Desktop");
        }

        [TestMethod]
        public void LaptopBatteryStartsAt100()
        {
            Assert.AreEqual(100, laptop.BatteryCharge);
        }

        [TestMethod]
        public void LaptopBatteryCanBeSet()
        {
            laptop.BatteryCharge = 50;
            Assert.AreEqual(50, laptop.BatteryCharge);
        }

        [TestMethod]
        public void LaptopIsLowPowerBelow20BatteryCharge()
        {
            laptop.BatteryCharge = 19;
            Assert.IsTrue(laptop.LowPower());
        }

        [TestMethod]
        public void SmartPhoneHasBrokenScreenFalseAtStart()
        {
            Assert.IsFalse(smartPhone.hasBrokenScreen);
        }

        [TestMethod]
        public void SmartPhoneHasBrokenScreenTrueAfterDropPhone()
        {
            smartPhone.DropPhone();
            Assert.IsTrue(smartPhone.hasBrokenScreen);
        }

        [TestMethod]
        public void ComputerTypeOnKeyboardOutput()
        {
            StringWriter sw = new System.IO.StringWriter();

            var output = System.Console.Out;
            var error = System.Console.Error;

            // redirect to the StringWriter so we can test output
            System.Console.SetOut(sw);
            System.Console.SetError(sw);

            computer1.TypeOnKeyboard();

            string result = sw.ToString();

            // restore the Console Out and Error
            System.Console.SetOut(output);
            System.Console.SetError(error);

            Assert.IsTrue(result == "Clickety-Clack\r\n");
        }
    }
}
