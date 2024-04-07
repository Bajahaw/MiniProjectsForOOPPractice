namespace TextApp
{
    public class Text 
    {
        private string text;
        public Text(string text)
        {
            this.text=text;
        }
        public int getCharacterOf(char c)
        {
           return text.IndexOf(c);
        }
        public int getConsonantsNumber()
        {
            return text.Length-getVowelsNumber();
        }
        public int getVowelsNumber()
        {
            int sum=0;
            for(int i=0;i<text.Length;i++)
            {
                if(text[i]=='i'||text[i]=='o'||text[i]=='e'||text[i]=='a'||text[i]=='u')
                {
                    sum++;
                }
            }
            return sum;
        }
        public string replaceCharacter(char oldChar, char newChar)
        {
            string newText=text;
            newText.Replace(oldChar,newChar);
            return newText;
        }
        public override string ToString()
        {
            return text;
        }
    }
}