using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WordManager : MonoBehaviour {

     public List<Word> words;

     public WordSpawner wordSpawner;

     public GameObject restartButton;
     private bool hasActiveWord;

     private Word activeWord;

     private void Start() 
     {
         Time.timeScale = 1f;
         AddWord();
         AddWord();
     }
     public void AddWord()
     {

         Word word = new Word(WordGenerator.GetRandomWord(),wordSpawner.SpawnWord());

         words.Add(word);
     }
     public void TypeLetter(char letter)
     {
         if (hasActiveWord)
         {
             // Check if letter was next
             // Remove it from the word
             if (activeWord.GetNextLetter() == letter)
             {
                 activeWord.TypeLetter();
             }

         }else
         {
             foreach (Word word in words)
             {
                 if(word.GetNextLetter() == letter )
                 {
                     activeWord = word;
                     hasActiveWord = true;
                     word.TypeLetter();
                     break;
                 }
             }

         }
         if(hasActiveWord && activeWord.WordTyped())
         {
             hasActiveWord = false;
             words.Remove(activeWord);

         }
     }
    public void ShowRestart()
    {
        Time.timeScale = 0f;
        restartButton.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
