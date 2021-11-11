using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuContoller : MonoBehaviour
{
  public void PlayGame()
    {
        // string clickedOBj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedCharacter;


        SceneManager.LoadScene("Gameplay");
    }
}
