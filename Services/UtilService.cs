using AccentureChallenge.Interfaces;

namespace AccentureChallenge.Services
{
    public class UtilService : IUtilService
    {
        #region Task 4: Problem-Solving
        public bool CheckPalindrome(string word)
        {
            // Transforms the word given into a char array divinding each letter
            char[] reversed = word.ToCharArray();

            // Inverts the char array
            Array.Reverse(reversed);

            // Stores the completely inverted word in the variable
            string newWord = new string(reversed);

            // Returns if the inverted word is the same as the original word
            return word.Equals(newWord);            
        }
        #endregion
    }
}
