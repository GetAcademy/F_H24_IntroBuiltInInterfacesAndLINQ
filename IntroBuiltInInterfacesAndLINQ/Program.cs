using IntroBuiltInInterfacesAndLINQ;
using IntroBuiltInInterfacesAndLINQ.Demos;


const DemoName demoToRun = DemoName.Linq;

var allDemos = new DemoBuilder()
    .Add(DemoName.BuilderPattern, new BuilderPatternDemo())
    .Add(DemoName.Extension, new ExtensionDemo())
    .Add(DemoName.Linq, new LinqDemo())
    .Add(DemoName.Enumerable, new ImplementEnumerableAndEnumeratorDemo())
    .Build();

allDemos[demoToRun].Run();




