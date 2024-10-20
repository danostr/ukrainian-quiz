using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    [SerializeField] GameObject mainScreen; // Main page canvas
    [SerializeField] GameObject quizScreen; // Quiz canvas

    // Starting the quiz
    public void StartQuiz()
    {
        mainScreen.SetActive(false);
        quizScreen.SetActive(true);

        InitializeQuiz();
    }

    // Initialize the quiz with the first question
    private void InitializeQuiz()
    {
        // Load the first question and get the game ready
        Debug.Log("Quiz started, loading first question...");
        // Here, you can load questions from your database or JSON file
        // Display the first question on the quiz screen
    }
}
