using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PetroExit : MonoBehaviour
{
    public Animator exit;
    bool animate;
    bool reset;

    float timeLeft;
    public float maxTime = 2f;

    private Vector3 tmpMousePosition;
    void Awake()
    {
        Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2)); //Move mouse to centre of screen.
    }
    // Start is called before the first frame update
    void Start()
    {
        tmpMousePosition = Input.mousePosition;

        timeLeft = maxTime;

        animate = false;
        reset = false;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tmpMousePosition != Input.mousePosition)
        {
            tmpMousePosition = Input.mousePosition;

            animate = true;
            exit.Play("PetroFadeIn");

            Cursor.visible = true;
        }
        else
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                Time.timeScale = 0;

                if (animate)
                {
                    exit.Play("PetroFadeOut");
                    Cursor.visible = false;

                    reset = true;
                    animate = false;
                }
            }
        }

        if (reset)
        {
            maxTime = 5f;
            timeLeft = maxTime;
            Time.timeScale = 1f;
            reset = false;
        }
    }
}
