using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    string sceneToMove = "MainMuseumArea";
    public Animator transition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitExhibit()
    {
        StartCoroutine(SceneTransition());
    }
    IEnumerator SceneTransition()
    {
        transition.Play("TransitionFadeIn");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(sceneToMove);
    }
}
