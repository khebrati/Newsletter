using Microsoft.AspNetCore.Mvc;

namespace Data;
public class DbInitializer
{
    private readonly WeblogContext _context;
    public DbInitializer(WeblogContext context)
    {
        _context = context;
    }
    public static void Initialize()
    {

        //FIXME: 2 articles with the same path to a file in database
            //1) generating the Id's in app
            //2) making rows in database, getting the Id, setting it as the file name and sending it to the database
        
        //TODO: add sample Articles with their related Authors
    }
}
