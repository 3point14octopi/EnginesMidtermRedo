using System.Collections;
using UnityEngine;

 public class MileageTracker : MonoBehaviour
    {
        public static MileageTracker instance;

        float mileage = 0;
        public bool shouldUpdate = false;
    private int divider = 30;
        // Use this for initialization
        void Awake()
        {
            if (!instance)
            {
                instance = this;
            }
        }

        public void AddMileage(float distanceTraveled)
        {
            mileage += distanceTraveled;

            if(mileage > 0 && (mileage/divider >= 1))
            {
                shouldUpdate = true;
                divider *= 2;
            }

           
        }
        public float TheMileage()
        {
            return mileage;
        }
    }