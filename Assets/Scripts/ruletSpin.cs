using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class ruletSpin : MonoBehaviour
{
    public GameObject spinButton;
    public static bool indicatorShows = false;
    private float rotationSpeed;
    public static float timee = 0.0f;
    private bool spinOver = true;
    public TMPro.TextMeshProUGUI zoneTxt;

    void Start()
    {
        rotationSpeed = (Random.Range(50.0f, 100.0f));
    }
    void Update()
    {
        if (timee >= 0.0f)
        {
            transform.Rotate(0, 0, rotationSpeed * timee);
            timee = timee - Time.deltaTime;
            indicatorShows = false;
        }
        else if(timee < 0.0f && !spinOver)
        {
            float zAngle = (int)transform.eulerAngles.z;
            if(zAngle % 45 > 22)
            {
                transform.Rotate(0, 0, 45-(zAngle % 45));
            }
            else if(zAngle % 45 <= 22)
            {
                transform.Rotate(0, 0, -(zAngle % 45));
            }

            indicatorShows = true;
            spinOver = true;
            Zone.counter++;
            zoneTxt.GetComponent<TMPro.TextMeshProUGUI>().text = Zone.counter.ToString();
            spinButton.GetComponent<Button>().enabled = true;
            Debug.Log(rotationSpeed);
        }
    }

    public void spinButtonMethod()
    {
        indicatorShows = false;
        rotationSpeed = (Random.Range(0f, 1f) + 0.25f);
        timee = 5.0f;
        spinOver = false;
        spinButton.GetComponent<Button>().enabled = false;
    }

}
