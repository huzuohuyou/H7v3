using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace InterconnectionAndInterworking.Entity.DTOs._7._19_21_23
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Response :ClassMoodAttr, IContent
    {
        /// <remarks/>
        public controlActProcessSubject subject { get; set; }

        /// <remarks/>
        public QueryAck queryAck { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubject:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectEncounterEvent encounterEvent { get; set; }

        
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEvent:ClassMoodAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public CodeSystem code { get; set; }

        /// <remarks/>
        public StatusCode statusCode { get; set; }

        /// <remarks/>
        public EffectiveTime effectiveTime { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventSubject subject { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventAdmitter admitter { get; set; }


    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventID
    {

        private string rootField;

        private string extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string root
        {
            get
            {
                return this.rootField;
            }
            set
            {
                this.rootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }

   

    

   

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventSubject:TypeCodeAttr
    {

        /// <remarks/>
        public controlActProcessSubjectEncounterEventSubjectPatient patient { get; set; }

 
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventSubjectPatient:ClassCodeAttr
    {

        /// <remarks/>
        public IDwithCode id { get; set; }

        /// <remarks/>
        public Person patientPerson { get; set; }


    }

   

   

   
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventAdmitter:TypeCodeAttr
    {

        /// <remarks/>
        public string time { get; set; }

        /// <remarks/>
        public AssignedPerson assignedPerson { get; set; }

 
    }

   

    
  

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventAdmitterAssignedPersonRepresentedOrganization:ClassDeterminerAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }

        /// <remarks/>
        public controlActProcessSubjectEncounterEventAdmitterAssignedPersonRepresentedOrganizationAsOrganizationPartOf asOrganizationPartOf { get; set; }

        
    }

   

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessSubjectEncounterEventAdmitterAssignedPersonRepresentedOrganizationAsOrganizationPartOf:ClassCodeAttr
    {

        /// <remarks/>
        public IDwithRootExtendsion id { get; set; }
        
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryAck
    {

        /// <remarks/>
        public controlActProcessQueryAckQueryResponseCode queryResponseCode { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class controlActProcessQueryAckQueryResponseCode:CodeAttr
    {
        
    }




}
