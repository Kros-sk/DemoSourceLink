using Microsoft.Extensions.Logging;

namespace DemoSourceLink
{
    public abstract class TextCalculatorBase : ITextCalculator
    {
        private readonly ILogger<TextCalculatorBase> _logger;

        public TextCalculatorBase(ILogger<TextCalculatorBase> logger)
        {
            _logger = logger;
        }

        public TextStats CalculateStats(string document)
        {
            if (string.IsNullOrWhiteSpace(document))
            {
                _logger.LogInformation("Empty document provided.");
                return TextStats.Zero;
            }
            var stats = CalculateStatsCore(document);
            _logger.LogInformation("Document calculated: chars = {0}, words = {1}, sentences = {2}, paragraphs = {3}",
                stats.CharCount, stats.WordCount, stats.SentenceCount, stats.ParagraphCount);
            return stats;
        }

        protected abstract TextStats CalculateStatsCore(string document);
    }
}
