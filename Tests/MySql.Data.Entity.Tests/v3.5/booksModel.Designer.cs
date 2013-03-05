﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("booksModel", "fk_authors_myBooks", "myauthors", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MySql.Data.Entity.Tests.myauthors), "mybooks", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.mybooks))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("booksModel", "myeditionsinmybooks", "mybooks", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.mybooks), "myeditions", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.myeditions))]

// Original file name:
// Generation date: 27/01/2012 06:28:16 p.m.
namespace MySql.Data.Entity.Tests
{
    
    /// <summary>
    /// There are no comments for mybooksEntities in the schema.
    /// </summary>
    public partial class mybooksEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new mybooksEntities object using the connection string found in the 'mybooksEntities' section of the application configuration file.
        /// </summary>
        public mybooksEntities() : 
                base("name=mybooksEntities", "mybooksEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new mybooksEntities object.
        /// </summary>
        public mybooksEntities(string connectionString) : 
                base(connectionString, "mybooksEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new mybooksEntities object.
        /// </summary>
        public mybooksEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "mybooksEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for myauthors in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<myauthors> myauthors
        {
            get
            {
                if ((this._myauthors == null))
                {
                    this._myauthors = base.CreateQuery<myauthors>("[myauthors]");
                }
                return this._myauthors;
            }
        }
        private global::System.Data.Objects.ObjectQuery<myauthors> _myauthors;
        /// <summary>
        /// There are no comments for mybooks in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<mybooks> mybooks
        {
            get
            {
                if ((this._mybooks == null))
                {
                    this._mybooks = base.CreateQuery<mybooks>("[mybooks]");
                }
                return this._mybooks;
            }
        }
        private global::System.Data.Objects.ObjectQuery<mybooks> _mybooks;
        /// <summary>
        /// There are no comments for myeditions in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<myeditions> myeditions
        {
            get
            {
                if ((this._myeditions == null))
                {
                    this._myeditions = base.CreateQuery<myeditions>("[myeditions]");
                }
                return this._myeditions;
            }
        }
        private global::System.Data.Objects.ObjectQuery<myeditions> _myeditions;
        /// <summary>
        /// There are no comments for myauthors in the schema.
        /// </summary>
        public void AddTomyauthors(myauthors myauthors)
        {
            base.AddObject("myauthors", myauthors);
        }
        /// <summary>
        /// There are no comments for mybooks in the schema.
        /// </summary>
        public void AddTomybooks(mybooks mybooks)
        {
            base.AddObject("mybooks", mybooks);
        }
        /// <summary>
        /// There are no comments for myeditions in the schema.
        /// </summary>
        public void AddTomyeditions(myeditions myeditions)
        {
            base.AddObject("myeditions", myeditions);
        }
    }
    /// <summary>
    /// There are no comments for booksModel.myauthors in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="booksModel", Name="myauthors")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class myauthors : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new myauthors object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        public static myauthors Createmyauthors(int id, string name)
        {
            myauthors myauthors = new myauthors();
            myauthors.Id = id;
            myauthors.Name = name;
            return myauthors;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for mybooks in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("booksModel", "fk_authors_myBooks", "mybooks")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<mybooks> mybooks
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<mybooks>("booksModel.fk_authors_myBooks", "mybooks");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<mybooks>("booksModel.fk_authors_myBooks", "mybooks", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for booksModel.mybooks in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="booksModel", Name="mybooks")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class mybooks : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new mybooks object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        public static mybooks Createmybooks(int id)
        {
            mybooks mybooks = new mybooks();
            mybooks.Id = id;
            return mybooks;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for myauthors in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("booksModel", "fk_authors_myBooks", "myauthors")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public myauthors myauthors
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<myauthors>("booksModel.fk_authors_myBooks", "myauthors").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<myauthors>("booksModel.fk_authors_myBooks", "myauthors").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for myauthors in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<myauthors> myauthorsReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<myauthors>("booksModel.fk_authors_myBooks", "myauthors");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<myauthors>("booksModel.fk_authors_myBooks", "myauthors", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for myeditions in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("booksModel", "myeditionsinmybooks", "myeditions")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<myeditions> myeditions
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<myeditions>("booksModel.myeditionsinmybooks", "myeditions");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<myeditions>("booksModel.myeditionsinmybooks", "myeditions", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for booksModel.myeditions in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="booksModel", Name="myeditions")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class myeditions : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new myeditions object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="title">Initial value of Title.</param>
        public static myeditions Createmyeditions(int id, string title)
        {
            myeditions myeditions = new myeditions();
            myeditions.Id = id;
            myeditions.Title = title;
            return myeditions;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for mybooks in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("booksModel", "myeditionsinmybooks", "mybooks")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<mybooks> mybooks
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<mybooks>("booksModel.myeditionsinmybooks", "mybooks");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<mybooks>("booksModel.myeditionsinmybooks", "mybooks", value);
                }
            }
        }
    }
}
