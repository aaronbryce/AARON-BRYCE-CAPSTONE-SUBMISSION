using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MegalithEntrance : MonoBehaviour
{
    public GameObject entranceCamera;
    public GameObject mainCamera;

    public GameObject arrow;

    public GameObject entranceCanvas;
    public GameObject noMoveCanvas;

    // Start is called before the first frame update
    void Start()
    {
        entranceCamera.SetActive(true);
        mainCamera.SetActive(false);

        arrow.SetActive(false);

        noMoveCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CentreMouse()
    {
        Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2)); //Move mouse to centre of screen.

        entranceCamera.SetActive(false);
        mainCamera.SetActive(true);

        arrow.SetActive(true);

        entranceCanvas.SetActive(false);

        noMoveCanvas.SetActive(true);
    }
}
