using UnityEngine;

[CreateAssetMenu(fileName = "character", menuName = "Character")]
public class Character : ScriptableObject
{
    [Header("Character Model")]
    [SerializeField] private GameObject _characterModel;
    public GameObject Model { get => _characterModel; }

    [Header("Character Information")]
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    public string Name { get => _name; }
    public string Description { get => _description; }

    [Header("Character Requirement")]
    [SerializeField] private int _unlockLevel;
    [SerializeField] private int _unlockPrice;
    public int UnlockLevel { get => _unlockLevel; }
    public int UnlockPrice { get => _unlockPrice; }

    [Header("Character Skills")]
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private int _startHealth;
    [SerializeField] private int _startDamage;
    [SerializeField] private float _startSpeed;
    public int StartHealth { get => _startHealth; }
    public int StartDamage { get => _startDamage; }
    public float StartSpeed { get => _startSpeed; }
    [SerializeField] private int _healthMax;
    [SerializeField] private int _damageMax;
    [SerializeField] private float _speedMax;
    public int Health { get => _health; set => _health = value;}
    public int Damage { get => _damage; set => _damage = value;}
    public float Speed { get => _speed; set => _speed = value;}
    public int HealthMax { get => _healthMax; }
    public int DamageMax { get => _damageMax; }
    public float SpeedMax { get => _speedMax; }
    
    public static float StatsMax { get; } = 2000f;

    [Header("Attack Settings")]
    public float Reloading = 3;
    public float AttackDistance = 10f;
    public int BulletAmount= 1;
    public float BulletSpeed = 8f;

    [Header("Character Levels")]
    [SerializeField] private int _currentLevel = 1;
    [SerializeField] private int _maxLevel = 10;
    [SerializeField] private int _currentExp = 0;
    [SerializeField] private int _enoughtExp = 5;
    public int CurrentLevel { get => _currentLevel; set => _currentLevel = value;}
    public int MaxLevel { get => _maxLevel; }
    public int CurrentExp { get => _currentExp; set => _currentExp = value;}
    public int EnoughtExp { get => _enoughtExp; set => _enoughtExp = value;}


    [Header("Character Statistics")]
    public int StatisticsPlayed = 0;
    public int StatisticsVictories = 0;
    public int StatisticsLosses = 0;
    public int StatisticsKilled = 0;
    public int StatisticsDeaths = 0;
    public int StatisticsMaxKilled = 0;
    public int StatisticsBonuses = 0;
    public int StatisticsDamage = 0;
    public int StatisticsRegeneration = 0;
    public int StatisticsEaten = 0;
}
