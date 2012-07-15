package ar.edu.unlam.cdp.patterns.command;

import java.io.File;
import java.io.IOException;
import java.nio.charset.Charset;

import com.google.common.io.Files;

public class CopyFile extends Command {

	private File target;
	private File source;
	private String previousContents;

	CopyFile(String description, File source, File target) {
		super(description);
		this.source = source;
		this.target = target;
	}

	@Override
	public void execute() {

		try {

			if (this.target.exists()) {
				this.previousContents = Files.toString(this.target, Charset.defaultCharset());
			}

			Files.copy(this.source, this.target);
			
		} catch (IOException e) {
			throw new RuntimeException(e);
		}
	}

	@Override
	public void undo() {
		try {
			
			Files.write(this.previousContents, this.target, Charset.defaultCharset());
			
		} catch (IOException e) {
			throw new RuntimeException(e);
		}
	}

}
