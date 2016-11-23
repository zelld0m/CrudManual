// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.41537 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Serialization_Deserialization</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>True</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Silverlight</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>True</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>True</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Serialization_Deserialization {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.IO.IsolatedStorage;
    
    
    #region Base entity class
    public partial class EntityBase<T>
     {
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current EntityBase object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an EntityBase object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output EntityBase object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out T obj, out System.Exception exception) {
            exception = null;
            obj = default(T);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out T obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static T Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((T)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current EntityBase object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            System.IO.IsolatedStorage.IsolatedStorageFile isoFile = null;
            System.IO.IsolatedStorage.IsolatedStorageFileStream isoStream = null;
            try {
                isoFile = IsolatedStorageFile.GetUserStoreForApplication();
                isoStream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(fileName, FileMode.Create, isoFile);
                streamWriter = new System.IO.StreamWriter(isoStream);
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
                isoStream.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
                if ((isoFile != null)) {
                    isoFile.Dispose();
                }
                if ((isoStream != null)) {
                    isoStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an EntityBase object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output EntityBase object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out T obj, out System.Exception exception) {
            exception = null;
            obj = default(T);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out T obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static T LoadFromFile(string fileName) {
            System.IO.IsolatedStorage.IsolatedStorageFile isoFile = null;
            System.IO.IsolatedStorage.IsolatedStorageFileStream isoStream = null;
            System.IO.StreamReader sr = null;
            try {
                isoFile = IsolatedStorageFile.GetUserStoreForApplication();
                isoStream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(fileName, FileMode.Open, isoFile);
                sr = new System.IO.StreamReader(isoStream);
                string xmlString = sr.ReadToEnd();
                isoStream.Close();
                sr.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((isoFile != null)) {
                    isoFile.Dispose();
                }
                if ((isoStream != null)) {
                    isoStream.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
        
        #region Clone method
        /// <summary>
        /// Create a clone of this T object
        /// </summary>
        public virtual T Clone() {
            return ((T)(this.MemberwiseClone()));
        }
        #endregion
    }
    #endregion
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="product")]
    public partial class product : EntityBase<product> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string nameField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private productPrice priceField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private productDescription descriptionField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string idField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string categorynameField;
        
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string name {get; set;}

    [System.Runtime.Serialization.DataMemberAttribute()]
    public productPrice price {get; set;}

    [System.Runtime.Serialization.DataMemberAttribute()]
    public productDescription description {get; set;}

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string id {get; set;}

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string categoryname {get; set;}

    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="productPrice")]
    public partial class productPrice : EntityBase<productPrice> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string unitField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private byte valueField;
        
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string unit {get; set;}

    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Runtime.Serialization.DataMemberAttribute()]
    public byte Value {get; set;}

    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Runtime.Serialization.DataContractAttribute(Name="productDescription")]
    public partial class productDescription : EntityBase<productDescription> {
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string colorField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string sizeField;
        
        [EditorBrowsable(EditorBrowsableState.Never)]
        private string weightField;
        
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string color {get; set;}

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string size {get; set;}

    [System.Runtime.Serialization.DataMemberAttribute()]
    public string weight {get; set;}

    }
}
