package ar.edu.unlam.cdp.patterns.strategy;

import org.junit.Test;

public class StrategyTest {

	@Test
	public void testStrategy(){

		Report report1 = new Report(new HTMLFormatter());
		report1.outputReport();
		
		Report report2 = new Report(new PlainTextFormatter());
		report2.outputReport();
		
	}

}
