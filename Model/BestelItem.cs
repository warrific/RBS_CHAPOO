namespace Model
{
    public class BestelItem
    {
        public int Id { get; private set; }
        public MenuItem MenuItem { get; private set; }
        public int Aantal { get; set; }                         // Moet private gemaakt worden
        public string Opmerking { get; set; }                   // Moet private gemaakt worden
        public Status Status_item { get; private set; }

        public BestelItem(int id_in, MenuItem item_in, int aantal_in, string opmerking_in, Status status_item_in)
        {
            Id = id_in;
            MenuItem = item_in;
            Aantal = aantal_in;
            Opmerking = opmerking_in;
            Status_item = status_item_in;
        }
    }
}
