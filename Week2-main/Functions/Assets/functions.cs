using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    public string myString;
    // Start is called before the first frame update
    void Start()
    {
        //ProblemOne(3, 7);

        /*Debug.Log("The most common letter is: " + 
            ProblemTwo("HELLO WORLD"));*/

        List<string> myWords = new List<string>();

        /*myWords.Add("The");
        myWords.Add("cake");
        myWords.Add("is");
        myWords.Add("a");
        myWords.Add("lie");*/

        string[] wordsAgain = myString.Split(' ');

        foreach (string s in wordsAgain)
            myWords.Add(s);

        Debug.Log("The letters in that phrase are: " + ProblemThree(myWords));
        ProblemOne(3,7);
       // ProblemTwo();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World");
    }

    void ProblemOne(int a, int b)
    {
        for (int i = 0; i <= 1000; i++)
        {
            string theNumber = i.ToString();
            if (theNumber.Contains(a.ToString()) &&
               theNumber.Contains(b.ToString()))
                Debug.Log(i);
        }
    }

    char ProblemTwo(string s)
    {
        char result = ' ';

        Dictionary<char, int> letters = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!letters.ContainsKey(c))
            {
                letters.Add(c, 1);
            }

            else
            {
                letters[c] += 1;
            }
        }

        foreach (var kvp in letters)
        {
            Debug.Log(kvp.Key + " = " + kvp.Value);
        }

        int resultCount = -1;

        foreach (var kvp in letters)
        {
            if (kvp.Value > resultCount)
            {
                result = kvp.Key;
                resultCount = kvp.Value;
            }
        }

        return result;
    }

    string ProblemThree(List<string> words)
    {
        string result = "";

        foreach (string s in words)
        {
            foreach (char c in s)
            {
                if (!result.Contains(c.ToString()))
                    result += c;
            }
        }

        return result;
    }
}

