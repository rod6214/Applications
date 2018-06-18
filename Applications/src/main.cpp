#include"stdargx.h"



void Evento01(nsys::Object& sender, nsys::EventArgs& args) 
{
	std::cout << "Evento01" << std::endl;
}

void Evento02(nsys::Object& sender, nsys::EventArgs& args) 
{
	std::cout << "Evento02" << std::endl;
}

int main(int argc, char *argv[]) 
{
	nsys::Event evt;
	evt += nsys::Delegate(Evento01);
	evt += nsys::Delegate(Evento02);
	evt.Invoke(nsys::Object(), nsys::EventArgs());
	return 0;
}