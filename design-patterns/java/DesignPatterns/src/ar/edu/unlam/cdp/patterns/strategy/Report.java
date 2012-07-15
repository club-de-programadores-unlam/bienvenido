package ar.edu.unlam.cdp.patterns.strategy;

import java.util.LinkedList;
import java.util.List;

public class Report {

	private String title;
	private List<String> text = new LinkedList<String>();
	private FormatStrategy formatter;
	
	public Report(FormatStrategy formatter) {
		this.title = "Monthly Report";
		this.text.add("Things are going");
		this.text.add("really, really well.");
		this.formatter = formatter;
	}
	
	public void outputReport(){
		this.formatter.outputReport(this);
	}

	public String getTitle() {
		return title;
	}

	public List<String> getText() {
		return text;
	}

}
