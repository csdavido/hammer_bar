using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCustomer : MonoBehaviour
{
        public int barCount = 0;
        public GameObject customerPrefab;
        private int randomNumber;
        public GameObject[] randomPrefab;
        
        void Start()
        {
            if (barCount < 2)
            {
                InvokeRepeating("getRandomCustomer", 2f, 5f);
            }
            
            
        }

        void Update()
        {
            if (barCount >= 2)
            {
                CancelInvoke();
            }
            
        }

        public void getRandomCustomer()
        {
           if(UnityEngine.Random.Range(0,10) < 5)
           {
               customerPrefab = randomPrefab[1];
           }
           else
           {
               customerPrefab = randomPrefab[0];
           }
           Instantiate(customerPrefab, new Vector2(-3, -4), Quaternion.identity);
           barCount++;


        }
    }