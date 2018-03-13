using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace carListVieww
{
    class CarListViewAdapter : BaseAdapter<Car>
    {
        Car[] cars;
        Activity context;

        public CarListViewAdapter(Activity context, Car[] cars) : base()
        {
            this.context = context;
            this.cars = cars;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Car this[int position]
        {
            get { return cars[position]; }
        }

        public override int Count
        {
            get { return cars.Length; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.listViewLayout, null);
            }
            view.FindViewById<ImageView>(Resource.Id.image).SetImageResource(cars[position].image);
            view.FindViewById<TextView>(Resource.Id.text1).Text = cars[position].manufacturer;
            view.FindViewById<TextView>(Resource.Id.text2).Text = cars[position].model;
            view.FindViewById<TextView>(Resource.Id.text3).Text = cars[position].kilowatts;
            return view;
        }
}
    }