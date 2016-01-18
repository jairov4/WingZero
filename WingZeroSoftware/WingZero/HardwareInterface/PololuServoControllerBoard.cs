using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace WingZero.HardwareInterface
{
	class PololuServoControllerBoard
    {
		SerialPort port;
		public PololuServoControllerBoard(string com, int baudrate)
		{
			//create new serial port object with certain comport and baudrate
			port = new SerialPort(com, baudrate, Parity.None, 8, StopBits.One);			
		}

        public void MiniSSC(int ServoNumber, int ServoPos) //Mini-SSC protocol
        {
            const int MIN_ANGLE = 0
                     ,MAX_ANGLE = 255;

            if (ServoPos < MIN_ANGLE)
            {
                throw new ArgumentException("The Servo Position being sent was SMALLER than the MIN Allowed.");
            }
            else if (ServoPos > MAX_ANGLE)
            {
                throw new ArgumentException("The Servo Position being sent was LARGER than the MAX Allowed.");
            }
                        
            // Open the port for communications
            if(!port.IsOpen) port.Open();
            //convert position into hex string
            string ServoPosHex = ServoPos.ToString("X");
            //convert position into single byte
            byte PositionByte = byte.Parse(ServoPosHex, System.Globalization.NumberStyles.HexNumber);
            //convert servo number into hex string
            string ServoNumberHex = ServoNumber.ToString("X");
            //convert servo number into single byte
            byte ServoNumberByte = byte.Parse(ServoNumberHex, System.Globalization.NumberStyles.HexNumber);

            //write 3 bytes, start byte, servo number, position
            port.Write(new byte[] { 0xFF, ServoNumberByte, PositionByte }, 0, 3);
			            
        }

        public void Pololu(int ServoNumber, int ServoPos, int ServoSpeed)
        {
            const int MIN_ANGLE = 1350
                    , MAX_ANGLE = 4350;
            //*********************************
            //********** POLOLU MODE **********
            //*********************************
            //# OF BYTES: 5 or 6
            //---------------------------------
            //     BYTE 1: Start Byte (0x80) 
            //     BYTE 2: Device type number (0x01 for 8 serial controller)
            //     BYTE 3: Specify Servo Command 
            //             COMMAND 0: Parameters (1 byte)
            //             COMMAND 1: Speed (1 byte)
            //             COMMAND 2: Position, 7 bit (1 byte) 
            //             COMMAND 3: Position, 8 bit (2 bytes)
            //             COMMAND 4: Position, Absolute (2 bytes)
            //             COMMAND 5: Neutral (2 bytes)
            //     BYTE 4: Servo Number 
            //     BYTE 5: Command Data Values (in conjunction with BYTE 3)
            //     BYTE 6: Command Data Values ((in conjunction with BYTE 3)(additional.  Not always necessary)


            //*************************************************************************************
            //FIRST: lets check to make sure our coordinates are within the mechanical range of servos
            //these variables are constants are defined in the beginning of the class.
            if (ServoPos < MIN_ANGLE)
            {
                throw new ArgumentException("The Servo Position being sent was SMALLER than the MIN Allowed.");
            }
            else if (ServoPos > MAX_ANGLE)
            {
                throw new ArgumentException("The Servo Position being sent was LARGER than the MAX Allowed.");
            }


            //code to convert integer servo position (500-5500) into 2 7 bit bytes.
            int[] binaryArray = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] upperBits = new int[6];
            int upperBitsInt = 0;
            int[] lowerBits = new int[7];
            int lowerBitsInt = 0;
            string[] binarystring = new string[13];
            //2^12 == 4096
            int pow = 4096;

            //MSB to LSB
            for (int i = 0; i < 13; i++)
            {
                if (ServoPos >= pow)
                {
                    binaryArray[i] = 1;
                    ServoPos = ServoPos - pow;
                    binarystring[i] = "1";
                }
                //reduce the power of 2
                pow = pow / 2;
            }
            //LOWER BITS
            //COPY 
            for (int i = 6; i < 12; i++)
            {
                lowerBits[i - 6] = binaryArray[i];
            }
            //convert lowerbits to decimal
            pow = 1;
            for (int i = 6; i >= 0; i--)  //start at 6 and go down so that we start with the LSB (pow = 1) and go up to the MSB
            {
                if (lowerBits[i] == 1)
                {
                    lowerBitsInt = lowerBitsInt + pow;
                }
                pow = pow * 2;
            }
            //UPPER BITS
            //COPY
            for (int i = 0; i < 6; i++)
            {
                upperBits[i] = binaryArray[i];
            }
            //convert upper bits to decimal
            pow = 1;
            for (int i = 5; i >= 0; i--) //start at 6 and go down so that we start with the LSB (pow = 1) and go up to the MSB
            {
                if (upperBits[i] == 1)
                {
                    upperBitsInt = upperBitsInt + pow;
                }
                pow = pow * 2;
            }
            string upperBitsHex = upperBitsInt.ToString("X");
            byte upperBitsByte = byte.Parse(upperBitsHex, System.Globalization.NumberStyles.HexNumber);

            string lowerBitsHex = lowerBitsInt.ToString("X");
            byte lowerBitsByte = byte.Parse(lowerBitsHex, System.Globalization.NumberStyles.HexNumber);

            //*************************************************************************************
			            
            // Open the port for communications            
			if (!port.IsOpen) port.Open();
                        
            //declare and initalize our first data byte at 0
            int data1 = 0;
            if (ServoPos > 127)
            {
                //set our first data byte (composed of 1 bit) to 1
                data1 = 1;
                ServoPos = ServoPos - 128;
            }
            string data1Hex = data1.ToString("X");
            byte data1Byte = byte.Parse(data1Hex, System.Globalization.NumberStyles.HexNumber);

            //convert SPEED into hex string
            string ServoSpeedHex = ServoSpeed.ToString("X");
            //convert into single byte
            byte SpeedByte = byte.Parse(ServoSpeedHex, System.Globalization.NumberStyles.HexNumber);

            //take servo number and convert into hex
            string ServoNumberHex = ServoNumber.ToString("X");
            //convert into single byte
            byte ServoNumberByte = byte.Parse(ServoNumberHex, System.Globalization.NumberStyles.HexNumber);

            //first send SPEED command
			//port.Write(new byte[] { 
			//    0x80, //synch value (always 0x80)
			//    0x01, //device ID (0x01 for 8 servo controller)
			//    0x01, //servo command (setting speed is command 1)
			//    ServoNumberByte, //servo number
			//    SpeedByte, //Data Byte 1: Speed.  0 = instant, 1-127 accel control (0 = quickest, 127 = slowest)
			//               //Data Byte 2: Unnecessary for setting speed.
			//}, 0, 5);

            //second, send ABSOLUTE POSITION command
            //we will use absolute position because we do not need to set the neutral position.
            port.Write(new byte[] { 
                0x80, //synch value (always 0x80)
                0x01, //device ID (0x01 for 8 servo controller)
                0x04, //servo command (command 4 == Absolute Position (2bytes) )
                ServoNumberByte, //servo number
                upperBitsByte, //Data Byte 1: This byte is composed of the upper bits of an integer ranging from 500-5500.
                               //             This is so because we are trying to send 13 bits to a controller which can only read 7,
                               //             therefore the upper 6 bits must be sent in one byte, and later we will send the lower 7.
                lowerBitsByte //Data Byte 2: Byte 2 is composed of the 7 remaining bits (from bit 0 up to and including bit 6)
            }, 0, 6);			            
        }//Pololu Fnc

		public void Open()
		{
			port.Open();
		}

		public void Close()
		{
			port.Close();
		}
    }//class

}
