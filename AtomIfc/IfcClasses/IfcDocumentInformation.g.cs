
/*
 *  Copyright (c) 2022 Qonic
 *
 *  This file is auto-generated.
 *
 *  Do not modify manually!
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Ifc
{
    public class IfcDocumentInformation : IfcExternalInformation, IEquatable<IfcDocumentInformation>, IIfcDocumentSelect
    {
        private string _identification;
        public string Identification 
        {
            get { 
                return _identification; 
            }
            set { 
                _identification = value;
            }
        }
        private string _name;
        public string Name 
        {
            get { 
                return _name; 
            }
            set { 
                _name = value;
            }
        }
        private string _description;
        public string Description 
        {
            get { 
                return _description; 
            }
            set { 
                _description = value;  // optional IfcText
            }
        }
        private string _location;
        public string Location 
        {
            get { 
                return _location; 
            }
            set { 
                _location = value;  // optional IfcURIReference
            }
        }
        private string _purpose;
        public string Purpose 
        {
            get { 
                return _purpose; 
            }
            set { 
                _purpose = value;  // optional IfcText
            }
        }
        private string _intendedUse;
        public string IntendedUse 
        {
            get { 
                return _intendedUse; 
            }
            set { 
                _intendedUse = value;  // optional IfcText
            }
        }
        private string _scope;
        public string Scope 
        {
            get { 
                return _scope; 
            }
            set { 
                _scope = value;  // optional IfcText
            }
        }
        private string _revision;
        public string Revision 
        {
            get { 
                return _revision; 
            }
            set { 
                _revision = value;  // optional IfcLabel
            }
        }
        private IfcId _documentOwnerId;
        public IfcId DocumentOwnerId 
        {
            get { 
                return _documentOwnerId; 
            }
            set { 
                _documentOwnerId = value;  // optional IfcActorSelect
            }
        }
        private List<IfcId> _editorIds;
        public List<IfcId> EditorIds 
        {
            get { 
                return _editorIds; 
            }
            set { 
                _editorIds = value;  // optional List<IfcActorSelect>
            }
        }
        private string _creationTime;
        public string CreationTime 
        {
            get { 
                return _creationTime; 
            }
            set { 
                _creationTime = value;  // optional IfcDateTime
            }
        }
        private string _lastRevisionTime;
        public string LastRevisionTime 
        {
            get { 
                return _lastRevisionTime; 
            }
            set { 
                _lastRevisionTime = value;  // optional IfcDateTime
            }
        }
        private string _electronicFormat;
        public string ElectronicFormat 
        {
            get { 
                return _electronicFormat; 
            }
            set { 
                _electronicFormat = value;  // optional IfcIdentifier
            }
        }
        private string _validFrom;
        public string ValidFrom 
        {
            get { 
                return _validFrom; 
            }
            set { 
                _validFrom = value;  // optional IfcDate
            }
        }
        private string _validUntil;
        public string ValidUntil 
        {
            get { 
                return _validUntil; 
            }
            set { 
                _validUntil = value;  // optional IfcDate
            }
        }
        private IfcDocumentConfidentialityEnum _confidentiality;
        public IfcDocumentConfidentialityEnum Confidentiality 
        {
            get { 
                return _confidentiality; 
            }
            set { 
                _confidentiality = value;  // optional IfcDocumentConfidentialityEnum?
            }
        }
        private IfcDocumentStatusEnum _status;
        public IfcDocumentStatusEnum Status 
        {
            get { 
                return _status; 
            }
            set { 
                _status = value;  // optional IfcDocumentStatusEnum?
            }
        }

        public IfcDocumentInformation(IfcId id, string identification, string name, string description, string location, string purpose, string intendedUse, string scope, string revision, IfcId documentOwnerId, List<IfcId> editorIds, string creationTime, string lastRevisionTime, string electronicFormat, string validFrom, string validUntil, IfcDocumentConfidentialityEnum confidentiality, IfcDocumentStatusEnum status) : base(id)
        {
            Identification = identification;
            Name = name;
            Description = description;
            Location = location;
            Purpose = purpose;
            IntendedUse = intendedUse;
            Scope = scope;
            Revision = revision;
            DocumentOwnerId = documentOwnerId;
            EditorIds = editorIds;
            CreationTime = creationTime;
            LastRevisionTime = lastRevisionTime;
            ElectronicFormat = electronicFormat;
            ValidFrom = validFrom;
            ValidUntil = validUntil;
            Confidentiality = confidentiality;
            Status = status;
        }

        public override ClassId GetClassId() => ClassId.IfcDocumentInformation;

        #region Equality

        public bool Equals(IfcDocumentInformation other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            if(!Utils.CompareList(EditorIds, other.EditorIds))
                return false;
            return base.Equals(other)
                && Identification == other.Identification
                && Name == other.Name
                && Description == other.Description
                && Location == other.Location
                && Purpose == other.Purpose
                && IntendedUse == other.IntendedUse
                && Scope == other.Scope
                && Revision == other.Revision
                && DocumentOwnerId == other.DocumentOwnerId
                && CreationTime == other.CreationTime
                && LastRevisionTime == other.LastRevisionTime
                && ElectronicFormat == other.ElectronicFormat
                && ValidFrom == other.ValidFrom
                && ValidUntil == other.ValidUntil
                && Confidentiality == other.Confidentiality
                && Status == other.Status;
        }

        public override bool Equals(object other) => Equals(other as IfcDocumentInformation);

        public static bool operator ==(IfcDocumentInformation one, IfcDocumentInformation other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcDocumentInformation one, IfcDocumentInformation other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}('{Identification}','{Name}','{Description}','{Location}','{Purpose}','{IntendedUse}','{Scope}','{Revision}',{DocumentOwnerId},{Utils.ConvertListToString(EditorIds)},'{CreationTime}','{LastRevisionTime}','{ElectronicFormat}','{ValidFrom}','{ValidUntil}',.{Confidentiality}.,.{Status}.)";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(DocumentOwnerId!= null && replacementTable.ContainsKey(DocumentOwnerId))
                DocumentOwnerId = replacementTable[DocumentOwnerId];
            if(EditorIds!= null)
                EditorIds = EditorIds.Select(id => replacementTable.ContainsKey(id) ? replacementTable[id] : id).ToList();
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcDocumentInformation (newId,Identification, Name, Description, Location, Purpose, IntendedUse, Scope, Revision, DocumentOwnerId, EditorIds, CreationTime, LastRevisionTime, ElectronicFormat, ValidFrom, ValidUntil, Confidentiality, Status);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcDocumentInformation },
                { "class", nameof(IfcDocumentInformation) },
                { "parameters" , new JArray
                    {
                        Identification.ToJValue(),
                        Name.ToJValue(),
                        Description.ToJValue(),
                        Location.ToJValue(),
                        Purpose.ToJValue(),
                        IntendedUse.ToJValue(),
                        Scope.ToJValue(),
                        Revision.ToJValue(),
                        DocumentOwnerId.ToJValue(),
                        EditorIds.ToJArray(),
                        CreationTime.ToJValue(),
                        LastRevisionTime.ToJValue(),
                        ElectronicFormat.ToJValue(),
                        ValidFrom.ToJValue(),
                        ValidUntil.ToJValue(),
                        Confidentiality.ToJValue(),
                        Status.ToJValue(),
                    }
                }
            };
        }

        public static IfcDocumentInformation CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcDocumentInformation(
                jObject["id"].ToIfcId(),
                parameters[0].ToString(),
                parameters[1].ToString(),
                parameters[2].ToOptionalString(),
                parameters[3].ToOptionalString(),
                parameters[4].ToOptionalString(),
                parameters[5].ToOptionalString(),
                parameters[6].ToOptionalString(),
                parameters[7].ToOptionalString(),
                parameters[8].ToOptionalIfcId(),
                parameters[9].ToOptionalIfcIdList(),
                parameters[10].ToOptionalString(),
                parameters[11].ToOptionalString(),
                parameters[12].ToOptionalString(),
                parameters[13].ToOptionalString(),
                parameters[14].ToOptionalString(),
                (IfcDocumentConfidentialityEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDocumentConfidentialityEnum](parameters[15].ToString()),
                (IfcDocumentStatusEnum)IfcAtom.EnumCreator[(int)EnumId.IfcDocumentStatusEnum](parameters[16].ToString()));
        }
        #endregion

    }
}