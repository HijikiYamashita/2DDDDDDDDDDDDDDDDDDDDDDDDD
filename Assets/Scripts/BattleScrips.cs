using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleScrips : MonoBehaviour
{
    int enemyHP = 100;
    int playerHP = 9999;

    public Text enemyHPText;
    public Text playerHPText;

    int enemyPower = 3333;

    int playerPower = 1;

    public Text PPT;

    int enemyAttack = 10;

    public Text EAT;

    void Start()
    {
        
    }

    void Update()
    {
        enemyHPText.text = "敵のHP : " + enemyHP.ToString();
        playerHPText.text = "ﾌﾟﾚｲﾔｰのHP : " + playerHP.ToString();
        PPT.text = "ﾌﾟﾚｲﾔｰの攻撃力 : " + playerPower.ToString();
        EAT.text = "敵攻撃まであと\n" + enemyAttack.ToString() + "ターン";

        if (enemyAttack == 0)
        {
            playerHP -= 3333;
            enemyAttack = 10;
        }
        if (enemyHP <= 0)
        {
            SceneManager.LoadScene("Clear");
        }
        if (playerHP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void charge()
    {
        playerPower += 1;
        enemyAttack -= 1;
    }
    public void attack()
    {
        enemyHP -= playerPower;
        enemyAttack -= 1;
    }
}
