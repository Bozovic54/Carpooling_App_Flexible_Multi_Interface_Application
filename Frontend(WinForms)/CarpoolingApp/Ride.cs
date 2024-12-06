using System;
using System.Windows.Forms;

namespace CarpoolingApp
{
    public partial class ucRide : UserControl
    {
        public ucRide()
        {
            InitializeComponent();
        }
        public void SetRideDetails(string startLocation,  string endLocation, decimal price, DateTime Date, TimeSpan arrivalTime,
            TimeSpan departureTime, string name, int experience, int rating)
        {
            lblStartLocation.Text = startLocation;
            lblEndLocation.Text = endLocation;
            lblDate.Text = Date.ToString("dd.MM.yyyy");
            lblPrice.Text = $"{price} RSD";
            lblArrivalTime.Text = arrivalTime.ToString(@"hh\:mm");
            lblDepartureTime.Text = departureTime.ToString(@"hh\:mm");
            lblCustomerName.Text = name;
            lblExperienceLevelValue.Text = experience.ToString();
            lblRatingValue.Text = rating.ToString();
        }
    }
}
