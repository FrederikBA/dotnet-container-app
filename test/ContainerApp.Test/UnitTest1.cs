namespace ContainerApp.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        const int value = 1;
        Assert.Equal(1, value);
    }
}