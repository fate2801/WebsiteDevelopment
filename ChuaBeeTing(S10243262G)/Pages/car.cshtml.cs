using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ChuaBeeTing_S10243262G_.Pages
{
    public class carModel : PageModel
    {

        [BindProperty]
        [Required(ErrorMessage = "You must enter your name")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "You must enter your contact number")]
        public string ContactNumber { get; set; }

        [BindProperty]
        public DateTime PickUpDateTime { get; set; } = System.DateTime.Now;

        [BindProperty]
        public string Type { get; set; }

        [BindProperty]
        public string Licence { get; set; }

        [BindProperty]
        public bool Insurance { get; set; }

        [BindProperty]
        public bool AddDriver { get; set; }

        [BindProperty]
        public bool CDW { get; set; }

        [BindProperty]
        public string Colours { get; set; }
        public string[] ColourList = { "White", "Blue", "Black", "Red", "Yellow" };

        public string[] Rules = { "• No Smoking", "• No Pets", "• No Litter", "• No Durian or Odorous Items", "• No Unauthorised driver", "• Only Grade 95 & above Petrols" };
        public string CustomerInfo { get; set; }
        public string OrderInfo { get; set; }

        public float TotalCost;

        public string Message;

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (PickUpDateTime < System.DateTime.Now.AddDays(1))
                {
                    Message = "Pick-up date & time must be 2 days in advance";
                    return Page();
                }

                CustomerInfo = "Name: " + Name + ", " +
                "Contact Number: " + ContactNumber + ", " + 
                "Pick-Up Date Time: " + PickUpDateTime.ToString("dd/MM/yyyy h:mm tt");

                OrderInfo = Colours + " ";

                TotalCost = 0.00f;

                if (Type == "Ferrari")
                {
                    OrderInfo += "Ferrari 458 Spider";
                    TotalCost += 560.00f;
                }
                else if (Type == "McLaren")
                {
                    OrderInfo += "McLaren Senna";
                    TotalCost += 580.00f;
                }
                else if (Type == "Porsche")
                {
                    OrderInfo += "Porsche 911 GT3 RS";
                    TotalCost += 530.00f;
                }
                else if (Type == "Lamborghini")
                {
                    OrderInfo += "Lamborghini Aventador SVJ";
                    TotalCost += 600.00f;
                }
                else if (Type == "AstonMartin")
                {
                    OrderInfo += "Aston Martin DB11";
                    TotalCost += 500.00f;
                }
                 
                if (Insurance == true)
                {
                    OrderInfo += ", include Insurrance";
                    TotalCost += 100.00f;
                }
                if (AddDriver == true)
                {
                    OrderInfo += ", add Driver";
                    TotalCost += 20.00f;
                }
                if (CDW == true)
                {
                    OrderInfo += ", include Collision Damage Waiver";
                    TotalCost += 50.00f;
                }

                return Page();
            }
            else
            {
                return Page();
            }
        }
    }
}
