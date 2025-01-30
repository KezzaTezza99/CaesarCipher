**CaesarCipher**
---
A little application that can be used to encrypt plain text and decrypt Caesar Ciphers.
---
### To-do:
1. Allow the ability to save output as a text file
2. Encrypt / Decrypt text based on uploading a text file
3. Some error handling and general refactoring
---
## Demonstration:
![home-page](https://github.com/user-attachments/assets/8a1a7852-870d-43e8-a022-4058a55c27f3)

On launch you'll be given the choice to encrypt some plain-text or decrypt an already ciphered message!
---
## Encrypting text:
![encrypting-text](https://github.com/user-attachments/assets/aed42a4e-e9bf-4ea6-80ea-c5c754f5df89)

You have the ability to decide on the key you want to use to cipher the text, this key is used to shift the characters that amount in a direction depending on encrypting or decrypting.
---
## Decrypting text:
![suggested-decipher](https://github.com/user-attachments/assets/4e7cc146-4453-4488-962b-140c7dc30734)

The program will analyis the text and find the most reoccuring character, using basic analysis of the English language and that the most common letter used is 'E' then we can try and guess the key used by taken the most occured character in the string and subtracting the ascii value of 'E' will give us the correct key. 
As this is highly subjective it isn't always correct! So I give the user the option to use their own key and I'll show them the first decrypted word from the text that can update on each key value change. Allowing the user to eventually get a word that is plain english! When this happens we know we have the correct key and should continue with decryption.
---
## Decryption continued:
![decrypted-text](https://github.com/user-attachments/assets/b8a5d65f-3545-4d0c-8e3f-c2c8fb66d35d)
