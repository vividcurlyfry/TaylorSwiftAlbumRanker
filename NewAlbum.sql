USE  [TaylorSwiftAlbumRanker]
GO
	
MERGE [dbo].[Albums] Albums USING (
    VALUES ('Taylor Swift', 'https://www.udiscovermusic.com/wp-content/uploads/2018/09/Taylor-Swift-debut-album-cover-web-optimised-820.jpg')
    )  AS src(NewAlbumName, NewPictureHyperlink)
	ON ([AlbumName] = src.NewAlbumName)
 WHEN MATCHED
     THEN 
  UPDATE
  SET 
    [AlbumName] = src.NewAlbumName,
    [PictureHyperlink]  = src.NewPictureHyperlink
 WHEN NOT MATCHED
     THEN 
  INSERT ([AlbumName],[PictureHyperlink])
  Values (src.NewAlbumName, src.NewPictureHyperlink);