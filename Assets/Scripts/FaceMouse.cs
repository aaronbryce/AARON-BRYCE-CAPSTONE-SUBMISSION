using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FaceMouse : MonoBehaviour
{
    private RectTransform rectTransform;
    private Canvas canvas;

    public Image painting;

    private bool animate;
    private bool fadeIn;

    private bool left;
    private bool right;

    public Animator pig;
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
                pig.Play("FaceRight");  //Returns animation to default position for fade-in.

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

            float direction = Input.mousePosition.x - Screen.width / 2;

            if (direction > 170)    //If the mouse is to the right of the x-position of the pig.
            {
                left = false;
                right = true;
            }
            else if (direction < -170)  //If the mouse is to the left of the x-position of the pig.
            {
                left = true;
                right = false;
            }

            if (left)
            {
                pig.Play("FaceLeft");   //Pig faces left.
            }

            if (right)
            {
                pig.Play("FaceRight");  //Pig faces right.
            }
        }
    }
}