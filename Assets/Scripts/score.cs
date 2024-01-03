using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public static int trialno;
    public Text scoreText;
    private static int marks;
    //value each pin
    private static int scorefactor = 10;
    private static int missfactor = 10;
    //value divide if not strike
    private static int penaltyfactor = 2;
    private static bool reset = false;
    private static int lastmarks = 0;
    private static int increpenalty = 0;
    private static float currentlevel = 1;
    public static int scorePublic = 0;
    public static bool isReset = false;
    public static float level = 1f;



    // Start is called before the first frame update
    void Start()
    {
        trialno = 0;
        marks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(monitor.fallcount);

        
        if (reset && !movement.launched)
        {
            reset = false;
            isReset = reset;

            if (lastmarks == marks)
            {
                //if no pin down, decrease marks. each time missfactor = 10;
                increpenalty += 1;
            }
            lastmarks = calmarks();
        }

        // add one trial if launched
        if (!reset && movement.launched)
        {
            trialno += 1;
            reset = true;
            isReset = reset;

          //  Debug.Log("mm" + lastmarks.ToString() + " " + marks.ToString());
;           
        }

        marks = calmarks();
        scorePublic = marks;
        if (monitor.fallcount == 10 && level == currentlevel && trialno <= 3){
            level++;
        }
        if (monitor.fallcount == 10 && !movement.launched)
        {
            //reset game
            currentlevel = level;
            trialno = 0;
            marks = 0;
            lastmarks = 0;
            increpenalty = 0;
        }


        scoreText.text = "Level : "+ level.ToString()+ "\n"+ "Trial     :  " + trialno.ToString() +"\n" + "Scores :  " + marks.ToString();

    }

    int calmarks()
    {
        return monitor.fallcount * scorefactor / ((trialno >= 2) ? penaltyfactor : 1) - increpenalty * missfactor;
    }
}
