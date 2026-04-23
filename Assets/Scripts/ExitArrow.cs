using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitArrow : MonoBehaviour
{
    public TMP_Text exitText;

    public float speed = 1f;    

    public float rotSpeed = 1f;

    public GameObject player;
    public Animator playerAnimator;

    bool exit;

    string sceneToMove = "MainMuseumArea";

    public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        exit = false;

        exitText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (exit)
        {
            GetComponent<MeshRenderer>().enabled = false;

            player.transform.position = Vector3.MoveTowards(player.transform.position, transform.position, speed * Time.deltaTime);
        }
    }
    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.yellow;

        exitText.enabled = true;

        Vector3 dir = transform.position - player.transform.position;

        Quaternion rot = Quaternion.Slerp(player.transform.rotation, Quaternion.LookRotation(dir), rotSpeed * Time.deltaTime);  //Rotate player's Y-axis in the direction of the highlighted object.

        rot.x = 0;
        rot.z = 0;

        player.transform.rotation = rot;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;

        exitText.enabled = false;
    }
    void OnMouseDown()
    {
        exit = true;
        playerAnimator.Play("Walking"); //Player walks towards exit.
        exitText.enabled = false;

        StartCoroutine(ExitExhibit());
    }
    IEnumerator ExitExhibit()   //Scene transition.
    {
        yield return new WaitForSeconds(0.4f);
        transition.Play("TransitionFadeIn");
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(sceneToMove);
    }
}
