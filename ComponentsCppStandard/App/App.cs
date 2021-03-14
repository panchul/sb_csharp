
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

class App : IFrameworkViewSource, IFrameworkView
{
    static void Main()
    {
        CoreApplication.Run(new App());
    }

    public IFrameworkView CreateView()
    {
        return this;
    }

    public void SetWindow(CoreWindow window)
    {
        Sample.Hen hen = new Sample.Hen();

        hen.Cluck();
    }

    public void Run()
    {
        CoreWindow window = CoreWindow.GetForCurrentThread();
        window.Activate();

        CoreDispatcher dispatcher = window.Dispatcher;
        dispatcher.ProcessEvents(CoreProcessEventsOption.ProcessUntilQuit);
    }

    public void Initialize(CoreApplicationView view)
    {
        
    }

    public void Load(string args)
    {

    }

    public void Uninitialize()
    {

    }
}