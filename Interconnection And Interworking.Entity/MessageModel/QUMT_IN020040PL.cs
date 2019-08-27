using System;
using System.ComponentModel;
using System.Xml.Serialization;
using InterconnectionAndInterworking.Entity.DBModes;
using InterconnectionAndInterworking.Entity.DTOs._7._15;

namespace InterconnectionAndInterworking.Entity.MessageModel
{
    /// <summary>
    /// 医嘱查询响应
    /// </summary>
    /// 
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:hl7-org:v3")]
    [XmlRoot(Namespace = "urn:hl7-org:v3", IsNullable = false, ElementName = "QUMT_IN020040PL")]
    public class QUMT_IN020040PL : BaseResponse<CommonAcknowledgement, Response>
    {
        public QUMT_IN020040PL() { }

        public QUMT_IN020040PL(IAI_ORDER result, string requestId)
        {
            id = new IDwithRootExtendsion()
            {
                extension = "040CD76A-ED0E-400B-9FD3-60387BCDE0EB",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "QUMT_IN020040PL",
            };
            processingCode = new Code()
            {
                code = "P",
            };
            processingModeCode = new Code()
            {
                code = "I",
            };
            acceptAckCode = new Code()
            {
                code = "AL",
            };
            receiver = new SendReceiver()
            {
                typeCode = "RCV",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.999.234",
                        //extension = "2.16.156.10011.0.1.2",
                    },
                },
            };
            sender = new SendReceiver()
            {
                typeCode = "SND",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.999.567",
                        //extension = "2.16.156.10011.0.1.1",
                    },
                },
            };
            acknowledgement = new CommonAcknowledgement()
            {
                typeCode = "AA",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        extension = "1ee83ff1-08ab-4fe7-b573-ea777e9bad51",
                    },
                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = "处理成功",
                },
            };
            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "EVN",
                code = new CodeSystem()
                {
                    code = "QUMT_TE020040PL",
                    codeSystem = "2.16.840.1.113883.1.6",
                },
                subject = new controlActProcessSubject()
                {
                    typeCode = "SUBJ",
                    registrationEvent = new controlActProcessSubjectRegistrationEvent()
                    {
                        classCode = "REG",
                        moodCode = "EVN",
                        statusCode = new StatusCode() { },
                        subject1 = new controlActProcessSubjectRegistrationEventSubject1()
                        {
                            typeCode = "SBJ",
                            substanceAdministrationRequest = new AdministrationRequest()
                            {
                                classCode = "SBADM",
                                moodCode = "RQO",
                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.1.28",
                                    extension = result.order_id,
                                },
                                code = new CodeSystem()
                                {
                                    code = result.order_type_code,
                                    codeSystem = "2.16.156.10011.2.3.1.268",
                                    codeSystemName = "医嘱项目类型代码表",
                                    displayName= "药品类医嘱"
                                },
                                text = result.text,
                                statusCode = new StatusCode() { code = "active", },
                                effectiveTime = new EffectiveTimewithLowHigh[] {
                                        new EffectiveTimewithLowHigh(){
                                            type="IVL_TS",
                                            low=new Value(){  value=result.effectivetime_low,},
                                            high=new Value(){  value=result.effectivetime_high,},
                                        },
                                        new EffectiveTimewithLowHigh(){
                                            type="PIVL_TS",
                                            Operator="A",
                                            period=new ValueUnit(){
                                                value =result.effectivetime_period,
                                                unit =result.effectivetime_unit},
                                        },
                                    },
                                routeCode = new CodeSystem()
                                {
                                    code = result.route_code,
                                    codeSystem = "2.16.156.10011.2.3.1.158",
                                    displayName = "口服",
                                    codeSystemName = "用药途径代码表",
                                },
                                doseQuantity = new ValueUnit()
                                {
                                    value = result.dose_quantity,
                                    unit = result.dose_quantity_unit,
                                },
                                doseCheckQuantity = new DoseCheckQuantity()
                                {
                                    type = "RTO_QTY_QTY",
                                    numerator = new ValueUnit()
                                    {
                                        type = "PQ",
                                        unit = "g",
                                        value = "1",
                                    },
                                    denominator = new ValueUnit()
                                    {
                                        type = "PQ",
                                        unit = "d",
                                        value = "1",
                                    },
                                },
                                administrationUnitCode = new CodeSystem()
                                {
                                    code = "12",
                                    codeSystem = "2.16.156.10011.2.3.1.211",
                                    displayName= "分散片(适应片)",
                                    codeSystemName = "药物剂型代码表",
                                },
                                consumable2 = new Consumable2()
                                {
                                    typeCode = "CSM",
                                    contextControlCode = "ON",
                                    medication1 = new Medication1()
                                    {
                                        classCode = "ADMM",
                                        administerableMedicine = new AdministerableMedicine()
                                        {
                                            classCode = "MMAT",
                                            determinerCode = "KIND",
                                            name = result.medicine_name,
                                            asContent = new AsContent()
                                            {
                                                classCode = "CONT",
                                                containerPackagedMedicine = new ContainerPackagedMedicine()
                                                {
                                                    classCode = "HOLD",
                                                    determinerCode = "KIND",
                                                    capacityQuantity = new ValueUnit()
                                                    {
                                                        value = result.capacity_quantity,
                                                        unit = "g/片",
                                                    },

                                                },
                                            },
                                        },
                                    },
                                },
                                author = new Author()
                                {
                                    typeCode = "AUT",
                                    contextControlCode = "OP",
                                    time = new Value() { value = result.author_time },
                                    signatureCode = new Code() { code = "S" },
                                    signatureText = result.signature_text,
                                    assignedEntity = new Entity.AssignedEntity()
                                    {
                                        classCode = "ASSIGNED",
                                        id = new IDwithRootExtendsion()
                                        {
                                            root = "2.16.156.10011.1.4",
                                            extension = result.assignedentity_id,
                                        },
                                        assignedPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name() { Value = result.assignedperson_name },
                                        },
                                        representedOrganization = new RepresentedOrganization()
                                        {
                                            classCode = "ORG",
                                            determinerCode = "INSTANCE",
                                            id = new IDwithRootExtendsion()
                                            {
                                                root = "2.16.156.10011.1.26",
                                                extension = result.organization_id,
                                            },
                                            name = result.organization_name,
                                            contactParty = new ContactParty()
                                            {
                                                classCode = "CON",
                                                contactPerson = new Person()
                                                {
                                                    classCode = "PSN",
                                                    determinerCode = "INSTANCE",
                                                    name = new Name()
                                                    {
                                                        Value = "王联系",
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                verifier = new Author()
                                {
                                    typeCode = "VRF",
                                    contextControlCode = "OP",
                                    time = new Value() { value = result.verifier_time },
                                    signatureCode = new Code() { code = "S" },
                                    signatureText = result.verifier_assignedentity_name,
                                    assignedEntity = new Entity.AssignedEntity()
                                    {
                                        classCode = "ASSIGNED",
                                        id = new IDwithRootExtendsion()
                                        {
                                            root = "2.16.156.10011.1.4",
                                            extension = result.verifier_assignedentity_id,
                                        },
                                        assignedPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name() { Value = result.verifier_assignedentity_name },
                                        },
                                    },
                                },
                                subjectOf6 = new SubjectOf6()
                                {
                                    typeCode = "SUBJ",
                                    contextConductionInd = "false",
                                    seperatableInd = new Value() { value = "false" },
                                    annotation = new Annotation()
                                    {
                                        text = result.annotion_text,
                                        statusCode = new StatusCode()
                                        {
                                            code = "completed",// result.annotion_status_code,
                                        },

                                        author = new Author()
                                        {
                                            assignedEntity = new Entity.AssignedEntity()
                                            {
                                                classCode = "ASSIGNED",
                                                id = new IDwithRootExtendsion()
                                                {
                                                    root = "2.16.156.10011.1.4",
                                                    extension = result.annotion_author_id,
                                                },
                                                assignedPerson = new Person()
                                                {
                                                    classCode = "PSN",
                                                    determinerCode = "INSTANCE",
                                                    name = new Name() { Value = result.annotion_author_name },
                                                },
                                                representedOrganization = new RepresentedOrganization()
                                                {
                                                    classCode = "ORG",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion()
                                                    {
                                                        root = "2.16.156.10011.1.26",
                                                        extension = result.annotion_organization_id,
                                                    },
                                                    name = result.annotion_organization_name,
                                                    //contactParty = new ContactParty()
                                                    //{
                                                    //    classCode = "CON",
                                                    //    contactPerson = new Person()
                                                    //    {
                                                    //        classCode = "PSN",
                                                    //        determinerCode = "INSTANCE",
                                                    //        name = new Name()
                                                    //        {
                                                    //            Value = "王联系",
                                                    //        },
                                                    //    },
                                                    //},
                                                },
                                            },
                                        },
                                    },
                                },
                                componentOf1 = new ComponentOf1()
                                {
                                    contextConductionInd = "false",
                                    encounter = new Encounter()
                                    {
                                        classCode = "ENC",
                                        moodCode = "EVN",
                                        id = "",
                                        statusCode = new StatusCode()
                                        {
                                            code = "active",
                                        },
                                        subject = new EncounterSubject()
                                        {
                                            typeCode = "SBJ",
                                            patient = new EncounterSubjectPatient()
                                            {
                                                classCode = "PAT",
                                                id = new IDwithRootExtendsion[] {
                                                       new IDwithRootExtendsion{
                                                            root="2.16.156.10011.1.10",
                                                        extension ="E10000000"
                                                       },
                                                       new IDwithRootExtendsion{
                                                            root="2.16.156.10011.1.12",
                                                        extension ="HA201102113366666"
                                                       }
                                                    },
                                                telecom = new Telecom { },
                                                statusCode = new StatusCode { code = "active" },
                                                patientPerson = new PatientPerson<AsOtherIDsofOrder>
                                                {
                                                    classCode = "PSN",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion
                                                    {
                                                        root = "2.16.156.10011.1.3",
                                                        extension = "1234567890"
                                                    },
                                                    name = new Name
                                                    {
                                                        use = "L",
                                                        Value = "王患者",
                                                    },
                                                    administrativeGenderCode = new CodeSystem
                                                    {
                                                        code = "1",
                                                        codeSystem = "2.16.156.10011.2.3.3.4",
                                                        displayName = "男性",
                                                        codeSystemName = "生理性别代码表(GB/T 2261.1)",
                                                    },
                                                    birthTime = new Value { value = "19570323" },
                                                    asOtherIDs = new AsOtherIDsofOrder
                                                    {
                                                        classCode = "ROL",
                                                        id = new asOtherIDsID[] {
                                                                new asOtherIDsID{
                                                                    root="2.16.156.10011.1.2",
                                                                    extension="12345678901234567"
                                                                },
                                                                new asOtherIDsID{
                                                                    root="2.16.156.10011.1.2",
                                                                    extension="12345678901234567"
                                                                },
                                                            },
                                                    },
                                                },

                                            },
                                        },
                                        location = new LocationofOrder
                                        {
                                            typeCode = "LOC",
                                            time = "",
                                            serviceDeliveryLocation = new ServiceDeliveryLocation()
                                            {
                                                classCode = "SDLOC",
                                                location = new ServiceDeliveryLocationLocation()
                                                {
                                                    classCode = "PLC",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion
                                                    {
                                                        root = "2.16.156.10011.1.22",
                                                        extension = "001",
                                                    },
                                                    name = "1床",
                                                    asLocatedEntityPartOf = new AsLocatedEntityPartOf
                                                    {
                                                        classCode = "LOCE",
                                                        location = new AsLocatedEntityPartOfLocation
                                                        {
                                                            classCode = "PLC",
                                                            determinerCode = "INSTANCE",
                                                            id = new IDwithRootExtendsion
                                                            {
                                                                root = "2.16.156.10011.1.21",
                                                                extension = "001",
                                                            },
                                                            name = "205室",
                                                        },

                                                    },
                                                },
                                                serviceProviderOrganization = new ServiceProviderOrganization
                                                {
                                                    classCode = "ORG",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion
                                                    {
                                                        root = "2.16.156.10011.1.26",
                                                        extension = "001"
                                                    },
                                                    name = "呼吸内科",
                                                    asOrganizationPartOf = new AsOrganizationPartOf2
                                                    {
                                                        classCode = "PART",
                                                        wholeOrganization = new WholeOrganization
                                                        {
                                                            classCode = "ORG",
                                                            determinerCode = "INSTANCE",
                                                            id = new IDwithRootExtendsion
                                                            {
                                                                root = "2.16.156.10011.1.27",
                                                                extension = "001"
                                                            },
                                                            name = "1病区"
                                                        },
                                                    },
                                                },
                                            },
                                        }
                                    },
                                },
                            },
                        },
                        custodian = new Custodian()
                        {
                            typeCode = "CST",
                            assignedEntity = new AssignedEntity()
                            {
                                classCode = "ASSIGNED",

                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.3.2",
                                    extension = "120109197706015518",

                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = "赵武",
                                    },
                                },
                                representedOrganization = new RepresentedOrganization()
                                {
                                    classCode = "ORG",
                                    determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion()
                                    {
                                        root = "2.16.156.10011.1.26",
                                        extension = "xxx12345-X",
                                    },
                                    name = "人事科",
                                    contactParty = new ContactParty()
                                    {
                                        classCode = "CON",
                                        contactPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name()
                                            {
                                                Value = "王联系",
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                queryAck = new QueryAck()
                {
                    queryResponseCode = new Code() { code = "OK" },
                },
                queryByParameterPayload = new QueryByParameterPayloadofOrder
                {
                    statusCode = new StatusCode
                    {
                        code = "new",
                    },
                    actId = new ValueSemanticsText<ValuewithRootExtension>
                    {
                        value = new ValuewithRootExtension
                        {
                            root = "2.16.156.10011.1.4",
                            extension = result.order_id,
                        },
                        semanticsText = "Act.ID",
                    },
                    authorId = new ValueSemanticsText<ValuewithRootExtension>
                    {
                        value = new ValuewithRootExtension
                        {
                            root = "2.16.156.10011.1.4",
                            extension = "1234567890",
                        },
                        semanticsText = "author.Entity.ID",
                    },
                    effectiveTime = new ValueSemanticsText<EffectiveTimewithLowHigh>
                    {
                        value = new EffectiveTimewithLowHigh
                        {
                            low = new Value { value = "20130303040404" },
                            high = new Value { value = "20130303050505" },
                        },
                        semanticsText = "EffectiveTime",
                    },
                    patientId = new ValueSemanticsText<ValuewithRootExtension>
                    {
                        value = new ValuewithRootExtension
                        {
                            root = "2.16.156.10011.1.12",
                            extension = "12345678901w",
                        },
                        semanticsText = "recordTarget.Patient.ID",
                    },
                    statusCodeParam = new ValueSemanticsText<ValuewithCode>
                    {
                        value = new ValuewithCode { code = "active" },
                        semanticsText = "StatusCode",
                    },
                },
            };
        }


        public QUMT_IN020040PL(IAI_OBSERVATION result,  string requestId)
        {
            id = new IDwithRootExtendsion()
            {
                extension = "040CD76A-ED0E-400B-9FD3-60387BCDE0EB",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "QUMT_IN020040PL",
            };
            processingCode = new Code()
            {
                code = "P",
            };
            processingModeCode = new Code()
            {
                code = "I",
            };
            acceptAckCode = new Code()
            {
                code = "AL",
            };
            receiver = new SendReceiver()
            {
                typeCode = "RCV",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.999.234",
                        //extension = "2.16.156.10011.0.1.2",
                    },
                },
            };
            sender = new SendReceiver()
            {
                typeCode = "SND",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.999.567",
                        //extension = "2.16.156.10011.0.1.1",
                    },
                },
            };
            acknowledgement = new CommonAcknowledgement()
            {
                typeCode = "AA",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        extension = requestId,
                    },
                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = "处理成功",
                },
            };
            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "EVN",
                code = new CodeSystem()
                {
                    code = "QUMT_TE020040PL",
                    codeSystem = "2.16.840.1.113883.1.6",
                },
                subject = new controlActProcessSubject()
                {
                    typeCode = "SUBJ",
                    registrationEvent = new controlActProcessSubjectRegistrationEvent()
                    {
                        classCode = "REG",
                        moodCode = "EVN",
                        statusCode = new StatusCode() { },
                        subject1 = new controlActProcessSubjectRegistrationEventSubject1()
                        {
                            typeCode = "SBJ",
                            
                            observationRequest = new ObservationRequest
                            {
                                classCode = "OBS",
                                moodCode = "RQO",
                                id = new IDwithRootExtendsion
                                {
                                    root = "2.16.156.10011.1.24",
                                    extension = result.observation_id,
                                },
                                code = "",
                                text = "",
                                statusCode = new StatusCode { code = "active" },
                                effectiveTime = new EffectiveTimewithLowHigh
                                {
                                    type = "IVL_TS",
                                    low = new Value() {
                                        value = result.effectivetime_low,//"20110202030303",// 
                                    },
                                    high = new Value() {
                                        value = result.effectivetime_high,//"20110202030303",//
                                    },
                                },
                                priorityCode = new CodeSystem
                                {
                                    code = result.prioritycode,
                                    displayName = "routine",
                                    codeSystem = "2.16.840.1.113883.1.11.16866",
                                    codeSystemName = "ActPriority"
                                },
                                specimen = new Specimen
                                {
                                    typeCode = "SPC",
                                    contextControlCode = "OP",
                                    specimen = new SpecimenSpecimen
                                    {
                                        classCode = "SPEC",
                                        id = new IDwithRootExtendsion
                                        {
                                            root = "2.16.156.10011.1.14",
                                            extension = result.specimen_id
                                        },
                                        code = "",
                                        specimenNatural = new SpecimenNatural
                                        {
                                            classCode = "ENT",
                                            determinerCode = "INSTANCE",
                                            code = "",
                                            desc =result.specimen_desc,//-------
                                            additive = new Additive
                                            {
                                                classCode = "ADTV",
                                                additive3 = new Additive3
                                                {
                                                    classCode = "MAT",
                                                    determinerCode = "INSTANCE",
                                                    desc = new Desc {
                                                        type="ST",
                                                        Value= result.additive3,//----
                                                    },

                                                },
                                            },
                                        },
                                        productOf = new ProductOf
                                        {
                                            typeCode = "PRD",
                                            time = new Value
                                            {
                                                value = result.productOf_time,
                                            },
                                            specimenProcessStep = new SpecimenProcessStep
                                            {
                                                classCode = "ACSN",
                                                moodCode = "EVN",
                                                effectiveTime = new EffectiveTime {
                                                    value= result.specimenProcessStep_time
                                                }
                                            },
                                        },
                                    },
                                },

                                recordTarget = new RecordTarget
                                {
                                    typeCode = "RCT",
                                    contextControlCode = "OP",
                                    patient = new RecordTargetPatient
                                    {
                                        classCode = "PAT",
                                        id = new IDwithRootExtendsion[] {
                                           new IDwithRootExtendsion{
                                               root="2.16.156.10011.1.10",
                                               extension=result.recordtarget,
                                           }
                                        }
                                    },
                                },
                                author = new Author
                                {
                                    typeCode = "AUT",
                                    contextControlCode = "OP",
                                    time = new Value {
                                        value = result.author_time,//---
                                    },
                                    signatureCode = new Code
                                    {
                                        code = "S"
                                    },
                                    signatureText =  result.signaturetext,
                                    assignedEntity = new AssignedEntity()
                                    {
                                        classCode = "ASSIGNED",

                                        id = new IDwithRootExtendsion()
                                        {
                                            root = "2.16.156.10011.0.3.2",
                                            extension =result.author_assignedentity_id,

                                        },
                                        assignedPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name()
                                            {
                                                //use = "L",
                                                Value = result.assignedperson_name,
                                            },
                                        },
                                        representedOrganization = new RepresentedOrganization()
                                        {
                                            classCode = "ORG",
                                            determinerCode = "INSTANCE",
                                            id = new IDwithRootExtendsion()
                                            {
                                                root = "2.16.156.10011.1.26",
                                                extension = result.represented_organization_id,
                                            },
                                            name = result.represented_organization_name,
                                           
                                        },
                                    },

                                },
                                verifier = new Author()
                                {
                                    typeCode = "VRF",
                                    contextControlCode = "OP",
                                    time = new Value() {

                                        value = result.verifier_time

                                    },
                                    signatureCode = new Code() { code = "S" },
                                    signatureText =  result.verifier_signaturetext,
                                    assignedEntity = new Entity.AssignedEntity()
                                    {
                                        classCode = "ASSIGNED",
                                        id = new IDwithRootExtendsion()
                                        {
                                            root = "2.16.156.10011.1.4",
                                            extension =  result.verifier_assignedentity_id,
                                        },
                                        assignedPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name() {
                                                Value =result.verifier_assignedperson_name
                                            },
                                        },
                                    },
                                },
                                goal = new Goal {
                                    typeCode= "OBJC",
                                    observationEventCriterion = new ObservationEventCriterion {
                                        text =  result.goal_text
                                    }
                                },
                                reason = new Reason[] {
                                    new Reason{
                                        typeCode="RSON",
                                        contextConductionInd="true",
                                        contextControlCode="OP",
                                        observation = new Observation{
                                            classCode="OBS",
                                            moodCode="EVN",
                                            code = new CodeSystem{
                                                code="DE04.01.119.00",
                                                codeSystem="2.16.156.10011.2.2.1",
                                                displayName="主诉",
                                                codeSystemName="卫生信息数据元目录"

                                            },
                                            value = new ValuewithValueType{
                                                type="ST",
                                                Value= result.goal_reason,
                                            },
                                        },
                                    },
                                },

                                subjectOf6 = new SubjectOf6()
                                {
                                    typeCode = "SUBJ",
                                    contextConductionInd = "false",
                                    seperatableInd = new Value() { value = "false" },
                                    annotation = new Annotation()
                                    {
                                        text =  result.annotation_text,
                                        statusCode = new StatusCode()
                                        {
                                            code = "completed",
                                        },
                                        author = new Author()
                                        {
                                            assignedEntity = new Entity.AssignedEntity()
                                            {
                                                classCode = "ASSIGNED",
                                                id = new IDwithRootExtendsion()
                                                {
                                                    root = "2.16.156.10011.1.4",
                                                    extension =  result.annotation_author_id,
                                                },
                                                assignedPerson = new Person()
                                                {
                                                    classCode = "PSN",
                                                    determinerCode = "INSTANCE",
                                                    name = new Name() {
                                                        Value = result.annotation_author_name
                                                    },
                                                },
                                                representedOrganization = new RepresentedOrganization()
                                                {
                                                    classCode = "ORG",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion()
                                                    {
                                                        root = "2.16.156.10011.1.26",
                                                        extension =  result.represented_organization_id,
                                                    },
                                                    name =  result.represented_organization_name,
                                                    
                                                },
                                            },
                                        },
                                    },
                                },
                                componentOf1 = new ComponentOf1()
                                {
                                    contextConductionInd = "false",
                                    encounter = new Encounter()
                                    {
                                        classCode = "ENC",
                                        moodCode = "EVN",
                                        id = "",
                                        statusCode = new StatusCode()
                                        {
                                            code = "active",
                                        },
                                        subject = new EncounterSubject()
                                        {
                                            typeCode = "SBJ",
                                            patient = new EncounterSubjectPatient()
                                            {
                                                classCode = "PAT",
                                                id = new IDwithRootExtendsion[] {
                                                       new IDwithRootExtendsion{
                                                            root="2.16.156.10011.1.10",
                                                        extension ="E10000000"
                                                       },
                                                       new IDwithRootExtendsion{
                                                            root="2.16.156.10011.1.12",
                                                        extension ="HA201102113366666"
                                                       }
                                                    },
                                                telecom = new Telecom { },
                                                statusCode = new StatusCode { code = "active" },
                                                patientPerson = new PatientPerson<AsOtherIDsofOrder>
                                                {
                                                    classCode = "PSN",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion
                                                    {
                                                        root = "2.16.156.10011.1.3",
                                                        extension = "1234567890"
                                                    },
                                                    name = new Name
                                                    {
                                                        use = "L",
                                                        Value = "王患者",
                                                    },
                                                    administrativeGenderCode = new CodeSystem
                                                    {
                                                        code = "1",
                                                        codeSystem = "2.16.156.10011.2.3.3.4",
                                                        displayName = "男性",
                                                        codeSystemName = "生理性别代码表(GB/T 2261.1)",
                                                    },
                                                    birthTime = new Value { value = "19570323" },
                                                    asOtherIDs = new AsOtherIDsofOrder
                                                    {
                                                        classCode = "ROL",
                                                        id = new asOtherIDsID[] {
                                                                new asOtherIDsID{
                                                                    root="2.16.156.10011.1.2",
                                                                    extension="12345678901234567"
                                                                },
                                                                new asOtherIDsID{
                                                                    root="2.16.156.10011.1.2",
                                                                    extension="12345678901234567"
                                                                },
                                                            },
                                                    },
                                                },

                                            },
                                        },
                                        location = new LocationofOrder
                                        {
                                            typeCode = "LOC",
                                            time = "",
                                            serviceDeliveryLocation = new ServiceDeliveryLocation()
                                            {
                                                classCode = "SDLOC",
                                                location = new ServiceDeliveryLocationLocation()
                                                {
                                                    classCode = "PLC",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion
                                                    {
                                                        root = "2.16.156.10011.1.22",
                                                        extension = "001",
                                                    },
                                                    name = "1床",
                                                    asLocatedEntityPartOf = new AsLocatedEntityPartOf
                                                    {
                                                        classCode = "LOCE",
                                                        location = new AsLocatedEntityPartOfLocation
                                                        {
                                                            classCode = "PLC",
                                                            determinerCode = "INSTANCE",
                                                            id = new IDwithRootExtendsion
                                                            {
                                                                root = "2.16.156.10011.1.21",
                                                                extension = "001",
                                                            },
                                                            name = "205室",
                                                        },

                                                    },
                                                },
                                                serviceProviderOrganization = new ServiceProviderOrganization
                                                {
                                                    classCode = "ORG",
                                                    determinerCode = "INSTANCE",
                                                    id = new IDwithRootExtendsion
                                                    {
                                                        root = "2.16.156.10011.1.26",
                                                        extension = "001"
                                                    },
                                                    name = "呼吸内科",
                                                    asOrganizationPartOf = new AsOrganizationPartOf2
                                                    {
                                                        classCode = "PART",
                                                        wholeOrganization = new WholeOrganization
                                                        {
                                                            classCode = "ORG",
                                                            determinerCode = "INSTANCE",
                                                            id = new IDwithRootExtendsion
                                                            {
                                                                root = "2.16.156.10011.1.27",
                                                                extension = "001"
                                                            },
                                                            name = "1病区"
                                                        },
                                                    },
                                                },
                                            },
                                        }
                                    },
                                },
                            },
                        },
                        custodian = new Custodian()
                        {
                            typeCode = "CST",
                            assignedEntity = new AssignedEntity()
                            {
                                classCode = "ASSIGNED",

                                id = new IDwithRootExtendsion()
                                {
                                    root = "2.16.156.10011.0.3.2",
                                    extension = "120109197706015518",

                                },
                                assignedPerson = new Person()
                                {
                                    classCode = "PSN",
                                    determinerCode = "INSTANCE",
                                    name = new Name()
                                    {
                                        use = "L",
                                        Value = "赵武",
                                    },
                                },
                                representedOrganization = new RepresentedOrganization()
                                {
                                    classCode = "ORG",
                                    determinerCode = "INSTANCE",
                                    id = new IDwithRootExtendsion()
                                    {
                                        root = "2.16.156.10011.1.26",
                                        extension = "xxx12345-X",
                                    },
                                    name = "人事科",
                                    contactParty = new ContactParty()
                                    {
                                        classCode = "CON",
                                        contactPerson = new Person()
                                        {
                                            classCode = "PSN",
                                            determinerCode = "INSTANCE",
                                            name = new Name()
                                            {
                                                Value = "王联系",
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                queryAck = new QueryAck()
                {
                    queryResponseCode = new Code() { code = "OK" },
                },
                queryByParameterPayload = new QueryByParameterPayloadofOrder
                {
                    statusCode = new StatusCode
                    {
                        code = "new",
                    },
                    actId = new ValueSemanticsText<ValuewithRootExtension>
                    {
                        value = new ValuewithRootExtension
                        {
                            root = "2.16.156.10011.1.4",
                            extension = result.observation_id,
                        },
                        semanticsText = "Act.ID",
                    },
                    authorId = new ValueSemanticsText<ValuewithRootExtension>
                    {
                        value = new ValuewithRootExtension
                        {
                            root = "2.16.156.10011.1.4",
                            extension = "1234567890",
                        },
                        semanticsText = "author.Entity.ID",
                    },
                    effectiveTime = new ValueSemanticsText<EffectiveTimewithLowHigh>
                    {
                        value = new EffectiveTimewithLowHigh
                        {
                            low = new Value { value = "20130303040404" },
                            high = new Value { value = "20130303050505" },
                        },
                        semanticsText = "EffectiveTime",
                    },
                    patientId = new ValueSemanticsText<ValuewithRootExtension>
                    {
                        value = new ValuewithRootExtension
                        {
                            root = "2.16.156.10011.1.12",
                            extension = "12345678901w",
                        },
                        semanticsText = "recordTarget.Patient.ID",
                    },
                    statusCodeParam = new ValueSemanticsText<ValuewithCode>
                    {
                        value = new ValuewithCode { code = "active" },
                        semanticsText = "StatusCode",
                    },
                },
            };
        }

        public QUMT_IN020040PL(string message,  string requestId)
        {
            id = new IDwithRootExtendsion()
            {
                extension = "040CD76A-ED0E-400B-9FD3-60387BCDE0EB",
            };
            creationTime = new Time
            {
                value = "20070803130624",
            };
            interactionId = new IDwithRootExtendsion()
            {
                root = "2.16.840.1.113883.1.6",
                extension = "POOR_IN200901UV",
            };
            processingCode = new Code()
            {
                code = "P",
            };
            processingModeCode = new Code()
            {
                code = "I",
            };
            acceptAckCode = new Code()
            {
                code = "AL",
            };
            receiver = new SendReceiver()
            {
                typeCode = "RCV",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.999.567",
                        //extension = "2.16.156.10011.0.1.2",
                    },
                },
            };
            sender = new SendReceiver()
            {
                typeCode = "SND",
                device = new Device()
                {
                    classCode = "DEV",
                    determinerCode = "INSTANCE",
                    id = new IDwithRootExtendsion()
                    {
                        root = "1.2.840.114350.1.13.999.234",
                        //extension = "2.16.156.10011.0.1.1",
                    },
                },
            };
            acknowledgement = new CommonAcknowledgement()
            {
                typeCode = "AE",
                targetMessage = new CommonTargetMessage()
                {
                    id = new IDwithRootExtendsion()
                    {
                        extension = requestId,
                    },
                },
                acknowledgementDetail = new CommonAcknowledgementDetail()
                {
                    text = "处理成功",
                },
            };
            controlActProcess = new Response()
            {
                classCode = "CACT",
                moodCode = "APT",

                queryAck = new QueryAck()
                {
                    queryResponseCode = new Code() { code = "OK" },
                },

            };
        }
    }
}
