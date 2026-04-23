using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timeline : MonoBehaviour
{
    public Image timelineOne;
    public Image timelineOneOutline;
    public TMP_Text timelineOneTitle;
    public TMP_Text timelineOneSubtitle;
    public TMP_Text timelineOneYear;
    public TMP_Text timelineOneDescription;

    public Image timelineTwo;
    public Image timelineTwoOutline;
    public TMP_Text timelineTwoTitle;
    public TMP_Text timelineTwoSubtitle;
    public TMP_Text timelineTwoYear;
    public TMP_Text timelineTwoDescription;

    public Image timelineThree;
    public Image timelineThreeOutline;
    public TMP_Text timelineThreeTitle;
    public TMP_Text timelineThreeSubtitle;
    public TMP_Text timelineThreeYear;
    public TMP_Text timelineThreeDescription;

    public Image timelineFour;
    public Image timelineFourOutline;
    public TMP_Text timelineFourTitle;
    public TMP_Text timelineFourSubtitle;
    public TMP_Text timelineFourYear;
    public TMP_Text timelineFourDescription;

    public Image timelineFive;
    public Image timelineFiveOutline;
    public Image timelineFiveBird;
    public TMP_Text timelineFiveTitle;
    public TMP_Text timelineFiveSubtitle;
    public TMP_Text timelineFiveYear;
    public TMP_Text timelineFiveDescription;

    public Image timelineSix;
    public Image timelineSixOutline;
    public TMP_Text timelineSixTitle;
    public TMP_Text timelineSixSubtitle;
    public TMP_Text timelineSixYear;
    public TMP_Text timelineSixDescription;

    public Animator fadeBackground;

    public Animator fadeImage1;
    public Animator fadeImage2;
    public Animator fadeImage3;
    public Animator fadeImage4;
    public Animator fadeImage5;
    public Animator fadeImage6;

    public Animator fadeText1;
    public Animator fadeText2;
    public Animator fadeText3;
    public Animator fadeText4;
    public Animator fadeText5;
    public Animator fadeText6;

    public Image indonesia1;
    public Image indonesia2;
    public Image australia;
    public Image france1;
    public Image france2;
    public Image spain;

    public TMP_Text introText;
    public GameObject noMoveCanvas;
    // Start is called before the first frame update
    void Start()
    {
        timelineOne.enabled = false;
        timelineOneOutline.enabled = false;
        timelineOneTitle.enabled = false;
        timelineOneSubtitle.enabled = false;
        timelineOneYear.enabled = false;
        timelineOneDescription.enabled = false;

        timelineTwo.enabled = false;
        timelineTwoOutline.enabled = false;
        timelineTwoTitle.enabled = false;
        timelineTwoSubtitle.enabled = false;
        timelineTwoYear.enabled = false;
        timelineTwoDescription.enabled = false;

        timelineThree.enabled = false;
        timelineThreeOutline.enabled = false;
        timelineThreeTitle.enabled = false;
        timelineThreeSubtitle.enabled = false;
        timelineThreeYear.enabled = false;
        timelineThreeDescription.enabled = false;

        timelineFour.enabled = false;
        timelineFourOutline.enabled = false;
        timelineFourTitle.enabled = false;
        timelineFourSubtitle.enabled = false;
        timelineFourYear.enabled = false;
        timelineFourDescription.enabled = false;

        timelineFive.enabled = false;
        timelineFiveOutline.enabled = false;
        timelineFiveBird.enabled = false;
        timelineFiveTitle.enabled = false;
        timelineFiveSubtitle.enabled = false;
        timelineFiveYear.enabled = false;
        timelineFiveDescription.enabled = false;

        timelineSix.enabled = false;
        timelineSixOutline.enabled = false;
        timelineSixTitle.enabled = false;
        timelineSixSubtitle.enabled = false;
        timelineSixYear.enabled = false;
        timelineSixDescription.enabled = false;

        indonesia1.enabled = false;
        indonesia2.enabled = false;
        australia.enabled = false;
        france1.enabled = false;
        france2.enabled = false;
        spain.enabled = false;

        introText.enabled = true;
        noMoveCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TimelineOne()
    {
        fadeBackground.SetBool("FadeOne", true);
        fadeImage1.Play("FadeIn");
        fadeImage2.Play("FadeOut");
        fadeImage3.Play("FadeOut");
        fadeImage4.Play("FadeOut");
        fadeImage5.Play("FadeOut");
        fadeImage6.Play("FadeOut");

        fadeText1.Play("FadeIn");
        fadeText2.Play("FadeOut");
        fadeText3.Play("FadeOut");
        fadeText4.Play("FadeOut");
        fadeText5.Play("FadeOut");
        fadeText6.Play("FadeOut");

        fadeBackground.SetBool("FadeTwo", false);
        fadeBackground.SetBool("FadeThree", false);
        fadeBackground.SetBool("FadeFour", false);
        fadeBackground.SetBool("FadeFive", false);
        fadeBackground.SetBool("FadeSix", false);

        timelineOne.enabled = true;
        timelineOneOutline.enabled = true;
        timelineOneTitle.enabled = true;
        timelineOneSubtitle.enabled = true;
        timelineOneYear.enabled = true;
        timelineOneDescription.enabled = true;

        timelineTwo.enabled = false;
        timelineTwoOutline.enabled = false;
        timelineTwoTitle.enabled = false;
        timelineTwoSubtitle.enabled = false;
        timelineTwoYear.enabled = false;
        timelineTwoDescription.enabled = false;

        timelineThree.enabled = false;
        timelineThreeOutline.enabled = false;
        timelineThreeTitle.enabled = false;
        timelineThreeSubtitle.enabled = false;
        timelineThreeYear.enabled = false;
        timelineThreeDescription.enabled = false;

        timelineFour.enabled = false;
        timelineFourOutline.enabled = false;
        timelineFourTitle.enabled = false;
        timelineFourSubtitle.enabled = false;
        timelineFourYear.enabled = false;
        timelineFourDescription.enabled = false;

        timelineFive.enabled = false;
        timelineFiveOutline.enabled = false;
        timelineFiveBird.enabled = false;
        timelineFiveTitle.enabled = false;
        timelineFiveSubtitle.enabled = false;
        timelineFiveYear.enabled = false;
        timelineFiveDescription.enabled = false;

        timelineSix.enabled = false;
        timelineSixOutline.enabled = false;
        timelineSixTitle.enabled = false;
        timelineSixSubtitle.enabled = false;
        timelineSixYear.enabled = false;
        timelineSixDescription.enabled = false;

        indonesia1.enabled = true;
        indonesia2.enabled = false;
        australia.enabled = false;
        france1.enabled = false;
        france2.enabled = false;
        spain.enabled = false;

        introText.enabled = false;
        noMoveCanvas.SetActive(false);
    }
    public void TimelineTwo()
    {
        fadeBackground.SetBool("FadeTwo", true);
        fadeImage1.Play("FadeOut");
        fadeImage2.Play("FadeIn");
        fadeImage3.Play("FadeOut");
        fadeImage4.Play("FadeOut");
        fadeImage5.Play("FadeOut");
        fadeImage6.Play("FadeOut");

        fadeText1.Play("FadeOut");
        fadeText2.Play("FadeIn");
        fadeText3.Play("FadeOut");
        fadeText4.Play("FadeOut");
        fadeText5.Play("FadeOut");
        fadeText6.Play("FadeOut");

        fadeBackground.SetBool("FadeOne", false);
        fadeBackground.SetBool("FadeThree", false);
        fadeBackground.SetBool("FadeFour", false);
        fadeBackground.SetBool("FadeFive", false);
        fadeBackground.SetBool("FadeSix", false);

        timelineTwo.enabled = true;
        timelineTwoOutline.enabled = true;
        timelineTwoTitle.enabled = true;
        timelineTwoSubtitle.enabled = true;
        timelineTwoYear.enabled = true;
        timelineTwoDescription.enabled = true;

        timelineOne.enabled = false;
        timelineOneOutline.enabled = false;
        timelineOneTitle.enabled = false;
        timelineOneSubtitle.enabled = false;
        timelineOneYear.enabled = false;
        timelineOneDescription.enabled = false;

        timelineThree.enabled = false;
        timelineThreeOutline.enabled = false;
        timelineThreeTitle.enabled = false;
        timelineThreeSubtitle.enabled = false;
        timelineThreeYear.enabled = false;
        timelineThreeDescription.enabled = false;

        timelineFour.enabled = false;
        timelineFourOutline.enabled = false;
        timelineFourTitle.enabled = false;
        timelineFourSubtitle.enabled = false;
        timelineFourYear.enabled = false;
        timelineFourDescription.enabled = false;

        timelineFive.enabled = false;
        timelineFiveOutline.enabled = false;
        timelineFiveBird.enabled = false;
        timelineFiveTitle.enabled = false;
        timelineFiveSubtitle.enabled = false;
        timelineFiveYear.enabled = false;
        timelineFiveDescription.enabled = false;

        timelineSix.enabled = false;
        timelineSixOutline.enabled = false;
        timelineSixTitle.enabled = false;
        timelineSixSubtitle.enabled = false;
        timelineSixYear.enabled = false;
        timelineSixDescription.enabled = false;

        indonesia1.enabled = false;
        indonesia2.enabled = true;
        australia.enabled = false;
        france1.enabled = false;
        france2.enabled = false;
        spain.enabled = false;

        introText.enabled = false;
        noMoveCanvas.SetActive(false);
    }
    public void TimelineThree()
    {
        fadeBackground.SetBool("FadeThree", true);
        fadeImage1.Play("FadeOut");
        fadeImage2.Play("FadeOut");
        fadeImage3.Play("FadeIn");
        fadeImage4.Play("FadeOut");
        fadeImage5.Play("FadeOut");
        fadeImage6.Play("FadeOut");

        fadeText1.Play("FadeOut");
        fadeText2.Play("FadeOut");
        fadeText3.Play("FadeIn");
        fadeText4.Play("FadeOut");
        fadeText5.Play("FadeOut");
        fadeText6.Play("FadeOut");

        fadeBackground.SetBool("FadeOne", false);
        fadeBackground.SetBool("FadeTwo", false);
        fadeBackground.SetBool("FadeFour", false);
        fadeBackground.SetBool("FadeFive", false);
        fadeBackground.SetBool("FadeSix", false);

        timelineThree.enabled = true;
        timelineThreeOutline.enabled = true;
        timelineThreeTitle.enabled = true;
        timelineThreeSubtitle.enabled = true;
        timelineThreeYear.enabled = true;
        timelineThreeDescription.enabled = true;

        timelineOne.enabled = false;
        timelineOneOutline.enabled = false;
        timelineOneTitle.enabled = false;
        timelineOneSubtitle.enabled = false;
        timelineOneYear.enabled = false;
        timelineOneDescription.enabled = false;

        timelineTwo.enabled = false;
        timelineTwoOutline.enabled = false;
        timelineTwoTitle.enabled = false;
        timelineTwoSubtitle.enabled = false;
        timelineTwoYear.enabled = false;
        timelineTwoDescription.enabled = false;

        timelineFour.enabled = false;
        timelineFourOutline.enabled = false;
        timelineFourTitle.enabled = false;
        timelineFourSubtitle.enabled = false;
        timelineFourYear.enabled = false;
        timelineFourDescription.enabled = false;

        timelineFive.enabled = false;
        timelineFiveOutline.enabled = false;
        timelineFiveBird.enabled = false;
        timelineFiveTitle.enabled = false;
        timelineFiveSubtitle.enabled = false;
        timelineFiveYear.enabled = false;
        timelineFiveDescription.enabled = false;

        timelineSix.enabled = false;
        timelineSixOutline.enabled = false;
        timelineSixTitle.enabled = false;
        timelineSixSubtitle.enabled = false;
        timelineSixYear.enabled = false;
        timelineSixDescription.enabled = false;

        indonesia1.enabled = false;
        indonesia2.enabled = false;
        australia.enabled = true;
        france1.enabled = false;
        france2.enabled = false;
        spain.enabled = false;

        introText.enabled = false;
        noMoveCanvas.SetActive(false);
    }
    public void TimelineFour()
    {
        fadeBackground.SetBool("FadeFour", true);
        fadeImage1.Play("FadeOut");
        fadeImage2.Play("FadeOut");
        fadeImage3.Play("FadeOut");
        fadeImage4.Play("FadeIn");
        fadeImage5.Play("FadeOut");
        fadeImage6.Play("FadeOut");

        fadeText1.Play("FadeOut");
        fadeText2.Play("FadeOut");
        fadeText3.Play("FadeOut");
        fadeText4.Play("FadeIn");
        fadeText5.Play("FadeOut");
        fadeText6.Play("FadeOut");

        fadeBackground.SetBool("FadeOne", false);
        fadeBackground.SetBool("FadeTwo", false);
        fadeBackground.SetBool("FadeThree", false);
        fadeBackground.SetBool("FadeFive", false);
        fadeBackground.SetBool("FadeSix", false);

        timelineFour.enabled = true;
        timelineFourOutline.enabled = true;
        timelineFourTitle.enabled = true;
        timelineFourSubtitle.enabled = true;
        timelineFourYear.enabled = true;
        timelineFourDescription.enabled = true;

        timelineOne.enabled = false;
        timelineOneOutline.enabled = false;
        timelineOneTitle.enabled = false;
        timelineOneSubtitle.enabled = false;
        timelineOneYear.enabled = false;
        timelineOneDescription.enabled = false;

        timelineTwo.enabled = false;
        timelineTwoOutline.enabled = false;
        timelineTwoTitle.enabled = false;
        timelineTwoSubtitle.enabled = false;
        timelineTwoYear.enabled = false;
        timelineTwoDescription.enabled = false;

        timelineThree.enabled = false;
        timelineThreeOutline.enabled = false;
        timelineThreeTitle.enabled = false;
        timelineThreeSubtitle.enabled = false;
        timelineThreeYear.enabled = false;
        timelineThreeDescription.enabled = false;

        timelineFive.enabled = false;
        timelineFiveOutline.enabled = false;
        timelineFiveBird.enabled = false;
        timelineFiveTitle.enabled = false;
        timelineFiveSubtitle.enabled = false;
        timelineFiveYear.enabled = false;
        timelineFiveDescription.enabled = false;

        timelineSix.enabled = false;
        timelineSixOutline.enabled = false;
        timelineSixTitle.enabled = false;
        timelineSixSubtitle.enabled = false;
        timelineSixYear.enabled = false;
        timelineSixDescription.enabled = false;

        indonesia1.enabled = false;
        indonesia2.enabled = false;
        australia.enabled = false;
        france1.enabled = true;
        france2.enabled = false;
        spain.enabled = false;

        introText.enabled = false;
        noMoveCanvas.SetActive(false);
    }
    public void TimelineFive()
    {
        fadeBackground.SetBool("FadeFive", true);
        fadeImage1.Play("FadeOut");
        fadeImage2.Play("FadeOut");
        fadeImage3.Play("FadeOut");
        fadeImage4.Play("FadeOut");
        fadeImage5.Play("FadeIn");
        fadeImage6.Play("FadeOut");

        fadeText1.Play("FadeOut");
        fadeText2.Play("FadeOut");
        fadeText3.Play("FadeOut");
        fadeText4.Play("FadeOut");
        fadeText5.Play("FadeIn");
        fadeText6.Play("FadeOut");

        fadeBackground.SetBool("FadeOne", false);
        fadeBackground.SetBool("FadeTwo", false);
        fadeBackground.SetBool("FadeThree", false);
        fadeBackground.SetBool("FadeFour", false);
        fadeBackground.SetBool("FadeSix", false);

        timelineFive.enabled = true;
        timelineFiveOutline.enabled = true;
        timelineFiveBird.enabled = true;
        timelineFiveTitle.enabled = true;
        timelineFiveSubtitle.enabled = true;
        timelineFiveYear.enabled = true;
        timelineFiveDescription.enabled = true;

        timelineOne.enabled = false;
        timelineOneOutline.enabled = false;
        timelineOneTitle.enabled = false;
        timelineOneSubtitle.enabled = false;
        timelineOneYear.enabled = false;
        timelineOneDescription.enabled = false;

        timelineTwo.enabled = false;
        timelineTwoOutline.enabled = false;
        timelineTwoTitle.enabled = false;
        timelineTwoSubtitle.enabled = false;
        timelineTwoYear.enabled = false;
        timelineTwoDescription.enabled = false;


        timelineThree.enabled = false;
        timelineThreeOutline.enabled = false;
        timelineThreeTitle.enabled = false;
        timelineThreeSubtitle.enabled = false;
        timelineThreeYear.enabled = false;
        timelineThreeDescription.enabled = false;

        timelineFour.enabled = false;
        timelineFourOutline.enabled = false;
        timelineFourTitle.enabled = false;
        timelineFourSubtitle.enabled = false;
        timelineFourYear.enabled = false;
        timelineFourDescription.enabled = false;

        timelineSix.enabled = false;
        timelineSixOutline.enabled = false;
        timelineSixTitle.enabled = false;
        timelineSixSubtitle.enabled = false;
        timelineSixYear.enabled = false;
        timelineSixDescription.enabled = false;

        indonesia1.enabled = false;
        indonesia2.enabled = false;
        australia.enabled = false;
        france1.enabled = false;
        france2.enabled = true;
        spain.enabled = false;

        introText.enabled = false;
        noMoveCanvas.SetActive(false);
    }
    public void TimelineSix()
    {
        fadeBackground.SetBool("FadeSix", true);
        fadeImage1.Play("FadeOut");
        fadeImage2.Play("FadeOut");
        fadeImage3.Play("FadeOut");
        fadeImage4.Play("FadeOut");
        fadeImage5.Play("FadeOut");
        fadeImage6.Play("FadeIn");

        fadeText1.Play("FadeOut");
        fadeText2.Play("FadeOut");
        fadeText3.Play("FadeOut");
        fadeText4.Play("FadeOut");
        fadeText5.Play("FadeOut");
        fadeText6.Play("FadeIn");

        fadeBackground.SetBool("FadeOne", false);
        fadeBackground.SetBool("FadeTwo", false);
        fadeBackground.SetBool("FadeThree", false);
        fadeBackground.SetBool("FadeFour", false);
        fadeBackground.SetBool("FadeFive", false);

        timelineSix.enabled = true;
        timelineSixOutline.enabled = true;
        timelineSixTitle.enabled = true;
        timelineSixSubtitle.enabled = true;
        timelineSixYear.enabled = true;
        timelineSixDescription.enabled = true;

        timelineOne.enabled = false;
        timelineOneOutline.enabled = false;
        timelineOneTitle.enabled = false;
        timelineOneSubtitle.enabled = false;
        timelineOneYear.enabled = false;
        timelineOneDescription.enabled = false;

        timelineTwo.enabled = false;
        timelineTwoOutline.enabled = false;
        timelineTwoTitle.enabled = false;
        timelineTwoSubtitle.enabled = false;
        timelineTwoYear.enabled = false;
        timelineTwoDescription.enabled = false;


        timelineThree.enabled = false;
        timelineThreeOutline.enabled = false;
        timelineThreeTitle.enabled = false;
        timelineThreeSubtitle.enabled = false;
        timelineThreeYear.enabled = false;
        timelineThreeDescription.enabled = false;

        timelineFour.enabled = false;
        timelineFourOutline.enabled = false;
        timelineFourTitle.enabled = false;
        timelineFourSubtitle.enabled = false;
        timelineFourYear.enabled = false;
        timelineFourDescription.enabled = false;

        timelineFive.enabled = false;
        timelineFiveOutline.enabled = false;
        timelineFiveBird.enabled = false;
        timelineFiveTitle.enabled = false;
        timelineFiveSubtitle.enabled = false;
        timelineFiveYear.enabled = false;
        timelineFiveDescription.enabled = false;

        indonesia1.enabled = false;
        indonesia2.enabled = false;
        australia.enabled = false;
        france1.enabled = false;
        france2.enabled = false;
        spain.enabled = true;

        introText.enabled = false;
        noMoveCanvas.SetActive(false);
    }


}
