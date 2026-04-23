using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InitialiseButtons : MonoBehaviour
{
    public GameObject entranceCamera;
    public GameObject mainCamera;

    public GameObject entranceCanvas;
    public GameObject noMoveCanvas;

    public GameObject nav;

    public string targetSceneName = "MainMuseumArea";

    bool entered;

    public GameObject museum;

    public Animator transition;

    public GameObject entrance;
    // Start is called before the first frame update
    void Start()
    {
        entranceCamera.SetActive(true);
        mainCamera.SetActive(false);

        noMoveCanvas.SetActive(false);

        entered = false;

        museum.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene != targetSceneName)    //Disable persistent objects if not in the main museum area.
        {
            if (entered)
            {
                mainCamera.SetActive(false);
                museum.SetActive(false);

                transition.Play("Idle");

                nav.SetActive(false);
            }
        }

        if (currentScene == targetSceneName)    //Enable persistent objects if not in the main museum area.
        {
            if (entered)
            {
                mainCamera.SetActive(true);
                museum.SetActive(true);

                nav.SetActive(true);
            }
        }
    }
    public void CentreMouse()
    {
        Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2)); //Move mouse to centre of screen.

        entranceCamera.SetActive(false);
        mainCamera.SetActive(true);

        entranceCanvas.SetActive(false);

        noMoveCanvas.SetActive(true);

        entered = true;

        entrance.GetComponent<BoxCollider>().enabled = true;
    }
}
