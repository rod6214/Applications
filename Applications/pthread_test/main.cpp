#include"libraries.h"

void* ejemplo01(void* arg) 
{
	std::cout << "ejemplo01" << std::endl;
	return nullptr;
}

int main(int argc, char *argv[]) 
{
	pthread_t th;
	pthread_attr_t attr;
	pthread_attr_init(&attr);
	pthread_attr_setdetachstate(&attr, PTHREAD_CREATE_JOINABLE);
	pthread_create(&th, &attr, ejemplo01, 0);
	pthread_join(th, 0);
	pthread_attr_destroy(&attr);
	return 0;
}