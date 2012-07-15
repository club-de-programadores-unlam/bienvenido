package ar.edu.unlam.cdp.patterns.command;

import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

public class CompositeCommand extends Command {

	List<Command> commands = new LinkedList<Command>();
	
	CompositeCommand() {
		super("");
	}

	public void add(Command command) {
		this.commands.add(command);
	}
	
	@Override
	public void execute() {
		for (Command command : this.commands) {
			command.execute();
		}
	}

	@Override
	public void undo() {
		Collections.reverse(this.commands);
		for (Command command : this.commands) {
			command.execute();
		}
		Collections.reverse(this.commands);
	}

	@Override
	public String getDescription(){
		String desc = "";
		for (Command command : this.commands) {
			desc = desc + command.getDescription() + "\n";
		}
		return desc;
	}
	
}
