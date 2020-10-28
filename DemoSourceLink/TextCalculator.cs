using Microsoft.Extensions.Logging;

namespace DemoSourceLink
{
    public class TextCalculator : TextCalculatorBase
    {
        public TextCalculator(ILogger<TextCalculator> logger)
            : base(logger)
        {
        }

        protected override TextStats CalculateStatsCore(string document)
        {
            int charCount = 0;
            int wordCount = 1;
            int sentenceCount = 1;
            int paragraphCount = 1;
            foreach (char c in document)
            {
                charCount++;
                switch (c)
                {
                    case ' ':
                        wordCount++;
                        break;

                    case '.':
                        sentenceCount++;
                        break;

                    case '\r':
                    case '\n':
                        paragraphCount++;
                        break;
                }
            }
            return  new TextStats(charCount, wordCount, sentenceCount, paragraphCount);
        }
    }
}
