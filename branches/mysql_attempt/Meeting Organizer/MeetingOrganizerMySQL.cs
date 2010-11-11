// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from Meeting Organizer on 2010-11-11 01:12:11Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
using System;
using System.ComponentModel;
using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
using System.Diagnostics;


public partial class MeetingOrganizer : DataContext
{
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
	
	
	public MeetingOrganizer(string connectionString) : 
			base(connectionString)
	{
		this.OnCreated();
	}
	
	public MeetingOrganizer(string connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public MeetingOrganizer(IDbConnection connection, MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		this.OnCreated();
	}
	
	public Table<Event> Event
	{
		get
		{
			return this.GetTable<Event>();
		}
	}
	
	public Table<EventInviteeRelation> EventInviteeRelation
	{
		get
		{
			return this.GetTable<EventInviteeRelation>();
		}
	}
	
	public Table<User> User
	{
		get
		{
			return this.GetTable<User>();
		}
	}
}

#region Start MONO_STRICT
#if MONO_STRICT

public partial class MeetingOrganizer
{
	
	public MeetingOrganizer(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
}
#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT

public partial class MeetingOrganizer
{
	
	public MeetingOrganizer(IDbConnection connection) : 
			base(connection, new DbLinq.SqlServer.SqlServerVendor())
	{
		this.OnCreated();
	}
	
	public MeetingOrganizer(IDbConnection connection, IVendor sqlDialect) : 
			base(connection, sqlDialect)
	{
		this.OnCreated();
	}
	
	public MeetingOrganizer(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
			base(connection, mappingSource, sqlDialect)
	{
		this.OnCreated();
	}
}
#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
#endregion

[Table(Name="Event")]
public partial class Event : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _Id;
	
	private int _CreatorId;
	
	private string _Title;
	
	private string _Subject;
	
	private System.DateTime _Start;
	
	private int _Duration;
	
	private EntitySet<EventInviteeRelation> _EventInviteeRelation;
	
	private EntityRef<User> _User = new EntityRef<User>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIdChanged();
		
		partial void OnIdChanging(int value);
		
		partial void OnCreatorIdChanged();
		
		partial void OnCreatorIdChanging(int value);
		
		partial void OnTitleChanged();
		
		partial void OnTitleChanging(string value);
		
		partial void OnSubjectChanged();
		
		partial void OnSubjectChanging(string value);
		
		partial void OnStartChanged();
		
		partial void OnStartChanging(System.DateTime value);
		
		partial void OnDurationChanged();
		
		partial void OnDurationChanging(int value);
		#endregion
	
	
	public Event()
	{
		_EventInviteeRelation = new EntitySet<EventInviteeRelation>(new Action<EventInviteeRelation>(this.EventInviteeRelation_Attach), new Action<EventInviteeRelation>(this.EventInviteeRelation_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_Id", Name="id", DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((_Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[Column(Storage="_CreatorId", Name="creatorId", DbType="Int NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int CreatorId
	{
		get
		{
			return this._CreatorId;
		}
		set
		{
			if ((_CreatorId != value))
			{
				this.OnCreatorIdChanging(value);
				this.SendPropertyChanging();
				this._CreatorId = value;
				this.SendPropertyChanged("CreatorId");
				this.OnCreatorIdChanged();
			}
		}
	}
	
	[Column(Storage="_Title", Name="title", DbType="NVarChar(2000)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if (((_Title == value) 
						== false))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[Column(Storage="_Subject", Name="subject", DbType="NVarChar(4000)", AutoSync=AutoSync.Never)]
	[DebuggerNonUserCode()]
	public string Subject
	{
		get
		{
			return this._Subject;
		}
		set
		{
			if (((_Subject == value) 
						== false))
			{
				this.OnSubjectChanging(value);
				this.SendPropertyChanging();
				this._Subject = value;
				this.SendPropertyChanged("Subject");
				this.OnSubjectChanged();
			}
		}
	}
	
	[Column(Storage="_Start", Name="start", DbType="DateTime NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public System.DateTime Start
	{
		get
		{
			return this._Start;
		}
		set
		{
			if ((_Start != value))
			{
				this.OnStartChanging(value);
				this.SendPropertyChanging();
				this._Start = value;
				this.SendPropertyChanged("Start");
				this.OnStartChanged();
			}
		}
	}
	
	[Column(Storage="_Duration", Name="duration", DbType="Int NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int Duration
	{
		get
		{
			return this._Duration;
		}
		set
		{
			if ((_Duration != value))
			{
				this.OnDurationChanging(value);
				this.SendPropertyChanging();
				this._Duration = value;
				this.SendPropertyChanged("Duration");
				this.OnDurationChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_EventInviteeRelation", OtherKey="EventId", ThisKey="Id", Name="eventid")]
	[DebuggerNonUserCode()]
	public EntitySet<EventInviteeRelation> EventInviteeRelation
	{
		get
		{
			return this._EventInviteeRelation;
		}
		set
		{
			this._EventInviteeRelation = value;
		}
	}
	#endregion
	
	#region Parents
	[Association(Storage="_User", OtherKey="Id", ThisKey="CreatorId", Name="Creator ID", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			if (((this._User.Entity == value) 
						== false))
			{
				if ((this._User.Entity != null))
				{
					User previousUser = this._User.Entity;
					this._User.Entity = null;
					previousUser.Event.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.Event.Add(this);
					_CreatorId = value.Id;
				}
				else
				{
					_CreatorId = default(int);
				}
			}
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
	#region Attachment handlers
	private void EventInviteeRelation_Attach(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.Event = this;
	}
	
	private void EventInviteeRelation_Detach(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.Event = null;
	}
	#endregion
}

[Table(Name="EventInviteeRelation")]
public partial class EventInviteeRelation : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _EventId;
	
	private int _InviteeId;
	
	private int _InviteeResponse;
	
	private EntityRef<Event> _Event = new EntityRef<Event>();
	
	private EntityRef<User> _User = new EntityRef<User>();
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnEventIdChanged();
		
		partial void OnEventIdChanging(int value);
		
		partial void OnInviteeIdChanged();
		
		partial void OnInviteeIdChanging(int value);
		
		partial void OnInviteeResponseChanged();
		
		partial void OnInviteeResponseChanging(int value);
		#endregion
	
	
	public EventInviteeRelation()
	{
		this.OnCreated();
	}
	
	[Column(Storage="_EventId", Name="eventId", DbType="Int NOT NULL", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int EventId
	{
		get
		{
			return this._EventId;
		}
		set
		{
			if ((_EventId != value))
			{
				this.OnEventIdChanging(value);
				this.SendPropertyChanging();
				this._EventId = value;
				this.SendPropertyChanged("EventId");
				this.OnEventIdChanged();
			}
		}
	}
	
	[Column(Storage="_InviteeId", Name="inviteeId", DbType="Int NOT NULL", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int InviteeId
	{
		get
		{
			return this._InviteeId;
		}
		set
		{
			if ((_InviteeId != value))
			{
				this.OnInviteeIdChanging(value);
				this.SendPropertyChanging();
				this._InviteeId = value;
				this.SendPropertyChanged("InviteeId");
				this.OnInviteeIdChanged();
			}
		}
	}
	
	[Column(Storage="_InviteeResponse", Name="inviteeResponse", DbType="Int NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int InviteeResponse
	{
		get
		{
			return this._InviteeResponse;
		}
		set
		{
			if ((_InviteeResponse != value))
			{
				this.OnInviteeResponseChanging(value);
				this.SendPropertyChanging();
				this._InviteeResponse = value;
				this.SendPropertyChanged("InviteeResponse");
				this.OnInviteeResponseChanged();
			}
		}
	}
	
	#region Parents
	[Association(Storage="_Event", OtherKey="Id", ThisKey="EventId", Name="eventid", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public Event Event
	{
		get
		{
			return this._Event.Entity;
		}
		set
		{
			if (((this._Event.Entity == value) 
						== false))
			{
				if ((this._Event.Entity != null))
				{
					Event previousEvent = this._Event.Entity;
					this._Event.Entity = null;
					previousEvent.EventInviteeRelation.Remove(this);
				}
				this._Event.Entity = value;
				if ((value != null))
				{
					value.EventInviteeRelation.Add(this);
					_EventId = value.Id;
				}
				else
				{
					_EventId = default(int);
				}
			}
		}
	}
	
	[Association(Storage="_User", OtherKey="Id", ThisKey="InviteeId", Name="inviteeid", IsForeignKey=true)]
	[DebuggerNonUserCode()]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			if (((this._User.Entity == value) 
						== false))
			{
				if ((this._User.Entity != null))
				{
					User previousUser = this._User.Entity;
					this._User.Entity = null;
					previousUser.EventInviteeRelation.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.EventInviteeRelation.Add(this);
					_InviteeId = value.Id;
				}
				else
				{
					_InviteeId = default(int);
				}
			}
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
}

[Table(Name="User")]
public partial class User : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{
	
	private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
	
	private int _Id;
	
	private string _Name;
	
	private string _Login;
	
	private string _Password;
	
	private EntitySet<Event> _Event;
	
	private EntitySet<EventInviteeRelation> _EventInviteeRelation;
	
	#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIdChanged();
		
		partial void OnIdChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnLoginChanged();
		
		partial void OnLoginChanging(string value);
		
		partial void OnPasswordChanged();
		
		partial void OnPasswordChanging(string value);
		#endregion
	
	
	public User()
	{
		_Event = new EntitySet<Event>(new Action<Event>(this.Event_Attach), new Action<Event>(this.Event_Detach));
		_EventInviteeRelation = new EntitySet<EventInviteeRelation>(new Action<EventInviteeRelation>(this.EventInviteeRelation_Attach), new Action<EventInviteeRelation>(this.EventInviteeRelation_Detach));
		this.OnCreated();
	}
	
	[Column(Storage="_Id", Name="id", DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((_Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[Column(Storage="_Name", Name="name", DbType="NVarChar(100) NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if (((_Name == value) 
						== false))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[Column(Storage="_Login", Name="login", DbType="NVarChar(100) NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Login
	{
		get
		{
			return this._Login;
		}
		set
		{
			if (((_Login == value) 
						== false))
			{
				this.OnLoginChanging(value);
				this.SendPropertyChanging();
				this._Login = value;
				this.SendPropertyChanged("Login");
				this.OnLoginChanged();
			}
		}
	}
	
	[Column(Storage="_Password", Name="password", DbType="NVarChar(100) NOT NULL", AutoSync=AutoSync.Never, CanBeNull=false)]
	[DebuggerNonUserCode()]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if (((_Password == value) 
						== false))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	#region Children
	[Association(Storage="_Event", OtherKey="CreatorId", ThisKey="Id", Name="Creator ID")]
	[DebuggerNonUserCode()]
	public EntitySet<Event> Event
	{
		get
		{
			return this._Event;
		}
		set
		{
			this._Event = value;
		}
	}
	
	[Association(Storage="_EventInviteeRelation", OtherKey="InviteeId", ThisKey="Id", Name="inviteeid")]
	[DebuggerNonUserCode()]
	public EntitySet<EventInviteeRelation> EventInviteeRelation
	{
		get
		{
			return this._EventInviteeRelation;
		}
		set
		{
			this._EventInviteeRelation = value;
		}
	}
	#endregion
	
	public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
	
	public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
		if ((h != null))
		{
			h(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(string propertyName)
	{
		System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
		if ((h != null))
		{
			h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
	#region Attachment handlers
	private void Event_Attach(Event entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void Event_Detach(Event entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	
	private void EventInviteeRelation_Attach(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void EventInviteeRelation_Detach(EventInviteeRelation entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	#endregion
}
