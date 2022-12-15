using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public Pizza pizza;
    public Collider rawIngredient;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        pizza.onIngredientPlaced.AddListener(IngredientComplete);
    }

    void IngredientComplete(Collider ingredient)
    {
        if (ingredient == rawIngredient)
        {
            gameObject.SetActive(true);
        }
    }

}
