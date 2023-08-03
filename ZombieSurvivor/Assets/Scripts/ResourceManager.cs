using System;
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
    //private static string zombieDataPath = default;
    //public ZombieData zombieData_default = default;

    public ZombieData zombieData_default = default;
    public ZombieData zombieData_fast = default;
    public ZombieData zombieData_strong = default;
    public ZombieData[] zombieDatas = default;

    private void Awake()
    {
        //dataPath = Application.dataPath;
        //zombieDataPath = string.Format("{0}/{1}", Application.dataPath, "01.UnityProject/Scriptables");

        //byte[] byteZombieData = System.IO.File.ReadAllBytes(zombieDataPath + "/Zombie Data Default");
        //ZombieData zombieData_ = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);

        //zombieDataPath = "Assets/01.UnityProject/Scriptables";
        //zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "/Zombie Data Default.asset");

        #region ���� ������ Scriptables���� �ۿ���
        //�⺻ ���� ������ �ҷ���
        //zombieDataPath = "Scriptables";
        //zombieDataPath = string.Format("{0}/{1}", zombieDataPath, "Zombie Data Default");
        //Resources ������ ������.
        //zombieData_default = Resources.Load<ZombieData>(zombieDataPath);
        #endregion

        //���� ������ �о����

        TextAsset datas = Resources.Load<TextAsset>("Zombie Datas/ZombieData_CSV");
        // ������ �� �� 
        string[] thisDatas = datas.text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        // ������ �� ���
        string[] elements = default;

        //thisDatas[0] = Ÿ�� �з�
        //thisDatas[1~3] = default, fast, heavy
        int count = thisDatas.Length-1; // �� �� �� 
        Debug.Log(count);
        zombieDatas = new ZombieData[count];

        //�� �� ��� �ɰ���
        for (int i = 1; i < count; i++)
        {
            elements = thisDatas[i].Split(new char[] { ',' });

            string zombieType = elements[0];
            float health = float.Parse(elements[1]); // �� ���� Index ���� ���. 
            float damage = float.Parse(elements[2]);
            float speed = float.Parse(elements[3]);
            Color zombieColor = default;
            string tempColor = elements[4].Remove(elements[4].Length - 1);
            ColorUtility.TryParseHtmlString(tempColor, out zombieColor);

            zombieDatas[i] = new ZombieData(health, damage, speed, zombieColor);
        }

        
        

        //�� ���� �����Ͱ� �������� ���� �ʿ�
        
        
        

        // zombieData_default = AssetDatabase.LoadAssetAtPath<ZombieData>(zombieDataPath);

        // Debug.LogFormat("Zombie Data Path: {0}", zombieDataPath);


        // Debug.LogFormat("Zombie data: {0}, {1}, {2}", zombieData_.health, zombieData_.damage,
        // zombieData_.speed);

        // ���� �������� ������ �ٿ� ������ �� Users ... AppData �� ���� ������ �� �ִ�. 
        //Debug.LogFormat("���� Save Data�� ���⿡�ٰ� �����ϴ� ���� ����̴�. -> {0}",
        //    Application.persistentDataPath);

    }
}
