// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdint.h>

int main()
{

	uint8_t  byte = 15;

	uint32_t bit_start = 1;
	uint32_t bit_count = 4;

	uint8_t mask = (0xff >> (8 - bit_count)) << bit_start;
	uint8_t result;
	byte &= mask;

	result = byte &mask;
	uint8_t d = sizeof(uint8_t);
    return 0;
}

