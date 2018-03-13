using Android.App;
using Android.Widget;
using Android.OS;

namespace carListVieww
{
    [Activity(Label = "carListVieww", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        Car[] cars;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Car firstCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "1");
            Car secondCar = new Car(Resource.Drawable.asdads, "Volvo", "KW235", "2");
            Car thirdCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "3");
            Car fourthCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "4");
            Car fifthCar = new Car(Resource.Drawable.asdads, "Volvo", "KW235", "5");
            Car sixthCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "6");
            Car seventhCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "7");
            Car eightCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "8");
            Car ninthCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "9");
            Car tenthCar = new Car(Resource.Drawable.car, "Volvo", "KW235", "10");

            cars = new Car[] { firstCar, secondCar, thirdCar, fourthCar, fifthCar, sixthCar, seventhCar, eightCar, ninthCar, tenthCar };

            ListAdapter = new CarListViewAdapter(this, cars);
            ListView.FastScrollEnabled = true;
          
        }
    }
}

