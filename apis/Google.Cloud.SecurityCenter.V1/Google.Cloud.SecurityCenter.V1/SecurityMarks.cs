// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v1/security_marks.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v1/security_marks.proto</summary>
  public static partial class SecurityMarksReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v1/security_marks.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SecurityMarksReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjEvc2VjdXJpdHlfbWFy",
            "a3MucHJvdG8SHmdvb2dsZS5jbG91ZC5zZWN1cml0eWNlbnRlci52MRocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKUAQoNU2VjdXJpdHlNYXJrcxIM",
            "CgRuYW1lGAEgASgJEkcKBW1hcmtzGAIgAygLMjguZ29vZ2xlLmNsb3VkLnNl",
            "Y3VyaXR5Y2VudGVyLnYxLlNlY3VyaXR5TWFya3MuTWFya3NFbnRyeRosCgpN",
            "YXJrc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAFClQEK",
            "ImNvbS5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIudjFQAVpMZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91ZC9zZWN1cml0",
            "eWNlbnRlci92MTtzZWN1cml0eWNlbnRlcqoCHkdvb2dsZS5DbG91ZC5TZWN1",
            "cml0eUNlbnRlci5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V1.SecurityMarks), global::Google.Cloud.SecurityCenter.V1.SecurityMarks.Parser, new[]{ "Name", "Marks" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// User specified security marks that are attached to the parent Cloud Security
  /// Command Center (Cloud SCC) resource. Security marks are scoped within a Cloud
  /// SCC organization -- they can be modified and viewed by all users who have
  /// proper permissions on the organization.
  /// </summary>
  public sealed partial class SecurityMarks : pb::IMessage<SecurityMarks> {
    private static readonly pb::MessageParser<SecurityMarks> _parser = new pb::MessageParser<SecurityMarks>(() => new SecurityMarks());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SecurityMarks> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V1.SecurityMarksReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityMarks() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityMarks(SecurityMarks other) : this() {
      name_ = other.name_;
      marks_ = other.marks_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SecurityMarks Clone() {
      return new SecurityMarks(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The relative resource name of the SecurityMarks. See:
    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name
    /// Examples:
    /// "organizations/123/assets/456/securityMarks"
    /// "organizations/123/sources/456/findings/789/securityMarks".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "marks" field.</summary>
    public const int MarksFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_marks_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> marks_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Mutable user specified security marks belonging to the parent resource.
    /// Constraints are as follows:
    ///   - Keys and values are treated as case insensitive
    ///   - Keys must be between 1 - 256 characters (inclusive)
    ///   - Keys must be letters, numbers, underscores, or dashes
    ///   - Values have leading and trailing whitespace trimmed, remaining
    ///     characters must be between 1 - 4096 characters (inclusive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Marks {
      get { return marks_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SecurityMarks);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SecurityMarks other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Marks.Equals(other.Marks)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Marks.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      marks_.WriteTo(output, _map_marks_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += marks_.CalculateSize(_map_marks_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SecurityMarks other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      marks_.Add(other.marks_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            marks_.AddEntriesFrom(input, _map_marks_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
