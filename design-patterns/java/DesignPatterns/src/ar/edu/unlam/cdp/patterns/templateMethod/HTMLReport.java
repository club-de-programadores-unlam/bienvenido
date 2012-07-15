package ar.edu.unlam.cdp.patterns.templateMethod;

public class HTMLReport extends Report {

	@Override
	public void outputLine(String line) {
		System.out.println("<p>" + line + "</p>");
	}

	@Override
	public void outputStart() {
		System.out.println("<html>");
	}

	@Override
	public void outputHead() {
		System.out.println("<head>");
		System.out.println("<title>" + this.getTitle() + "</title>");
		System.out.println("</head>");
	}

	@Override
	public void outputBodyStart() {
		System.out.println("<body>");
	}

	@Override
	public void outputBodyEnd() {
		System.out.println("</body>");
	}

	@Override
	public void outputEnd() {
		System.out.println("</html>");
	}

}
