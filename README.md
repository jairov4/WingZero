# WingZero
Arm Robot Controller application to handle and simulate its behavior. 

It uses DirectInput and XNA to get access to joystick and 3D rendering of robot state. 
It uses JTAG Avalon DLL from Altera to comunicate to FPGA movement commanding and feed servo motors.
That native DLL is used with marshaling to interoperate with this C# project. 

Joystick data feeds to an Inverse Kinematic Solver to based on Desdendant Gradient to get robot articulation positions.
