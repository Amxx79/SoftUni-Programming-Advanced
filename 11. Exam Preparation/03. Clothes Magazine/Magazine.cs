using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Capacity > GetClothCount())
            {
                Clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            return Clothes.Remove(Clothes.FirstOrDefault(c => c.Color == color));
        }
        public Cloth GetSmallestCloth()
        {
            return Clothes.MinBy(c => c.Size);
        }
        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }
        public int GetClothCount()
        {
            return Clothes.Count;
        }
        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (var cloth in Clothes.OrderBy(c => c.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
