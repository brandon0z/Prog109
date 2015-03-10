using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class House
{

    const double ROOM_PRICE = 75000.00;
    const double ROOM_SURCHARGE = 1000.00;

    //The fields

    private String color;

    private int numRooms;

    private bool hasView;

    //The constructor

    public House(String color1, int numRooms1, bool hasView1)
    {
        // get explanation for this.color
        this.color = color1;

        numRooms = numRooms1;

        hasView = hasView1;

    }

    public String GetDetails()
    {

        String output = color + " house with " + numRooms + " rooms";

        if (hasView)
        {

            output += " and a view";

        }

        return output;

    }

    public void PaintHouse(String paintColor)
    {

        color = paintColor;

    }

    public double GetPrice()
    {
       
        if (hasView)
        {
            return numRooms * ROOM_PRICE + ROOM_SURCHARGE;
        }
        else
        {
            return numRooms * ROOM_PRICE;
        }
        
        

    }

}
