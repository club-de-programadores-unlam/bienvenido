require_relative 'report'

class PlainTextReport < Report
  def output_start
  end
  
  def output_head
    p "**** #{title} ****"
    puts
  end
  
  def output_body_start
  end
  
  def output_line(line)
    p line
  end
  
  def output_body_end
  end
  
  def output_end
  end
end
