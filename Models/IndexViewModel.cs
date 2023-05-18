using occupy.Models.Entities;

namespace occupy.Models;

public class IndexViewModel
{
    public IEnumerable<Site>? Sites { get; set; }
    public Site? Site { get; set; }
    public IEnumerable<Slide>? Slides { get; set; }
    public IEnumerable<About>? Abouts { get; set; }
    public About? About { get; set; }
    public IEnumerable<Team>? Teams { get; set; }
    public IEnumerable<Service>? Services { get; set; }
    public Service? Service { get; set; }
    public IEnumerable<Success>? Successes { get; set; }
    public Success? Success { get; set; }
   public IEnumerable<Message>? Messages { get; set; }
    public Message? Message { get; set; }
}
