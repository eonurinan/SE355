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


    public float defaultWallHealth = 300f;

    public float defaultMinSpawnDelay = 1f;
    public float defaultMaxSpawnDelay = 5f;


    public float defaultAmmoStandardSpeed = 10f;
    public int defaultAmmoStandardDamage = 50;

    public float defaultAmmoSlowingSpeed = 8f;
    public int defaultAmmoSlowingDamage = 30;

    public float defaultAmmoLaneSwiperSpeed = 15f;
    public int defaultAmmoLaneSwiperDamage = 1000;


    public static float ammoStandardSpeed { get; private set; }
    public static int ammoStandardDamage { get; private set; }

    public static float ammoSlowingSpeed { get; private set; }
    public static int ammoSlowingDamage { get; private set; }

    public static float ammoLaneSwiperSpeed { get; private set; }
    public static int ammoLaneSwiperDamage { get; private set; }


    public static float minSpawnDelay { get; private set; }

    public static float maxSpawnDelay { get; private set; }

    public static float wallHealth { get; private set; }

    public static float alienBalloonSpeed { get; private set; }
    public static int alienBalloonHealth { get; private set; }
    public static int alienBalloonDamage { get; private set; }

    public static float alienBirdSpeed { get; private set; }
    public static int alienBirdHealth { get; private set; }
    public static int alienBirdDamage { get; private set; }

    public static float alienOctopusSpeed { get; private set; }
    public static int alienOctopusHealth { get; private set; }
    public static int alienOctopusDamage { get; private set; }


    void Awake()
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

        wallHealth = defaultWallHealth;

        minSpawnDelay = defaultMinSpawnDelay;
        maxSpawnDelay = defaultMaxSpawnDelay;

        ammoStandardSpeed = defaultAmmoStandardSpeed;
        ammoStandardDamage = defaultAmmoStandardDamage;
        ammoSlowingSpeed = defaultAmmoSlowingSpeed;
        ammoSlowingDamage = defaultAmmoSlowingDamage;
        ammoLaneSwiperSpeed = defaultAmmoLaneSwiperSpeed;
        ammoLaneSwiperDamage = defaultAmmoLaneSwiperDamage;


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

            wallHealth = RemoteSettings.GetFloat("wallHealth", wallHealth);
            minSpawnDelay = RemoteSettings.GetFloat("minSpawnDelay", minSpawnDelay);
            maxSpawnDelay = RemoteSettings.GetFloat("maxSpawnDelay", maxSpawnDelay);

            ammoStandardSpeed = RemoteSettings.GetFloat("ammoStandardSpeed", ammoStandardSpeed);
            ammoStandardDamage = RemoteSettings.GetInt("ammoStandardDamage", ammoStandardDamage);

            ammoSlowingSpeed = RemoteSettings.GetFloat("ammoSlowingSpeed", ammoSlowingSpeed);
            ammoSlowingDamage = RemoteSettings.GetInt("ammoSlowingDamage", ammoSlowingDamage);

            ammoLaneSwiperSpeed = RemoteSettings.GetFloat("ammoLaneSwiperSpeed", ammoLaneSwiperSpeed);
            ammoLaneSwiperDamage = RemoteSettings.GetInt("ammoLaneSwiperDamage", ammoLaneSwiperDamage);
        };
    }
}