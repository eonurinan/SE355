using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteConfig : MonoBehaviour
{
    public float defaultAlienBalloonSpeed = 1f;
    public int defaultAlienBalloonHealth = 20;
    public int defaultAlienBalloonDamage = 10;

    public float defaultAlienBirdSpeed = 1.5f;
    public int defaultAlienBirdHealth = 10;
    public int defaultAlienBirdDamage = 50;

    public float defaultAlienOctopusSpeed = 0.5f;
    public int defaultAlienOctopusHealth = 100;
    public int defaultAlienOctopusDamage = 10;


    public static float alienBalloonSpeed { get; private set; }
    public static int alienBalloonHealth { get; private set; }
    public static int alienBalloonDamage { get; private set; }

    public static float alienBirdSpeed { get; private set; }
    public static int alienBirdHealth { get; private set; }
    public static int alienBirdDamage { get; private set; }

    public static float alienOctopusSpeed { get; private set; }
    public static int alienOctopusHealth { get; private set; }
    public static int alienOctopusDamage { get; private set; }


    void Start()
    {
        alienBalloonSpeed = defaultAlienBalloonSpeed;
        alienBalloonHealth = defaultAlienBalloonHealth;
        alienBalloonDamage = defaultAlienBalloonDamage;

        alienBirdSpeed = defaultAlienBirdSpeed;
        alienBirdHealth = defaultAlienBirdHealth;
        alienBirdDamage = defaultAlienBirdDamage;

        alienOctopusSpeed = defaultAlienOctopusSpeed;
        alienOctopusHealth = defaultAlienOctopusHealth;
        alienOctopusDamage = defaultAlienOctopusDamage;

        RemoteSettings.Completed += (b, b1, arg3) =>
        {
            alienBalloonSpeed = RemoteSettings.GetFloat("alienBalloonSpeed", alienBalloonSpeed);
            alienBalloonHealth = RemoteSettings.GetInt("alienBalloonHealth", alienBalloonHealth);
            alienBalloonDamage = RemoteSettings.GetInt("alienBalloonDamage", alienBalloonDamage);

            alienBirdSpeed = RemoteSettings.GetFloat("alienBirdSpeed", alienBirdSpeed);
            alienBirdHealth = RemoteSettings.GetInt("alienBirdHealth", alienBirdHealth);
            alienBirdDamage = RemoteSettings.GetInt("alienBirdDamage", alienBirdDamage);

            alienOctopusSpeed = RemoteSettings.GetFloat("alienOctopusSpeed", alienOctopusSpeed);
            alienOctopusHealth = RemoteSettings.GetInt("alienOctopusHealth", alienOctopusHealth);
            alienOctopusDamage = RemoteSettings.GetInt("alienOctopusDamage", alienOctopusDamage);
        };
    }
}