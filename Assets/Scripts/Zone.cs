using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Zone : MonoBehaviour
{
    public static int counter = 1;

    public Sprite[] zoneSprites = new Sprite[3];
    public GameObject zoneSprite;

    public Sprite[] spinSprites = new Sprite[3];
    public GameObject spinSprite;

    public Sprite[] indicatorSprites = new Sprite[3];
    public GameObject indicatorSprite;

    public GameObject[] rewardsOnSpin;
    public Sprite[] bronzeRewards;
    public Sprite[] silverRewards;
    public Sprite[] goldRewards;

    // Update is called once per frame
    void Update()
    {
        if(counter % 30 == 0)
        {
            zoneSprite.GetComponent<Image>().sprite = zoneSprites[2];
            spinSprite.GetComponent<SpriteRenderer>().sprite = spinSprites[2];
            indicatorSprite.GetComponent<SpriteRenderer>().sprite = indicatorSprites[2];
            for (int i = 0; i < 8; i++)
            {
                rewardsOnSpin[i].GetComponent<SpriteRenderer>().sprite = goldRewards[i];
            }
        }
        else if(counter % 5 == 0 && counter % 30 != 0)
        {
            zoneSprite.GetComponent<Image>().sprite = zoneSprites[1];
            spinSprite.GetComponent<SpriteRenderer>().sprite = spinSprites[1];
            indicatorSprite.GetComponent<SpriteRenderer>().sprite = indicatorSprites[1];
            for (int i=0; i < 8; i++)
            {
                rewardsOnSpin[i].GetComponent<SpriteRenderer>().sprite = silverRewards[i];
            }
        }
        else
        {
            zoneSprite.GetComponent<Image>().sprite = zoneSprites[0];
            spinSprite.GetComponent<SpriteRenderer>().sprite = spinSprites[0];
            indicatorSprite.GetComponent<SpriteRenderer>().sprite = indicatorSprites[0];
            for (int i = 0; i < 8; i++)
            {
                rewardsOnSpin[i].GetComponent<SpriteRenderer>().sprite = bronzeRewards[i];
            }
        }
    }
}
