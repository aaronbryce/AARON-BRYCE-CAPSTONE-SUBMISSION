using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExitMuseum : MonoBehaviour
{
    public TMP_Text exitText;

    public Image timerActive;
    float timeLeft;
    public float maxTime = 1f;

    public GameObject timer;

    bool isHeld;

    public Image black;

    // Start is called before the first frame update
    void Start()
    {
        exitText.enabled = false;

        timeLeft = maxTime;

        timer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isHeld)
        {
            if (timeLeft > 0)   //Timer animation.
            {
                timeLeft -= Time.deltaTime;
                timerActive.fillAmount = timeLeft / maxTime;
                black.fillAmount = 1 - (timeLeft / maxTime);
            }
            else
            {
                Time.timeScale = 0;

                timer.SetActive(false);
                exitText.enabled = false;

                Application.Quit(); //Quit project.
            }
        }

        if (!isHeld)    //Reset timer animation.
        {
            maxTime = 1f;
            timeLeft = maxTime;
            timerActive.fillAmount = 1f;
            black.fillAmount = 0;
            Time.timeScale = 1f;
        }
    }
    void OnMouseOver()
    {
        exitText.enabled = true;
    }
    void OnMouseExit()
    {
        exitText.enabled = false;
    }
    void OnMouseDown()
    {
        isHeld = true;

        timer.SetActive(true);
    }
    void OnMouseUp()
    {
        isHeld = false;

        timer.SetActive(false);
    }
}
