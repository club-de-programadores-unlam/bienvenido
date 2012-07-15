package ar.edu.unlam.cdp.patterns.strategy;

public class PlainTextFormatter implements FormatStrategy {

	public void outputReport(Report context) {

		System.out.println("***** " + context.getTitle() + " *****");
		for(String line : context.getText()){
			System.out.println(line);
		}
		
	}

}
