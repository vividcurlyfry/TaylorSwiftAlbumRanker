namespace TaylorSwiftAlbumRanker.Entities
{
    public class Ranking
    {
        public int Id { get; set; }
        public required int AlbumId { get; set; }
        public required int UserRanking { get; set; }
        public required int UserId { get; set; }
        public required DateTime TM_STAMP { get; set; }
    }
}
