using VillaProject_VillaAPI.Models.Dto;

namespace VillaProject_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
         {
                new VillaDTO {Id=1,Name="Havuz Manzaralı", Occupancy=4 ,Sqft=100},
                new VillaDTO {Id=2,Name="Deniz Manzaralı",Occupancy=3 ,Sqft=400}
         };
    }
}
