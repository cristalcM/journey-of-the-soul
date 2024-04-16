using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UIElements;
public static class SaveManajer 
{
    public static void SavePlayerData(movimientopersonaje player)
    {
        playerdata playerdata = new playerdata(player);
        string dataPath = Application.dataPath + "/player.save";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryformatter = new BinaryFormatter();
        binaryformatter.Serialize(fileStream, playerdata);
        fileStream.Close();
    }
    public static playerdata LoadPlayerData()
    {
        string datapath = Application.dataPath + "/player.save";
        if (File.Exists(datapath))
        {
            FileStream filestream = new FileStream(datapath, FileMode.Open);
            BinaryFormatter binformatter = new BinaryFormatter();   
            playerdata playerdata = (playerdata)binformatter.Deserialize(filestream);
            filestream.Close();
            return playerdata;  
        }
        else

        {
            Debug.LogError("NO HAY ARCHIVOS GUARDADOS");
            return null;  
        }
        
    }
}
