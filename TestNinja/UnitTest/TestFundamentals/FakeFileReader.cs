using TestNinja.Fundamentals;

namespace UnitTest.TestFundamentals
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
