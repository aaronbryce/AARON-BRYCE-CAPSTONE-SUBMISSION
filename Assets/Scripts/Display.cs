using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Display : MonoBehaviour
{
    public Camera displayCam;
    public Camera mainCam;

    public Canvas displayCanvas;
    public Animator backgroundCanvas;

    public Renderer rend;

    public GameObject displayObject;

    public float rotSpeed = 1f;

    public GameObject player;

    public Collider disableCollider1;
    public Collider disableCollider2;
    public Collider disableCollider3;
    public Collider disableCollider4;

    public TMP_Text title;

    public Animator highlight;

    public GameObject noMoveCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        displayObject.SetActive(false);
        displayCam.enabled = false;
        mainCam.enabled = true;

        displayCanvas.enabled = false;

        title.enabled = false;

        noMoveCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {
        highlight.SetBool("On", true);

        Vector3 dir = transform.position - player.transform.position;

        Quaternion rot = Quaternion.Slerp(player.transform.rotation, Quaternion.LookRotation(dir), rotSpeed * Time.deltaTime);  //Rotate player's Y-axis in the direction of the highlighted object.

        rot.x = 0;
        rot.z = 0;

        player.transform.rotation = rot;

        title.enabled = true;

        noMoveCanvas.SetActive(false);
    }
    private void OnMouseExit()
    {
        highlight.SetBool("On", false);

        title.enabled = false;
    }
    private void OnMouseDown()
    {
        displayObject.SetActive(true);  //Switch to interactive camera and enable UI.
        displayCam.enabled = true;
        mainCam.enabled = false;

        displayCanvas.enabled = true;
        backgroundCanvas.Play("CanvasFadeIn");

        disableCollider1.enabled = false;   //Disable all colliders for the other figurines.
        disableCollider2.enabled = false;
        disableCollider3.enabled = false;
        disableCollider4.enabled = false;

        title.enabled = false;
    }
    public void ExitDisplay()
    {
        displayObject.SetActive(false); //Switch back to main camera and disable UI.
        displayCam.enabled = false;
        mainCam.enabled = true;

        displayCanvas.enabled = false;
        backgroundCanvas.Play("CanvasFadeOut");

        disableCollider1.enabled = true;    //Reenable all colliders for figurines.
        disableCollider2.enabled = true;
        disableCollider3.enabled = true;
        disableCollider4.enabled = true;
    }
}
