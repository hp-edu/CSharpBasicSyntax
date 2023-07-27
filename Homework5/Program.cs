using System;
using System.Collections.Generic;


// Create new event
var event1 = new Event
{
    EventName = "Some Event for Highschool Volunteer",
    EventLocation = "Central Park",
    EventDateTime = new DateTime(2023, 8, 30, 13, 00, 00)
};

// Create some people
var person1 = new Person { FullName = "John Doe", IsHost = true };
var person2 = new Person { FullName = "Jane Smith", IsHost = false };

// Add RSVPs
event1.AddRSVP(person1);
event1.AddRSVP(person2);

// Check-in
event1.CheckIn(person1);

// Print attendees (at this point only John Doe has checked in)
event1.PrintAttendees();

// Check-out
event1.CheckOut(person1);

// Print attendees (now John Doe has checked out)
event1.PrintAttendees();


public class Person
{
    public string FullName { get; set; }
    public bool IsHost { get; set; }
}

public class Event
{
    public string EventName { get; }
    public string EventLocation { get; }
    public DateTime EventDateTime { get; }
    public List<Person> RSVPs { get; }
    public List<EventAttendance> Attendances { get; }

    public Event()
    {
        RSVPs = new List<Person>();
        Attendances = new List<EventAttendance>();
    }

    public void AddRSVP(Person person)
    {
        RSVPs.Add(person);
    }

    public void CheckIn(Person person)
    {
        var attendance = new EventAttendance
        {
            Attendee = person,
            AttendedEvent = this,
            CheckedInAt = DateTime.Now
        };

        Attendances.Add(attendance);
    }

    public void CheckOut(Person person)
    {
        var attendance = Attendances.Find(a => a.Attendee == person);
        if (attendance != null)
        {
            attendance.CheckedOutAt = DateTime.Now;
        }
    }

    public void PrintAttendees()
    {
        foreach (var attendance in Attendances)
        {
            string checkedIn = attendance.CheckedInAt.HasValue ?
                attendance.CheckedInAt.Value.ToString("g") : "Not checked in";
            string checkedOut = attendance.CheckedOutAt.HasValue ?
                attendance.CheckedOutAt.Value.ToString("g") : "Not checked out";

            Console.WriteLine($"Attendee: {attendance.Attendee.FullName}, Checked in at: {checkedIn}, Checked out at: {checkedOut}");
        }
    }
}

public class EventAttendance
{
    public Person Attendee { get; set; }
    public Event AttendedEvent { get; set; }
    public DateTime? CheckedInAt { get; set; }
    public DateTime? CheckedOutAt { get; set; }
}

