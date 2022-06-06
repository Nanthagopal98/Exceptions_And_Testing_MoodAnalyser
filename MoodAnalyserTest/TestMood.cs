namespace MoodAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenMood_CheckMood_ReturnResultAsSad()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser("I am in sad mood");
            string actualResult = checkMood.AnalyseMood();
            Assert.AreEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMood_CheckMood_ReturnResultAsHappy()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser("I am in any mood");
            string actualResult = checkMood.AnalyseMood();
            Assert.AreNotEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMoodNull_WhenCheckMood_ThenThrowException()
        {
            try
            {
                Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser(null);
                string actualResult = checkMood.AnalyseMood();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Mood Should not be null", e.Message);
            }
        }
    }
}