using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FollowMouseUI : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 500f;

    [SerializeField] private Vector2 minPosition = new Vector2(-200f, -200f);
    [SerializeField] private Vector2 maxPosition = new Vector2(200f, 200f);

    private RectTransform rectTransform;
    private Canvas canvas;

    public Image painting;

    private bool fly;
    private bool fadeIn;

    private bool left;
    private bool right;

    public Animator bird;
    public Animator fade;

    public float timeRequired = 2f;
    private float currentHoverTime = 0.0f;

    Vector3 originPosition;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();

        fly = false;
        fadeIn = false;

        originPosition = transform.position;
    }

    void Update()
    {
        FollowMousePositionDelayed(maxSpeed);

        if (EventSystem.current.IsPointerOverGameObject())
        {
            fly = true;
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

                fly = false;
                transform.position = originPosition; //Return bird to original position.
            }
        }
    }
    private void FollowMousePositionDelayed(float speed)
    {
        if (fly)
        {
            Vector2 mousePos;   //Mouse position.

            RectTransformUtility.ScreenPointToLocalPointInRectangle //Convert mouse coordinates to local coordinates.
            (
                canvas.transform as RectTransform,
                Input.mousePosition,
                canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera,
                out mousePos
            );

            mousePos.x = Mathf.Clamp(mousePos.x, minPosition.x, maxPosition.x); //Movement bounds for bird.
            mousePos.y = Mathf.Clamp(mousePos.y, minPosition.y, maxPosition.y);

            rectTransform.anchoredPosition = Vector2.MoveTowards    //Delay bird movement.
            (
                rectTransform.anchoredPosition,
                mousePos,
                speed * Time.deltaTime
            );

            Vector2 direction = mousePos - rectTransform.anchoredPosition;  //Detect what side of screen mouse is on.
            if (direction.x < 0)
            {
                left = true;
                right = false;
            }
            else if (direction.x > 0)
            {
                left = false;
                right = true;
            }

            if (Vector2.Distance(rectTransform.anchoredPosition, mousePos) > 0.1f)  //Detect mouse movement to animate bird.
            {
                bird.SetBool("flying", true);
            }
            else
            {
                bird.SetBool("flying", false);
            }

            if (left)   //Flip bird animation depending on mouse position.
            {
                rectTransform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if (right)
            {
                rectTransform.localRotation = Quaternion.Euler(0, 180f, 0);
            }
        }
    }
}