using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RSDSCADA.Models
{
    public class Order: INotifyPropertyChanged
    {

        public int id { get; set; }

        public string status { get; set; }

        public int blue { get; set; }

        public int red { get; set; }

        public int yellow { get; set; }


        public double rating()
        {
            if (status != "ready")
                return 0;

            
            var time = blue + red + yellow+ CostOfNewOrder;

            var Orderpoints = points+2;


            if (time==0||Orderpoints==0)
                return 0;

            return Orderpoints/time;
        }

        [JsonIgnore]
        public double points =>(CorrectOrder? (blue * 1 + red * 3 + yellow * 5 +2):-20)+ (Ontime ? 0 : -10);

        private const double CostOfNewOrder = 4;
        //private double timeEstimate => blue + red + yellow + CostOfNewOrder;

        private bool ontime=true;


        [JsonIgnore]
        public bool Ontime {
            get { return ontime; }
            set { ontime = value; NotifyPropertyChanged("points"); } }



        private bool correctOrder=true;

        [JsonIgnore]
        public bool CorrectOrder {
            get { return correctOrder; }
            set { correctOrder = value; NotifyPropertyChanged("points"); } }


        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
