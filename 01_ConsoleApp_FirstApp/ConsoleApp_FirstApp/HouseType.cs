namespace ConsoleApp_GameOfThrones
{
    public class HouseType
    {
        public HouseType(char type)
        {
            switch (type)
            {
                case 'N':
                    TypeName = "Noble";
                    break;
                case 'R':
                    TypeName = "Royal";
                    break;
                case 'D':
                    TypeName = "Dragon";
                    break;
                case 'F':
                    TypeName = "Feudal";
                    break;
                case 'I':
                    TypeName = "Ironborn";
                    break;
                default:
                    TypeName = "Unknown";
                    break;
            }
        }

        public string TypeName { get; set; }
    }
}
