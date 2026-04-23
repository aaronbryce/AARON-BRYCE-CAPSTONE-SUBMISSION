using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MegalithNav : MonoBehaviour
{
    public Camera player;
    public float movement;

    public Image timerActive;
    float timeLeft;
    public float maxTime = 2f;

    public GameObject timer;
    public TMP_Text room;

    bool isHeld;

    public Animator monuments1;
    public Animator monuments2;
    public Animator monuments3;
    public Animator monuments4;
    public Animator monuments5;
    public Animator monuments6;

    public Animator subtitle1;
    public Animator subtitle2;
    public Animator subtitle3;
    public Animator subtitle4;
    public Animator subtitle5;
    public Animator subtitle6;
    public Animator subtitle7;
    public Animator subtitle8;
    public Animator subtitle9;
    public Animator subtitle10;
    public Animator subtitle11;
    public Animator subtitle12;

    public float popUpWait1;
    public float popUpWait2;
    public float popUpWait3;
    public float popUpWait4;
    public float popUpWait5;
    public float popUpWait6;
    public float popUpWait7;
    public float popUpWait8;
    public float popUpWait9;

    public float subtitleWait1;
    public float subtitleWait2;
    public float subtitleWait3;
    public float subtitleWait4;
    public float subtitleWait5;
    public float subtitleWait6;
    public float subtitleWait7;
    public float subtitleWait8;
    public float subtitleWait9;
    public float subtitleWait10;
    public float subtitleWait11;

    public GameObject noMoveCanvas;
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

        noMoveCanvas.SetActive(false);
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

        noMoveCanvas.SetActive(true);
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

                player.transform.position = new Vector3(0f, 1.5f, movement);

                timer.SetActive(false);
                room.enabled = false;

                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<BoxCollider>().enabled = false;

                StartCoroutine(NarrationSequence());

                StartCoroutine(SubtitleSequence());
            }
        }

        if (!isHeld)    //Reset timer.
        {
            maxTime = 1f;
            timeLeft = maxTime;
            timerActive.fillAmount = 2f;
            Time.timeScale = 1f;
        }
    }

    IEnumerator NarrationSequence() //Image pop-up timings.
    {
        yield return new WaitForSeconds(popUpWait1);
        monuments1.Play("PopIn");
        yield return new WaitForSeconds(popUpWait2);
        monuments1.Play("PopOut");
        monuments2.Play("PopIn");
        yield return new WaitForSeconds(popUpWait3);
        monuments2.Play("PopOut");
        yield return new WaitForSeconds(popUpWait4);
        monuments3.Play("PopIn");
        yield return new WaitForSeconds(popUpWait5);
        monuments3.Play("PopOut");
        monuments4.Play("PopIn");
        yield return new WaitForSeconds(popUpWait6);
        monuments4.Play("PopOut");
        yield return new WaitForSeconds(popUpWait7);
        monuments5.Play("PopIn");
        yield return new WaitForSeconds(popUpWait8);
        monuments5.Play("PopOut");
        monuments6.Play("PopIn");
        yield return new WaitForSeconds(popUpWait9);
        monuments6.Play("PopOut");
    }

    IEnumerator SubtitleSequence()  //Subtitle timings.
    {
        yield return new WaitForSeconds(1f);
        FindObjectOfType<AudioManager>().Play("MegalithNarration");
        subtitle1.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait1);
        subtitle1.Play("PopDown");
        subtitle2.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait2);
        subtitle2.Play("PopDown");
        subtitle3.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait3);
        subtitle3.Play("PopDown");
        subtitle4.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait4);
        subtitle4.Play("PopDown");
        subtitle5.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait5);
        subtitle5.Play("PopDown");
        subtitle6.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait6);
        subtitle6.Play("PopDown");
        subtitle7.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait7);
        subtitle7.Play("PopDown");
        subtitle8.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait8);
        subtitle8.Play("PopDown");
        subtitle9.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait9);
        subtitle9.Play("PopDown");
        subtitle10.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait10);
        subtitle10.Play("PopDown");
        subtitle11.Play("PopUp");
        yield return new WaitForSeconds(subtitleWait11);
        subtitle11.Play("PopDown");
        subtitle12.Play("PopUp");
        yield return new WaitForSeconds(5f);
        subtitle12.Play("PopDown");
    }
}
