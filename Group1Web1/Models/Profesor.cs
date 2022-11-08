namespace Group1Web1.Models
{
    public class Profesor
    {
        public Profesor(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

    }
}
