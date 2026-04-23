using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MuseumNav : MonoBehaviour
{
    public string sceneToMove;

    public Image timerActive;
    float timeLeft;
    public float maxTime = 1f;

    public GameObject timer;
    public TMP_Text exhibit;

    bool isHeld;

    public Animator transition;

    public GameObject mainCamera;
    public GameObject arrow;
    public GameObject museum;
    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.gray;

        exhibit.enabled = true;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;

        exhibit.enabled = false;
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

        exhibit.enabled = false;
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
                exhibit.enabled = false;

                StartCoroutine(SceneTransition());
            }
        }

        if (!isHeld)    //Reset timer.
        {
            maxTime = 1f;
            timeLeft = maxTime;
            timerActive.fillAmount = 1f;
            Time.timeScale = 1f;
        }
    }

    IEnumerator SceneTransition()
    {
        transition.Play("TransitionFadeIn");
        yield return new WaitForSeconds(0.2f);

        //mainCamera.SetActive(false);
        //arrow.SetActive(false);
        //museum.SetActive(false);

        SceneManager.LoadScene(sceneToMove);
    }
}
