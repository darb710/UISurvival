using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class eat : MonoBehaviour
{

    //HungerSlider vitals : PlayerVitals;
    public PlayerVitals vitals;
    

    public void eatMe()
    {
        
        if (System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) > 1)
        {
            GameObject hunger = GameObject.FindWithTag("hunger");
            int tcount = System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) - 1;
            this.transform.Find("Text").GetComponent<Text>().text = "" + tcount;
            hunger.GetComponent<PlayerVitals>().hungerSlider.value += 20;


        }
        else
        {
            Destroy(this.gameObject);
            //hungerSlider.
        }


    }
    void Update()
    {
       
        if (Input.GetKeyDown("1"))
        {
 
            eatMe();
            
            //vitals.hungerSlider.value = vitals.hungerSlider.value + 20;
            
            //vitals.eatFood(gameObject);
            //vitals.thirstSlider.value += 20;
            // Debug.Log("Trying Slider", vitals);
        }
    }
    void start()
    {
     
        //vitals = Player.Find("PlayerVitals").GetComponent<PlayerVitals>().healthSlider.value;
       // vitals = GameObject.Find("hungerSlider").GetComponent<PlayerVitals>();
       // vitals = PlayerVitals.hungerSlider.transform.Find("hungerSlider").GetComponent<PlayerVitals>();
        //vitals = GameObject.Find("hunderSlider").
}
}
