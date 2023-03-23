using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirtBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;
	public KitchenStuffCounter KSC;
	public float DirtHeath;


	private void Start()
    {
		KSC = GetComponent<KitchenStuffCounter>();

		DirtHeath = KSC.percentage;
    }

    private void Update()
    {
		SetMaxHealth(DirtHeath);
    }
    public void SetMaxHealth(float health)
	{
		slider.maxValue = 100;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
	}

	public void SetHealth(int health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
	// Update is called once per frame
}
