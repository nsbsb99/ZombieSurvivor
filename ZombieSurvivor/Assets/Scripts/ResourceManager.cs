using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ???
//using UnityEditor;

public class ResourceManager : MonoBehaviour
{

    private static ResourceManager m_instance; // �̱����� �Ҵ�� static ����
    public static ResourceManager instance
    {
        get
        {
            // ���� �̱��� ������ ���� ������Ʈ�� �Ҵ���� �ʾҴٸ�
            if (m_instance == null)
            {
                // ������ GameManager ������Ʈ�� ã�� �Ҵ�
                m_instance = FindObjectOfType<ResourceManager>();
            }

            // �̱��� ������Ʈ�� ��ȯ
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

        //�⺻ ���� ������ �ҷ���
        zombieDataPath = "Scriptables";
        zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");
        //Resources ������ ������.
        zombieData_default = Resources.Load<ZombieData>(zombieDataPath);

        // zombieData_default = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);

        // Debug.LogFormat("Zombie Data Path: {0}", zombieDataPath);


        // Debug.LogFormat("Zombie data: {0}, {1}, {2}", zombieData_.health, zombieData_.damage,
        // zombieData_.speed);

        // ���� �������� ������ �ٿ� ������ �� Users ... AppData �� ���� ������ �� �ִ�. 
        Debug.LogFormat("���� Save Data�� ���⿡�ٰ� �����ϴ� ���� ����̴�. -> {0}",
            Application.persistentDataPath);

    }
}
