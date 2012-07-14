class Report
  attr_reader :title, :text

  def initialize
    @title = 'Monthly Report'
    @text = ['Things are going', 'really, really well.']
  end
  
  def output_report
    output_start
    output_head
    output_body_start
    output_body
    output_body_end
    output_end
  end
  
  def output_body
    text.each do |line|
      output_line(line)
    end
  end
  
  def output_start
    raise "Called abstract method: #{__method__}"
  end
  
  def output_head
    raise "Called abstract method: #{__method__}"
  end
  
  def output_body_start
    raise "Called abstract method: #{__method__}"
  end
  
  def output_line(line)
    raise "Called abstract method: #{__method__}"
  end
  
  def output_body_end
    raise "Called abstract method: #{__method__}"
  end
  
  def output_end
    raise "Called abstract method: #{__method__}"
  end
end
