using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {
    private static string[] wordList = {"wonderful","amazing","cool","pretty","awesome","easy","fun","yeah"};
    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0,wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
