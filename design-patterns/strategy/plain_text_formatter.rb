class PlainTextFormatter
  def output_report(context)
    p "***** #{context.title} *****"
    context.text.each do |line|
      p line
    end
  end
end

#PLAIN_TEXT_FORMATTER = lambda do |context|
#    p "***** #{context.title} *****"
#    context.text.each do |line|
#      p line
#    end
#end
