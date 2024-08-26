using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        OnPlayerScore(1);
    }

    public void OnPlayerScore(int amount)
    {
        AudioManager.Instance.PlaySound(Sounds.Coin, 3);
    }
}
