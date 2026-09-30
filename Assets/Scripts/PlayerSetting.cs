using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlayerSetting", menuName = "ScriptableObject/PlayerSetting")]
public class PlayerSetting : ScriptableObject
{

    static PlayerSetting PlayerData;

    public static PlayerSetting data
    {
        get
        {
            if (PlayerData == null)
            {
                PlayerData = Resources.Load<PlayerSetting>("PlayerSetting");
            }
            return PlayerData;
        }
    }

    public int score;

    public EnemyStats[] enemies;
    //public float[] enemySpeed;
    //public List<string> enemiesList;
}

[System.Serializable]
public class EnemyStats
{
    public GameObject enemyPrefab;
    public float speed;
    public int HP;
}