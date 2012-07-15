package ar.edu.unlam.cdp.patterns.command;

import java.io.File;
import java.io.IOException;
import java.nio.charset.Charset;

import com.google.common.io.Files;

public class DeleteFile extends Command {

	private String path;
	private String previousContents;

	DeleteFile(String description, String path) {
		super(description);
		this.path = path;
	}

	@Override
	public void execute() {

		try {
			
			File target = new File(this.path);

			if (target.exists()) {
				this.previousContents = Files.toString(target, Charset.defaultCharset());
			}

			target.delete();
			
		} catch (IOException e) {
			throw new RuntimeException(e);
		}
	}

	@Override
	public void undo() {
		try {
			
			File target = new File(this.path);
			Files.write(this.previousContents, target, Charset.defaultCharset());
			
		} catch (IOException e) {
			throw new RuntimeException(e);
		}
	}

}
