namespace MyGameNamespace
{
    [System.Serializable]
    public class ScoreEntry
    {
        public string playerName;
        public float score;

        public ScoreEntry(string playerName, float score)
        {
            this.playerName = playerName;
            this.score = score;
        }
    }
}