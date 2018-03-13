using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace carListVieww
{
    class Car
    {
        public int image { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string kilowatts { get; set; }

        public Car(int image , string manufacturer, string model, string kilowatts)
        {
            this.image = image;
            this.manufacturer = manufacturer;
            this.model = model;
            this.kilowatts = kilowatts;
        }
    }
}