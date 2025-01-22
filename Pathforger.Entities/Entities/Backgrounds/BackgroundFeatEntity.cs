using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pathforger.Entities.Entities.Backgrounds;
[Table("BackgroundFeats")]
public class BackgroundFeatEntity
{
    [Key]
    public string Key { get; set; }    // e.g. "1v9gz"

    public string Img { get; set; }    // from singleItemDto.img
    public int Level { get; set; }     // from singleItemDto.level
    public string Name { get; set; }   // from singleItemDto.name
    public string Uuid { get; set; }   // from singleItemDto.uuid
    public string BackgroundId { get; set; }
    public BackgroundEntity Background { get; set; }
}