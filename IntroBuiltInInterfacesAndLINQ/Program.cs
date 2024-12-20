using IntroBuiltInInterfacesAndLINQ.Demos;


const DemoName demoToRun = DemoName.Linq;

// Should we consider Generics for this?
var allDemos = new DemoBuilder()
    .Add(DemoName.Extension, new ExtensionDemo())
    .Add(DemoName.Linq, new LinqDemo())
    .Add(DemoName.Enumerable, new ImplementEnumerableAndEnumeratorDemo())
    .Build();

// Could this use LINQ as well?
allDemos[demoToRun].Run();