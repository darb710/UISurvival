using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class eat : MonoBehaviour
{
    private PlayerVitals vitals;
    public void eatMe()
    {
        if (System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) > 1)
        {
            int tcount = System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) - 1;
            this.transform.Find("Text").GetComponent<Text>().text = "" + tcount;
            vitals.hungerSlider.value += 10;
            vitals.thirstSlider.value += 10;
        }
        else
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            eatMe();
           
          

            
        }
    }
}
