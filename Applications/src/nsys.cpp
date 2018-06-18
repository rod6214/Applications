
#include"nsys.h"

namespace nsys 
{
	void Delegate::Invoke(Object& sender, EventArgs& args) 
	{
		_fun(sender, args);
	}

	Event& Event::operator += (Delegate& del) 
	{
		_lstEvents.push_back(del);
		return *this;
	}

	void Event::Invoke(Object& sender, EventArgs& args) 
	{
		std::list<Delegate>::iterator it = _lstEvents.begin();
		std::list<Delegate>::iterator et = _lstEvents.end();
		for (; it != et; ++it)
			(*it).Invoke(sender, args);
	}
}