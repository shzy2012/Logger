Logger
======

The logger is used to webapplicaton , it can define size of log and how many logs to keep


Total  3 files (class) 

LogConfig is config the log's name,  max size , max backups 

LogWriter is used to write detail error messaget to log 

LogManager is used to called


log list below:


--------------------------------------------------------------------------------------------
2014-09-16 02:34:39    [Error]: Defailt.aspx      [Exception: Index was out of range. Must be non-negative and less than the size of the collection.
Parameter name: index]
   at System.ThrowHelper.ThrowArgumentOutOfRangeException()
   at System.Collections.Generic.List`1.set_Item(Int32 index, T value)
   at WebLogger._default.ExcuteEror() in d:\Source\Local\OpenSource\SolSouce\WebLogger\default.aspx.cs:line 37
   at WebLogger._default.Page_Load(Object sender, EventArgs e) in d:\Source\Local\OpenSource\SolSouce\WebLogger\default.aspx.cs:line 19
