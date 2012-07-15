package ar.edu.unlam.cdp.patterns.templateMethod;

import java.util.LinkedList;
import java.util.List;

public abstract class Report {

	private String title;
	private List<String> text = new LinkedList<String>();
	
	public Report() {
		this.title = "Monthly Report";
		this.text.add("Things are going");
		this.text.add("really, really well.");
	}
	
	public final void outputReport(){
	    this.outputStart();
	    this.outputHead();
	    this.outputBodyStart();
	    this.outputBody();
	    this.outputBodyEnd();
	    this.outputEnd();
	}
	
	public void outputBody() {
		for (String line : this.text) {
			this.outputLine(line);
		}
	}
	
	public abstract void outputLine(String line);

	public abstract void outputStart();
	public abstract void outputHead();
	public abstract void outputBodyStart();
	public abstract void outputBodyEnd();
	public abstract void outputEnd();

	public String getTitle() {
		return title;
	}

	public List<String> getText() {
		return text;
	}

}
