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
        print(other.tag);
        if (other.tag == "Player")
        {
            other.GetComponent<Player>().points++;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
    if (counter >= 1)
    {
        counter++;
    }
    }
}
