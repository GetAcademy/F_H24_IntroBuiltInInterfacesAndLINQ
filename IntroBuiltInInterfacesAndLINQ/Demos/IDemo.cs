namespace IntroBuiltInInterfacesAndLINQ.Demos;

public interface IDemo
{
    public DemoName Name { get; }
    public void Run();
}