package ar.edu.unlam.cdp.patterns.templateMethod;

import org.junit.Test;

public class TemplateMethodTest {

	@Test
	public void testTemplateMethod(){

		Report report1 = new HTMLReport();
		report1.outputReport();
		
		Report report2 = new PlainTextReport();
		report2.outputReport();
		
	}

}
