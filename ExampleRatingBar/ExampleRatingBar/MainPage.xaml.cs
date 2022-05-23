using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExampleRatingBar
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int ratingVal;
        public int RatingValue
        {
            get
            {
                return this.ratingVal;
            }
            set
            {
                this.ratingVal = value;
                OnPropertyChanged("RatingValue");
            }
        }
        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();
            RatingValue = 0;
        }
    }
}
