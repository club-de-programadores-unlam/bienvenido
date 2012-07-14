require_relative 'command'

class CreateFile < Command
  attr_reader :path, :contents
  
  def initialize(path, contents)
    super "Create file: #{path}"
    @path = path
    @contents = contents
  end
  
  def execute
    File.open(path, "w") do |f|
      f.write(contents)
    end
  end
  
  def undo
    File.delete path
  end
end
