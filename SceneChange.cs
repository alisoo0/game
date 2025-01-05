using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    //Имя сцены, которую нужно перезапустить
    public string sceneName;
        
    

    void OnTriggerEnter()
    {
    EditorSceneMnager.LoadScene(sceneName);
    }
}
