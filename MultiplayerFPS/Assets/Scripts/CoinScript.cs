using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    int counter = 1;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        print("[CoinScript.cs] triggered");
        print(other.name);
        if (other.name == "Player 1")
        {
            other.GetComponent<Player>().points++;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
    if ("Player" + counter == "1")
    {
        counter++;
    }
  }
}
