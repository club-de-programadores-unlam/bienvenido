require 'fileutils'

require_relative 'command'

class CopyFile < Command
  attr_reader :source, :target
  
  def initialize(source, target)
    super "Copy file: #{source} to #{target}"
    @source, @target = source, target
  end
  
  def execute
    @contents = File.read(target) if File.exists?(target)
    FileUtils.copy source, target
  end
  
  def undo
    File.open(target, 'w') do |f|
      f << @contents
    end
  end
end