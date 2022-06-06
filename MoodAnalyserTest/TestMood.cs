namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenMood_CheckMood_ReturnResultAsSad()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser();
            string actualResult = checkMood.AnalyseMood("I am in sad mood");
            Assert.AreEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMood_CheckMood_ReturnResultAsHappy()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser();
            string actualResult = checkMood.AnalyseMood("Hai, Today i am in any mood");
            Assert.AreNotEqual("Sad", actualResult);
        }

    }
}