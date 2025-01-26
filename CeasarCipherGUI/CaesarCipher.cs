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

        protected int m_key;
        int[] m_alphabetCount = new int[26];
       
        //// This constructor will be called when the user wants to pass in text from the GUI to encrypt
        //public CaesarCipher(ref string _plainText)
        //{
        //    m_plainText = _plainText;
        //}

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
            int key = 3;

            for (i = 0; i < m_inputText.Length; i++) {
                // Get the current character from the string
                char currentChar = m_inputText[i];

                // Check to ensure that the character is apart of the Roman Alphabet
                if (char.IsLetter(currentChar)) {
                    // Is the character uppercase or lowercase?
                    if (char.IsUpper(currentChar)) {
                        // Shift backwards by key value and wrap around if necessary
                        output += (char)((((currentChar - 'A' - key + 26) % 26) + 'A'));
                    } else {
                        // Character is lowercase 
                        output += (char)((((currentChar - 'a' - key + 26) % 26) + 'a'));
                    }
                } else {
                    // Character is not part of the alphabet such as (! ?) etc
                    output += currentChar;
                }
            }

            return output;
        }

        // Useful utility methods
        private void AnalysisOfText()
        {
            // Using the analysis of English Language we can make an educated guess that the key to
            // use to decipher the text is 'E' as this is the most frequently used character in english
            char analysisCharacter = 'e';

            // Finding the most reoccuring character from the text
            int indexOfMaxOccurignCharacter = MaxIndex(m_alphabetCount);
            char maxCharacter = (char)((char)indexOfMaxOccurignCharacter + 'a');

            // Suggesting a key by educating a guess that maxCharacter - e will be correct
            // As the key is Integer and not Char we need to subtract 'a' to get the values position in the alphabet
            int suggestedKey = (maxCharacter - 'a') - (analysisCharacter - 'a');

            // Suggesting this key to the user
            //TODO: Will need to change a label to be this value!

            // TODO: Would then get user input, i.e., continue with the suggested key or enter a new one
            // TODO: Could then show them a suggested decrypted word using that key?
        }

        private int MaxIndex(int[] _alphabet)
        {
            // Used to find the max value
            int maxValue = 0;
            int indexOfMaxValue = -1;

            // Looping through the alphabet
            for(int i = 0; i < 26; i++)
            {
                if (_alphabet[i] >= maxValue)
                {
                    maxValue = _alphabet[i];
                    indexOfMaxValue = i;
                }
            }

            return maxValue;
        }

        // Getters and Setters
        public void SetCipherKey(int _key)
        {
            m_key = _key;
        }

        public int GetCipherKey() { return m_key; }
    } //!CaesarCipher
} //!CeasarCipherGUI