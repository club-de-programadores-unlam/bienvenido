#!/usr/bin/env ruby

require_relative 'html_report'
require_relative 'plain_text_report'

if __FILE__ == $0
  report = HTMLReport.new
  report.output_report
  
  report = PlainTextReport.new
  report.output_report
end
