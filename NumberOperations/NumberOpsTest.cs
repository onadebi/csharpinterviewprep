using Xunit;
using Xunit.Abstractions;
using System.Text;


namespace grouping.NumberOperations
{
    public class NumberOpsTest: IClassFixture<MyNumbFixture>
    {
        MyNumbFixture fixture;
        public ITestOutputHelper _output;

        public NumberOpsTest(ITestOutputHelper output)
        {
            fixture = new MyNumbFixture();
            _output = output;
        }

        [Fact(DisplayName ="MaxProductCheckTest")]
        void MaxProductReturnTest()
        {
            int[] tt = { 5, 3, 2, 5, 7, 8, 1, 10,-11 };
            int[] t0 = { 5, 3, 2, 5, 7, 8, 1,10 };
            int[] t1 = { 5, 3, 2, 5, 7, 8, 1 };
            int[] t2 = { -2, -1, -3, 4, 8, 0 };
            int[] t3 = { -20, 10, 3, 9, -8 };

            _output.WriteLine($"Max return of tt {fixture.numbOps.MaxProductReturn(tt)}");
            _output.WriteLine($"Max return of t0 {fixture.numbOps.MaxProductReturn(t0)}");
            _output.WriteLine($"Max return of t1 {fixture.numbOps.MaxProductReturn(t1)}");
            _output.WriteLine($"Max return of t2 {fixture.numbOps.MaxProductReturn(t2)}");
            _output.WriteLine($"Max return of t3 {fixture.numbOps.MaxProductReturn(t3)}");
        }

        [Fact(DisplayName = "MaxProductReturnIndexesTest")]
        void MaxProductReturnIndexesTest()
        {
            int[] tt = { 5, 3, 2, 5, 7, 8, 1, 10, -11 };
            int[] t0 = { 5, 3, 2, 5, 7, 8, 1, 10 };
            int[] t1 = { 5, 3, 2, 5, 7, 8, 1 };
            int[] t2 = { -2, -1, -3, 4, 8, 0 };
            int[] t3 = { -20, 10, 3, 9, -8 };


            var ttResult = fixture.numbOps.MaxProductReturnIndexes(tt);
            StringBuilder sb = new(); 
             foreach(KeyValuePair<int, int> data in  ttResult )
            {
                sb.Append($"[{data.Key},{data.Value}],");
            };
            _output.WriteLine($"Max return of tt {sb.ToString().Substring(0, sb.ToString().Length-1)}");
            Assert.Equal(new Dictionary<int, int> { {5,8 },{7,10 } }, ttResult);

            _output.WriteLine($"Max return of t0 {fixture.numbOps.MaxProductReturnIndexes(t0)}");
            _output.WriteLine($"Max return of t1 {fixture.numbOps.MaxProductReturnIndexes(t1)}");
            _output.WriteLine($"Max return of t2 {fixture.numbOps.MaxProductReturnIndexes(t2)}");
            _output.WriteLine($"Max return of t3 {fixture.numbOps.MaxProductReturnIndexes(t3)}");
        }
    }
}
