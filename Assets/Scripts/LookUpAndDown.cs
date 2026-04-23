using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LookUpAndDown : MonoBehaviour
{
    private RectTransform rectTransform;
    private Canvas canvas;

    public Image painting;

    private bool animate;
    private bool fadeIn;

    private bool up;
    private bool down;

    public Animator megafauna;
    public Animator fade;

    public float timeRequired = 2f;
    private float currentHoverTime = 0.0f;

    Vector3 originPosition;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();

        animate = false;
        fadeIn = false;

        originPosition = transform.position;
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            animate = true; //Animate painting (if contains specific animation conditions, mouse interaction, etc).
            fadeIn = true;

            fade.SetBool("FadeOut", true);  //Fade-out animation for the original cave painting image.
            fade.SetBool("FadeIn", false);  //Fade-in animation for the original cave painting image.
        }

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            fadeIn = false; //Fade-in animation for original cave painting + reset animation to original position.
        }

        if (!fadeIn)
        {
            currentHoverTime += Time.deltaTime;


            if (currentHoverTime >= timeRequired)   //Timer to trigger fade-in animation for original cave painting image.
            {
                currentHoverTime = 0.0f;

                fade.SetBool("FadeOut", false);
                fade.SetBool("FadeIn", true);
                megafauna.Play("MegafaunaLookDown");    //Returns animation to default position for fade-in.

                animate = false;
                transform.position = originPosition;
            }
        }

        if (animate)
        {
            Vector2 mousePos;   //Mouse position.

            RectTransformUtility.ScreenPointToLocalPointInRectangle //Convert mouse coordinates to local coordinates.
            (
                canvas.transform as RectTransform,
                Input.mousePosition,
                canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera,
                out mousePos
            );

            Vector2 direction = mousePos - rectTransform.anchoredPosition;
            if (direction.x < 100 || direction.y < 50)
            {
                up = false;
                down = true;
            }
            else if (direction.x > 100 && direction.y > 50)
            {
                up = true;
                down = false;
            }

            if (down)
            {
                megafauna.Play("MegafaunaLookDown");
            }

            if (up)
            {
                megafauna.Play("MegafaunaLookUp");
            }
        }
    }
}