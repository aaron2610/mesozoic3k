[Header("Character Info")]
[Header(charName + " of " + charFrom;)]
[Tooltip("Health value between 0 and 100.")]
public int health = 0;
public int maxHealth = 100;
public string charNickName;
public string charFrom;
public float charStr = 50 + clan_skill_bonus;
public float charStamina = 20 + clan_skill_bonus;
public float charFootSpeed = Random.range(.9, 1.2);
public float charTotalDMG = (charStr / 10 ) + weaponDMG;

string charDisplayName = charName + " of " + charFrom;
