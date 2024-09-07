namespace calcTest
{
    public class MyCalcTests
    {
        [Fact]
        private void SumTest()
        {          
            int x = 10; int y = 20;
            int expected = 30;
            MyCalc c = new MyCalc(); 
            int actual = x + y;
            Assert.Equal(expected, actual);
        }
        [Fact]
        private void MinTest()
        {
            int x = 20;
            int y = 10;
            int expected = 10;
            MyCalc c = new MyCalc();
            int actual = x - y;
            Assert.Equal(expected, actual);
        }
        [Fact]
        private void UmnTest()
        {
            int x = 5;
            int y = 2;
            int expected = 10;
            MyCalc c = new MyCalc();
            int actual = x * y;
            Assert.Equal(expected, actual);
        }
        [Fact]
        private void DelTest()
        {
            int x = 100;
            int y = 10;
            int expected = 10;
            MyCalc c = new MyCalc();
            int actual = x / y;
            Assert.Equal(expected, actual);
        }

    }
    public class MyCalc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Min(int a, int b) 
        { 
            return a - b;
        }
        public int Umn(int a, int b)
        {
            return a * b;
        }
        public int Del(int a, int b)
        {
            return a / b;
        }
    }
}