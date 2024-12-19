namespace IntroBuiltInInterfacesAndLINQ.Demos;

public class DemoBuilder
{
    private readonly Dictionary<DemoName, IDemo> _demos = new();
    
    public DemoBuilder Add(DemoName demoName, IDemo demo)
    {
        _demos.Add(demoName, demo);
        
        return this;
    }
    
    public Dictionary<DemoName, IDemo> Build() => _demos;
    
}