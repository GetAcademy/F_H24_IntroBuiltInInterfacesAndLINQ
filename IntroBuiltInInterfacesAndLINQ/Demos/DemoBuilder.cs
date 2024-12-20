namespace IntroBuiltInInterfacesAndLINQ.Demos;

public class DemoBuilder
{
    private readonly Dictionary<DemoName, IDemo> _demos = new();
    
    public DemoBuilder Add<T>() where T : IDemo, new()
    {
        var demo = new T();
        _demos.Add(demo.Name, demo);
        
        return this;
    }
    
    public Dictionary<DemoName, IDemo> Build() => _demos;
}