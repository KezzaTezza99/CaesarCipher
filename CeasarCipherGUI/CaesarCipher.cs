using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CeasarCipherGUI
{
    internal class CaesarCipher
    {
        protected string m_inputText = string.Empty;
        protected string m_outputFilename = string.Empty;
        protected int m_suggestedKey;
        protected string m_suggestedDecipherText = string.Empty;
        
        protected int m_key;
        int[] m_alphabetCount = new int[26];
       
        public CaesarCipher(string _inputText)
        {
            m_inputText = _inputText;
        }

        public string EncryptText()
        {
            string output = String.Empty;
           
            for (int i = 0; i < m_inputText.Length; i++)
            {
                // Get the current character from the string
                char currentChar = m_inputText[i];

                // Check to ensure that the character is apart of the Roman Alphabet
                if (char.IsLetter(currentChar))
                {
                    // Is the character uppercase or lowercase?
                    if (char.IsUpper(currentChar))
                    {
                        // Shift backwards by key value and wrap around if necessary
                        output += (char)((((currentChar - 'A' + m_key + 26) % 26) + 'A'));
                    }
                    else
                    {
                        // Character is lowercase 
                        output += (char)((((currentChar - 'a' + m_key + 26) % 26) + 'a'));
                    }
                }
                else
                {
                    // Character is not part of the alphabet such as (! ?) etc
                    output += currentChar;
                }
            }

            return output;
        }

        public string DecryptText() 
        {
            int i;
            string output = String.Empty;

            for (i = 0; i < m_inputText.Length; i++) {
                // Get the current character from the string
                char currentChar = m_inputText[i];

                // Check to ensure that the character is apart of the Roman Alphabet
                if (char.IsLetter(currentChar)) {
                    // Is the character uppercase or lowercase?
                    if (char.IsUpper(currentChar)) {
                        // Shift backwards by key value and wrap around if necessary
                        output += (char)((((currentChar - 'A' - m_key + 26) % 26) + 'A'));
                    } else {
                        // Character is lowercase 
                        output += (char)((((currentChar - 'a' - m_key + 26) % 26) + 'a'));
                    }
                } else {
                    // Character is not part of the alphabet such as (! ?) etc
                    output += currentChar;
                }
            }

            return output;
        }

        // Useful utility methods
        public void AnalysisOfText()
        {
            // We need to know the occurance of characters in the input string
            GetCharacterCountFromInputText();

            // Using the analysis of English Language we can make an educated guess that the key to
            // use to decipher the text is 'E' as this is the most frequently used character in english
            char analysisCharacter = 'e';

            // Finding the most reoccuring character from the text
            int indexOfMaxOccurignCharacter = MaxIndex();
            char maxCharacter = (char)((char)indexOfMaxOccurignCharacter + 'a');

            // Suggesting a key by educating a guess that maxCharacter - e will be correct
            // As the key is Integer and not Char we need to subtract 'a' to get the values position in the alphabet
            int suggestedKey = (maxCharacter - 'a') - (analysisCharacter - 'a');

            // Suggesting this key to the user
            m_suggestedKey = suggestedKey;

            // TODO: Would then get user input, i.e., continue with the suggested key or enter a new one
            // TODO: Could then show them a suggested decrypted word using that key?
            m_suggestedDecipherText = PartialDecipher();
        }

        private int MaxIndex()
        {
            // Used to find the max value
            int maxValue = 0;
            int indexOfMaxValue = -1;

            // Looping through the alphabet
            for(int i = 0; i < 26; i++)
            {
                if (m_alphabetCount[i] > maxValue)
                {
                    maxValue = m_alphabetCount[i];
                    indexOfMaxValue = i;
                }
            }

            return indexOfMaxValue;
        }

        private void GetCharacterCountFromInputText()
        {
            // Looping through the entire string
            for (int i = 0; i < m_inputText.Length; i++)
            {
                char currentChar = m_inputText[i];

                // Checking if character in the string is part of the Alphabet
                if (char.IsLetter(currentChar))
                {
                    // Checking to see if the character is uppercase or lowercase as both need to be counted as the same value
                    if (char.IsUpper(currentChar))
                    {
                        // Increasing the count at the character index in the alphabet
                        // Need to subtract "A" (as char is capital) or  65 to get the characters position in alphabet
                        m_alphabetCount[currentChar - 'A']++;
                    }
                    else
                    {
                        // Subtracting 'a' or 97 as the current character is lowercase this will give the same index
                        // as uppercase characters which means the same character will be counted both uppercase and lowercase
                        m_alphabetCount[currentChar - 'a']++;
                    }
                }
            }
        }

        //TODO: CODE IS NOT DRY
        private string PartialDecipher()
        {
            int i;
            string output = String.Empty;
            int spaceIndex = m_inputText.IndexOf(' ');
            string word = m_inputText.Substring(0, spaceIndex);

            for (i = 0; i < word.Length; i++)
            {
                // Get the current character from the string
                char currentChar = word[i];

                // Check to ensure that the character is apart of the Roman Alphabet
                if (char.IsLetter(currentChar))
                {
                    // Is the character uppercase or lowercase?
                    if (char.IsUpper(currentChar))
                    {
                        // Shift backwards by key value and wrap around if necessary
                        output += (char)((((currentChar - 'A' - m_suggestedKey + 26) % 26) + 'A'));
                    }
                    else
                    {
                        // Character is lowercase 
                        output += (char)((((currentChar - 'a' - m_suggestedKey + 26) % 26) + 'a'));
                    }
                }
                else
                {
                    // Character is not part of the alphabet such as (! ?) etc
                    output += currentChar;
                }
            }

            return output;
        }

        // Getters and Setters
        public void SetCipherKey(int _key) { m_key = _key; }
        public int GetSuggestedCipherKey() { return m_suggestedKey; }
        public string GetSuggestedDecipheredWord() { return m_suggestedDecipherText; }
        public void SetKeyToBeSuggestedKey() { m_key = m_suggestedKey; }
    } //!CaesarCipher
} //!CeasarCipherGUI