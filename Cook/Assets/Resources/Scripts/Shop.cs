using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int wallUpgradeLevel = 1, breadUpgradeLevel = 1, chickenUpgradeLevel = 1, spicyUpgradeLevel = 1; //Upgrade Level Counters
    public int WallUpgradePrize = 10, BreadUpgradePrize = 10, ChickenUpgradePrize = 10, SpicyUpgradePrize = 10; //Prize For Each Upgrade
    public GameObject ShopPanel; //Manual ekledim inspectordan
    public Button WallUpgradeButton_, BreadUpgradeButton_, ChickenUpgradeButton_, SpicyUpgradeButton_;
    public Text WallUpgradeLevel_, BreadUpgradeLevel_, ChickenUpgradeLevel_, SpicyUpgradeLevel_;




    // Start is called before the first frame update

    public void Awake()
    {
        ButtonTextİnitial();
    }
    public void ButtonTextİnitial()
    {
        WallUpgradeButton_ = GameObject.Find("WallUpgradeButton").GetComponent<Button>();
        WallUpgradeLevel_ = GameObject.Find("WallUpgradeLevel").GetComponent<Text>();
        BreadUpgradeButton_ = GameObject.Find("BreadUpgradeButton").GetComponent<Button>();
        BreadUpgradeLevel_ = GameObject.Find("BreadUpgradeLevel").GetComponent<Text>();
        ChickenUpgradeButton_ = GameObject.Find("ChickenUpgradeButton").GetComponent<Button>();
        ChickenUpgradeLevel_ = GameObject.Find("ChickenUpgradeLevel").GetComponent<Text>();
        SpicyUpgradeButton_ = GameObject.Find("SpicyUpgradeButton").GetComponent<Button>();
        SpicyUpgradeLevel_ = GameObject.Find("SpicyUpgradeLevel").GetComponent<Text>();
        ReloadText();
    }

    public void ReloadText()
    {
        WallUpgradeLevel_.text = "Level : " + wallUpgradeLevel;
        BreadUpgradeLevel_.text = "Level : " + breadUpgradeLevel;
        ChickenUpgradeLevel_.text = "Level : " + chickenUpgradeLevel;
        SpicyUpgradeLevel_.text = "Level : " + spicyUpgradeLevel;
        GameManager.instance.reloadGold();
    }

    void Update()
    {
        //GameManager.instance.reloadGold();
    }
    public void ToggleShop()
    {
        ShopPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ExitShop()
    {
        ShopPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void wallUpgradeButton()
    {
        if(GameManager.gold >= WallUpgradePrize && wallUpgradeLevel < 2)
        {
            GameManager.gold = GameManager.gold - WallUpgradePrize;
            wallUpgradeLevel++;
            Wall.health = Wall.health + 200;
            Debug.Log("Wall Health increased 200");
            ReloadText();

        }
        else if(wallUpgradeLevel == 2)
        {
            WallUpgradeButton_.interactable = false;
            Debug.Log("Wall Upgrade Reached Max Level");
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }
    public void BreadUpgradeButton()
    {
        if (GameManager.gold >= BreadUpgradePrize && breadUpgradeLevel < 4)
        {
            breadUpgradeLevel++;
            GameManager.gold = GameManager.gold - BreadUpgradePrize;
            Debug.Log("Bread Upgrade Level İncrease 1");
            ReloadText();
        }
        else if(breadUpgradeLevel == 4)
        {
            BreadUpgradeButton_.interactable = false;
            Debug.Log("Bread Upgrade Reached Max Level");
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }
    public void ChickenButton()
    {
        if (GameManager.gold >= ChickenUpgradePrize && breadUpgradeLevel < 4)
        {
            chickenUpgradeLevel++;
            GameManager.gold = GameManager.gold - ChickenUpgradePrize;
            Debug.Log("Chicken Upgrade Level İncrease 1");
            ReloadText();
        }
        else if (chickenUpgradeLevel == 4)
        {
            ChickenUpgradeButton_.interactable = false;
            Debug.Log("Chicken Upgrade Reached Max Level");
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }
    public void SpicyButton()
    {
        if (GameManager.gold >= SpicyUpgradePrize && spicyUpgradeLevel < 4)
        {
            chickenUpgradeLevel++;
            GameManager.gold = GameManager.gold - SpicyUpgradePrize;
            Debug.Log("Spicy Upgrade Level İncrease 1");
            ReloadText();
        }
        else if (chickenUpgradeLevel == 4)
        {
            ChickenUpgradeButton_.interactable = false;
            Debug.Log("Spicy Upgrade Reached Max Level");
        }
        else
        {
            Debug.Log("Not Enough Gold");
        }
    }
}
