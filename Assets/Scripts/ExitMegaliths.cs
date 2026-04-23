using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitMegaliths : MonoBehaviour
{
    public Animator transition;
    string sceneToMove = "MainMuseumArea";

    public Image timerActive;
    float timeLeft;
    public float maxTime = 2f;

    public GameObject timer;
    public TMP_Text room;

    bool isHeld;
    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.yellow;

        room.enabled = true;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;

        room.enabled = false;
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

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = maxTime;

        timer.SetActive(false);

        room.enabled = false;
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
            }
            else
            {
                Time.timeScale = 0;

                timer.SetActive(false);
                room.enabled = false;

                StartCoroutine(ExitExhibit());
            }
        }
        
        if (!isHeld)    //Reset timer animation.
        {
            maxTime = 1f;
            timeLeft = maxTime;
            timerActive.fillAmount = 2f;
            Time.timeScale = 1f;
        }
    }
    IEnumerator ExitExhibit()   //Scene transition.
    {
        transition.Play("TransitionFadeIn");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(sceneToMove);
    }
}
