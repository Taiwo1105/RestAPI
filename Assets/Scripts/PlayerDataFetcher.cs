using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayerDataFetcher : MonoBehaviour
{
    public string url = "https://api.jsonbin.io/v3/b/6686a992e41b4d34e40d06fa";
    public PlayerUIController uiController;

    IEnumerator Start()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Error: " + request.error);
            yield break;
        }

        string json = request.downloadHandler.text;
        Root data = JsonUtility.FromJson<Root>(json);

        uiController.DisplayPlayerData(data.record);
    }
}

