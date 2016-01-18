library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;
use ieee.std_logic_unsigned.all;

entity pwm_gen is
	port 
	(
		clk    : in std_logic;		
		trig      : in std_logic_vector(31 downto 0);
		max 	  : in std_logic_vector(31 downto 0);
		pwm : out std_logic
	);

end entity;

architecture behavioral of pwm_gen is
	signal current : integer;
	signal pwm_ur : std_logic;
begin

	process(clk)
	begin
		if rising_edge(clk) then		
			if current = max then
				current <= 0;
			else
				current <= current + 1;
			end if;
			pwm <= not pwm_ur;
		end if;		
	end process;

	pwm_ur <= '0' when current < trig else '1';

end architecture;
