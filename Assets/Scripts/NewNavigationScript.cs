using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class NewNavigationScript : MonoBehaviour
{
    public Camera player;

    public Texture2D entranceTexture;
    public Texture2D pictoTexture;
    public Texture2D petroTexture;
    public Texture2D figTexture;
    public Texture2D megaTexture;

    public GameObject entrance;
    public GameObject pictoLeft;
    public GameObject pictoRight;
    public GameObject petroLeft;
    public GameObject petroRight;
    public GameObject figLeft;
    public GameObject figRight;
    public GameObject megaLeft;
    public GameObject megaRight;

    public GameObject pictoEntrance;
    public GameObject petroEntrance;
    public GameObject figEntrance;
    public GameObject megaEntrance;

    public TMP_Text pictoText;
    public TMP_Text petroText;
    public TMP_Text figText;
    public TMP_Text megaText;

    public GameObject noMoveCanvas;

    public Collider example1;
    public Collider example2;

    public Collider exit;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        entrance.GetComponent<BoxCollider>().enabled = false;
        pictoLeft.GetComponent<BoxCollider>().enabled = false;
        pictoRight.GetComponent<BoxCollider>().enabled = false;
        petroLeft.GetComponent<BoxCollider>().enabled = false;
        petroRight.GetComponent<BoxCollider>().enabled = false;
        figLeft.GetComponent<BoxCollider>().enabled = false;
        figRight.GetComponent<BoxCollider>().enabled = false;
        megaLeft.GetComponent<BoxCollider>().enabled = false;
        megaRight.GetComponent<BoxCollider>().enabled = false;

        pictoEntrance.GetComponent<BoxCollider>().enabled = false;
        petroEntrance.GetComponent<BoxCollider>().enabled = false;
        figEntrance.GetComponent<BoxCollider>().enabled = false;
        megaEntrance.GetComponent<BoxCollider>().enabled = false;

        exit.enabled = false;

        noMoveCanvas.SetActive(true);

        pictoText.enabled = false;
        petroText.enabled = false;
        figText.enabled = false;
        megaText.enabled = false;

        example1.enabled = false;
        example2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        if (tag == "Entrance")
        {
            Debug.Log("Entrance");
            Cursor.SetCursor(entranceTexture, hotSpot, cursorMode);

            pictoText.enabled = true;
            petroText.enabled = false;
            figText.enabled = false;
            megaText.enabled = false;
        }

        if (tag == "Pictographs")
        {
            Debug.Log("Pictographs");
            Cursor.SetCursor(pictoTexture, hotSpot, cursorMode);

            pictoText.enabled = true;
            petroText.enabled = false;
            figText.enabled = false;
            megaText.enabled = false;
        }

        if (tag == "Petroglyphs")
        {
            Debug.Log("Petroglyphs");
            Cursor.SetCursor(petroTexture, hotSpot, cursorMode);

            pictoText.enabled = false;
            petroText.enabled = true;
            figText.enabled = false;
            megaText.enabled = false;
        }

        if (tag == "Figurines")
        {
            Debug.Log("Figurines");
            Cursor.SetCursor(figTexture, hotSpot, cursorMode);

            pictoText.enabled = false;
            petroText.enabled = false;
            figText.enabled = true;
            megaText.enabled = false;
        }

        if (tag == "Megalithic")
        {
            Debug.Log("Megalithic");
            Cursor.SetCursor(megaTexture, hotSpot, cursorMode);

            pictoText.enabled = false;
            petroText.enabled = false;
            figText.enabled = false;
            megaText.enabled = true;
        }
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);

        pictoText.enabled = false;
        petroText.enabled = false;
        figText.enabled = false;
        megaText.enabled = false;
    }

    private void OnMouseDown()
    {
        if (tag == "Entrance")
        {
            player.transform.position = new Vector3(0.0f, 12.0f, -24.0f);

            entrance.GetComponent<BoxCollider>().enabled = false;
            pictoLeft.GetComponent<BoxCollider>().enabled = true;
            pictoRight.GetComponent<BoxCollider>().enabled = true;
            petroLeft.GetComponent<BoxCollider>().enabled = false;
            petroRight.GetComponent<BoxCollider>().enabled = false;
            figLeft.GetComponent<BoxCollider>().enabled = false;
            figRight.GetComponent<BoxCollider>().enabled = false;
            megaLeft.GetComponent<BoxCollider>().enabled = false;
            megaRight.GetComponent<BoxCollider>().enabled = false;

            pictoEntrance.GetComponent<BoxCollider>().enabled = true;
            petroEntrance.GetComponent<BoxCollider>().enabled = false;
            figEntrance.GetComponent<BoxCollider>().enabled = false;
            megaEntrance.GetComponent<BoxCollider>().enabled = false;

            noMoveCanvas.SetActive(false);

            exit.enabled = true;

            example1.enabled = true;
            example2.enabled = true;
        }

        if (tag == "Pictographs")
        {
            player.transform.position = new Vector3(0.0f, 12.0f, -24.0f);

            pictoLeft.GetComponent<BoxCollider>().enabled = true;
            pictoRight.GetComponent<BoxCollider>().enabled = true;
            petroLeft.GetComponent<BoxCollider>().enabled = false;
            petroRight.GetComponent<BoxCollider>().enabled = false;
            figLeft.GetComponent<BoxCollider>().enabled = false;
            figRight.GetComponent<BoxCollider>().enabled = false;
            megaLeft.GetComponent<BoxCollider>().enabled = false;
            megaRight.GetComponent<BoxCollider>().enabled = false;

            pictoEntrance.GetComponent<BoxCollider>().enabled = true;
            petroEntrance.GetComponent<BoxCollider>().enabled = false;
            figEntrance.GetComponent<BoxCollider>().enabled = false;
            megaEntrance.GetComponent<BoxCollider>().enabled = false;

            exit.enabled = true;
        }

        if (tag == "Petroglyphs")
        {
            player.transform.position = new Vector3(0.0f, 12.0f, 12.0f);

            pictoLeft.GetComponent<BoxCollider>().enabled = false;
            pictoRight.GetComponent<BoxCollider>().enabled = false;
            petroLeft.GetComponent<BoxCollider>().enabled = true;
            petroRight.GetComponent<BoxCollider>().enabled = true;
            figLeft.GetComponent<BoxCollider>().enabled = false;
            figRight.GetComponent<BoxCollider>().enabled = false;
            megaLeft.GetComponent<BoxCollider>().enabled = false;
            megaRight.GetComponent<BoxCollider>().enabled = false;

            pictoEntrance.GetComponent<BoxCollider>().enabled = false;
            petroEntrance.GetComponent<BoxCollider>().enabled = true;
            figEntrance.GetComponent<BoxCollider>().enabled = false;
            megaEntrance.GetComponent<BoxCollider>().enabled = false;

            exit.enabled = false;
        }

        if (tag == "Figurines")
        {
            player.transform.position = new Vector3(-10.0f, 12.0f, 0.0f);

            pictoLeft.GetComponent<BoxCollider>().enabled = false;
            pictoRight.GetComponent<BoxCollider>().enabled = false;
            petroLeft.GetComponent<BoxCollider>().enabled = false;
            petroRight.GetComponent<BoxCollider>().enabled = false;
            figLeft.GetComponent<BoxCollider>().enabled = true;
            figRight.GetComponent<BoxCollider>().enabled = true;
            megaLeft.GetComponent<BoxCollider>().enabled = false;
            megaRight.GetComponent<BoxCollider>().enabled = false;

            pictoEntrance.GetComponent<BoxCollider>().enabled = false;
            petroEntrance.GetComponent<BoxCollider>().enabled = false;
            figEntrance.GetComponent<BoxCollider>().enabled = true;
            megaEntrance.GetComponent<BoxCollider>().enabled = false;

            exit.enabled = false;
        }

        if (tag == "Megalithic")
        {
            player.transform.position = new Vector3(10.0f, 12.0f, 0.0f);

            pictoLeft.GetComponent<BoxCollider>().enabled = false;
            pictoRight.GetComponent<BoxCollider>().enabled = false;
            petroLeft.GetComponent<BoxCollider>().enabled = false;
            petroRight.GetComponent<BoxCollider>().enabled = false;
            figLeft.GetComponent<BoxCollider>().enabled = false;
            figRight.GetComponent<BoxCollider>().enabled = false;
            megaLeft.GetComponent<BoxCollider>().enabled = true;
            megaRight.GetComponent<BoxCollider>().enabled = true;

            pictoEntrance.GetComponent<BoxCollider>().enabled = false;
            petroEntrance.GetComponent<BoxCollider>().enabled = false;
            figEntrance.GetComponent<BoxCollider>().enabled = false;
            megaEntrance.GetComponent<BoxCollider>().enabled = true;

            exit.enabled = false;
        }
    }
}
