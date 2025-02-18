using NUnit.Framework;

public class BaseTest
{
    protected DriverFactory driverFactory;

    [OneTimeSetUp]
    public void Setup()
    {
        driverFactory = DriverFactory.Instance;
    }

    [OneTimeTearDown]
    public void Teardown()
    {
        driverFactory.StopDriver();
    }

}