require_relative 'report'

class HTMLReport < Report
  def output_start
    p '<html>'
  end
  
  def output_head
    p '<head>'
    p "<title>#{title}</title>"
    p '</head>'
  end
  
  def output_body_start
    p '<body>'
  end
  
  def output_line(line)
    p "<p>#{line}</p>"
  end
  
  def output_body_end
    p '</body>'
  end
  
  def output_end
    p '</html>'
  end
end

