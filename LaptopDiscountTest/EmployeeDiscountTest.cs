namespace LaptopDiscountTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        // test case 1 
        [Test]
        public void EmployeeType_Parttime_Nodiscount()
        {
            // define a loatop object with employee type at parttime
            var laptopDiscount = new EmployeeDiscount()
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 1000
            };

            // assert calculated price
            // no discount
            Assert.That(laptopDiscount.CalculateDiscountedPrice(), Is.EqualTo(1000));
        }

        // test case 2
        [Test]
        public void EmployeeType_PartialLoad_FivePercent()
        {
            // define a loatop object with employee type at PartialLoad
            var laptopDiscount = new EmployeeDiscount()
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 1000
            };

            // assert calculated price
            // 5 percent discount
            Assert.That(laptopDiscount.CalculateDiscountedPrice(), Is.EqualTo(950));
        }

        // test case 3
        [Test]
        public void EmployeeType_FullTime_TenPercent()
        {
            // define a loatop object with employee type at PartialLoad
            var laptopDiscount = new EmployeeDiscount()
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 1000
            };

            // assert calculated price
            // 10 percent discount
            Assert.That(laptopDiscount.CalculateDiscountedPrice(), Is.EqualTo(900));
        }

        // test case 4
        [Test]
        public void EmployeeType_CompanyPurchasing_TenPercent()
        {
            // define a loatop object with employee type at CompanyPurchasing
            var laptopDiscount = new EmployeeDiscount()
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 1000
             };

            // assert calculated price
            // 20 percent discount
            Assert.That(laptopDiscount.CalculateDiscountedPrice(), Is.EqualTo(800));
        }

        // test case 5
        [Test]
        public void CalculateDiscountedPrice_NegativePrice_InvalidInput()
        {
            // define a loatop object with employee type at FullTime
            var laptopDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -1000 // a negative price
            };
            // assert calculated price
            // 10 percent discount
            Assert.That(laptopDiscount.CalculateDiscountedPrice(), Is.EqualTo(-900)); // No discount expected (invalid input)
        }

        // test case 6
        [Test]
        public void Price_Zero_InvalidInput()
        {
            // define a loatop object with employee type at CompanyPurchasing
            var laptopDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 0
            };

            // assert calculated price
            // 20 percent discount final discount is 0
            Assert.That(laptopDiscount.CalculateDiscountedPrice(), Is.EqualTo(0));
        }

    }
}