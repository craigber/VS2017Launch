//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Launch2017;
//using Launch2017.Fakes;

//namespace Launch2017.UnitTests
//{
//    [TestClass]
//    public class CustomerDataTests
//    {
//        [TestMethod]
//        public void SaveShouldUpdateTheRepository()
//        {
//            // Arrange

//            // Create a variable to stash the actual value passed to the repository. 
//            var savedCustomer = default(Customer); // null

//            // Create a new stub repository
//            var repository = new StubICustomerRepository
//            {
//                // this is a closure
//                SaveOrUpdateCustomer = customer => savedCustomer = customer
//            };

//            // Create a customer object to pass to the view model
//            var actualCustomer = new Customer { Id = 1, Name = "Nerry Jixon" };

//            // Create the view model we will test
//            var viewModel = new CustomerViewModel(actualCustomer, repository);

//            // Act

//            // Call the save method on the view model
//            viewModel.Save();

//            // Assert

//            // Verify the customer object is the same one we gave to the view model
//            Assert.IsNotNull(savedCustomer);
//            Assert.AreEqual(1, savedCustomer.Id);
//            Assert.AreEqual("Nerry Jixon", savedCustomer.Name);

//        }
//    }
//}
