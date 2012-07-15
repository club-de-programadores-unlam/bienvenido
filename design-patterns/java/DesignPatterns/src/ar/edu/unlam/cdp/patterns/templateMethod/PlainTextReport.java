package ar.edu.unlam.cdp.patterns.templateMethod;

public class PlainTextReport extends Report {

	@Override
	public void outputLine(String line) {
		System.out.println(line);
	}
	@Override
	public void outputStart() {
	}

	@Override
	public void outputHead() {
		System.out.println("***** " + this.getTitle() + " *****");
	}

	@Override
	public void outputBodyStart() {
	}

	@Override
	public void outputBodyEnd() {
	}

	@Override
	public void outputEnd() {
	}

}
