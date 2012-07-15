package ar.edu.unlam.cdp.patterns.command;

public class Button {

	private Command command;
	
	public Button(Command command) {
		this.command = command;
	}
	
	// Other button stuff :)
	
	public void click(){
		this.command.execute();
	}
	
}
