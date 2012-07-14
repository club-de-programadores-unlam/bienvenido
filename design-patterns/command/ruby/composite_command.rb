require_relative 'command'

#Usage:
#cmds = CompositeCommand.new
#cmds << CreateFile.new('file1.txt', "hello world\n")
#cmds << CopyFile.new('file1.txt', 'file2.txt')

class CompositeCommand < Command
  def initialize
    @commands = []
  end
  
  def <<(cmd)
    @commands << cmd
  end
  
  def execute
    @commands.each { |cmd| cmd.execute }
  end
  
  def undo
    @commands.reverse_each { |cmd| cmd.undo }
  end
  
  def description
    @commands.inject('') do |desc, cmd|
      desc += "#{cmd.description}\n"
    end
  end
end