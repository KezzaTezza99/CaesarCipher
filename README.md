## **CaesarCipher**
---
## A little application that can be used to encrypt plain text and decrypt Caesar Ciphers.
---
### To-do:
1. Allow the ability to save output as a text file
2. Encrypt / Decrypt text based on uploading a text file
3. Some error handling and general refactoring
---
## Demonstration:
![home-page](https://github.com/user-attachments/assets/f409daac-3721-4357-b3e4-b75ece870268)

On launch you'll be given the choice to encrypt some plain-text or decrypt an already ciphered message!

## Encrypting text:
![encrypting-text](https://github.com/user-attachments/assets/e9114a10-3e38-4ee3-a09c-2543b28328a2)


You have the ability to decide on the key you want to use to cipher the text, this key is used to shift the characters that amount in a direction depending on encrypting or decrypting.

## Decrypting text:
![suggested-decipher](https://github.com/user-attachments/assets/b64b6e4c-0534-404a-9e45-77001edaf8fa)


The program will analysis the text and find the most reoccurring character, using basic analysis of the English language and that the most common letter used is 'E' then we can try and guess the key used by taken the most occurred character in the string and subtracting the ascii value of 'E' will give us the correct key.
As this is highly subjective it isn't always correct! So I give the user the option to use their own key and I'll show them the first decrypted word from the text that can update on each key value change. Allowing the user to eventually get a word that is plain English! When this happens we know we have the correct key and should continue with decryption.

## Decryption continued:
![decrypted-text](https://github.com/user-attachments/assets/638c7566-764d-475e-8b9b-baa5f5708b27)
