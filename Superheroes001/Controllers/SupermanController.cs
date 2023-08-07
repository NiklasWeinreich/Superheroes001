namespace Superheroes001.Controllers
{
    public class SupermanController : ControllerBase
    {
        DatabaseContext context { get; set; }
        // The parametre in this method is called Dependecy Injection
        public SupermanController(DatabaseContext data) { 
            context = data;
        }

        [HttpGet]
        public ActionResult<Superman> GetAllInfo()
        {
            Superman superman = new Superman
            {
                Id = 1,
                RealName = "Clark Kent",
                SuperPower = "pew pew laser goes brrrrr",
                Gender = "Male",
                Age = 69,
                DebutYear = DateTime.Now,
            };

            return superman;
        }

        [HttpGet("Superman")]
        public ActionResult<Superman> GetAll()
        {
            List<Superman> list = new List<Superman>();
            list = context.Superman.ToList();
            return Ok(list);
        }
    }
}
