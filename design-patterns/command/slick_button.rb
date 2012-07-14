class Button
  attr_accessor :command
  
  def initialize(&block)
    @command = block
  end
  #
  # Lots of button drawing and management
  # code omitted...
  #
  def on_button_clicked
    command.call if command
  end
end