class Command
  attr_reader :description
  
  def initialize(description)
    @description = description
  end
  
  def execute
  end
  
  def undo
  end
end