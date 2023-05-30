using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking
{
    abstract class Movie_Ticket
    {
        public string Movie_Name { get; set; }

        public string Theater_Name { get; set; }

        public string Show_Time { get; set; }

        public int No_Of_Seats { get; set; }

        public int Ticket_Price { get; set; }

        //Method to calculate Ticket_Price...

        public abstract string calculate_Ticket_Price();
        

    }
    class online_Booking : Movie_Ticket
    {

        public float discount { get; set; }
        public online_Booking( int No_Of_Seats, int Ticket_Price)
        {
            /*this.Movie_Name = Movie_Name;
            this.Theater_Name = Theater_Name;
            this.Show_Time = Show_Time;*/
            this.No_Of_Seats = No_Of_Seats;
            this.Ticket_Price = Ticket_Price;
       
        }

        public override string calculate_Ticket_Price()
        {
            float TP = No_Of_Seats * Ticket_Price;
            discount= TP * 0.10f;
            TP=TP-discount;
            return "" + TP;
        }
    }

    class Box_Office : Movie_Ticket
    {
        public float Booking_Amount { get; set; }
            public Box_Office(int No_Of_Seats, int Ticket_Price)
            {
                //this.Movie_Name = Movie_Name;
                //this.Theater_Name = Theater_Name;
                //this.Show_Time = Show_Time;
                this.No_Of_Seats = No_Of_Seats;
                this.Ticket_Price = Ticket_Price;

            }

        #region ==== METHODS ====
        /// <summary>
        /// method to calculate
        /// </summary>
        /// <returns></returns>
        public override string calculate_Ticket_Price()
            {
                float TP = No_Of_Seats * Ticket_Price;
                Booking_Amount = 20;
                TP=TP+20;
                return "Total price : " + TP.ToString();
            }
        #endregion
    }

}
