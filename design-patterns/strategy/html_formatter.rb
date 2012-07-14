class HTMLFormatter
  def output_report(context)
    p '<html>'
    p '<head>'
    p "<title>#{context.title}</title>"
    p '</head>'
    p '<body>'
    context.text.each do |line|
      p "<p>#{line}</p>"
    end
    p '</body>'
    p '</html>'
  end
end
