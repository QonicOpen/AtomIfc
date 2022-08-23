
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
    public class IfcApplication : IfcBase, IEquatable<IfcApplication>
    {
        private IfcId _applicationDeveloperId;
        public IfcId ApplicationDeveloperId 
        {
            get { 
                return _applicationDeveloperId; 
            }
            set { 
                if( value == null) 
                      throw new ArgumentNullException("ApplicationDeveloperId is not allowed to be null"); 
                _applicationDeveloperId = value;
            }
        }
        private string _version;
        public string Version 
        {
            get { 
                return _version; 
            }
            set { 
                _version = value;
            }
        }
        private string _applicationFullName;
        public string ApplicationFullName 
        {
            get { 
                return _applicationFullName; 
            }
            set { 
                _applicationFullName = value;
            }
        }
        private string _applicationIdentifier;
        public string ApplicationIdentifier 
        {
            get { 
                return _applicationIdentifier; 
            }
            set { 
                _applicationIdentifier = value;
            }
        }

        public IfcApplication(IfcId id, IfcId applicationDeveloperId, string version, string applicationFullName, string applicationIdentifier) : base(id)
        {
            ApplicationDeveloperId = applicationDeveloperId;
            Version = version;
            ApplicationFullName = applicationFullName;
            ApplicationIdentifier = applicationIdentifier;
        }

        public override ClassId GetClassId() => ClassId.IfcApplication;

        #region Equality

        public bool Equals(IfcApplication other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != GetType())
                return false;
            return base.Equals(other)
                && ApplicationDeveloperId == other.ApplicationDeveloperId
                && Version == other.Version
                && ApplicationFullName == other.ApplicationFullName
                && ApplicationIdentifier == other.ApplicationIdentifier;
        }

        public override bool Equals(object other) => Equals(other as IfcApplication);

        public static bool operator ==(IfcApplication one, IfcApplication other)
        {
            if (ReferenceEquals(one, null))
                return ReferenceEquals(other, null);
            return one.Equals(other);
        }

        public static bool operator !=(IfcApplication one, IfcApplication other) => !(one == other);

        public override int GetHashCode() => Id.GetHashCode();

        public override string GetDataHash() => $"{GetClassId().ToString().ToUpper()}({ApplicationDeveloperId},'{Version}','{ApplicationFullName}','{ApplicationIdentifier}')";
        #endregion

        public override void ReplaceIds(Dictionary<IfcId, IfcId> replacementTable)
        {
            if(ApplicationDeveloperId!= null && replacementTable.ContainsKey(ApplicationDeveloperId))
                ApplicationDeveloperId = replacementTable[ApplicationDeveloperId];
            base.ReplaceIds(replacementTable);

        }
        public override IfcBase Copy(IfcId newId)
        {
            return new IfcApplication (newId,ApplicationDeveloperId, Version, ApplicationFullName, ApplicationIdentifier);
        }
        #region Json Serialization

        public override JObject ToJson()
        {
            return new JObject
            {
                { "id", (string)Id },
                { "class_id", (int)ClassId.IfcApplication },
                { "class", nameof(IfcApplication) },
                { "parameters" , new JArray
                    {
                        ApplicationDeveloperId.ToJValue(),
                        Version.ToJValue(),
                        ApplicationFullName.ToJValue(),
                        ApplicationIdentifier.ToJValue(),
                    }
                }
            };
        }

        public static IfcApplication CreateFromJson(JObject jObject)
        {
            var parameters = jObject["parameters"] as JArray;
            return new IfcApplication(
                jObject["id"].ToIfcId(),
                parameters[0].ToIfcId(),
                parameters[1].ToString(),
                parameters[2].ToString(),
                parameters[3].ToString());
        }
        #endregion

    }
}