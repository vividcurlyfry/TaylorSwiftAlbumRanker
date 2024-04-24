USE  [TaylorSwiftAlbumRanker]
GO
	
MERGE [dbo].[PermissionsTable] PermissionsTable USING (
    VALUES('AddUser','Add users.'),('DeleteUser','Delete users.'),('UpdateUser','Change a user''s role.'),('UpdateAlbums','Add, delete, or update albums.'),('ViewOverallRankings','View overall rankings of albums')
    )  AS src(PermissionName, PermissionDescription)
	ON (PermissionsTable.[PermissionName] = src.PermissionName)
 WHEN MATCHED
     THEN 
  UPDATE
  SET 
    [PermissionName] = src.PermissionName,
	[PermissionDescription] = src.PermissionDescription
 WHEN NOT MATCHED
     THEN 
  INSERT (PermissionName, PermissionDescription)
  Values (src.PermissionName, src.PermissionDescription);

////////////////////////////////////////////////////
  MERGE [dbo].[RolesTable] RolesTable USING (
    VALUES('admin','Access to every role.')
    )  AS src(RoleName, RoleDescription)
	ON (RolesTable.[RoleName] = src.RoleName)
 WHEN MATCHED
     THEN 
  UPDATE
  SET 
    [RoleName] = src.RoleName,
	[RoleDescription] = src.[RoleDescription]
 WHEN NOT MATCHED
     THEN 
  INSERT ([RoleName], [RoleDescription])
  Values (src.[RoleName], src.[RoleDescription]);

///////////////////////////////////////////////////
 MERGE [dbo].[RolePermissionsTable] RolePermissionsTable USING (
    VALUES((SELECT DISTINCT RoleID FROM RolesTable WHERE RoleName = 'admin'),(SELECT DISTINCT PermissionID FROM PermissionsTable WHERE PermissionName = 'AddUser'), 1)
    )  AS src(RoleID, PermissionID, CanPerform)
	ON (RolePermissionsTable.RoleID = src.RoleID AND RolePermissionsTable.PermissionID = src.PermissionID)
 WHEN MATCHED
     THEN 
  UPDATE
  SET 
    RoleID = src.RoleID,
	PermissionID = src.PermissionID,
	CanPerform = src.CanPerform
 WHEN NOT MATCHED
     THEN 
 INSERT (RoleID, PermissionID, CanPerform)
 Values (src.RoleID, src.PermissionID, src.CanPerform);