using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Arrows : MonoBehaviour
{
    public Animator entranceArrow;

    public Animator leftArrows;
    public Animator rightArrows;

    void Start()
    {

    }

    void Update()
    {
        float direction = Input.mousePosition.x - Screen.width / 2;

        if (direction < -45 || direction > 45)  //If mouse is not in the centre of the screen (main arrows).
        {
            leftArrows.Play("FlyOffLeft");
            rightArrows.Play("FlyOffRight");
        }
        else                                    //If mouse is in the centre of the screen (main arrows).
        {
            leftArrows.Play("FlyOnLeft");
            rightArrows.Play("FlyOnRight");
        }

        if (direction < -30 || direction > 30)  //If mouse is not in the centre of the screen (entrance arrow).
        {
            entranceArrow.Play("FlyUp");
        }
        else                                    //If mouse is in the centre of the screen (entrance arrow).
        {
            entranceArrow.Play("FlyDown");
        }
    }
}