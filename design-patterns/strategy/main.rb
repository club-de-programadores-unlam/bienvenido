require_relative 'report'
require_relative 'html_formatter'
require_relative 'plain_text_formatter'

if __FILE__ == $0
  html_formatter = HTMLFormatter.new
  Report.new(html_formatter).output_report
  
  plain_text_formatter = HTMLFormatter.new
  Report.new(plain_text_formatter).output_report
  
  #Report.new(&PLAIN_TEXT_FORMATTER).output_report
  
  #report = Report.new do |context|
  #  p "***** #{context.title} *****"
  #  context.text.each do |line|
  #    p line
  #  end
  #end
  #report.output_report
end
