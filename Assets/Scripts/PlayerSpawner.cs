using UnityEngine;
using Cinemachine;

//referenced:https://github.com/TylerPottsDev/yt-unity-character-selector

public class PlayerSpawner : MonoBehaviour {
    public GameObject myPlayer;
    public CinemachineVirtualCamera Vcamera;

    public void Start() {

        myPlayer = Instantiate(GameManager.instance.currentCharacter.prefab, transform.position, Quaternion.identity);

        // Vcamera = GameObject.Find("Vcamera").GetComponent<CinemachineVirtualCamera>();
    
        Vcamera.Follow = myPlayer.GetComponent<Transform>();
        
    
    }


}