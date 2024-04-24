USE [master]
GO

DROP DATABASE TaylorSwiftAlbumRanker
CREATE DATABASE TaylorSwiftAlbumRanker

USE [TaylorSwiftAlbumRanker] 

CREATE TABLE RolePermissions(
	RolePermissionID int NOT NULL PRIMARY KEY,
	PermissionName varchar,
	CanPerform BIT
)

CREATE TABLE Roles(
	RoleID int NOT NULL PRIMARY KEY,
	RoleName varchar,
	RolePermissionID int FOREIGN KEY REFERENCES RolePermissions(RolePermissionID)
)

CREATE TABLE Albums(
	AlbumID int NOT NULL PRIMARY KEY,
	AlbumName varchar,
	PictureHyperlinks varchar 
)


CREATE TABLE Users(
	UserID int NOT NULL PRIMARY KEY,
	Username varchar,
	RoleID int FOREIGN KEY REFERENCES Roles(RoleID)
)

CREATE TABLE Ranking(
	RankingID int NOT NULL PRIMARY KEY,
	AlbumID int FOREIGN KEY REFERENCES Albums(AlbumID),
	Ranking int,
	UserID int FOREIGN KEY REFERENCES Users(UserID)
)

MERGE INTO Albums