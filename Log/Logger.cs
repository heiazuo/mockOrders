using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Web;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using log4net.Repository; //using DonvvTools.Utils;
using ins = ErpDataFactory.Log.Logger;


namespace ErpDataFactory.Log
{
	#region 日志记录的主要使用类

	public static class Logger
	{
		#region level consts

		public enum LogType
		{
			/// <summary>
			/// 跟踪日志，主要用来在调试使用（可用来跟踪）
			/// </summary>
			Trace = LogLevel02Trace,
			/// <summary>
			/// 跟踪日志，主要用来调试使用
			/// </summary>
			Debug = LogLevel03Debug,
			/// <summary>
			/// 普通业务日志
			/// </summary>
			Info = LogLevel04Info,
			/// <summary>
			/// 重要业务日志（通知日志）
			/// </summary>
			Notice = LogLevel05Notice,
			/// <summary>
			/// 业务日志错误（警告日志）
			/// </summary>
			Warn = LogLevel06Warn,
			/// <summary>
			/// 记录调用外部服务日志（服务日志）
			/// </summary>
			Server = LogLevel08Severe
		};

		internal const int LogLevel01Verbose = 1;
		internal const int LogLevel02Trace = 2;
		internal const int LogLevel03Debug = 3;
		internal const int LogLevel04Info = 4;
		internal const int LogLevel05Notice = 5;
		internal const int LogLevel06Warn = 6;
		internal const int LogLevel07Error = 7;
		internal const int LogLevel08Severe = 8;
		internal const int LogLevel11Fatal = 11;

		#endregion

		#region singleton

		private static IZLog _zlog;
		private static IZLog Instance
		{
			get
			{
				if (_zlog == null)
				{
					const string configFile = "log4.config";
					var file = new FileInfo(configFile);
					if (!file.Exists)
					{
						file = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFile));
					}

					if (file.Exists)
					{
						XmlConfigurator.ConfigureAndWatch(file);
					}
					else
					{
						BasicConfigurator.Configure(new ConsoleAppender { Layout = new PatternLayout() });
					}


					//XmlConfigurator.Configure();
					_zlog = ZLogManager.GetLogger(typeof(Logger));
				}
				return _zlog;
			}
		}

		#endregion

		#region functions for log

		/// <summary>
		/// 记录跟踪日志（主要用来调试）
		/// </summary>
		/// <param name="title"></param>
		/// <param name="message"></param>
		public static void Trace(string title, string message)
		{
			Instance.Log(title, message, Convert.ToInt32(LogType.Trace));
		}

		/// <summary>
		/// 记录跟踪日志（主要用来调试）
		/// </summary>
		/// <param name="title"></param>
		/// <param name="message"></param>
		public static void Debug(string title, string message)
		{
			Instance.Log(title, message, Convert.ToInt32(LogType.Debug));
		}

		/// <summary>
		/// 记录信息日志（主要业务信息）
		/// </summary>
		/// <param name="title"></param>
		/// <param name="message"></param>
		public static void Info(string title, string message)
		{
			Instance.Log(title, message, Convert.ToInt32(LogType.Info));
		}
		/// <summary>
		/// 记录业务错误
		/// </summary>
		/// <param name="title"></param>
		/// <param name="message"></param>
		public static void Notice(string title, string message)
		{
			Instance.Log(title, message, Convert.ToInt32(LogType.Notice));
		}

		/// <summary>
		/// 记录一般的信息
		/// </summary>
		/// <param name="title"></param>
		/// <param name="message"></param>
		public static void Warn(string title, string message)
		{
			Instance.Log(title, message, Convert.ToInt32(LogType.Warn));
		}
		/// <summary>
		/// 纪录重要的信息
		/// </summary>
		/// <param name="title"></param>
		/// <param name="message"></param>
		public static void Server(string title, string message)
		{
			Instance.Log(title, message, Convert.ToInt32(LogType.Server));
		}

		#endregion

		#region functions for error
		public static void Error(Exception ex)
		{
			Instance.Error(ex);
		}

		public static void Error(string title, Exception ex)
		{
			Instance.Error(title, ex);
		}

		public static void Error(string title, Exception ex, LogType level)
		{
			Instance.Error(title, ex, Convert.ToInt32(level));
		}
		#endregion

		#region configure

		public static void Configure()
		{
			XmlConfigurator.Configure();
		}

		#endregion
	}

	#endregion

	#region 重写的辅助接口：IZLog，类似Log4net中ILog的功能

	interface IZLog : ILoggerWrapper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="level"></param>
		void Log(string message, int level);
		void Log(string title, string message, int level);
		void Error(Exception ex);
		void Error(string title, Exception ex);
		void Error(string title, Exception ex, int level);
		bool Is01VerboseEnabled { get; }
		bool Is02TraceEnabled { get; }
		bool Is03DebugEnabled { get; }
		bool Is04InfoEnabled { get; }
		bool Is05NoticeEnabled { get; }
		bool Is06WarnEnabled { get; }
		bool Is07ErrorEnabled { get; }
		bool Is08SevereEnabled { get; }
		bool Is11FatalEnabled { get; }
	}

	#endregion

	#region 重写的辅助类：ZLogManager，类似Log4net中LogManager的功能

	sealed class ZLogManager
	{
		public static IZLog Exists(string name)
		{
			return Exists(Assembly.GetCallingAssembly(), name);
		}
		public static IZLog Exists(string repository, string name)
		{
			return WrapLogger(LoggerManager.Exists(repository, name));
		}
		public static IZLog Exists(Assembly repositoryAssembly, string name)
		{
			return WrapLogger(LoggerManager.Exists(repositoryAssembly, name));
		}
		public static IZLog[] GetCurrentLoggers()
		{
			return GetCurrentLoggers(Assembly.GetCallingAssembly());
		}
		public static IZLog[] GetCurrentLoggers(string repository)
		{
			return WrapLoggers(LoggerManager.GetCurrentLoggers(repository));
		}
		public static IZLog[] GetCurrentLoggers(Assembly repositoryAssembly)
		{
			return WrapLoggers(LoggerManager.GetCurrentLoggers(repositoryAssembly));
		}
		public static IZLog GetLogger(string name)
		{
			return GetLogger(Assembly.GetCallingAssembly(), name);
		}
		public static IZLog GetLogger(string repository, string name)
		{
			return WrapLogger(LoggerManager.GetLogger(repository, name));
		}
		public static IZLog GetLogger(Assembly repositoryAssembly, string name)
		{
			return WrapLogger(LoggerManager.GetLogger(repositoryAssembly, name));
		}
		public static IZLog GetLogger(Type type)
		{
			return GetLogger(Assembly.GetCallingAssembly(), type.FullName);
		}
		public static IZLog GetLogger(string repository, Type type)
		{
			return WrapLogger(LoggerManager.GetLogger(repository, type));
		}
		public static IZLog GetLogger(Assembly repositoryAssembly, Type type)
		{
			return WrapLogger(LoggerManager.GetLogger(repositoryAssembly, type));
		}
		public static void Shutdown()
		{
			LoggerManager.Shutdown();
		}
		public static void ShutdownRepository()
		{
			ShutdownRepository(Assembly.GetCallingAssembly());
		}
		public static void ShutdownRepository(string repository)
		{
			LoggerManager.ShutdownRepository(repository);
		}
		public static void ShutdownRepository(Assembly repositoryAssembly)
		{
			LoggerManager.ShutdownRepository(repositoryAssembly);
		}
		public static void ResetConfiguration()
		{
			ResetConfiguration(Assembly.GetCallingAssembly());
		}
		public static void ResetConfiguration(string repository)
		{
			LoggerManager.ResetConfiguration(repository);
		}
		public static void ResetConfiguration(Assembly repositoryAssembly)
		{
			LoggerManager.ResetConfiguration(repositoryAssembly);
		}
		[Obsolete("Use GetRepository instead of GetLoggerRepository")]
		public static ILoggerRepository GetLoggerRepository()
		{
			return GetRepository(Assembly.GetCallingAssembly());
		}
		[Obsolete("Use GetRepository instead of GetLoggerRepository")]
		public static ILoggerRepository GetLoggerRepository(string repository)
		{
			return GetRepository(repository);
		}
		[Obsolete("Use GetRepository instead of GetLoggerRepository")]
		public static ILoggerRepository GetLoggerRepository(Assembly repositoryAssembly)
		{
			return GetRepository(repositoryAssembly);
		}
		public static ILoggerRepository GetRepository()
		{
			return GetRepository(Assembly.GetCallingAssembly());
		}
		public static ILoggerRepository GetRepository(string repository)
		{
			return LoggerManager.GetRepository(repository);
		}
		public static ILoggerRepository GetRepository(Assembly repositoryAssembly)
		{
			return LoggerManager.GetRepository(repositoryAssembly);
		}
		[Obsolete("Use CreateRepository instead of CreateDomain")]
		public static ILoggerRepository CreateDomain(Type repositoryType)
		{
			return CreateRepository(Assembly.GetCallingAssembly(), repositoryType);
		}
		public static ILoggerRepository CreateRepository(Type repositoryType)
		{
			return CreateRepository(Assembly.GetCallingAssembly(), repositoryType);
		}
		[Obsolete("Use CreateRepository instead of CreateDomain")]
		public static ILoggerRepository CreateDomain(string repository)
		{
			return LoggerManager.CreateRepository(repository);
		}
		public static ILoggerRepository CreateRepository(string repository)
		{
			return LoggerManager.CreateRepository(repository);
		}
		[Obsolete("Use CreateRepository instead of CreateDomain")]
		public static ILoggerRepository CreateDomain(string repository, Type repositoryType)
		{
			return LoggerManager.CreateRepository(repository, repositoryType);
		}
		public static ILoggerRepository CreateRepository(string repository, Type repositoryType)
		{
			return LoggerManager.CreateRepository(repository, repositoryType);
		}
		[Obsolete("Use CreateRepository instead of CreateDomain")]
		public static ILoggerRepository CreateDomain(Assembly repositoryAssembly, Type repositoryType)
		{
			return LoggerManager.CreateRepository(repositoryAssembly, repositoryType);
		}
		public static ILoggerRepository CreateRepository(Assembly repositoryAssembly, Type repositoryType)
		{
			return LoggerManager.CreateRepository(repositoryAssembly, repositoryType);
		}
		public static ILoggerRepository[] GetAllRepositories()
		{
			return LoggerManager.GetAllRepositories();
		}
		private static IZLog WrapLogger(ILogger logger)
		{
			return (IZLog)SWrapperMap.GetWrapper(logger);
		}
		private static IZLog[] WrapLoggers(ILogger[] loggers)
		{
			var results = new IZLog[loggers.Length];
			for (int i = 0; i < loggers.Length; i++)
			{
				results[i] = WrapLogger(loggers[i]);
			}
			return results;
		}
		private static ILoggerWrapper WrapperCreationHandler(ILogger logger)
		{
			return new ZLogger(logger);
		}
		private static readonly WrapperMap SWrapperMap = new WrapperMap(WrapperCreationHandler);
	}

	#endregion

	#region 重写的辅助类：ZLogger，类似Log4net中LogImpl的功能

	sealed class ZLogger : LoggerWrapperImpl, IZLog
	{
		#region 日志处理级别

		private Level _mLevel01Verbose;
		private Level _mLevel02Trace;
		private Level _mLevel03Debug;
		private Level _mLevel04Info;
		private Level _mLevel05Notice;
		private Level _mLevel06Warn;
		private Level _mLevel07Error;
		private Level _mLevel08Severe;
		private Level _mLevel11Fatal;

		//定义日志记录标准化的格式：
		// 0 - 服务器时间
		// 1 - 日志摘要
		// 2 - 服务器IP
		// 3 - 客户端IP
		// 4 - 当前用户ptNumId
		// 5 - 日志内容

		private const string LogTmpl01Verbose = "<Verbose Titile={1} ServerTime={0} ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Verbose>";
		private const string LogTmpl02Trace = "<Trace Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Trace>";
		private const string LogTmpl03Debug = "<Debug  Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Debug>";
		private const string LogTmpl04Info = "<Info  Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Info>";
		private const string LogTmpl05Notice = "<Notice Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Notice>";
		private const string LogTmpl06Warn = "<Warn Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Warn>";
		private const string LogTmpl07Error = "<Error Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Error>";
		private const string LogTmpl08Severe = "<Severe Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Severe>";
		private const string LogTmpl11Fatal = "<Fatal Titile={1} ServerTime={0}  ServerIP={2} ClientIP={3} UserID={4}><Desc>\r\n{5}\r\n</Desc></Fatal>";

		#endregion

		#region 构造和辅助方法
		private readonly static Type ThisDeclaringType = typeof(ZLogger);
		private void LoggerRepositoryConfigurationChanged(object sender, EventArgs e)
		{
			var repository = sender as ILoggerRepository;
			if (repository != null)
			{
				ReloadLevels(repository);
			}
		}

		public ZLogger(ILogger logger)
			: base(logger)
		{
			logger.Repository.ConfigurationChanged += LoggerRepositoryConfigurationChanged;

			ReloadLevels(logger.Repository);
		}

		#endregion

		#region 处理日志级别

		private void ReloadLevels(ILoggerRepository repository)
		{
			LevelMap levelMap = repository.LevelMap;

			_mLevel01Verbose = levelMap.LookupWithDefault(Level.Verbose);
			_mLevel02Trace = levelMap.LookupWithDefault(Level.Trace);
			_mLevel03Debug = levelMap.LookupWithDefault(Level.Debug);
			_mLevel04Info = levelMap.LookupWithDefault(Level.Info);
			_mLevel05Notice = levelMap.LookupWithDefault(Level.Notice);
			_mLevel06Warn = levelMap.LookupWithDefault(Level.Warn);
			_mLevel07Error = levelMap.LookupWithDefault(Level.Error);
			_mLevel08Severe = levelMap.LookupWithDefault(Level.Severe);
			_mLevel11Fatal = levelMap.LookupWithDefault(Level.Fatal);
		}

		#endregion

		#region IZLog 成员

		public void Log(string message, int level)
		{
			Log("[TitleMissing]", message, level);
		}

		public void Log(string title, string message, int level)
		{
			Level lvl = _mLevel04Info;

			switch (level)
			{
				case ins.LogLevel01Verbose:
					lvl = _mLevel01Verbose;
					break;

				case ins.LogLevel02Trace:
					lvl = _mLevel02Trace;
					break;

				case ins.LogLevel03Debug:
					lvl = _mLevel03Debug;
					break;

				case ins.LogLevel04Info:
					lvl = _mLevel04Info;
					break;

				case ins.LogLevel05Notice:
					lvl = _mLevel05Notice;
					break;

				case ins.LogLevel06Warn:
					lvl = _mLevel06Warn;
					break;

				case ins.LogLevel07Error:
					lvl = _mLevel07Error;
					break;

				case ins.LogLevel08Severe:
					lvl = _mLevel08Severe;
					break;

				case ins.LogLevel11Fatal:
					lvl = _mLevel11Fatal;
					break;
			}

			Logger.Log(ThisDeclaringType, lvl, GetLogMessage(title, message, level), null);
		}

		public void Error(Exception ex)
		{
			Error(ex.GetType().Name, ex, ins.LogLevel07Error);
		}

		public void Error(string title, Exception ex)
		{
			Error(title, ex, ins.LogLevel07Error);
		}

		public void Error(string title, Exception ex, int level)
		{

			if (level >= ins.LogLevel07Error)
			{
				Log(title, ex.ToString(), level);
			}
			else
			{
				var exgen = new Exception("日志记录失败：尝试记录未达级别的异常信息！");
				Error("日志记录失败", exgen);
			}
		}

		#region formater

		private string GetLogMessage(string title, string message, int level)
		{
			var rts = new object[6];

			rts[0] = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
			rts[1] = HttpUtility.HtmlEncode(title.Replace("/", "-"));
			rts[2] = (Dns.GetHostAddresses(Dns.GetHostName())[0]).ToString();
			#region todo 记录用户
			//if (HttpContext.Current != null)
			//{

			//    var session = HttpContext.Current.Session["User"];
			//    if (session != null)
			//    {
			//        var user = (UserLoginModel) ;
			//        rts[4] = user.User.Id.ToString();
			//    }
			//    else
			//    {
			//        rts[4] = "Anonymous";
			//    }
			//    //rts[4] = HttpContext.Current.User != null ? HttpContext.Current.User.Identity.Name : "Anonymous";

			//}
			//else
			//{
			//    rts[3] = string.Empty;
			//    rts[4] = string.Empty;
			//} 
			#endregion
			rts[3] = string.Empty;
			rts[4] = string.Empty;
			rts[5] = message;

			var rt = string.Empty;

			switch (level)
			{
				case ins.LogLevel01Verbose:
					rt = string.Format(LogTmpl01Verbose, rts);
					break;

				case ins.LogLevel02Trace:
					rt = string.Format(LogTmpl02Trace, rts);
					break;

				case ins.LogLevel03Debug:
					rt = string.Format(LogTmpl03Debug, rts);
					break;

				case ins.LogLevel04Info:
					rt = string.Format(LogTmpl04Info, rts);
					break;

				case ins.LogLevel05Notice:
					rt = string.Format(LogTmpl05Notice, rts);
					break;

				case ins.LogLevel06Warn:
					rt = string.Format(LogTmpl06Warn, rts);
					break;

				case ins.LogLevel07Error:
					rt = string.Format(LogTmpl07Error, rts);
					break;

				case ins.LogLevel08Severe:
					rt = string.Format(LogTmpl08Severe, rts);
					break;

				case ins.LogLevel11Fatal:
					rt = string.Format(LogTmpl11Fatal, rts);
					break;
			}

			return rt;
		}

		#endregion

		public bool Is01VerboseEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel01Verbose); }
		}

		public bool Is02TraceEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel02Trace); }
		}

		public bool Is03DebugEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel03Debug); }
		}

		public bool Is04InfoEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel04Info); }
		}

		public bool Is05NoticeEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel05Notice); }
		}

		public bool Is06WarnEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel06Warn); }
		}

		public bool Is07ErrorEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel07Error); }
		}

		public bool Is08SevereEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel08Severe); }
		}

		public bool Is11FatalEnabled
		{
			get { return Logger.IsEnabledFor(_mLevel11Fatal); }
		}

		#endregion
	}

	#endregion

}
