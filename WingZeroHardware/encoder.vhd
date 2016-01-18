library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;
use ieee.STD_LOGIC_ARITH.all;
use ieee.std_logic_unsigned.all;

entity encoder is
	port 
	(
		clk		: in std_logic;
		dataout	: out std_logic_vector(31 downto 0);	
		reset	: in std_logic;
		p0		: in std_logic;
		p1		: in std_logic
	);
end entity;

architecture behavioral of encoder is
	signal prev_p0 : std_logic;
	signal prev_p1 : std_logic;
	type lastchange_t is (change_p0, change_p1, change_none);
	signal lastchange : lastchange_t := change_none;
	signal current : integer := 0;
begin
	process(clk, reset) 
	begin
		if reset = '1' then 
			current <= 0;
		elsif rising_edge(clk) then			
			-- estado pasado para deteccion de cambio
			prev_p0 <= p0;
			prev_p1 <= p1;
			
			-- avance o retroceso
			if    not (p0 = prev_p0) and p0 = p1 and lastchange = change_p1 then
				current <= current + 1;				
			elsif not (p1 = prev_p1) and p1 = p0 and lastchange = change_p0 then 
				current <= current - 1;
			end if;
			
			-- last change
			if not (p0 = prev_p0) then
				lastchange <= change_p0;
			elsif not (p1 = prev_p1)  then				
				lastchange <= change_p1;			
			end if;			
			
		end if;
	end process;
	
	dataout <= conv_std_logic_vector(current, 32);
	
end architecture;