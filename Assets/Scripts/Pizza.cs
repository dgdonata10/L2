using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pizza : MonoBehaviour
{
    public Collider[] Ingredients;
    int index = 0;

    public class OnIngredientPlaced: UnityEvent<Collider> {}
    public OnIngredientPlaced onIngredientPlaced = new OnIngredientPlaced();

    private void OnTriggerEnter(Collider other)
    {
        if (other == Ingredients[index])
        {
            Ingredients[index].gameObject.SetActive(false);
            onIngredientPlaced.Invoke(other);
            index++;
            Debug.Log("Labas vakaras");
        }
    }
}
