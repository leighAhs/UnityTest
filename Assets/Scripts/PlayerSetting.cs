using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSetting", menuName = "Scriptable Objects/PlayerSetting")]
public class PlayerSetting : ScriptableObject
{
    static PlayerSetting PlayerData;

    public static PlayerSetting data
    {
        get
        {
            if(PlayerData == null)
            {
                PlayerData = Resources.Load<PlayerSetting>("PlayerSetting");
            }
            return PlayerData;
        }
    }

    public PlayerData playerData;
}
[System.Serializable]
public class PlayerData
{
    public int score;
}

