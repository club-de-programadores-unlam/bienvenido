package ar.edu.unlam.cdp.patterns.command;

import java.io.File;
import java.io.IOException;
import java.nio.charset.Charset;

import com.google.common.io.Files;

public class CreateFile extends Command {

	private String path;
	private String contents;

	CreateFile(String description, String path, String contents) {
		super(description);
		this.path = path;
		this.contents = contents;
	}

	@Override
	public void execute() {

		File target = new File(this.path);
		
		try {
			
			Files.write(this.contents, target, Charset.defaultCharset());
			
		} catch (IOException e) {
			throw new RuntimeException(e);
		}

	}

	@Override
	public void undo() {
		
		File target = new File(this.path);
		target.delete();
		
	}

}
