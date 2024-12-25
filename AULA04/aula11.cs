using System;

class aula11
{
    static string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
    static string[] rsvps = new string[10];
    static int count = 0;

    static void Main()
    {
        RSVP("Rebecca", 1, "none", true);
        RSVP("Nadia", 2, "Nuts", true);
        RSVP("Linh", 2, "none", false);
        RSVP("Tony", 1, "Jackfruit", true);
        RSVP("Noor", 4, "none", false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();
    }

    static void RSVP(string name, int partySize, string allergies, bool inviteOnly)
    {
        if (inviteOnly)
        {
            bool found = false;
            foreach (string guest in guestList)
            {
                if (guest.Equals(name))
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Sorry, {name} is not on the guest list");
                return;
            }
        }

        if (count < rsvps.Length)
        {
            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }
        else
        {
            Console.WriteLine("RSVP list is full.");
        }
    }

    static void ShowRSVPs()
    {
        Console.WriteLine("\nTotal RSVPs:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(rsvps[i]);
        }
    }
}
