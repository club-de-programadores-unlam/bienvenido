package ar.edu.unlam.cdp.patterns.strategy;

public class HTMLFormatter implements FormatStrategy{

	
	public void outputReport(Report context) {
		
		System.out.println("<html>");
		System.out.println("<head>");
		System.out.println("<title>" + context.getTitle() + "</title>");
		System.out.println("</head>");
		System.out.println("<body>");
		for (String line : context.getText()) {
			System.out.println("<p>" + line + "</p>");
		}
		System.out.println("</body>");
		System.out.println("</html>");
		
	}
	
	
}
