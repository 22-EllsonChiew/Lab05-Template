using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerObject : MonoBehaviour
{

    private float scoreValue;

    public float totalCoins;

    public float timeLeft;

    public int timeRemaining;

    public Text ScoreText;
    public Text TimerText;

    private float TimerValue;

    //public int theScore;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timeRemaining = Mathf.FloorToInt(timeLeft % 60);

        TimerText.text = "Timer: " + timeRemaining.ToString();

        if(scoreValue >= 60)
        {
            
            SceneManager.LoadScene("GameWin");
            /*if(timeLeft <= TimerValue)
            {
                Debug.Log("Win");
                //SceneManager.LoadScene("");
            }*/
        }
        else if (timeLeft <= 0)
        {
            
            SceneManager.LoadScene("GameLose");
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coins")
        {
            scoreValue += 10;
            ScoreText.GetComponent<Text>().text = "Score: " + scoreValue;
            Destroy(other.gameObject);
        }
        
        if(other.gameObject.tag == "Water")
        {
            
            SceneManager.LoadScene("GameLose");
        }


    }
}
