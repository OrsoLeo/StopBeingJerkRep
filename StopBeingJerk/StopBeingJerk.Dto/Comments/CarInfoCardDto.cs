namespace StopBeingJerk.Dto.Comments
{
    public class CarInfoCardDto
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int RegistrationNumberId { get; set; }

        public ColorDto Color { get; set; }
        public CarModelDto Model { get; set; }
        public RegistrationNumberDto RegistrationNumber { get; set; }
    }
}
