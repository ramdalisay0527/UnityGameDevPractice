using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGuess();
        
    }

    void StartGuess()
    {
        NextGuess();
        

        //Debug.Log("Let's PLay Number Wizard!");
        //Debug.Log("Please Pick a Number from" + min + "to" + max);
        //Debug.Log("Highest Number is:" + max);
        //Debug.Log("Lowest Number is :" + min);
        //Debug.Log("Tell Me if your number is lower or higher than" + guess);
        //Debug.Log("Push up = If Your Number Higher, Push Down = If Your Number Is Lower, Push Enter = Correct");

    }

    // Update is called once per frame

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
        
    }

    public void OnPressLower()
    {
        max = guess - 1; 
        NextGuess();
        
    }



    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        //guess = (max + min) / 2;
        //Debug.Log("Is it lower or higher than" + guess);
        //Debug.Log(guess);
        guessText.text = guess.ToString();
    }
}
