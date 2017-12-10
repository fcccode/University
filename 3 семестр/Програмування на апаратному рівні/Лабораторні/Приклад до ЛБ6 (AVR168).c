#define F_CPU 8000000
#include <avr/io.h>
#include <avr/interrupt.h>
#include <stdint.h>

volatile uint8_t counter;

int main (void){
    DDRC = 0xFF;  //sets PORTC as output
    PORTC = 0xFF; //initial output value
    /*COUNTER0 settings*/
    TIMSK0 = ((1<<OCIE0A) | (1<<OCIE0B));  // Enable Interrupt TimerCounter0 Compare Match A & B
    TCCR0A = (1<<WGM01);  // Mode = CTC
    TCCR0B = (1<<CS01) | (1<<CS00);   // Clock/64, 1/(8000000/64)= 0.000008 seconds per tick
    OCR0A = 200;      //   0.000008 *230 = 1.6 ms
    OCR0B = 100;      //     0.8 ms

    /*16bit timer - counter1 settings*/
    TIMSK1 &= ~(1<<OCIE1A); // Disable Interrupt Counter 1, output compare A (TIMER1_CMPA_vect)
    TCCR1B = ((1<<CS12) | (1<<CS10) | (1<<WGM12));    // Clock/1024, 1/(8000000/1024) = 0.000128 seconds per tick, Mode=CTC
    OCR1A = 40;                       // 0.000128*40 ~= 5.12 milliseconds

    sei(); //interrupts are globally switched on
    counter =0;
    while(1){
        if(counter >= 4){
            TCNT1 = 0; // clear the counter 1
            TIMSK1 = (1<<OCIE1A);// Enables the interrupt for Counter 1,(TIMER1_CMPA_vect)
            TIMSK0 &= ~((1<<OCIE0A) | (1<<OCIE0B)); //disables the Counter 0's interrupts
            counter = 0;
        }
    }
    return 0;
}

ISR(TIMER0_COMPA_vect){ //1.6ms
    PORTC = 0xFF;
    counter++;
}

ISR(TIMER0_COMPB_vect){  //0.8 ms
    PORTC = ~PORTC;
}

ISR(TIMER1_COMPA_vect){ // 5.2 milisecond interrupt
    PORTC = 0x00;
    TCNT0 = 0; //clear the counter of counter0
//  TIMSK0 = ((1<<OCIE0A) | (1<<OCIE0B)); //Enable the Counter 0 interrupts
//  TIMSK1 &= ~(1<<OCIE1A);// Disable Interrupt Counter 1, output compare A (TIMER1_CMPA_vect)
}

