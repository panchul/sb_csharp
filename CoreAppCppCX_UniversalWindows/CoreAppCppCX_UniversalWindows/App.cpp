#include "pch.h"

using namespace Platform;
using namespace Windows::ApplicationModel::Core;
using namespace Windows::UI::Core;

ref class App : IFrameworkViewSource, IFrameworkView
{
public:

	virtual IFrameworkView^ CreateView()
	{
		return this;
	}

	virtual void SetWindow(CoreWindow^ window)
	{

	}

	virtual void Run()
	{
		CoreWindow^ window = CoreWindow::GetForCurrentThread();
		window->Activate();

		CoreDispatcher^ dispatcher = window->Dispatcher;
		dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessUntilQuit);
	}

	virtual void Initialize(CoreApplicationView^ view)
	{

	}

	virtual void Load(String^ args)
	{

	}

	virtual void Uninitialize()
	{

	}
};

int main(Array<String^>^ args)
{
	CoreApplication::Run(ref new App);
}
