namespace Core.Entities.Abstracts;

public interface IEntityBase
{
	DateTime CreatedDate { get; set; }
	DateTime? UpdatedDate { get; set; }
	DateTime? DeletedDate { get; set; }
}
