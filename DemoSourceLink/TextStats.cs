namespace DemoSourceLink
{
    public class TextStats
    {
        public static readonly TextStats Zero = new TextStats(0, 0, 0, 0);

        public TextStats(int charCount, int wordCount, int sentenceCount, int paragraphCount)
        {
            CharCount = charCount;
            WordCount = wordCount;
            SentenceCount = sentenceCount;
            ParagraphCount = paragraphCount;
        }

        public int CharCount { get; }
        public int WordCount { get; }
        public int SentenceCount { get; }
        public int ParagraphCount { get; }
    }
}
