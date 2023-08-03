using UnityEngine;

// 좀비 생성시 사용할 셋업 데이터
[CreateAssetMenu(menuName = "Scriptable/ZombieData", fileName = "Zombie Data")]
public class ZombieData : ScriptableObject {
    public float health = 100f; // 체력
    public float damage = 20f; // 공격력
    public float speed = 2f; // 이동 속도
    public Color skinColor = Color.white; // 피부색

    public ZombieData(float health_, float damage_, float speed_, Color skinColor_)
    {
        health = health_;
        damage = damage_;
        speed = speed_;
        skinColor = skinColor_;
    }
}
