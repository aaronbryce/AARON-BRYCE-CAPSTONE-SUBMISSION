using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetroSubtitles : MonoBehaviour
{
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
    public Animator subtitle13;
    public Animator subtitle14;
    public Animator subtitle15;
    public Animator subtitle16;
    public Animator subtitle17;
    public Animator subtitle18;
    public Animator subtitle19;
    public Animator subtitle20;
    public Animator subtitle21;

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
    public float subtitleWait12;
    public float subtitleWait13;
    public float subtitleWait14;
    public float subtitleWait15;
    public float subtitleWait16;
    public float subtitleWait17;
    public float subtitleWait18;
    public float subtitleWait19;
    public float subtitleWait20;
    public float subtitleWait21;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SubtitleSequence());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SubtitleSequence()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        subtitle1.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait1);
        subtitle1.Play("PopDown");
        subtitle2.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait2);
        subtitle2.Play("PopDown");
        subtitle3.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait3);
        subtitle3.Play("PopDown");
        subtitle4.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait4);
        subtitle4.Play("PopDown");
        subtitle5.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait5);
        subtitle5.Play("PopDown");
        subtitle6.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait6);
        subtitle6.Play("PopDown");
        subtitle7.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait7);
        subtitle7.Play("PopDown");
        subtitle8.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait8);
        subtitle8.Play("PopDown");
        subtitle9.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait9);
        subtitle9.Play("PopDown");
        subtitle10.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait10);
        subtitle10.Play("PopDown");
        subtitle11.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait11);
        subtitle11.Play("PopDown");
        subtitle12.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait12);
        subtitle12.Play("PopDown");
        subtitle13.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait13);
        subtitle13.Play("PopDown");
        subtitle14.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait14);
        subtitle14.Play("PopDown");
        subtitle15.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait15);
        subtitle15.Play("PopDown");
        subtitle16.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait16);
        subtitle16.Play("PopDown");
        subtitle17.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait17);
        subtitle17.Play("PopDown");
        subtitle18.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait18);
        subtitle18.Play("PopDown");
        subtitle19.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait19);
        subtitle19.Play("PopDown");
        subtitle20.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait20);
        subtitle20.Play("PopDown");
        subtitle21.Play("PopUp");
        yield return new WaitForSecondsRealtime(subtitleWait21);
        subtitle21.Play("PopDown");
    }
}
