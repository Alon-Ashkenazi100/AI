using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{ 
public class DestroyOnTrigger : MonoBehaviour
    {
        public string nameContains;

        void OnTriggerEnter(Collider col)
        {
            //If name contains the string 'nameContains'
            if(col.name.Contains(nameContains))
            {
                //Destroy that object
                Destroy(col.gameObject);
            }
        }
	}
}
