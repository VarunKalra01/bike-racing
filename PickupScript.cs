using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    private ScoreScript scoreScript;
    void Start()
    {
        scoreScript = GameObject.FindObjectOfType<ScoreScript>();
        if (scoreScript == null)
        {
            Debug.LogError("ERORRRRR!");
            return;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            scoreScript.IncreaseScore(20);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
