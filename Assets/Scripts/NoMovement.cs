using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMovement : MonoBehaviour
{
    public Animator reminder;
    bool animate;
    bool reset;

    float timeLeft;
    public float maxTime = 5f;

    private Vector3 tmpMousePosition;
    // Start is called before the first frame update
    void Start()
    {
        tmpMousePosition = Input.mousePosition;

        timeLeft = maxTime;

        animate = false;
        reset = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tmpMousePosition != Input.mousePosition)    //If mouse hasn't moved, reminder pops up.
        {
            tmpMousePosition = Input.mousePosition;

            if (animate)
            {
                animate = false;
                reminder.Play("ReminderFadeOut");
                reset = true;
            }
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

                animate = true;
                reminder.Play("ReminderFadeIn");
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
