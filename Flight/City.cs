﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Flight
{
    public class City
    
        {

            private String name;
	        private Double latitude;
            private Double longitude;

            /**
             * Empty-argument constructor to put 
             * object into a consistent state.
             */
            public City()
            {
                name = "";
                latitude = 0.0;
                longitude = 0.0;
            }//end constructor

            /**
             * Constructor to instantiate the object.
             * @param name
             * @param latitude
             * @param longitude
             */
            public City(String name, double latitude, double longitude)
            {
                this.name = name;
                this.latitude = latitude;
                this.longitude = longitude;
            }//end constructor

            /**
             * Getter for name
             * @return
             */
            public String getName()
            {
                return name;
            }//end getName

            /**
             * Getter for latitude
             * @return
             */
            public double getLatitude()
            {
                return latitude;
            }//end getName

            /**
             * Getter for longitude
             * @return
             */
            public double getLongitude()
            {
                return longitude;
            }

            
            public String toString()
            {
                return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
            }
        }//end class
    
}
