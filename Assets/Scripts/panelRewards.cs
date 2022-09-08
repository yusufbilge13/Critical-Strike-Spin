using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class panelRewards : MonoBehaviour
{
    public GameObject[] rewardsOnPanel = new GameObject[24];
    public Sprite bomb;
    private int k = 0;
    public GameObject spinOverPanel;
    public GameObject currentReward;
    public GameObject panelCurrentReward;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("reward"))
        {
            if (ruletSpin.indicatorShows && other.gameObject.GetComponent<SpriteRenderer>().sprite == bomb)
            {
                spinOverPanel.SetActive(true);
            }
            else if (ruletSpin.indicatorShows)
            {
                panelCurrentReward.SetActive(true);
                currentReward.GetComponent<SpriteRenderer>().sprite = other.gameObject.GetComponent<SpriteRenderer>().sprite;
                rewardsOnPanel[k].GetComponent<SpriteRenderer>().sprite = other.GetComponent<SpriteRenderer>().sprite;
                k++;

                ruletSpin.indicatorShows = false;
            }
        }
    }

    public void tryAgainButton()
    {
        ruletSpin.indicatorShows = false;
        ruletSpin.timee = 0.0f;
        spinOverPanel.SetActive(false);
        Zone.counter = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void exitButton()
    {
        Application.Quit();
    }
    public void goOnButton()
    {
        panelCurrentReward.SetActive(false);
    }
}
