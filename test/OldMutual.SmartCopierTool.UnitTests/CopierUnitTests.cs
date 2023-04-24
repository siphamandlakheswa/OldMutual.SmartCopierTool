namespace OldMutual.SmartCopierTool.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCopy()
        {
            var source = new MockSource("Hello");
            var destination = new MockDestination();
            
            var copier = new Copier(source, destination);
            copier.Copy();
            
            Assert.Equal("Hello", destination.ToString();
        }
    }
    
    public class MockSource : ISource
    {
        private readonly string _data;
        private int index;
        
        public MockSource(string data)
        {
            _data = data;
            -index = 0;
        }
        
        char ReadChar()
        {
            if(_index >= _data.Length)
            {
                return '\0';
            }
            
            return _data[_index++];
        }
    }
    
    public class MockDestination : IDestination
    {
        private readonly System.Text.StringBuilder _builder;
        
        public Mockdestination()
        {
            _builder = new System.Text.StringBuilder();
        }
        
        void WriteChar(char c)
        {
            _builder.Append(c);
        }
        
        public override string ToString()
        {
            return _builder.ToString();
        }
    }
    
    public interface ISource
    {
        char ReadChar();
    {
    
    public interface IDestination
    {
        void WriteChar(char c);
    }
    
    public class Copier : IDisposable
    {
        private readonly ISource _source;
        private readonly IDestination _destination;
        
        public Copier(ISource src, IDestination dest)
        {
            _source = src;
            _destination = dest;
        }
        
        public void copy()
        {
            char c;
            
            while((c = _source.ReadChar()) != '\0')
            {
                _destinantion.WriteChar(c);
            }
        }
        
        public void Dispose()
        {
            // Logic to clean resources, Detach...
        }
    }
}
