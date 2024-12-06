using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace CarpoolingApp
{
    public partial class Carpooling : Form
    {
        public Carpooling()
        {
            InitializeComponent();
            SetPlaceholder(txtStartLocation, "Polazak");
            SetPlaceholder(txtEndLocation, "Dolazak");

        }
        private List<dynamic> rides;
        private List<dynamic> filteredRides;

        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
        private void DisplayRides(List<dynamic> rides)
        {
            pnlRides.Controls.Clear();

            if(rides.Count == 0)
            {
                MessageBox.Show($"Nažalost, nema rezultata za Vašu pretragu", "Obaveštenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (var ride in rides)
            {
                var startLocation = ride["startLocation"].ToString();
                var endLocation = ride["endLocation"].ToString();
                var price = decimal.Parse(ride["price"].ToString()); 
                var date = DateTime.Parse(ride["date"].ToString()); 
                var departureTime = TimeSpan.Parse(ride["departureTime"].ToString());
                var arrivalTime = TimeSpan.Parse(ride["arrivalTime"].ToString());
                var name = ride["customer"]["firstName"].ToString(); 
                var experience = int.Parse(ride["customer"]["experienceLevel"].ToString());
                var rating = int.Parse(ride["customer"]["rating"].ToString());

                var rideControl = new ucRide();
                rideControl.SetRideDetails(startLocation, endLocation, price, date, arrivalTime, departureTime, 
                                            name, experience, rating);
                rideControl.Dock = DockStyle.Top;
                pnlRides.Controls.Add(rideControl);
            }
        }
        private async Task SearchRides(string startLocaion, string endLocation, string date, decimal seats)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    var queryParameters = new List<string>();

                    queryParameters.Add($"StartLocation={Uri.EscapeDataString(startLocaion)}");
                    queryParameters.Add($"EndLocation={Uri.EscapeDataString(endLocation)}");
                    queryParameters.Add($"Date={Uri.EscapeDataString(date)}");
                    queryParameters.Add($"SeatsAvailable={seats}");

                    string queryString = string.Join("&", queryParameters);
                    string apiUrl = $"http://localhost:5283/search?{queryString}";

                    var response = await client.GetAsync(apiUrl);
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    rides = JsonConvert.DeserializeObject<List<dynamic>>(jsonResponse);
                    filteredRides = rides;
                    DisplayRides(rides);
                }
            }
            
            catch (Exception ex)
            {

                MessageBox.Show($"Greška: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            pnlWelcome.Visible = false;
            gboxFilter.Visible = true;
            gboxSort.Visible = true;
            pnlRides.Visible = true;

            string startLocation = txtStartLocation.Text; 
            string endLocation = txtEndLocation.Text;
            string date = DatePicker.Value.ToString("yyyy-MM-dd");
            decimal seats = numericSeats.Value;

            if (string.IsNullOrWhiteSpace(startLocation) || startLocation.Equals("Polazak"))
            {
                MessageBox.Show("Unesite validnu lokaciju polaska.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(endLocation) || endLocation.Equals("Dolazak"))
            {
                MessageBox.Show("Unesite validnu lokaciju dolaska.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndLocation.Focus();
                return;
            }
            await SearchRides(startLocation, endLocation, date, seats);
        }
        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            txtStartLocation.Focus();
        }

        private void SortRides(object sender, EventArgs e)
        {

            if (btnTimeASC.Checked)
            {
                filteredRides = filteredRides.OrderBy(r => r.departureTime).ToList();
            }
            else if (btnTimeDSC.Checked)
            {
                filteredRides = filteredRides.OrderByDescending(r => r.departureTime).ToList();
            }
            else if (btnPriceASC.Checked)
            {
                filteredRides = filteredRides.OrderBy(r => r.price).ToList();
            }
            else if (btnPriceDSC.Checked)
            {
                filteredRides = filteredRides.OrderByDescending(r => r.price).ToList();
            }

            DisplayRides(filteredRides);

        }

        private void FilterRides(object sender, EventArgs e)
        { 
            filteredRides = rides;
            
            if (btnTimeMorning.Checked)
            {
                filteredRides = filteredRides
                    .Where(ride =>
                    {
                        var timeParts = ride.departureTime.ToString().Split(':');
                        var hours = int.Parse(timeParts[0]);

                        return hours >= 6 && hours < 12;
                    })
                    .ToList();
            }
            else if (btnTimeNoon.Checked)
            {
                filteredRides = filteredRides
                   .Where(ride =>
                   {
                       var timeParts = ride.departureTime.ToString().Split(':');
                       var hours = int.Parse(timeParts[0]);

                       return hours >= 12 && hours <= 18;
                   })
                   .ToList();
            }
            else if (btnTimeNight.Checked)
            {
                filteredRides = filteredRides
                     .Where(ride =>
                     {
                         var timeParts = ride.departureTime.ToString().Split(':');
                         var hours = int.Parse(timeParts[0]);

                         return hours > 18;
                     })
                     .ToList();
            }
            DisplayRides(filteredRides);
        }
        private void gbox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

    }
}
