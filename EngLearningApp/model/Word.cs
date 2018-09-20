namespace EngLearningApp.model
{
    public enum KnownColor
    {
        Green, //User know this word
        Red,   //User don't know this word
        Black  //Not words: Names, and others
        
    }

    public class Word
    {
        public string english;
        public string hungarian;
        public KnownColor knowledgeLevel;
        
        public Word(string eng, string hun,KnownColor color)
        {
            this.english = eng;
            this.hungarian = hun;
            this.knowledgeLevel = color;
        }
    }
}
