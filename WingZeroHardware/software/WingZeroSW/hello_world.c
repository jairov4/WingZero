#include <stdio.h>
#include "system.h"
#include <altera_avalon_pio_regs.h>

#define NDIGITS 8
#define CMD_CHAR ('f')

alt_u32 freq = 20.0e-3f*(float)ALT_CPU_FREQ;
alt_u32 trigger[4] = {0};
//{ 
//    1.0e-3f*(float)ALT_CPU_FREQ, 
//    0.9e-3f*(float)ALT_CPU_FREQ, 
//    2.0e-3f*(float)ALT_CPU_FREQ, 
//    1.3e-3f*(float)ALT_CPU_FREQ 
//};


void ProcessCommand(void)
{           
    alt_u8 servo;
    alt_u8 dutyH, dutyM, dutyL;
        
    fread(&servo, 1, 1, stdin);
    if((servo & 0xFC) != 0x80) return; // 1000 00xx
    servo = servo & 0x03;
    
    fread(&dutyH, 1, 1, stdin); // 0xxx xxxx
    if(dutyH & 0x80) return;
    
    fread(&dutyM, 1, 1, stdin); // 0xxx xxxx
    if(dutyM & 0x80) return;
    
    fread(&dutyL, 1, 1, stdin); // 0xxx xxxx
    if(dutyL & 0x80) return;
        
    if(servo < 4) 
    {
        trigger[servo] = (dutyH << 14)| (dutyM << 7) | dutyL;
    }
}

void ShowInfoChannel(int c) {
    const float clock = (float)ALT_CPU_FREQ/1000000.0f;
    printf("Channel: %d\n", c);
    printf("Freq: %u\n", freq);
    printf("Trig: %u\n", trigger[c]);
    printf("Duty: %f\n", (float)trigger[c]/(float)freq);    
    printf("High time: %0.3f ms\n", (float)trigger[c]/clock/1000.0f);
    printf("Total cycle: %0.2f ms\n", (float)freq/clock/1000.0f);
    printf("Freq Hz: %0.2f kHz\n\n", 1.0f/((float)freq/clock/1000.0f));          
}

void UpdateChannels(void) 
{
    IOWR_ALTERA_AVALON_PIO_DATA(PIO_0_BASE, trigger[0]);
    IOWR_ALTERA_AVALON_PIO_DATA(PIO_1_BASE, trigger[1]);
    IOWR_ALTERA_AVALON_PIO_DATA(PIO_2_BASE, trigger[2]);
    IOWR_ALTERA_AVALON_PIO_DATA(PIO_3_BASE, trigger[3]);
    IOWR_ALTERA_AVALON_PIO_DATA(PIO_CTL_BASE, freq);
}

int main()
{   
    printf("Boot complete\n");
    fflush(stdin);
    
    while(1) {
        UpdateChannels();
//        ShowInfoChannel(0);
//        ShowInfoChannel(1);
//        ShowInfoChannel(2);
//        ShowInfoChannel(3);
        ProcessCommand();
    }
    return 0;
}

