namespace TaylorSwiftAlbumRanker.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public required string AlbumName { get; set; }
        public required string PictureHyperlink { get; set; }
        public required int Ranking { get; set; }
        public required int NumRanking { get; set; }

    }
}
