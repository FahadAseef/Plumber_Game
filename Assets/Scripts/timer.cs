using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float countdownTime = 360f;
    private float loweringSpeed = 5f;
    private float remainingTime;
    [SerializeField] GameObject deathPanel;

    void Start()
    {
        deathPanel.SetActive(false);
        StartCoroutine(TimerCoroutine());
    }

    IEnumerator TimerCoroutine()
    {
        remainingTime = countdownTime;
        while (remainingTime > 0)
        {
            timerText.text = remainingTime.ToString("00 : 00");
            remainingTime -= Time.deltaTime*loweringSpeed;
            yield return null;
        }

        timerText.text = "00 : 00";
        Debug.Log("Time is up!");
        deathPanel.SetActive(true);
       
    }

    public void resetTimer()
    {
        StopAllCoroutines();
        remainingTime = countdownTime;
        StartCoroutine(TimerCoroutine());
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
