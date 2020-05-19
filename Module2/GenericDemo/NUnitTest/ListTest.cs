using NUnit.Framework;
using PhoneManagement;

namespace NUnitTest
{
    public class ListTest
    {
        public  PhoneBookList service;
        [SetUp]
        public void Setup()
        {
            service = new PhoneBookList();
        }

        [Test]
        public void AddPhoneTest_1()
        {
            service.InsertPhone("Khoa", "123");
            Assert.IsTrue(service.contacts.Count == 1);
        }

        [Test]
        public void AddPhoneTest_10()
        {
            AddPhoneTest_1();
            service.InsertPhone("Khoa", "123");
            Assert.IsTrue(service.contacts.Count == 1);
        }

        [Test]
        public void UpdatePhoneTest_1()
        {
            AddPhoneTest_1();
            service.UpdatePhone("Khoa", "456");
            var contact = service.Check("Khoa");
            Assert.AreEqual("456", contact.PhoneNumber);
        }

        [Test]
        public void RemovePhoneTest_1()
        {
            AddPhoneTest_1();
            service.RemovePhone("Khoa");
            var contact = service.Check("Khoa");
            Assert.IsTrue(contact == null);
        }
            [Test]
        public void RemovePhoneTest_2()
        {
            AddPhoneTest_1();
            service.RemovePhone("Duy");
            var contact = service.Check("Khoa");
            Assert.IsTrue(contact != null);
        }
    }
}