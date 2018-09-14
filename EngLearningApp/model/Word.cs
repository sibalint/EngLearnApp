namespace EngLearningApp.model
{
    enum KnownColor
    {
        Green,  //I really know this word
        Yellow, //I don't really know this word
        Red     //This is a totally new word for me
    }

    class Word
    {
        public string english;
        public string hungarian;

        public KnownColor knowledgeLevel;

        public Word()
        {

        }

        public Word(string eng, string hun)
        {
            this.english = eng;
            this.hungarian = hun;
            this.knowledgeLevel = KnownColor.Red;
        }

        public Word(string eng, string hun,KnownColor color)
        {
            this.english = eng;
            this.hungarian = hun;
            this.knowledgeLevel = color;
        }
    }
}
