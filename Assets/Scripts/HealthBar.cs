using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	public Character character;
	public Transform foregroundSprite;
	public SpriteRenderer foregroundRenderer;
	public Color maxHealthColor = new Color(255f / 255f, 63f / 255f, 63f / 255f);
	public Color minHealthColor = new Color(64f / 255f, 137f / 255f, 255f / 255f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var healthPercent = character.health / character.maxHealth;

		foregroundSprite.localScale = new Vector3(healthPercent, 1f, 1f);
		foregroundRenderer.color = Color.Lerp(maxHealthColor, minHealthColor, healthPercent);
	}
}
