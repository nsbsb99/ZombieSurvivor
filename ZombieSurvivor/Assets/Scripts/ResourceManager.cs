using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ???
//using UnityEditor;

public class ResourceManager : MonoBehaviour
{

    private static ResourceManager m_instance; // 싱글톤이 할당될 static 변수
    public static ResourceManager instance
    {
        get
        {
            // 만약 싱글톤 변수에 아직 오브젝트가 할당되지 않았다면
            if (m_instance == null)
            {
                // 씬에서 GameManager 오브젝트를 찾아 할당
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // 싱글톤 오브젝트를 반환
            return m_instance;
        }
    }

    //private string dataPath = default;
    private static string zombieDataPath = default;
    public ZombieData zombieData_default = default;

    private void Awake()
    {
        //dataPath = Application.dataPath;
        //zombieDataPath = string.Format("{0}/{1}", Application.dataPath, "01.UnityProject/Scriptables");

        //byte[] byteZombieData = System.IO.File.ReadAllBytes(zombieDataPath + "/Zombie Data Default");
        //ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);

        //zombieDataPath = "Assets/01.UnityProject/Scriptables";
        //zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "/Zombie Data Default.asset");

        //기본 좀비 데이터 불러옴
        zombieDataPath = "Scriptables";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");
        //Resources 하위를 뒤진다.
        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);

        // zombieData_default = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);

        // Debug.LogFormat("Zombie Data Path: {0}", zombieDataPath);


        // Debug.LogFormat("Zombie data: {0}, {1}, {2}", zombieData_.health, zombieData_.damage,
        // zombieData_.speed);

        // 스팀 같은데서 게임을 다운 받으면 다 Users ... AppData 안 하위 폴더에 들어가 있다. 
        Debug.LogFormat("게임 Save Data를 여기에다가 저장하는 것이 상식이다. -> {0}",
            Application.persistentDataPath);

    }
}
