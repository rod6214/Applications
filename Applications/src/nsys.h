#pragma once

#ifndef NSYS_H
#define NSYS_H
#include<list>
namespace nsys
{
	class Object {};

	class EventArgs : public Object {};

	class Delegate : public Object
	{
	public:
		typedef void(*Handle)(Object& sender, EventArgs& args);
		Delegate(void* fn) : _fun((Handle)fn) {}
		void Invoke(Object& sender, EventArgs& args);
	private:
		Handle _fun;
	};

	class Event : public Object
	{
	private:
		std::list<Delegate> _lstEvents;
	public:
		Event() {}
		Event& operator += (Delegate& del);
		void Invoke(Object& sender, EventArgs& args);
	};
}
#endif