using IntroBuiltInInterfacesAndLINQ.Demos;

const DemoName demoToRun = DemoName.Linq;

var allDemos = new DemoBuilder()
    .Add<ExtensionDemo>()
    .Add<LinqDemo>()
    .Add<ImplementEnumerableAndEnumeratorDemo>()
    .Build();

allDemos[demoToRun].Run();