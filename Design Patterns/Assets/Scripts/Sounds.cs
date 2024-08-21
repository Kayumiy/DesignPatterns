using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public static AudioClip Score;
    public static AudioClip Death;
    public static AudioClip Coin;

    public AudioClip score;
    public AudioClip death;
    public AudioClip coin;


    private void Awake()
    {
        Score = score;
        Coin = coin;
        Death = death;
    }


}
