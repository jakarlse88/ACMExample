using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FindTestExistingCustomer()
        {
            //-- Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

			//-- Act
			var result = repository.Find(customerList, 2);

			//-- Assert
			Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod]
        public void FindTestNotFound()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            // Act
            var result = repository.Find(customerList, 42);

            // Assert
            Assert.IsNull(result);
        }

		[TestMethod]
		public void SortByNameTest()
		{
			//-- Arrange
			var repository = new CustomerRepository();
			var customerList = repository.Retrieve();

			//-- Act
			var result = repository.SortByName(customerList);

			//-- Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.First().CustomerId);
			Assert.AreEqual("Baggins", result.First().LastName);
			Assert.AreEqual("Bilbo", result.First().FirstName);
		}

		[TestMethod]
		public void SortByNameInReverseTest()
		{
			//-- Arrange
			var repository = new CustomerRepository();
			var customerList = repository.Retrieve();

			//-- Act
			var result = repository.SortByNameInReverse(customerList);

			//-- Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(2, result.Last().CustomerId);
			Assert.AreEqual("Baggins", result.Last().LastName);
			Assert.AreEqual("Bilbo", result.Last().FirstName);
		}

		[TestMethod]
		public void SortByTypeTest()
		{
			//-- Arrange
			var repository = new CustomerRepository();
			var customerList = repository.Retrieve();

			//-- Act
			var result = repository.SortByType(customerList);

			//-- Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(null, result.Last().CustomerTypeId);
			
		}

		[TestMethod]
		public void GetNamesTest()
		{
			//-- Arrange
			var repository = new CustomerRepository();
			var customerList = repository.Retrieve();

			//-- Act
			var query = repository.GetNames(customerList);

			//-- Analyse
			foreach (var item in query)
			{
				Console.WriteLine(item);
			}

			//-- Assert
			Assert.IsNotNull(query);
		}

		[TestMethod]
		public void GetNamesAndEmailTest()
		{
			//-- Arrange
			var repository = new CustomerRepository();
			var customerList = repository.Retrieve();

			//-- Act
			var query = repository.GetNamesAndEmail(customerList);

			//-- NOT AN ACTUAL TEST
		}

		[TestMethod]
		public void GetNamesAndTypeTest()
		{
			//-- Arrange
			var customerRepository = new CustomerRepository();
			var customerList = customerRepository.Retrieve();

			var customerTypeRepository = new CustomerTypeRepository();
			var customerTypeList = customerTypeRepository.Retrieve();

			//-- Act
			var query = customerRepository.GetNamesAndType(customerList, customerTypeList);

			//-- NOT AN ACTUAL TEST
		}

		[TestMethod]
		public void GetOverdueCustomersTest()
		{
			//-- Arrange
			var repository = new CustomerRepository();
			var customerList = repository.Retrieve();

			//-- Act
			var query = repository.GetOverdueCustomers(customerList);

			//-- Analyse
			foreach (var item in query)
			{
				Console.WriteLine(item.LastName + ", " + item.FirstName);
			}

			//-- Assert
			Assert.IsNotNull(query);
		}
	}
}
