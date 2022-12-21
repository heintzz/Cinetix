using Cinetix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CinetixUnitTest
{
    [TestClass]
    public class MakeReservationTest
    {
        [TestMethod]
        public void FormValidationTest()
        {
            string name = "muhammad hasnan";
            string date = "21 December 2022";
            int amountOfOrder = 1;

            MakeReservation makeReservationClass = new MakeReservation();
            bool isEmpty = makeReservationClass.IsFormEmpty(name, date, amountOfOrder.ToString());

            bool expected = false;

            Assert.AreEqual(expected, isEmpty, "Form belum selesai diisi.");
        }

        [TestMethod]
        public void AmountOfOrderTest()
        {
            int amountOfOrder = -1;
            MakeReservation makeReservationClass = new MakeReservation();
            bool isNaturalNumber = makeReservationClass.IsNaturalNumber(amountOfOrder);

            bool expected = false;

            Assert.AreEqual(expected, isNaturalNumber, "Jumlah pesanan harus lebih dari 0.");
        }

        public void CheckTotalPrice()
        {
            int person = 4;
            int pricePerPerson = 35000;
            int totalPrice = 140000;

            MakeReservation makeReservationClass = new MakeReservation();
            int testTotalPrice = makeReservationClass.CalculateTotalPrice(person, pricePerPerson);

            Assert.AreEqual(totalPrice, testTotalPrice);
        }

    }
}
