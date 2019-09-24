// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/annotation_payload.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/annotation_payload.proto</summary>
  public static partial class AnnotationPayloadReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/annotation_payload.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnotationPayloadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvYXV0b21sL3YxL2Fubm90YXRpb25fcGF5bG9hZC5w",
            "cm90bxIWZ29vZ2xlLmNsb3VkLmF1dG9tbC52MRooZ29vZ2xlL2Nsb3VkL2F1",
            "dG9tbC92MS90cmFuc2xhdGlvbi5wcm90bxoZZ29vZ2xlL3Byb3RvYnVmL2Fu",
            "eS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJjChFBbm5v",
            "dGF0aW9uUGF5bG9hZBJECgt0cmFuc2xhdGlvbhgCIAEoCzItLmdvb2dsZS5j",
            "bG91ZC5hdXRvbWwudjEuVHJhbnNsYXRpb25Bbm5vdGF0aW9uSABCCAoGZGV0",
            "YWlsQqoBChpjb20uZ29vZ2xlLmNsb3VkLmF1dG9tbC52MVABWjxnb29nbGUu",
            "Z29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2F1dG9tbC92",
            "MTthdXRvbWyqAhZHb29nbGUuQ2xvdWQuQXV0b01MLlYxygIWR29vZ2xlXENs",
            "b3VkXEF1dG9NTFxWMeoCGUdvb2dsZTo6Q2xvdWQ6OkF1dG9NTDo6VjFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.AnnotationPayload), global::Google.Cloud.AutoML.V1.AnnotationPayload.Parser, new[]{ "Translation" }, new[]{ "Detail" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains annotation information that is relevant to AutoML.
  /// </summary>
  public sealed partial class AnnotationPayload : pb::IMessage<AnnotationPayload> {
    private static readonly pb::MessageParser<AnnotationPayload> _parser = new pb::MessageParser<AnnotationPayload>(() => new AnnotationPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnnotationPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.AnnotationPayloadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnotationPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnotationPayload(AnnotationPayload other) : this() {
      switch (other.DetailCase) {
        case DetailOneofCase.Translation:
          Translation = other.Translation.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnotationPayload Clone() {
      return new AnnotationPayload(this);
    }

    /// <summary>Field number for the "translation" field.</summary>
    public const int TranslationFieldNumber = 2;
    /// <summary>
    /// Annotation details for translation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TranslationAnnotation Translation {
      get { return detailCase_ == DetailOneofCase.Translation ? (global::Google.Cloud.AutoML.V1.TranslationAnnotation) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Translation;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      Translation = 2,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnnotationPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnnotationPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Translation, other.Translation)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (detailCase_ == DetailOneofCase.Translation) hash ^= Translation.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (detailCase_ == DetailOneofCase.Translation) {
        output.WriteRawTag(18);
        output.WriteMessage(Translation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (detailCase_ == DetailOneofCase.Translation) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Translation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnnotationPayload other) {
      if (other == null) {
        return;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.Translation:
          if (Translation == null) {
            Translation = new global::Google.Cloud.AutoML.V1.TranslationAnnotation();
          }
          Translation.MergeFrom(other.Translation);
          break;
      }

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
          case 18: {
            global::Google.Cloud.AutoML.V1.TranslationAnnotation subBuilder = new global::Google.Cloud.AutoML.V1.TranslationAnnotation();
            if (detailCase_ == DetailOneofCase.Translation) {
              subBuilder.MergeFrom(Translation);
            }
            input.ReadMessage(subBuilder);
            Translation = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
