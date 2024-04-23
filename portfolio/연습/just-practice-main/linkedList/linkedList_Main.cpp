#include"linkedList.h"

#include<iostream>
using namespace std;


int main()
{
	tLinkedList list = {};
	
	InitList(&list);
	PushBack(&list, 100);
	PushBack(&list, 200);

	PushBack(&list, 300);
	PushBack(&list, 400);
	PushBack(&list, 500);



	return 0;
}