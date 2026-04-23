using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleHighlight : MonoBehaviour
{
    public string pickUp;
    public string putDown;

    public Animator highlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        highlight.Play(pickUp);
    }

    private void OnMouseExit()
    {
        highlight.Play(putDown);
    }
}
