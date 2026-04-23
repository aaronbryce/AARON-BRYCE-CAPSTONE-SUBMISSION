using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HighlightPoint : MonoBehaviour
{
    public Camera player;

    public Image entranceLeft;
    public TMP_Text entranceLeftText;

    public Image figurineLeft;
    public TMP_Text figurineLeftText;
    public Image figurineRight;
    public TMP_Text figurineRightText;

    public Image megaLeft;
    public TMP_Text megaLeftText;
    public Image megaRight;
    public TMP_Text megaRightText;

    public Image petroLeft;
    public TMP_Text petroLeftText;
    public Image petroRight;
    public TMP_Text petroRightText;

    public Image pictoLeft;
    public TMP_Text pictoLeftText;
    public Image pictoRight;
    public TMP_Text pictoRightText;

    public GameObject picto;
    public GameObject petro;
    public GameObject fig;
    public GameObject mega;

    public GameObject noMoveCanvas;

    public Collider exit;

    // Start is called before the first frame update
    void Start()
    {
        entranceLeft.enabled = true;
        entranceLeftText.enabled = true;

        figurineLeft.enabled = false;
        figurineLeftText.enabled = false;
        figurineRight.enabled = false;
        figurineRightText.enabled = false;

        megaLeft.enabled = false;
        megaLeftText.enabled = false;
        megaRight.enabled = false;
        megaRightText.enabled = false;

        petroLeft.enabled = false;
        petroLeftText.enabled = false;
        petroRight.enabled = false;
        petroRightText.enabled = false;

        pictoLeft.enabled = false;
        pictoLeftText.enabled = false;
        pictoRight.enabled = false;
        pictoRightText.enabled = false;

        picto.GetComponent<BoxCollider>().enabled = false;
        petro.GetComponent<BoxCollider>().enabled = false;
        fig.GetComponent<BoxCollider>().enabled = false;
        mega.GetComponent<BoxCollider>().enabled = false;

        exit.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pictographs()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        //Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2));

        player.transform.position = new Vector3(0.0f, 12.0f, -24.0f);

        //StartCoroutine(Unlock());

        entranceLeft.enabled = false;
        entranceLeftText.enabled = false;

        figurineLeft.enabled = true;
        figurineLeftText.enabled = true;
        megaRight.enabled = true;
        megaRightText.enabled = true;

        petroLeft.enabled = false;
        petroLeftText.enabled = false;
        petroRight.enabled = false;
        petroRightText.enabled = false;

        pictoLeft.enabled = false;
        pictoLeftText.enabled = false;
        pictoRight.enabled = false;
        pictoRightText.enabled = false;

        picto.GetComponent<BoxCollider>().enabled = true;
        petro.GetComponent<BoxCollider>().enabled = false;
        fig.GetComponent<BoxCollider>().enabled = false;
        mega.GetComponent<BoxCollider>().enabled = false;

        noMoveCanvas.SetActive(false);

        exit.enabled = true;
    }

    public void Figurines()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        //Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2));

        player.transform.position = new Vector3(-10.0f, 12.0f, 0.0f);

        //StartCoroutine(Unlock());

        entranceLeft.enabled = false;
        entranceLeftText.enabled = false;

        petroRight.enabled = true;
        petroRightText.enabled = true;
        pictoLeft.enabled = true;
        pictoLeftText.enabled = true;

        figurineLeft.enabled = false;
        figurineLeftText.enabled = false;
        figurineRight.enabled = false;
        figurineRightText.enabled = false;

        megaLeft.enabled = false;
        megaLeftText.enabled = false;
        megaRight.enabled = false;
        megaRightText.enabled = false;

        picto.GetComponent<BoxCollider>().enabled = false;
        petro.GetComponent<BoxCollider>().enabled = false;
        fig.GetComponent<BoxCollider>().enabled = true;
        mega.GetComponent<BoxCollider>().enabled = false;

        exit.enabled = false;
    }

    public void Megalithic()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        //Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2));

        player.transform.position = new Vector3(10.0f, 12.0f, 0.0f);

        //StartCoroutine(Unlock());

        entranceLeft.enabled = false;
        entranceLeftText.enabled = false;

        petroLeft.enabled = true;
        petroLeftText.enabled = true;
        pictoRight.enabled = true;
        pictoRightText.enabled = true;

        figurineLeft.enabled = false;
        figurineLeftText.enabled = false;
        figurineRight.enabled = false;
        figurineRightText.enabled = false;

        megaLeft.enabled = false;
        megaLeftText.enabled = false;
        megaRight.enabled = false;
        megaRightText.enabled = false;

        picto.GetComponent<BoxCollider>().enabled = false;
        petro.GetComponent<BoxCollider>().enabled = false;
        fig.GetComponent<BoxCollider>().enabled = false;
        mega.GetComponent<BoxCollider>().enabled = true;

        exit.enabled = false;
    }

    public void Petroglyphs()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        //Mouse.current.WarpCursorPosition(new Vector2(Screen.width / 2, Screen.height / 2));

        player.transform.position = new Vector3(0.0f, 12.0f, 12.0f);

        //StartCoroutine(Unlock());

        entranceLeft.enabled = false;
        entranceLeftText.enabled = false;

        figurineLeft.enabled = true;
        figurineLeftText.enabled = true;
        megaRight.enabled = true;
        megaRightText.enabled = true;

        petroLeft.enabled = false;
        petroLeftText.enabled = false;
        petroRight.enabled = false;
        petroRightText.enabled = false;

        pictoLeft.enabled = false;
        pictoLeftText.enabled = false;
        pictoRight.enabled = false;
        pictoRightText.enabled = false;

        picto.GetComponent<BoxCollider>().enabled = false;
        petro.GetComponent<BoxCollider>().enabled = true;
        fig.GetComponent<BoxCollider>().enabled = false;
        mega.GetComponent<BoxCollider>().enabled = false;

        exit.enabled = false;
    }

    IEnumerator Unlock()
    {
        yield return new WaitForEndOfFrame();
        Cursor.lockState = CursorLockMode.None;
    }
}
