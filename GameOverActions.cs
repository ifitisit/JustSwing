using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class GameOverActions : MonoBehaviour
{   
    public GameOverScreen GameOverScreen;

    private void OnTriggerEnter2D(Collider2D collision){
    if (collision.GetComponent<Collider2D>()!=null){
        AnalyticsResult analyticsResult = Analytics.CustomEvent(
            "Player died",
            new Dictionary<string,object>{
                {"Level", 1},
                {"Position", transform.position.x},
                {"Time spent", Time.time }
            }
        );
        UnityEngine.Debug.Log("Death log:"+analyticsResult + "; Time spent: " + Time.time.ToString());
        GameOverScreen.Setup();
    }
}
}
