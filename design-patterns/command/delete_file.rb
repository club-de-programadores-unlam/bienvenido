require_relative 'command'

class DeleteFile < Command
  attr_reader :path
  
  def initialize(path)
    super "Delete file: #{path}"
    @path = path
  end
  
  def execute
    @contents = File.read(path) if File.exists?(path)
    File.delete(@path)
  end
  
  def undo
    File.open(path, 'w') do |f|
      f << @contents
    end
  end
end