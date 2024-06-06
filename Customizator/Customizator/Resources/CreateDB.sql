CREATE TABLE "DbTypes"(
  [ID] INTEGER PRIMARY KEY ASC AUTOINCREMENT NOT NULL, 
  [Name] VARCHAR NOT NULL);

CREATE TABLE "ExecScriptTypes"(
  [ID] INTEGER PRIMARY KEY AUTOINCREMENT, 
  [Name] VARCHAR);

CREATE TABLE [ExecScripts](
  [ID] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
  [Name] VARCHAR, 
  [ExecScriptTypeID] INTEGER REFERENCES "ExecScriptTypes"([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  [DbTypeID] INTEGER REFERENCES [DbTypes]([ID]) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE [Functions](
  [ID] INTEGER PRIMARY KEY AUTOINCREMENT, 
  [Name] VARCHAR, 
  [CreateSqlText] VARCHAR, 
  [DropSqlText] VARCHAR, 
  [DbTypeID] INTEGER REFERENCES [DbTypes]([ID]) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE [Parametrs](
  [ID] INTEGER PRIMARY KEY AUTOINCREMENT, 
  [Name] VARCHAR);

CREATE TABLE "PluginExecScripts"([ID] INTEGER PRIMARY KEY REFERENCES [ExecScripts]([ID]) ON DELETE CASCADE ON UPDATE CASCADE);

CREATE TABLE [Servers](
  [ID] INTEGER PRIMARY KEY ASC AUTOINCREMENT NOT NULL, 
  [ServerName] VARCHAR NOT NULL, 
  [DbTypeID] INTEGER REFERENCES [DbTypes]([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  [Port] VARCHAR, 
  [User] VARCHAR, 
  [Password] VARCHAR, 
  [DbName] VARCHAR, 
  [IsCurrent] VARCHAR);

CREATE TABLE "SqlExecScripts"(
  [ID] INTEGER PRIMARY KEY REFERENCES [ExecScripts]([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  [FunctionName] VARCHAR, 
  [ScriptText] VARCHAR, 
  [PluginFormName] VARCHAR, 
  [DbTypeID] INTEGER);

CREATE TABLE [SqlExecScriptFunctions](
  [SqlExecScriptID] INTEGER REFERENCES [SqlExecScripts]([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  [FunctionID] INTEGER REFERENCES [Functions]([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  PRIMARY KEY([SqlExecScriptID], [FunctionID]));

CREATE TABLE [SqlExecScriptParametrs](
  [SqlExecScriptID] INTEGER REFERENCES "SqlExecScripts"([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  [ParametrID] INTEGER REFERENCES [Parametrs]([ID]) ON DELETE CASCADE ON UPDATE CASCADE, 
  PRIMARY KEY([SqlExecScriptID], [ParametrID]));

CREATE TRIGGER [ai_iscurrent_server_trigger] AFTER INSERT ON [Servers] FOR EACH ROW
BEGIN
  UPDATE
    [servers]
  SET
    [iscurrent] = '-'
  WHERE
    [id] <> [new].[id];
END;

CREATE TRIGGER [au_iscurrentserver_trigger] AFTER UPDATE ON [Servers] FOR EACH ROW
BEGIN
  UPDATE
    [Servers]
  SET
    [IsCurrent] = '-'
  WHERE
    [IsCurrent] = '+'
    AND [ID] <> [new].[ID]
    AND [new].[IsCurrent] = '+';
END;

Insert into DbTypes(ID, Name )
values(1, 'Microsoft SQL Server'),
(2, 'PostgreSQL');

Insert into ExecScriptTypes(ID, Name )
values(1, 'SQL'),
(2, 'Plugin');

