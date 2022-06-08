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
        [Test]
        public void GivenMoodEmptyString_WhenCheckMood_ThenThrowException()
        {
            try
            {
                Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser("");
                string actualResult = checkMood.AnalyseMood();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Mood Shold not be Empty", e.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ReturnMoodAnalyserObject()
        {
            object expected = new Mood_Analyser.MoodAnalyser(null);
            object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyze("Mood_Analyser.MoodAnalyser", "Mood_Analyser.MoodAnalyser");
            expected.Equals(actual);
        }
        [Test]
        public void GivenMoodAnalyserInvalidClassName_ReturnNoSuchClassException()
        {
            try
            {
                object expected = new Mood_Analyser.MoodAnalyser(null);
                object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyze("Mood_Analyser.Mood", "Mood_Analyser.MoodAnalyser");
                expected.Equals(actual);
                //string actualResult = checkMood.AnalyseMood();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        [Test]
        public void GivenInvalidConstructorName_ReturnNoSuchMethodException()
        {
            try
            {
                object expected = new Mood_Analyser.MoodAnalyser(null);
                object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyze("Mood_Analyser.MoodAnalyser", "Mood_Analyser.Mood");
                expected.Equals(actual);                
            }
            catch (Exception e)
            {
                Assert.AreEqual("Method Not Found", e.Message);
            }
        }
        // TC-5.1-usingn perameterized constructor
        [Test]
        public void GivenPerameteConstructor_ReturnMoodAnalyserObject()
        {
            object expected = new Mood_Analyser.MoodAnalyser("I am in sad mood");
            object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyzeWithParamaterConstructor("Mood_Analyser.MoodAnalyser", "MoodAnalyser", "I am in sad mood");
            expected.Equals(actual);
        }
        [Test]
        public void GivenInvalidClassNameAndValidPerameterizedConstructor_ReturnNoSuchConstructor()
        {
            try
            {
                object expected = new Mood_Analyser.MoodAnalyser("I am in sad mood");
                object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyzeWithParamaterConstructor("Mood_Analyser.Mood", "MoodAnalyser", "I am in sad mood");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        [Test]
        public void GivenInvalidPerameterizedConstructor_ReturnNoSuchConstructor()
        {
            try
            {
                object expected = new Mood_Analyser.MoodAnalyser("I am in sad mood");
                object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyzeWithParamaterConstructor("Mood_Analyser.MoodAnalyser", "Mood", "I am in sad mood");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Constructor Not Found", e.Message);
            }
        }
        [Test]
        public void GivenHappyMoodReturnHappy()
        {
            string expected = "Happy";
            string findMood = Mood_Analyser.MoodAnalyserFactory.InvokeMoodAnalyser("happy", "AnalyseMood");
            Assert.AreEqual(expected, findMood);
        }
        [Test]
        public void GivenHappyinInvalidMood_ThrowException()
        {
            try
            {
                string expected = "Happy";
                string findMood = Mood_Analyser.MoodAnalyserFactory.InvokeMoodAnalyser("happy", "Analyse");
                Assert.AreEqual(expected, findMood);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Method Not Found", e.Message);
            }
        }
        //TectCase-7.1
        [Test]
        public void GivenHappyMoodDynamicRefactorReturnHappy()
        {
            string result = Mood_Analyser.MoodAnalyserFactory.SetField("Happy","mood");           
            Assert.AreEqual("Happy", result);
        }
        [Test]
        public void GivenHappyMoodAndInvalidFielsThrowException()
        {
            try
            {
                string result = Mood_Analyser.MoodAnalyserFactory.SetField("Happy", "testMood");
                Assert.AreEqual("Happy", result);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Field Not Found", e.Message);
            }
        }
        [Test]
        public void GivenInvalidMoodThrowException()
        {
            try
            {
                string result = Mood_Analyser.MoodAnalyserFactory.SetField("null", "mood");
                Assert.AreEqual("null", result);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Mood Should not be null", e.Message);
            }
        }
    }
}
