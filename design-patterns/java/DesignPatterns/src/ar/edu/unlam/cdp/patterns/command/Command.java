package ar.edu.unlam.cdp.patterns.command;

public abstract class Command {

	private String description;
	
	Command(String description) {
		this.description = description;
	}
	
	public abstract void execute();
	public abstract void undo();

	public String getDescription() {
		return description;
	}
	
}
