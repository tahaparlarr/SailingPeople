using System;

namespace SailingPeople.Domain;

public class User
{
public int Id { get; set; }
public required string Username { get; set; }
public required string Password { get; set; }

}
