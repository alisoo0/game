using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    //��� �����, ������� ����� �������������
    public string sceneName;
        
    

    void OnTriggerEnter()
    {
    EditorSceneMnager.LoadScene(sceneName);
    }
}
