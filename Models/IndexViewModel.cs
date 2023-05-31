using System.ComponentModel.DataAnnotations;
using occupy.Models.Entities;

namespace occupy.Models;

public class IndexViewModel
{
      [Required(ErrorMessage = "Lütfen Boş geçmeyiniz")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Lütfen Boş geçmeyiniz")]
    public string? Password { get; set; }
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
    public IEnumerable<User>? Users { get; set; }
    public User? User { get; set; }
}
