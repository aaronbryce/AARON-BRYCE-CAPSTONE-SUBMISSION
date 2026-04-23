using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Bison : MonoBehaviour
{
    public Image painting;

    private bool fadeIn;

    public Animator fade;

    public float timeRequired = 2f;
    private float currentHoverTime = 0.0f;

    Vector3 originPosition;
    void Start()
    {
        fadeIn = false;

        originPosition = transform.position;
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            fadeIn = true;

            fade.SetBool("FadeOut", true);  //Fade-out animation for the original cave painting image.
            fade.SetBool("FadeIn", false);  //Fade-in animation for the original cave painting image.
        }

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            fadeIn = false;
        }

        if (!fadeIn)
        {
            currentHoverTime += Time.deltaTime;


            if (currentHoverTime >= timeRequired)   //Timer to trigger fade-in animation for original cave painting image.
            {
                currentHoverTime = 0.0f;

                fade.SetBool("FadeOut", false);
                fade.SetBool("FadeIn", true);

                transform.position = originPosition;
            }
        }
    }
}